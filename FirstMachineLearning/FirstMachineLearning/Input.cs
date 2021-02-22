using Microsoft.ML.Data;
using System;

namespace FirstMachineLearning
{
    internal class Input
    {
        [LoadColumn(0)]
        public float Diferenca1 { get; set; }

        [LoadColumn(1)]
        public float Diferenca2 { get; set; }

        [LoadColumn(2)]
        public float Diferenca3 { get; set; }

        [LoadColumn(3)]
        public float Diferenca4 { get; set; }

        [LoadColumn(4)]
        public float Diferenca5 { get; set; }

        [LoadColumn(5)]
        public float Diferenca6 { get; set; }

        [LoadColumn(6)]
        public float Diferenca7 { get; set; }

        [LoadColumn(7)]
        public float Diferenca8 { get; set; }

        [LoadColumn(8), ColumnName("Label")]
        public float SouEu { get; set; }

    }
}