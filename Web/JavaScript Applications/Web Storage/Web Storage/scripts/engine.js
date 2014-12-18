/// <reference path="../libs/underscore.js" />
(function () {
    var digits = [];
    var digitsCount = 4;
    var MIN_DIGIT = 0;
    var MAX_DIGIT = 9;

    function generateRandomNumber(min, max) {
        return Math.floor((Math.random() * max) + min);
    }

    // initializing the first digit to be bigger than 0
    function generateFourRandomDifferentDigits() {
        // first element should be bigger than 0
        var currentDigit = generateRandomNumber(1, MAX_DIGIT);
        digits.push(currentDigit);

        for (var i = 1; i < digitsCount; i++) {
            currentDigit = generateRandomNumber(MIN_DIGIT, MAX_DIGIT);

            // currentDigit should NOT exist
            var checkDigitsForCurrentDigit = _.find(digits, function (digit) {
                return digit === currentDigit;
            });

            var doesCurrentDigitExist = !(_.isUndefined(checkDigitsForCurrentDigit));

            while (doesCurrentDigitExist) {
                currentDigit = generateRandomNumber(MIN_DIGIT, MAX_DIGIT);

                checkDigitsForCurrentDigit = _.find(digits, function (digit) {
                    return digit === currentDigit;
                });

                doesCurrentDigitExist = !(_.isUndefined(checkDigitsForCurrentDigit));
            }

            digits.push(currentDigit);
        }

        console.log(digits.toString());
        return digits
    }

    var digits = generateFourRandomDifferentDigits();

    var turnsCountElement = document.getElementById('turnsCount');
    var turnsCount = turnsCountElement.innerText;

    function handleUserInput() {
        var userInput = parseInt(document.getElementById('userInput').value);
        var isInputValidLength = userInput.toString().length != digitsCount;
        if (_.isNaN(userInput)) {
            alert('You must enter a valid number!');
        }
        else if (isInputValidLength) {
            alert('You must enter four digits!');
        }
        else {
            var userInputAsArray = [];
            userInput = userInput.toString();
            for (var i = 0; i < digitsCount; i++) {
                userInputAsArray.push(parseInt(userInput[i]));
            }

            checkUserGuess(userInputAsArray);
        }
    }

    function checkUserGuess(userInputAsArray) {
        turnsCount++;
        turnsCountElement.innerText = turnsCount;

        var ramsCount = checkForRams(userInputAsArray, digits);

        if (ramsCount === digitsCount) {
            gameOver();
            window.location.reload();
        }
        else {
            var sheepsCount = checkForSheeps(userInputAsArray, digits);
        }
    }

    function checkForRams(userInputAsArray, digits) {
        var ram = 0;
        for (var i = 0; i < digitsCount; i++) {
            if (userInputAsArray[i] === digits[i]) {
                ram++;
            }
        }

        var ramsDisplayElement = document.getElementById('rams');
        ramsDisplayElement.innerText = ram;
        return ram;
    }

    function checkForSheeps(userInputAsArray, digits) {
        var sheep = 0;
        var cloneDigits = [];
        _.extend(cloneDigits, digits);

        // removing rams so the search for sheeps will work properly
        for (var i = digitsCount - 1; i >= 0; i--) {
            if (userInputAsArray[i] === cloneDigits[i]) {
                cloneDigits.splice(i, 1);
            }
        }

        for (var i = 0; i < digitsCount; i++) {
            for (var j = 0; j < cloneDigits.length; j++) {
                if (userInputAsArray[i] === cloneDigits[j]) {
                    sheep++;
                    cloneDigits.splice(j, 1);
                }
            }
        }

        var sheepsDisplayElement = document.getElementById('sheeps');
        sheepsDisplayElement.innerText = sheep;
        return sheep;
    }

    function gameOver() {
        var endGameText = 'GEEGEE\nNumber of turns: ' + turnsCount + '\nEnter nickname: ';
        var nickName = prompt(endGameText, 'Nostradamus');
        var currentUser = {
            nickName: nickName,
            turnsCount: turnsCount
        };

        window.localStorage.setObject(nickName, currentUser);
    }

    var enterButton = document.getElementsByTagName('button')[0];
    enterButton.onclick = handleUserInput;
    
    // extend localStorage
    Storage.prototype.setObject = function setObject(key, object) {
        this.setItem(key, JSON.stringify(object));
    }
    Storage.prototype.getObject = function getObject(key) {
        return JSON.parse(this.getItem(key));
    }

    function getAllUsers() {
        var allUsers = [];
        var usersCount = window.localStorage.length;
        for (var i = 0; i < usersCount; i++) {
            var currentUser = window.localStorage.getObject(window.localStorage.key(i));
            allUsers.push(currentUser);
        }

        return allUsers;
    }

    var allUsers = getAllUsers();
    var sortedUsers = _.sortBy(allUsers, function (user) {
        return user.turnsCount;
    });

    var highscoreFragment = new DocumentFragment();
    _.each(sortedUsers, function (user) {
        var currentUser = document.createElement('div');
        currentUser.innerText = user.nickName + ', ' + user.turnsCount;
        highscoreFragment.appendChild(currentUser);
    });
    
    var highscoreDiv = document.getElementById('highscoreList');
    highscoreDiv.appendChild(highscoreFragment);
}());