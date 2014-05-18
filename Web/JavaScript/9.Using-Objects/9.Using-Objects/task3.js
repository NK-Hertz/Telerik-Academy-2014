/*3.Write a function that makes a deep copy of an object
 The function should work for both primitive and reference types
*/
function deepCopy(variable) {
    var copyVariable = new Object();
    var typeOfVar = typeof (variable);
    switch (typeOfVar) {
        case "object":
            for (var prop in variable) {
                copyVariable[prop] = variable[prop];
            }

            break;
        default:
            copyVariable = variable;
            break;
    }

    return copyVariable;
}

function executeTask3() {
    var string = "waka maka fo";
    var stringCopy = deepCopy(string);
    console.log(stringCopy);

    var person = {
        fname: "Ime",
        lname: "Familiq",
        toString: function () {
            return this.fname + " " + this.lname;
        }
    }

    var personCopy = deepCopy(person);
    person.fname = "Veselin";
    console.log(person.toString());
    console.log(personCopy.toString());
}