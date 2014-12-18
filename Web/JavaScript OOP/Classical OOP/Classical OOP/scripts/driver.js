var Driver = (function () {
    function Driver(fname, lname, experiance) {
        Person.call(this, fname, lname);
        this._experiance = experiance;
    }

    Driver.prototype = new Person();

    Driver.prototype.introduceDriver = function () {
        //Person.prototype.introduce(this);
        //Person.call(Person.prototype.introduce(this));
        // right way to call parent method
        Person.prototype.introduce.call(this);
        console.log("I have " + this._experiance + " years experience");
    }

    return Driver;
}());