/// <reference path="modules/controls.js" />
/// <reference path="libs/jquery.min.js" />
//app.js
(function () {
    'use strict';
    require.config({
        paths: {
            "jquery": "libs/jquery.min",
            "handlebars": "libs/handlebars.min"
        }
    });

    require(['modules/controls'], function (controls) {
        var arrayOfOptions = ['One', 'Two', 'Three'];        

        var printBox = controls.ComboBox(arrayOfOptions);
        //console.log(printBox);
    });
}());
