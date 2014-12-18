var controls = (function () {
    var Calculator = (function () {
        this._div = document.createElement('div');
        var initialHTML = "My Calc: ";
        this._div.innerHTML = initialHTML;
        document.body.appendChild(this._div);

        var Calculator = function () {

        }

        Calculator.prototype.sum = function sum(a, b) {
            var result = a + b;
            appendResult(result);
            return result;
        }

        Calculator.prototype.subtract = function subtract(a, b) {
            var result = a - b;
            appendResult(result);
            return result;
        }

        function appendResult(result) {
            this._div.innerHTML =initialHTML + result;
        }
        //Calculator = {
        //    sum: sum,
        //    subtr: subtract
        //}

        return Calculator;
    }());

    return {
        Calculator: Calculator,
    };
}());