/* 1.Write a script that selects all the div nodes that are directly inside other div elements
 * Create a function using querySelectorAll()
 * Create a function using getElementsByTagName()
 */
function getAllNestedDivs() {
    //var nestedDivs = document.querySelectorAll('div div');
    var divs = document.getElementsByTagName('div');
    var nestedDivs = 0;
    var index = 0;

    while (divs[index] != null) {
        nestedDivs += divs[index].getElementsByTagName('div').length;
        index++;
    }

    console.log("Nested divs count : " + nestedDivs);
}

/* 2.Create a function that gets the value of <input type="text"> 
 * ands prints its value to the console
 */
function getValueFromInput() {
    var valueOfInputLoki = document.getElementsByTagName('input')[0];
    var valueOfInputIronMan = document.getElementsByTagName('input')[1];
    console.log(valueOfInputLoki.value);
    console.log(valueOfInputIronMan.value);
}

/* 3.Crеate a function that gets the value of <input type="color"> and 
 * sets the background of the body to this value
 */
function changeBGColor() {
    var color = document.getElementById('colorInput');
    document.bgColor = color.value;
}