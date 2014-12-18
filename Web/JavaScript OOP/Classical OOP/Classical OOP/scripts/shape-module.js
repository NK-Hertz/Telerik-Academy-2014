var shapeModule = (function () {
    var self;

    // Rect, by given position (X, Y) and size (Width, Height)
    function drawRect(x, y, width, height) {
        this._x = x;
        this._y = y;
        this._width = width;
        this._height = height;
        context.beginPath();
        context.rect(this._x, this._y, this._width, this._height);
        context.stroke();
    }

    function drawCircle(x, y, radius) {
        this._x = x;
        this._y = y;
        this._radius = radius;
        context.beginPath();
        context.arc(this._x, this._y, this._radius, 0, 2 * Math.PI);
        context.stroke();
    }

    function drawLine(x1, y1, x2, y2) {
        this._x1 = x1;
        this._y1 = y1;
        this._x2 = x2;
        this._y2 = y2;

        context.beginPath();
        context.moveTo(x1, y1);
        context.lineTo(x2, y2);
        context.stroke();
    }

    self = {
        rect: drawRect,
        circle: drawCircle,
        line: drawLine
    }

    return self;
}());