function add(value1, value2) {
    //return one value added to another
    return value1 + value2;
}

function CompareNumbers(value1, value2) {
    //If the first value is greater then the second one
    if (value1 > value2) {
        return "First value is greater than the second one.";
    }
    //If the second value is greater then the first one
    else if (value2 > value1) {
        return "Second value is greater than the first one."
    }
    //The only left options is that they are equal
    else {
        return "Values are equal.";
    }
}


function ReturnWords(word1, word2, word3, word4) {
    //Concatenating the Words with a space between them
    return word1 + " " +
        word2 + " " +
        word3 + " " +
        word4;
}

function ConvertMinutesToHourAndMinutes(minutes) {
    //Getting the hours
    var totalInHours = minutes / 60;
    //getting the int part from the hours
    var hours = Math.trunc(totalInHours);

    //Taking out the minutes that are already being counted on hours
    var minutes = minutes - (hours * 60);

    return hours + " Hour(s) and " + minutes + " Minute(s)";
}

function ConvertRadiusToAreaAndPerimeter(radius) {
    //Area Formula
    //A = pi * r^2
    //pow = ^
    var area = Math.PI * (Math.pow(radius, 2));

    //Perimeter Formula
    //C=2* pi * r
    var perimeter = 2 * Math.PI * radius;

    return "Area : " + area + " Perimeter : " + perimeter;
}

function ConvertMilesToKm(miles) {
    //Formula: miles * 1.609344
    return miles * 1.609344;

}
function ConvertKmToMiles(km) {
    //Formula: km / 1.609
    return km / 1.609;
}

function InvertMilesAndKm(value, type) {
    if (type == "MILES") {
        return ConvertMilesToKm(value) + " kilometres.";
    }
    else
        if (type == "KM") {
            return ConvertKmToMiles(value) + " Miles.";
        }
        else {
            return "Invalid Input, Type must be (MILES|KM)";
        }
}

function Calculate(value1, value2, operator) {
    if (operator == "-") {
        return value1 - value2;
    }
    else
        if (operator == "+") {
            return value1 + value2;
        }
        else
            if (operator == "/") {
                if (value2 !== 0) {
                    return value1 / value2;
                }
                else {
                    return "Invalid input of value2, will cause a divison by 0."
                }
            }
            else
                if (operator == "*") {
                    return value1 * value2;
                }
                else {
                    return "Invalid Input, operator must be (*|/|+|-)";
                }
}
//Questions Tests
function executeQ1() {
    console.log("Testing Question 1");
    console.log("Command to run: ");
    console.log("Add(15,10)");
    console.log("Return : " + add(15, 10));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ2() {
    console.log("Testing Question 2");
    console.log("Command to run: ");
    console.log("CompareNumbers(14,15)");
    console.log("Return : " + CompareNumbers(14, 15));
    console.log("Command to run: ");
    console.log("CompareNumbers(15,15)");
    console.log("Return : " + CompareNumbers(15, 15));
    console.log("Command to run: ");
    console.log("CompareNumbers(15,16)");
    console.log("Return : " + CompareNumbers(15, 16));
    console.log("");
    console.log("End");
    console.log("");
}


function executeQ3() {
    console.log("Testing Question 3");
    console.log("Function 3 was not defined on the exercise");
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ4() {
    console.log("Testing Question 4");
    console.log("Command to run: ");
    console.log("ReturnWords('FirstWord','SecondWord','ThirdWord','FourthWord')");
    console.log("Return : " + ReturnWords('FirstWord', 'SecondWord', 'ThirdWord', 'FourthWord'));
    console.log("");
    console.log("End");
    console.log("");
}


function executeQ5() {
    console.log("Testing Question 5");
    console.log("Command to run: ");
    console.log("ConvertMinutesToHourAndMinutes(258)");
    console.log("Return : " + ConvertMinutesToHourAndMinutes(258));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ6() {
    console.log("Testing Question 6");
    console.log("Command to run: ");
    console.log("ConvertRadiusToAreaAndPerimeter(15)");
    console.log("Return : " + ConvertRadiusToAreaAndPerimeter(15));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ7() {
    console.log("Testing Question 7");
    console.log("Command to run: ");
    console.log("InvertMilesAndKm(150,\"KM\")");
    console.log("Return : " + InvertMilesAndKm(150, "KM"));
    console.log("Command to run: ");
    console.log("InvertMilesAndKm(150,\"MILES\")");
    console.log("Return : " + InvertMilesAndKm(150, "MILES"));

    console.log("");
    console.log("End");
    console.log("");
}


function executeQ8() {
    console.log("Testing Question 8");
    console.log("Command to run: ");
    console.log("Calculate(10,10,\"+\")");
    console.log("Return : " + Calculate(10, 10, "+"));

    console.log("Command to run: ");
    console.log("Calculate(10,10,\"-\")");
    console.log("Return : " + Calculate(10, 10, "-"));

    console.log("Command to run: ");
    console.log("Calculate(10,10,\"/\")");
    console.log("Return : " + Calculate(10, 10, "/"));

    console.log("Command to run: ");
    console.log("Calculate(10,10,\"*\")");
    console.log("Return : " + Calculate(10, 10, "*"));

    console.log("");
    console.log("End");
    console.log("");
}







