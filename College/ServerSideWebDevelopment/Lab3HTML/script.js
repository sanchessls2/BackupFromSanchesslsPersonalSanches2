function changeTitle(newtitle) {    
    document.getElementById("lab3").innerText = newtitle;
}

function getInput() {    
    return document.getElementById("inputA").value;
}

const button = document.querySelector('button');
button.onclick = display;

function display() {    
    var valueToDisplay = getInput();
    
    console.log(valueToDisplay);
    document.getElementById("h2ToChange").innerText = valueToDisplay;
}

function getP()
{
   var listOfP = document.getElementsByTagName("p");
   for (let index = 0; index < listOfP.length; index++) {
       const element = listOfP[index];
       console.log(element.innerText);       
   }  

}