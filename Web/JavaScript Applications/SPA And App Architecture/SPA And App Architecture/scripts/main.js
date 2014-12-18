/// <reference path="log-in-handler.js" />
/// <reference path="requester.js" />
/// <reference path="../libs/sammy-0.7.4.js" />
/// <reference path="../libs/jquery-2.1.1.js" />
(function () {
    var resourceUrl = 'http://crowd-chat.herokuapp.com/posts';

    var app = Sammy('#container', function () {
        this.get('#/', function () {
            $('#container').html('<h1>Welcome!</h1>');
        });

        this.get('#/log-in', function () {
            logIn.show();
        });
        
        this.get('#/chat', function () {

            // works
            var allMessages = requester.getJSON(resourceUrl);
            $('#container').html(allMessages);

            var userMsg = {
                user: '1111',
                text: 'hahaaha'
            };
            // works
            //requester.postJSON(resourceUrl, userMsg);

        });
    });

    app.run('#/');
}());