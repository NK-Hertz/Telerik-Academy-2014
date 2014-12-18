(function () {
    var people = new LifeForms.getCollectionOfStudents(50);
    console.log(people);

    var mostCommonFirstNameCollection = _.chain(people).groupBy(function (person) {
        return person._firstName;
    }).max(function (person) {
        return person.length;
    });

    var mostCommonFirstName = mostCommonFirstNameCollection.value()[0]._firstName;
    var firstNameMet = mostCommonFirstNameCollection.value().length;
    console.log('Most popular first name is ' + mostCommonFirstName +
        ', ' + firstNameMet);

    var mostCommonLastNameCollection = _.chain(people).groupBy(function (person) {
        return person._lastName;
    }).max(function (person) {
        return person.length;
    });

    var mostCommonLastName = mostCommonLastNameCollection.value()[0]._lastName;
    var lastNameMet = mostCommonLastNameCollection.value().length;
    console.log('Most popular last name is ' + mostCommonLastName +
        ', ' + lastNameMet);
}());