function getFirstElementOfArray(array) {
    //return the first element of an array
    return array[0];
}

function getLastElementOfArray(array) {
    //return the first element of an array
    return array[array.length - 1];
}


function checkIfIsArray(array) {
    //return the first element of an array
    return Array.isArray(array);
}

function getArrayLength(array) {
    //get the array size
    return array.length;
}

function DisplayArray(array) {
    //loop through the array and display it
    var result = "";
    for (let index = 0; index < array.length; index++) {
        result += array[index] + "\n";
    }

    return result;
}

function SortArray(array) {
    //Sorting an array
    return array.sort();
}

function JoinArrayIntoString(array, separator) {
    //Join array into string
    var result = "";
    for (let index = 0; index < array.length; index++) {
        //separate the elements after the first one with the choosen character
        if (index > 0) {
            result += separator;
        }

        result += array[index];
    }

    return result;
}

function AddOneToIntegerArray(array) {
    for (let index = 0; index < array.length; index++) {
        //add 1 to each element
        array[index] = array[index] + 1;
    }

    return array;
}

function SumIntegerArrayValues(array) {
    var result = 0;
    for (let index = 0; index < array.length; index++) {
        //sum each element
        result += array[index];
    }

    return result;
}

function FilterValuesInIntegerArray(array, cutline) {

    var result = [];
    for (let index = 0; index < array.length; index++) {
        //check if the element is above the cut line
        if (array[index] > cutline) {
            result.push(array[index]);
        }
    }

    return result;
}

function ReturnPositionOfSearch(array, search) {
    for (let index = 0; index < array.length; index++) {
        //check if the element is equal if it is return the position
        if (array[index] == search) {
            return index;
        }
    }

    //case we dont find it 
    return -1;
}

function ReturnQuantityOf(value, array) {
    //Checking how many in that array has that exactly value
    var returnCount = 0;
    for (let index = 0; index < array.length; index++) {
        if (array[index] == value) {
            //add 1 in the final count if it's the same
            returnCount++;
        }
    }

    return returnCount;
}

function ReturnMostFrequentItem(array) {
    //to storage the value
    var returnValue;
    //to storage the count
    var returnCount = 0;

    for (let index = 0; index < array.length; index++) {
        //Check how many of that element are in the array
        var quantity = ReturnQuantityOf(array[index], array);

        //if that item has more counts that the archieved one
        //then we swap it
        if (quantity > returnCount) {
            //swap 
            returnValue = array[index];
            returnCount = quantity;
        }
    }

    return returnValue;
}

function InvertCase(word) {
    var returnWord = "";
    //loop through the word and invert the case
    for (let index = 0; index < word.length; index++) {
        if (word[index] !== word[index].toUpperCase()) {
            returnWord += word[index].toUpperCase();
        }
        else {
            returnWord += word[index].toLowerCase();
        }
    }

    return returnWord;
}

function DisplayMatrix(matrix) {
    //loop through the array and display it
    var result = "";
    for (let index = 0; index < matrix.length; index++) {
        result += "\n"; // line between Lines of the matrix
        for (let index2 = 0; index2 < matrix[index].length; index2++) {
            //identing the space between columns of the matrix
            if (index2 > 0) {
                result += "     ";
            }
            result += matrix[index][index2];
        }
    }

    return result;
}


//Questions Tests
function executeQ1() {
    console.log("Testing Question 1");
    console.log("Command to run: ");
    console.log("getFirstElementOfArray(myArray)");
    var myArray = [9, 10, 11];
    console.log("Return : " + getFirstElementOfArray(myArray));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ2() {
    console.log("Testing Question 2");
    console.log("Command to run: ");
    console.log("getLastElementOfArray(myArray)");
    var myArray = [9, 10, 11];
    console.log("Return : " + getLastElementOfArray(myArray));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ3() {
    console.log("Testing Question 3");
    console.log("Command to run: ");
    console.log("checkIfIsArray(myTrueArray)");
    var myTrueArray = [9, 10, 11];
    console.log("Return : " + checkIfIsArray(myTrueArray));
    console.log("");
    console.log("Command to run: ");
    console.log("checkIfIsArray(myFalseArray)");
    var myFalseArray = 45;
    console.log("Return : " + checkIfIsArray(myFalseArray));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ4() {
    console.log("Testing Question 4");
    console.log("Command to run: ");
    console.log("getArrayLength(myArray)");
    var myArray = [9, 10, 11];
    console.log("Return : " + getArrayLength(myArray));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ5() {
    console.log("Testing Question 5");
    console.log("Command to run: ");
    console.log("DisplayArray(myArray)");
    var myArray = [9, 10, 11];
    console.log("Return : " + DisplayArray(myArray));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ6() {
    console.log("Testing Question 6");
    console.log("Command to run: ");
    console.log("SortArray(myArray)");
    var myArray = ["cndre", "bndre", "andre"];
    console.log("Return : " + SortArray(myArray));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ7() {
    console.log("Testing Question 7");
    console.log("Command to run: ");
    console.log("DisplayArray(SortArray(myArray))");
    var myArray = ["90", "50", "21"];
    console.log("Return : " + DisplayArray(SortArray(myArray)));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ8() {
    console.log("Testing Question 8");
    console.log("Command to run: ");

    var myArray = ["90", "50", "21"];
    var sortedarray = SortArray(myArray);
    var minValue = getFirstElementOfArray(sortedarray);
    var maxValue = getLastElementOfArray(sortedarray);

    console.log(" Min and Max Value from array [\"90\",\"50\",\"21\"]");

    console.log("Return : Min: " + minValue + " Max: " + maxValue);
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ9() {
    console.log("Testing Question 9");
    console.log("Command to run: ");

    var myArray = ["90", "50", "21"];
    console.log("JoinArrayIntoString(myArray,\"\")    [\"90\",\"50\",\"21\"]");

    console.log("Return : " + JoinArrayIntoString(myArray, ""));
    console.log("");
    console.log("End");
    console.log("");
}


function executeQ10() {
    console.log("Testing Question 10");
    console.log("Command to run: ");

    var myArray = ["90", "50", "21"];
    console.log("JoinArrayIntoString(myArray,\"-\")    [\"90\",\"50\",\"21\"]");

    console.log("Return : " + JoinArrayIntoString(myArray, "-"));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ11() {
    console.log("Testing Question 11");
    console.log("Command to run: ");

    var myArray = [90, 50, 21];
    console.log(" AddOneToIntegerArray(myArray)  [90,50,21]");

    console.log("Return : " + AddOneToIntegerArray(myArray));
    console.log("");
    console.log("End");
    console.log("");
}


function executeQ12() {
    console.log("Testing Question 12");
    console.log("Command to run: ");

    var myArray = [90, 50, 21];
    console.log(" SumIntegerArrayValues(myArray)  [90,50,21]");
    console.log("Return : " + SumIntegerArrayValues(myArray));
    console.log("");
    console.log("End");
    console.log("");
}


function executeQ13() {
    console.log("Testing Question 13");
    console.log("Command to run: ");

    var myArray = [90, 50, 21];
    console.log(" FilterValuesInIntegerArray(myArray,49)  [90,50,21]");
    console.log("Return : " + FilterValuesInIntegerArray(myArray, 49));
    console.log("");
    console.log("End");
    console.log("");
}


function executeQ14() {
    console.log("Testing Question 14");
    console.log("Command to run: ");

    var myArray = ["ANDRE", "PEDRO"];
    console.log(" ReturnPositionOfSearch(myArray,\"ANDRE\")  [\"ANDRE\",\"PEDRO\"");
    console.log("Return : " + ReturnPositionOfSearch(myArray, "ANDRE"));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ15() {
    console.log("Testing Question 15");
    console.log("Command to run: ");

    var myArray = ["ANDRE", "PEDRO", "ANDRE", "ANDRE"];
    console.log(" ReturnMostFrequentItem(myArray)");
    console.log("Return : " + ReturnMostFrequentItem(myArray));
    console.log("");

    var myArray2 = [12, 1, 5, 5, 5];
    console.log(" ReturnMostFrequentItem(myArray2)");
    console.log("Return : " + ReturnMostFrequentItem(myArray2));
    console.log("");

    console.log("End");
    console.log("");
}

function executeQ16() {
    console.log("Testing Question 16");
    console.log("Command to run: ");

    var word = "aBcDeFgHiJkLmNoPqRsT";
    console.log(" InvertCase(word)");
    console.log("Return : " + InvertCase(word));
    console.log("");
    console.log("End");
    console.log("");
}

function executeQ17() {
    console.log("Testing Question 17");
    console.log("Command to run: ");

    var items = [
        [1, 2],
        [3, 4],
        [5, 6]
    ];

    console.log(" DisplayMatrix(items)");
    console.log("Return : " + DisplayMatrix(items));
    console.log("");
    console.log("End");
    console.log("");
}

//Function that run the tests
function executeTests() {
    executeQ1();
    executeQ2();
    executeQ3();
    executeQ4();
    executeQ5();
    executeQ6();
    executeQ7();
    executeQ8();
    executeQ9();
    executeQ10();
    executeQ11();
    executeQ12();
    executeQ13();
    executeQ14();
    executeQ15();
    executeQ16();
    executeQ17();
}


//execute
executeTests();




