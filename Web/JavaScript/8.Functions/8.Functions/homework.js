﻿//1.Write a function that returns the last digit of given integer as an English word. 
//Examples: 512 > "two", 1024 > "four", 12309 > "nine"
function returnLastDigit() {
    var num = 12309;
    var result = num % 10;
    var resultString = "";
    switch (result) {
        case 0: resultString = "Zero"; break;
        case 1: resultString = "One"; break;
        case 2: resultString = "Two"; break;
        case 3: resultString = "Three"; break;
        case 4: resultString = "Four"; break;
        case 5: resultString = "Five"; break;
        case 6: resultString = "Six"; break;
        case 7: resultString = "Seven"; break;
        case 8: resultString = "Eight"; break;
        case 9: resultString = "Nine"; break;
        default:
            resultString = "The input should be a number!"; break;
    }

    console.log(resultString);
}

//2.Write a function that reverses the digits of given decimal number. Example: 256  652
function reverseDigits() {
    var num = (256).toString();
    var result = "";
    for (var index = num.length - 1; index >= 0; index--) {
        result += num[index];
    }

    console.log(result);
}

//3.Write a function that finds all the occurrences of word in a text
//The search can case sensitive or case insensitive
//Use function overloading
var text = document.getElementById("textToUse").innerHTML;
var wordToSearch = "Keanu";
var caseSensitive = false;

function searchFor(text, word, caseSensitive) {
    textToUse = text || document.getElementById("textToUse").innerHTML;
    wordToSearch = word || "Keanu";
    caseSensitive = caseSensitive || false;
    var wordCount = 0;
    
    if (caseSensitive === false) {
        var strArr = textToUse.split(wordToSearch);

        for (var str in strArr) {
            wordCount++;
        }
        
        console.log("Case-insesitive");
        console.log("Word to search for: " + wordToSearch + ", Word count: " + wordCount);
    }
    else {
        var index = text.indexOf(wordToSearch);

        while (index >= 0) {
            countSearchedWord++;
            index = text.indexOf(wordToSearch, index+1);
        }

        console.log("Case-sesitive");
        console.log("Word to search for: " + wordToSearch + ", Word count: " + wordCount);
    }
}

//4.Write a function to count the number of divs on the web page
function divCounter() {
    var divs = document.getElementsByTagName("div").length;
    console.log("Total divs in the page : " + divs);
}

//5.Write a function that counts how many times given number appears in given array. 
//Write a test function to check if the function is working correctly.
function numCounter(arr, num) {
    var myArr = arr || [1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6];
    var numToSearch = num || 5;
    var count = 0;
    for (var index = 0; index < myArr.length; index++) {
        if (numToSearch === myArr[index]) {
            count += 1;
        }
    }

    console.log("The number " + numToSearch + " appears "  + count + " times");
    return count;
}

function testNumCounter() {
    if (numCounter([1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6], 1) != 1) {
        return false;
    }
    if (numCounter([1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6], 2) != 2) {
        return false;
    }
    if (numCounter([1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6], 3) != 3) {
        return false;
    }
    if (numCounter([1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6], 4) != 1) {
        return false;
    }
    if (numCounter([1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6], 5) != 4) {
        return false;
    }
    if (numCounter([1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5, 6], 6) != 1) {
        return false;
    }
    
    return true;
}

//6.Write a function that checks if the element at given position in given array of 
//integers is bigger than its two neighbors (when such exist).
function checkNeighbors(position) {
    var arr = [96, 30, 85, 73, 6, 58, 34, 64, 10, 4, 83, 34, 98, 61, 48];
    //if there is no position as input it will automatically search at 14 pos
    var posToCheck = position;
    var isBiggerThanNeighbors = false;
    //if the position is always a number(index) within the limits of the array  
    if (posToCheck == 0) {
        if (arr[posToCheck] > arr[posToCheck + 1]) {
            isBiggerThanNeighbors = true;
        }
    }
    else if (posToCheck == arr.length - 1) {
        if (arr[posToCheck] > arr[posToCheck - 1]) {
            isBiggerThanNeighbors = true;
        }
    }
    else {
        if (arr[posToCheck] > arr[posToCheck - 1] && arr[posToCheck] > arr[posToCheck + 1]) {
            isBiggerThanNeighbors = true;
        }
    }

    console.log("Is the number at pos " + posToCheck + " bigger than its neighbors : " + isBiggerThanNeighbors);
    return isBiggerThanNeighbors;
}

//7.Write a function that returns the index of the first element in array that is bigger 
//than its neighbors, or -1, if there’s no such element.
//Use the function from the previous exercise.
function indexOfBiggerThanNeighbors(arr) {
    for (var index = 0; index < arr.length; index++) {
        if (checkNeighbors(index) == true) {
            console.log("The first number bigger than its neighbors is : " + arr[index]);
            console.log("And the index is : " + index);
            return index;
        }
    }

    console.log("There is no number bigger than its two neighbors");
    return -1;
}