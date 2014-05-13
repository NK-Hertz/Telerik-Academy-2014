//1.Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

function greater() {
    var first = document.getElementById('greaterFirst').value;
    var second = document.getElementById('greaterSecond').value;
    var container = first;
    if (first > second) {
        container = first;
        first = second;
        second = container;
    }

    alert("A : " + first + "\nB : " + second);
}

//2.Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

function showSign() {
    var first = document.getElementById('signFirst').value;
    var second = document.getElementById('signSecond').value;
    var third = document.getElementById('signThird').value;
    //if one of the three is + and the two other numbers are -
    if (first > 0 && second < 0 && third < 0|| 
        first < 0 && second > 0 && third < 0 ||
        first < 0 && second < 0 && third > 0) {
        alert("Sign : +");
    }
    else if (first < 0 && second > 0 && third > 0 ||
             first > 0 && second < 0 && third > 0 ||
             first > 0 && second > 0 && third < 0) {
        alert("Sign : -");
    }
    else if (first < 0 && second < 0 && third < 0) {
        alert("Sign : -");
    }
    else {
        alert("Sign : +");
    }
}

//3.Write a script that finds the biggest of three integers using nested if statements.
//what happens with 2 or 3 equal ints
function biggestOfThree() {
    var first = document.getElementById('biggestFirst').value;
    var second = document.getElementById('biggestSecond').value;
    var third = document.getElementById('biggestThird').value;
    if (first > second) {
        if (first > third) {
            alert("The first is bigger than the rest!\nFirst : " + first);
        }
        else if (first < third) {
            alert("The third is bigger than the rest!\nThird : " + third);
        }
    }
    else if (second > first) {
        if (second > third) {
            alert("The second is bigger than the rest!\nSecond : " + second);
        }
        else if (second < third) {
            alert("The third is bigger than the rest!\nThird : " + third);
        }
    }
}

//4.Sort 3 real values in descending order using nested if statements.

function sortThreeValuesDesc() {
    var first = document.getElementById('sortValuesFirst').value;
    var second = document.getElementById('sortValuesSecond').value;
    var third = document.getElementById('sortValuesThird').value;
    if (first > second) {
        if (first > third) {
            if (second  > third) {
                alert("A > B > C");
            }
            else if (second < third) {
                alert("A > C > B");
            }
        }
        else if (first < third) {
            alert("C > A > B");
        }
    }
    else if (second > first) {
        if (second > third) {
            if (first > third) {
                alert("B > A > C");
            }
            else if (first < third) {
                alert("B > C > A");
            }
        }
        else if (second < third) {
            alert("C > B > A");
        }
    }
}

//5.Write script that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

function digitToText() {
    var digit = document.getElementById('digit').value * 1;
    switch (digit)
    {
        case 0: alert("Zero"); break;
        case 1: alert("One"); break;
        case 2: alert("Two"); break;
        case 3: alert("Three"); break;
        case 4: alert("Four"); break;
        case 5: alert("Five"); break;
        case 6: alert("Six"); break;
        case 7: alert("Seven"); break;
        case 8: alert("Eight"); break;
        case 9: alert("Nine"); break;
        default: alert("The input was not a digit!"); break;
    }
}

/*6.Write a script that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
    and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
*/

function quadraticEquation() {
    var a = document.getElementById('quadrEqFirst').value;
    var b = document.getElementById('quadrEqSecond').value;
    var c = document.getElementById('quadrEqThird').value;
    var discriminant = (b * b - 4 * a * c);
    if (discriminant > 0) {
        var firstRoot = (( - b + Math.sqrt(discriminant)) / 2 * a) | 0;
        var secondRoot = (( - b - Math.sqrt(discriminant)) / 2 * a) | 0;
        alert("X1 = " + firstRoot + "\nX2 = " + secondRoot);
    }
    else if (discriminant === 0) {
        var x = -b / 2 * a;
        alert("X = " + x);
    }
    else {
        alert("No real roots!");
    }
}

//7.Write a script that finds the greatest of given 5 variables.

function greatestOfFive() {
    var first = document.getElementById('greatestValueFirst').value * 1;
    var second = document.getElementById('greatestValueSecond').value * 1;
    var third = document.getElementById('greatestValueThird').value * 1;
    var fourth = document.getElementById('greatestValueFourth').value * 1;
    var fifth = document.getElementById('greatestValueFifth').value * 1;
    var greatest = first;
    if (second > greatest) {
        greatest = second;
    }
    if (third > greatest) {
        greatest = third;
    }
    if (fourth > greatest) {
        greatest = fourth;
    }
    if (fifth > greatest) {
        greatest = fifth;
    }
    alert("Biggest : " + greatest);
}