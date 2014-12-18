(function () {
    var students = new LifeForms.getCollectionOfStudents(5);

    _.each(students, function (student) {
        student.greet();
    });

    var studentsBetween18And24 = _.filter(students, function (student) {
        return 18 <= student._age && student._age <= 24
    });

    console.log('');
    console.log('Between 18 and 24');
    _.each(studentsBetween18And24, function (student) {
        student.greet();
    });
}());