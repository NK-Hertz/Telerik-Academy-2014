/// <reference path="../libs/oauth.js" />
/// <reference path="../libs/jquery-2.1.1.js" />
(function () {

    function authenticate() {
        OAuth.initialize('5GpUb0yno56fFqUoSn8WBGmnFfc');
        var authPromise = OAuth.popup('twitter', {
            cache: true
        });
		

        return authPromise;
    }

    $('#logIn').on('click', function () {
        authenticate()
        .done(function (result) {
            console.log('Successfuly loged in!');
            //console.log(result);
        })
        .fail(function (error) {
            console.log(error);
        });
    });

    $('#getTweetsBtn').on('click', function () {
        var screenName = document.getElementsByTagName('input')[0].value;
        var numberOfTweets = document.getElementsByTagName('input')[1].value;

        var requestUrl = 'https://api.twitter.com/1.1/statuses/user_timeline.json?screen_name=' +
            screenName + '&count=' + numberOfTweets;

        authenticate()
        .done(function (result) {
            result.get(requestUrl)
            .done(function (response) {
                console.log('User messages recieved.');
                console.log(response);

                appendTweetsToDOM(response);
            })
            .fail(function (error) {
                console.log(error);
            });
        })
        .fail(function (error) {
            console.error(error);
        });
    });

    function appendTweetsToDOM(collection) {
        var $tweetConsole = $('#tweetConsole');
        $tweetConsole.text('');

        var tweetFragment = document.createDocumentFragment();
        for (var i = 0, len = collection.length; i < len; i++) {
            var createdAt = collection[i].created_at;
            var currentTweetText = collection[i].text;
            var $currentTweetTextContainer = $('<div>').html('--' + currentTweetText);
            var $currentTweet = $('<div>').html(createdAt);
            
            $currentTweet.append($currentTweetTextContainer);
            $(tweetFragment).append($currentTweet);
        }

        $tweetConsole.append(tweetFragment);
    }
}());
