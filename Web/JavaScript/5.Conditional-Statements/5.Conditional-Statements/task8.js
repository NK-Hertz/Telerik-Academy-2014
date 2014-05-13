function numToText() {
    var num = document.getElementById('number').value;
    var ones = "";
    var tens = "";
    var hundreds = "";
    var special = "";
    var specialActive = false;
    var bucket = num / 100 | 0;
    var bucketTens = num / 10 % 10 | 0;
    var bucketOnes = num % 10 % 10;
    var result = "";

    //hundreds
    if (bucket == 1) {
        ones = "One";
    }
    else if (bucket == 2) {
        ones = "Two";
    }
    else if (bucket == 3) {
        ones = "Three";
    }
    else if (bucket == 4) {
        ones = "Four";
    }
    else if (bucket == 5) {
        ones = "Five";
    }
    else if (bucket == 6) {
        ones = "Six";
    }
    else if (bucket == 7) {
        ones = "Seven";
    }
    else if (bucket == 8) {
        ones = "Eight";
    }
    else if (bucket == 9) {
        ones = "Nine";
    }

    if (bucket !== 0) {
        hundreds = ones + " hundred";
        result = hundreds;
    }
    // tens
    if (bucketTens == 1) {
        //11-19
        if (num % 10 == 1) {
            special = "Eleven";
            specialActive = true;
        }
        else if (num % 10 == 2) {
            special = "Twelve";
            specialActive = true;
        }
        else if (num % 10 == 3) {
            special = "Thirteen";
            specialActive = true;
        }
        else if (num % 10 == 4) {
            special = "Fourteen";
            specialActive = true;
        }
        else if (num % 10 == 5) {
            special = "Fifteen";
            specialActive = true;
        }
        else if (num % 10 == 6) {
            special = "Sixteen";
            specialActive = true;
        }
        else if (num % 10 == 7) {
            special = "Seventeen";
            specialActive = true;
        }
        else if (num % 10 == 8) {
            special = "Eighteen";
            specialActive = true;
        }
        else if (num % 10 == 9) {
            special = "Nineteen";
            specialActive = true;
        }
        else
            tens = "Ten";
    }
    else if (bucketTens == 2) {
        tens = "Twenty";
    }
    else if (bucketTens == 3) {
        tens = "Thirty";
    }
    else if (bucketTens == 4) {
        tens = "Fourty";
    }
    else if (bucketTens == 5) {
        tens = "Fifty";
    }
    else if (bucketTens == 6) {
        tens = "Sixty";
    }
    else if (bucketTens == 7) {
        tens = "Seventy";
    }
    else if (bucketTens == 8) {
        tens = "Eighty";
    }
    else if (bucketTens == 9) {
        tens = "Ninety";
    }
    result = result + " " + tens;

    if (specialActive === true) {
        result = result + " " + special;
    }
    else {
        //ones
        if (bucketOnes == 1) {
            ones = "One";
        }
        else if (bucketOnes == 2) {
            ones = "Two";
        }
        else if (bucketOnes == 3) {
            ones = "Three";
        }
        else if (bucketOnes == 4) {
            ones = "Four";
        }
        else if (bucketOnes == 5) {
            ones = "Five";
        }
        else if (bucketOnes == 6) {
            ones = "Six";
        }
        else if (bucketOnes == 7) {
            ones = "Seven";
        }
        else if (bucketOnes == 8) {
            ones = "Eight";
        }
        else if (bucketOnes == 9) {
            ones = "Nine";
        }
        else {
            ones = "";
        }

        result = result + " " + ones;
    }
    //if all of the buckets are 0 then 
    if (bucket === 0 && bucketTens === 0 && bucketOnes === 0) {
        alert("Zero");
    }
    else {
        alert(result);
    }

}
