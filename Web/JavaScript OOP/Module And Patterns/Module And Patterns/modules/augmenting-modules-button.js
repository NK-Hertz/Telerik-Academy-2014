var controls = controls || {};
(function (scope) {
    var Button = (function () {
        function Button(text) {
            this._text = text;
        }

        return Button;
    }());

    // using lazy-loading method
    scope.getButton = function (text) {
        return new Button(text);
    };

}(controls))