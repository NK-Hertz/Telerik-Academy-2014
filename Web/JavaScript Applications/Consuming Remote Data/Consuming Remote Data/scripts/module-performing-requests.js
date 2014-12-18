/// <reference path="../libs/jquery-2.1.1.js" />
var requestModule = function () {
    'use strict';
    var self;

    var defaultHeaders = {
        accept: '',
        connection: 'keep - alive',
        contentType: '',
        data: null,
        // success and error are not made like promises
        success: function (success) {
            if (!success) {
                return;
            }

            console.log(success);
        },
        error:  function (error) {
            if (error) {
                return;
            }

            console.log(error);
        }
    };

    function getJSON(url, headers) {
        if (!headers) {
            headers = defaultHeaders;
        }

        $.ajax({
            type: 'GET',
            url: url,
            accept: headers.accept,
            connection: headers.connection,
            contentType: headers.contentType
        }).then(headers.success, headers.error).done();
    }

    function postJSON(url, headers) {
        if (!headers) {
            headers = defaultHeaders;
        }

        $.ajax({
            type: 'POST',
            url: url,
            accept: headers.accept,
            connection: headers.connection,
            contentType: headers.contentType,
            data: headers.data
        }).then(headers.success, headers.error).done();
    }

    self = {
        getJSON: getJSON,
        postJSON: postJSON
    };

    return self;
};