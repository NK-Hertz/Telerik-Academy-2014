/// <reference path="../libs/jquery-2.1.1.js" />
/// <reference path="requester.js" />
(function () {
    var resourceUrl = 'http://crowd-chat.herokuapp.com/posts';

    function postMessage(data) {
        requester.postJSON(resourceUrl, data);
    }

    function loadMessages() {
        var maxMessagesToDisplay = 50;
        var messages = requester.getJSON(resourceUrl).then(function (data) {
            console.log(data);
            var startIndex = data.length - maxMessagesToDisplay;
            var len = data.length;
            var $messageConsole = $('<div>').attr('id', 'message-console');
            var messageFragment = document.createDocumentFragment();
            for (var i = startIndex; i < len; i++) {
                var $currentDiv = $('<div>').html('<strong>' +
                            data[i].by + '</strong>:' + data[i].text);
                $currentDiv.appendTo(messageFragment);
            }
            
            $('#container').html(messageFragment);

        });


    }

    setInterval(loadMessages, 1000);
}());