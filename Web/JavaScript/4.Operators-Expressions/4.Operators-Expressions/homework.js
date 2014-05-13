//1.Write an expression that checks if given integer is odd or even.
function isEven() {
    var number = 2;
    var isEven = (number % 2 == 0) ? true : false;
    alert("The number " + number + " is even: " + isEven);
}

/*2.Write a boolean expression that checks for given integer 
 * if it can be divided (without remainder) by 7 and 5 in the same time.*/
function isDevisibleBy7And5() {
    var number = 35;
    var devisibleBy7And5 = ((number % 7 == 0) && (number % 5 == 0)) ? true : false;
    alert("The number " + number + " is devisible by 7 and 5 : " + devisibleBy7And5);
}


//3.Write an expression that calculates rectangle’s area by given width and height.

function area() {
    var width = 15;
    var height = 10;
    var area = width * height;
    alert("Area : " + area);
}

//4.Write an expression that checks for given integer if its 
//third digit (right-to-left) is 7. E. g. 1732  true.

function isThirdDigitSeven() {
    var number = 1743;
    var isThirdDigit7 = (number / 100 % 10 | 0) == 7;
    alert("Is third digit seven in " + number + " : " + isThirdDigit7);
}


//5.Write a boolean expression for finding if the bit 3 
//(counting from 0) of a given integer is 1 or 0.

function isZero() {
    number = (11).toString(2);
    var isZero = number[3] == 0;
    alert("Is zero : " + isZero);
}


//6.Write an expression that checks if given print (x,  y) is within a circle K(O, 5).

function isWithinCircle() {
    var pointX = 7;
    var pointY = 2;
    var circleX = 0;
    var circleY = 1;
    var radius = 5;
    var resultX = (pointX - circleX) * (pointX - circleX);
    var resultY = (pointY - circleY) * (pointY - circleY);
    var finalResult = resultX + resultY;
    var isWithinCircle = finalResult < radius * radius;
    alert("Is within the circle : " + isWithinCircle);
}

//7.Write an expression that checks if given positive integer number n 
//(n ≤ 100) is prime. E.g. 37 is prime.
function isPrime() {
    var num = 37;
    var isPrime = (num % 2 > 0 && num % 3 > 0 && num % 5 > 0 && num % 7 > 0 || num == 2 || num == 5 || num == 7);
    alert("Is " + num + " prime : " + isPrime);
}

//8.Write an expression that calculates trapezoid's area by given sides a and b and height h.

function trapezoidArea() {
    var a = 5;
    var b = 7;
    var h = 10;
    var trapezoid = (h / 2) * (a + b);
    alert("Trapezoid area : " + trapezoid);
}


//9.Write an expression that checks for given point (x, y) if it is 
//within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
function outOfRectangleWithinCirlce() {
    var pointX = 1.7;
    var pointY = 2.5;
    var centerX = 1.0;
    var centerY = 1.0;
    var resultX = (pointX - centerX) * (pointX - centerX);
    var resultY = (pointY - centerY) * (pointY - centerY);
    var radius = 3;
    var finalResult = resultX + resultY;
    var isWithinCircle = finalResult < radius * radius;
    var rectTopX = 1.0;
    var rectTopY = -1.0;
    var rectWidth = 6.0;
    var rectHeight = 2.0;
    var rectBottomX = rectTopX + rectWidth;
    var rectBottomY = rectTopY - rectHeight;
    var isOutOfRect = (pointX < rectTopX || rectBottomX < pointX) ||
                      (pointY < rectBottomY || rectTopY < pointY);
    var bothConditions = (isOutOfRect && isWithinCircle);
    alert("Is within circle: " + isWithinCircle +
          "\nIs out of rectangle: " + isOutOfRect + 
          "\nBoth conditions: " + bothConditions);
}
