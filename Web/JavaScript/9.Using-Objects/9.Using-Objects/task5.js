/*5.Write a function that finds the youngest person in a given array of persons and prints his/hers full name
 *Each person have properties firstname, lastname and age, as shown:
 * var persons = [
  { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
 */
function getYoungestPerson(people) {
    var minAge = people[0].age;
    var youngestName;
    var minAgeBest = people[0].age;
    var youngestNameBest;
    for (var person in people) {
        if (minAge > people[person].age) {
            minAge = people[person].age;
            youngestName = people[person].firstname + " " + people[person].lastname;

            if (minAgeBest > minAge) {
                minAgeBest = minAge;
                youngestNameBest = youngestName;
            }
        }
    }

    var result = "Youngest person is : " + youngestNameBest + ", with age of : " + minAgeBest;
    console.log(result);
    return result;
}

function executeTask5() {
    var persons = [
 { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
 { firstname: 'Bay', lastname: 'Ivan', age: 81 },
 { firstname: 'Ivan', lastname: 'Petrov', age: 18 },
 { firstname : 'Kiril', lastname: 'Tonev', age: 21 },
 { firstname: 'Nikolai', lastname: 'Penchev', age: 29 }];

    getYoungestPerson(persons);
}