/// <reference path="../libs/underscore.js" />
/// <reference path="../libs/chance.js" />
(function () {
    var students = new LifeForms.getCollectionOfStudents(5);

    _.each(students, function (student) {
        student.greet();
    });

    var studentWithHighestGPA = _.chain(students).sortBy(function (student) {
                                    return student._gpa;
                                }).last().value();

    console.log('');
    console.log(studentWithHighestGPA.greet());
}());