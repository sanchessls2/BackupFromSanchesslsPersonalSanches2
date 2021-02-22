using Microsoft.ML;
using System;
using System.Linq;
using Microsoft.ML.Data;
using System.Collections.Generic;
using FirstMachineLearningML.Model;

namespace FirstMachineLearning
{
    class Program
    {
        //private static readonly Lazy<PredictionEngine<HousingData, HousingDataOutput>> PredictionEngine = new Lazy<PredictionEngine<HousingData, HousingDataOutput>>(CreatePredictionEngine);
        private static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(CreatePredictionEnginePassword);
        static void Main(string[] args)
        {

            var resultados = PredictionEngine.Value.Predict(new ModelInput()
            {
                col0 = Convert.ToSingle(87.9698),
                col1 = Convert.ToSingle(240.9617),
                col2 = Convert.ToSingle(190.8678),
                col3 = Convert.ToSingle(80.5532),
                col4 = Convert.ToSingle(208.1451),
                col5 = Convert.ToSingle(79.5895),
                col6 = Convert.ToSingle(247.7941),
                col7 = Convert.ToSingle(104.3366)
            });

            Console.WriteLine(resultados.Score[0]);
            Console.WriteLine(resultados.Score[1]);
            Console.WriteLine(resultados.Prediction);

            var resultados2 = PredictionEngine.Value.Predict(new ModelInput()
            {
                col0 = Convert.ToSingle(100),
                col1 = Convert.ToSingle(200),
                col2 = Convert.ToSingle(300),
                col3 = Convert.ToSingle(400),
                col4 = Convert.ToSingle(500),
                col5 = Convert.ToSingle(600),
                col6 = Convert.ToSingle(700),
                col7 = Convert.ToSingle(800)
            });

            Console.WriteLine(resultados2.Score[0]);
            Console.WriteLine(resultados2.Score[1]);
            Console.WriteLine(resultados2.Prediction);

            //aqui e outro 2
            //var resultados = PredictionEngine.Value.Predict(new HousingData()
            //{
            //    Longitude = (float)-122.23,
            //    Latitude = (float)37.88,
            //    HousingMedianAge = (float)41.0,
            //    TotalRooms = (float)880.0,
            //    TotalBedrooms = (float)129.0,
            //    Population = (float)322.0,
            //    Households = (float)126.0,
            //    MedianIncome = (float)8.3252,
            //    //MedianHouseValue = (float)452600.0,
            //    OceanProximity = "NEAR BAY"
            //});


            //AQI E OUTRO
            //Console.WriteLine(resultados.Score);

            //var context = new MLContext();

            //var trainData = context.Data.LoadFromTextFile<HousingData>("housing.csv", hasHeader: true, separatorChar: ',');

            //var settings = new RegressionExperimentSettings
            //{
            //    MaxExperimentTimeInSeconds = 20,
            //    OptimizingMetric = RegressionMetric.MeanAbsoluteError
            //};

            //var labelColumnInfo = new ColumnInformation()
            //{
            //    LabelColumnName = "Label"
            //};

            //var progress = new Progress<RunDetail<RegressionMetrics>>(p =>
            //{
            //    if (p.ValidationMetrics != null)
            //    {
            //        Console.WriteLine($"Current Result - {p.TrainerName}, {p.ValidationMetrics.RSquared}, {p.ValidationMetrics.MeanAbsoluteError}");
            //    }
            //});

            //var experiment = context.Auto().CreateRegressionExperiment(settings);

            //var result = experiment.Execute(trainData, labelColumnInfo, progressHandler: progress);

            //Console.WriteLine(Environment.NewLine);
            //Console.WriteLine("Best run:");
            //Console.WriteLine($"Trainer name - {result.BestRun.TrainerName}");
            //Console.WriteLine($"RSquared - {result.BestRun.ValidationMetrics.RSquared}");
            //Console.WriteLine($"MAE - {result.BestRun.ValidationMetrics.MeanAbsoluteError}");

            Console.ReadLine();

        }


        public static PredictionEngine<HousingData, HousingDataOutput> CreatePredictionEngine()
        {
            var context = new MLContext();

            var data = context.Data.LoadFromTextFile<HousingData>("housing.csv", hasHeader: true,
                separatorChar: ',');

            // Data process configuration with pipeline data transformations 
            var dataProcessPipeline = context.Transforms.Conversion.MapValueToKey("col8", "col8")
                                      .Append(context.Transforms.Concatenate("Features", new[] { "col0", "col1", "col2", "col3", "col4", "col5", "col6", "col7" }));
            // Set the training algorithm 
            var trainer = context.MulticlassClassification.Trainers.LightGbm(labelColumnName: "col8", featureColumnName: "Features")
                                      .Append(context.Transforms.Conversion.MapKeyToValue("PredictedLabel", "PredictedLabel"));

            var pipeline = dataProcessPipeline.Append(trainer);


            var model = pipeline.Fit(data);

            var crossValidationResults = context.MulticlassClassification.CrossValidate(data, pipeline, numberOfFolds: 5, labelColumnName: "col8");
            PrintMulticlassClassificationFoldsAverageMetrics(crossValidationResults);

            return context.Model.CreatePredictionEngine<HousingData, HousingDataOutput>(model);

        }

        public static void PrintMulticlassClassificationFoldsAverageMetrics(IEnumerable<TrainCatalogBase.CrossValidationResult<MulticlassClassificationMetrics>> crossValResults)
        {
            var metricsInMultipleFolds = crossValResults.Select(r => r.Metrics);

            var microAccuracyValues = metricsInMultipleFolds.Select(m => m.MicroAccuracy);
            var microAccuracyAverage = microAccuracyValues.Average();
            var microAccuraciesStdDeviation = CalculateStandardDeviation(microAccuracyValues);
            var microAccuraciesConfidenceInterval95 = CalculateConfidenceInterval95(microAccuracyValues);

            var macroAccuracyValues = metricsInMultipleFolds.Select(m => m.MacroAccuracy);
            var macroAccuracyAverage = macroAccuracyValues.Average();
            var macroAccuraciesStdDeviation = CalculateStandardDeviation(macroAccuracyValues);
            var macroAccuraciesConfidenceInterval95 = CalculateConfidenceInterval95(macroAccuracyValues);

            var logLossValues = metricsInMultipleFolds.Select(m => m.LogLoss);
            var logLossAverage = logLossValues.Average();
            var logLossStdDeviation = CalculateStandardDeviation(logLossValues);
            var logLossConfidenceInterval95 = CalculateConfidenceInterval95(logLossValues);

            var logLossReductionValues = metricsInMultipleFolds.Select(m => m.LogLossReduction);
            var logLossReductionAverage = logLossReductionValues.Average();
            var logLossReductionStdDeviation = CalculateStandardDeviation(logLossReductionValues);
            var logLossReductionConfidenceInterval95 = CalculateConfidenceInterval95(logLossReductionValues);

            Console.WriteLine($"*************************************************************************************************************");
            Console.WriteLine($"*       Metrics for Multi-class Classification model      ");
            Console.WriteLine($"*------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"*       Average MicroAccuracy:    {microAccuracyAverage:0.###}  - Standard deviation: ({microAccuraciesStdDeviation:#.###})  - Confidence Interval 95%: ({microAccuraciesConfidenceInterval95:#.###})");
            Console.WriteLine($"*       Average MacroAccuracy:    {macroAccuracyAverage:0.###}  - Standard deviation: ({macroAccuraciesStdDeviation:#.###})  - Confidence Interval 95%: ({macroAccuraciesConfidenceInterval95:#.###})");
            Console.WriteLine($"*       Average LogLoss:          {logLossAverage:#.###}  - Standard deviation: ({logLossStdDeviation:#.###})  - Confidence Interval 95%: ({logLossConfidenceInterval95:#.###})");
            Console.WriteLine($"*       Average LogLossReduction: {logLossReductionAverage:#.###}  - Standard deviation: ({logLossReductionStdDeviation:#.###})  - Confidence Interval 95%: ({logLossReductionConfidenceInterval95:#.###})");
            Console.WriteLine($"*************************************************************************************************************");

        }
        public static double CalculateStandardDeviation(IEnumerable<double> values)
        {
            double average = values.Average();
            double sumOfSquaresOfDifferences = values.Select(val => (val - average) * (val - average)).Sum();
            double standardDeviation = Math.Sqrt(sumOfSquaresOfDifferences / (values.Count() - 1));
            return standardDeviation;
        }

        public static double CalculateConfidenceInterval95(IEnumerable<double> values)
        {
            double confidenceInterval95 = 1.96 * CalculateStandardDeviation(values) / Math.Sqrt((values.Count() - 1));
            return confidenceInterval95;
        }
        public static PredictionEngine<ModelInput,ModelOutput> CreatePredictionEnginePassword()
        {
            var context = new MLContext(seed: 1);

            var data = context.Data.LoadFromTextFile<ModelInput>("Password.csv", hasHeader: true,
                separatorChar: ',',allowQuoting:true,allowSparse:false);

            // Data process configuration with pipeline data transformations 
            var dataProcessPipeline = context.Transforms.Conversion.MapValueToKey("col8", "col8")
                                      .Append(context.Transforms.Concatenate("Features", new[] { "col0", "col1", "col2", "col3", "col4", "col5", "col6", "col7" }));
            // Set the training algorithm 
            var trainer = context.MulticlassClassification.Trainers.LightGbm(labelColumnName: "col8", featureColumnName: "Features")
                                      .Append(context.Transforms.Conversion.MapKeyToValue("PredictedLabel", "PredictedLabel"));

            var pipeline = dataProcessPipeline.Append(trainer);

            var model = pipeline.Fit(data);

            var crossValidationResults = context.MulticlassClassification.CrossValidate(data, pipeline, numberOfFolds: 5, labelColumnName: "col8");
            PrintMulticlassClassificationFoldsAverageMetrics(crossValidationResults);

            return context.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);

        }
    }
}
