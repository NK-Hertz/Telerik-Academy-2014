var Person = (function () {
    function Person(fname, lname) {
        this._fname = fname;
        this._lname = lname;
    }

    Person.prototype.introduce = function introduce() {
        console.log("Hello, I am " + this._fname + " " + this._lname);
    }

    return Person;
}());

