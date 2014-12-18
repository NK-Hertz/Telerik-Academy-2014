/// <reference path="../libs/jquery-2.1.1.js" />
var logIn = (function () {
    var self;

    var show = function () {
        $('#container').load('../view/log-in.html');
        $('#btn-submit').on('click', function () {
            window.location = '#/';
        });
    };

    self = {
        show: show
    };

    return self;
}());