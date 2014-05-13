//1.Write a script that prints all the numbers from 1 to N

function print1ToN() {
    var n = 10;
    var strResult = "";
    for (var index = 0; index < n; index++) {
        if (index > 0) {
            strResult += " ";
        }
        strResult = strResult + (index + 1);
    }

    console.log(strResult);
}

//2.Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
function notDevisibleBy3And7() {
    var n = 22;
    var strResult = "";
    for (var index = 0; index < n; index++) {
        if (index > 0) {
            strResult += " ";
        }

        if ((index + 1) % 3 != 0 || (index + 1) % 7 != 0) {
            strResult = strResult + (index + 1);
        }
    }

    console.log(strResult);
}

//3.Write a script that finds the max and min number from a sequence of numbers
function minAndMax() {
    var numbers = [1, 2, 3, 4, 5];
    var max = numbers[0];
    var min = numbers[0];
    for (var index = 0; index < numbers.length; index++) {
        if (numbers[index] * 1 > max) {
            max = numbers[index];
        }

        if (numbers[index] < min) {
            min = numbers[index];
        }
    }

    console.log("Min : " + min + "\nMax : " + max);
}

//4.Write a script that finds the lexicographically smallest and 
//largest property in document, window and navigator objects
function lexicoSmallestAndLargest() {
    var arr = [document, window, navigator];
    var smallestProp;
    var largestProp;

    for (var property in document) {
        smallestProp = property;
        largestProp = property;
        break;
    }

    for (var index = 0; index < arr.length; index++) {
        for (var property in arr[index]) {
            if (smallestProp > property) {
                smallestProp = property;
            }

            if (largestProp < property) {
                largestProp = property;
            }
        }
    }
    
    console.log(smallestProp);
    console.log(largestProp);
}