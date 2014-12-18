var Book = (function () {
    'use strict';
    function Book(name, author) {
        this._name = name;
        this._author = author;
    }

    Book.prototype.getInfo = function () {
        console.log(this._name + ' by ' + this._author);
    }

    return Book;
}());