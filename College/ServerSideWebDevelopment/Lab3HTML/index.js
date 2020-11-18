function displayMessage(message)
{
    document.getElementById("answer").innerText = message;
}
// Call this function when Add button is clicked
function calcAdd() {
    var numA = parseFloat(document.getElementById("numA").value, 10);
    var numB = parseFloat(document.getElementById("numB").value, 10);
    var answer = numA + numB;
    var answerText = `${numA} + ${numB} = ${answer}`;
  
    // use getElementById() to get values
    // do addition
    // display anser on page
  
    // Log to console (useful for debugging)
    displayMessage(answerText);
    return true;
  }

  // Call this function when Add button is clicked
function calcSub() {
    var numA = parseFloat(document.getElementById("numA").value, 10);
    var numB = parseFloat(document.getElementById("numB").value, 10);
    let answer = numA - numB;
    let answerText = `${numA} - ${numB} = ${answer}`;
  
    // use getElementById() to get values
    // do addition
    // display anser on page
  
    // Log to console (useful for debugging)
    displayMessage(answerText);
    return true;
  }
  
    // Call this function when Add button is clicked
function calcMult() {
    var numA = parseFloat(document.getElementById("numA").value, 10);
    var numB = parseFloat(document.getElementById("numB").value, 10);
    let answer = numA * numB;
    let answerText = `${numA} * ${numB} = ${answer}`;
  
    // use getElementById() to get values
    // do addition
    // display anser on page
  
    // Log to console (useful for debugging)
    displayMessage(answerText);
    return true;
  }

    // Call this function when Add button is clicked
function calcDiv() {
    var numA = parseFloat(document.getElementById("numA").value, 10);
    var numB = parseFloat(document.getElementById("numB").value, 10);
    let answer = numA / numB;
    let answerText = `${numA} / ${numB} = ${answer}`;
  
    // use getElementById() to get values
    // do addition
    // display anser on page
  
    // Log to console (useful for debugging)
    displayMessage(answerText);
    return true;
  }
 
const Addbutton = document.getElementById('Add');
Addbutton.onclick = calcAdd;

const Subbutton = document.getElementById('Sub');
Subbutton.onclick = calcSub;

const Multbutton = document.getElementById('Mult');
Multbutton.onclick = calcMult;

const Divbutton = document.getElementById('Div');
Divbutton.onclick = calcDiv;

  // Implement the other calculator functions
  

