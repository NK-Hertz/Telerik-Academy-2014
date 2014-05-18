/*6.Write a function that groups an array of persons by age, first or last name. 
The function must return an associative array, with keys - the groups, and values
- arrays with persons in this groups
    Use function overloading (i.e. just one function)
    var persons = {…};
    var groupedByFname = group(persons, 'firstname');
    var groupedByAge= group(persons, 'age');
 */
function executeTask6() {

    function printArray(resultArr) {
        for (var i = 0; i < resultArr.length; i++) {
            console.log(resultArr[i].key + ": ");
            for (var j in resultArr[i].group) {
                console.log("(" + resultArr[i].group[j].firstname + " " + resultArr[i].group[j].lastname + ") ");
            }
            console.log();
        }
    }

    function groupByProperty(array, property) {
        var resultArr = new Array();

        resultArr.contains = function (key) {
            for (var i = 0; i < resultArr.length; i++) {
                if (this[i].key == key) {
                    return i;
                }
            }

            return -1;
        }

        switch (property) {
            case "age":
                for (var person in persons) {
                    var index = resultArr.contains(persons[person].age);

                    if (index == -1) {
                        resultArr.push({ key: persons[person].age, group: new Array(persons[person]) });
                    }
                    else {
                        resultArr[index].group.push(persons[person]);
                    }
                }
                break;
            case "firstname":
                for (var person in persons) {
                    var index = resultArr.contains(persons[person].firstname);

                    if (index == -1) {
                        resultArr.push({ key: persons[person].firstname, group: new Array(persons[person]) });
                    }
                    else {
                        resultArr[index].group.push(persons[person]);
                    }
                }
                break;
            case "lastname":
                for (var person in persons) {
                    var index = resultArr.contains(persons[person].lastname);

                    if (index == -1) {
                        resultArr.push({ key: persons[person].lastname, group: new Array(persons[person]) });
                    }
                    else {
                        resultArr[index].group.push(persons[person]);
                    }
                }
                break;
            default:
                console.log("The properties are age, firstname, lastname.You must chose between them!");
                break;
        }

        return resultArr;
    }

    var persons = [
     { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
     { firstname: 'Bay', lastname: 'Ivan', age: 81 },
     { firstname: 'Ivan', lastname: 'Petrov', age: 18 },
     { firstname: 'Kiril', lastname: 'Ivaylov', age: 21 },
     { firstname: 'Nikolai', lastname: 'Ivan', age: 29 },
     { firstname: 'Toshko', lastname: 'Ivan', age: 21 },
     { firstname: 'Mihail', lastname: 'Tunev', age: 81 },
     { firstname: 'Kiril', lastname: 'Tonev', age: 21 },
     { firstname: 'Bay', lastname: 'Kushlev', age: 32 }
    ];

    console.log("Group by age:");
    var groupedByAge = groupByProperty(persons, "age");
    printArray(groupedByAge);

    console.log("Group by first name:");
    var groupedByFirstName = groupByProperty(persons, "firstname");
    printArray(groupedByFirstName);

    console.log("Group by last name:");
    var groupedByLastName = groupByProperty(persons, "lastname");
    printArray(groupedByLastName);
}