var LifeForms = (function () {
    'use strict';

    var Student = function (firstName, lastName, age, gpa) {
        this._firstName = firstName;
        this._lastName = lastName;
        this._age = age || 1;
        this._gpa = gpa || 0;
    };

    Student.prototype.greet = function () {
        console.log('My name is ' + this._firstName + ' ' + this._lastName + ', ' +
            this._age + ' years old');
        console.log('My GPA is: ' + this._gpa);
    };
    
    var collectionOfStudents = function (studentsCount) {
        var students = [];
        for (var i = 0; i < studentsCount; i++) {
            students.push(new LifeForms.Student(
                chance.first(),
                chance.last(),
                chance.integer({ min: 15, max: 30 }),
                chance.floating({ min: 2, max: 6, fixed: 2 })));
        }

        return students;
    }

    var Animal = function (species, numberOfLegs) {
        this._species = species;
        this._numberOfLegs = numberOfLegs;
    };

    Animal.prototype.getInfo = function () {
        console.log(this._species + ', ' + this._numberOfLegs + ' legs');
    };

    var CollectionOfAnimals = function () {
        return [
            new Animal('Reptilia', 4),
            new Animal('Aves', 2),
            new Animal('Mammalia', 4),
            new Animal('Arachnid', 8),
            new Animal('Reptilia', 0),
            new Animal('Aves', 2),
            new Animal('Mammalia', 2),
            new Animal('Arachnid', 16),
            new Animal('Reptilia', 4),
            new Animal('Aves', 2),
            new Animal('Mammalia', 4),
            new Animal('Arachnid', 100)];
    }


    return {
        Student: Student,
        getCollectionOfStudents: collectionOfStudents,
        Animal: Animal,
        getCollectionOfAnimals: CollectionOfAnimals
    };
}());