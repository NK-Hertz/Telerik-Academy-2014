(function () {
    var students = new LifeForms.getCollectionOfStudents(5);
    var studentsWithFirstNameBeforeLast = [];

    // print`em all, don`t catch`em all
    // only the ones with first name before last alphabetically
    console.log('Initial Students');
    _.each(students, function (student) {
        var firstName = student._firstName,
            lastName = student._lastName;

        student.greet();
        //console.log(firstName + ' ' + lastName);
        //console.log(firstName < lastName);

        if (firstName < lastName) {
            studentsWithFirstNameBeforeLast.push(student);
        }
    });

    var sortedDescending =
            //_.sortBy(studentsWithFirstNameBeforeLast, function (student) {
            //    return student._firstName;
            //}).reverse();

            _.sortBy(studentsWithFirstNameBeforeLast, '_firstName').reverse();

    console.log('');
    console.log('Students with firstname before lastname alphabetically:');
    _.each(sortedDescending, function (sortedStudent) {
        sortedStudent.greet();
    });
}());