//1.Write a script that allocates array of 20 integers and initializes each 
//element by its index multiplied by 5. Print the obtained array on the console.
function elementByFive() {
    var arr = new Array(20);
    for (var index = 0; index < arr.length; index++) {
        arr[index] = index * 5;
    }
    console.log(arr);
}

//2.Write a script that compares two char arrays lexicographically (letter by letter).
function compareCharArrays() {
    var charArrayOne = ['m', 'u', 'n', 'c', 'h', 'i', 'e'];
    var charArrayTwo = ['m', 'a', 'n', 'e'];

    var shortestLenght = (charArrayOne.length > charArrayTwo.length) ? charArrayTwo.length : charArrayOne.length;

    for (var index = 0; index < shortestLenght; index++) {
        if (charArrayOne[index] > charArrayTwo[index])  {
            console.log(charArrayTwo + " is First!");
            break;
        }
        else if (charArrayOne[index] < charArrayTwo[index]) {
            console.log(charArrayOne + " is First!");
            break;
        }
        
    }
}

//3.Write a script that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
function longestSequenceOfEqualElem() {
    var element;
    var sequenceLenght = 1;
    var maxElement = 0;
    var maxSequenceLenght = 0;
    var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

    for (var index = 0; index < arr.length - 1; index++) {
        if (arr[index] === arr[index + 1]) {
            element = arr[index];
            sequenceLenght += 1;
            if (sequenceLenght > maxSequenceLenght) {
                maxSequenceLenght = sequenceLenght;
                maxElement = element;
            }
        }
        else {
            element = undefined;
            sequenceLenght = 1;
        }
    }

    console.log("Max sequence element : " + maxElement);
    console.log("Max sequence lenght : " + maxSequenceLenght);
}

//4.Write a script that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
function longestIncreasingSequence() {
    var lastIndex;
    var sequenceLenght = 1;
    var maxLastIndex = 0;
    var maxSequenceLenght = 0;
    var arr = [3, 2, 3, 4, 2, 2, 4];

    for (var index = 0; index < arr.length - 1; index++) {
        if (arr[index] < arr[index + 1]) {
            lastIndex = index + 1;
            sequenceLenght += 1;
            if (sequenceLenght > maxSequenceLenght) {
                maxLastIndex = lastIndex;
                maxSequenceLenght = sequenceLenght;
            }
        }
        else {
            lastIndex = undefined;
            sequenceLenght = 1;
        }
    }

    for (index = maxLastIndex - maxSequenceLenght + 1; index <= maxSequenceLenght; index++) {
        console.log(arr[index]);
    }
}

//5.Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array. Use the "selection sort" algorithm
function selectionSort() {
    var arr = [8, 5, 2, 6, 9, 3, 1 ,0, 4, 7];
    var secondaryArr = [];
    var smallestIndex = 0;

    for (var index = 0; index < arr.length;) {
        smallestIndex = index;
        for (var secIndex = index + 1; secIndex < arr.length; secIndex++) {
            if (arr[smallestIndex] > arr[secIndex]) {
                smallestIndex = secIndex;
            }
        }

        secondaryArr.push(arr[smallestIndex]);
        console.log(secondaryArr);
        arr.splice(smallestIndex, 1);
        console.log(arr);
    }
}

//6.Write a program that finds the most frequent number in an array. 
//Example:{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
function mostFrequentNum() {
    var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
    var number;
    var times = 1;
    var maxTimes;
    var mostFreqElement;

    for (var index = 0; index < arr.length; index++) {
        for (var secIndex = index + 1; secIndex < arr.length; secIndex++) {
            if (arr[index] === arr[secIndex]) {
                number = arr[index];
                times++;
                if (times > maxTimes || maxTimes == null) {
                    maxTimes = times;
                    mostFreqElement = number;
                }
            }

            if (secIndex === arr.length - 1) {
                number = 0;
                times = 1;
            }
        }
    }

    console.log("Most frequent element : " + mostFreqElement);
    console.log("Number of times appeared : " + maxTimes);
}

//7.Write a program that finds the index of given element in a sorted array 
//of integers by using the binary search algorithm (find it in Wikipedia).
function findIndex(values, target) {
    return binarySearch(values, target, 0, values.length - 1);
}

function binarySearch(values, target, start, end) {
    if (start > end) {
        return -1;
    } //does not exist

    var middle = Math.floor((start + end) / 2);
    var value = values[middle];

    if (value > target) {
        return binarySearch(values, target, start, middle - 1);
    }
    if (value < target) {
        return binarySearch(values, target, middle + 1, end);
    }

    console.log("The index of the wanted element(" + target + ") is : " + middle);
}

