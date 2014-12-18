/// <reference path="../libs/jquery-2.1.1.js" />
var requester = (function () {
    'use strict';
    var self;

    function getJSON(url) {
        var deferred = $.Deferred();

        $.ajax({
            type: 'GET',
            url: url,
            success: function (data) {
                //console.log(data);
                deferred.resolve(data);
            },
            error: function (error) {
                console.log(error);
                deferred.reject(error);
            }
        });

        return deferred.promise();
    }

    function postJSON(url, data) {
        var deferred = $.Deferred();

        $.ajax({
            type: 'POST',
            url: url,
            data: data,
            success: function (data) {
                console.log(data);
                deferred.resolve(data);
            },
            error: function (error) {
                console.log(error);
                deferred.reject(error);
            }
        });

        return deferred.promise();
    }

    self = {
        getJSON: getJSON,
        postJSON: postJSON
    };

    return self;
}());