/*1.Write functions for working with shapes in  standard Planar coordinate system
Points are represented by coordinates P(X, Y)
Lines are represented by two points, marking their beginning and ending
L(P1(X1,Y1), P2(X2,Y2))
Calculate the distance between two points
Check if three segment lines can form a triangle */
//constructor for points 
function point(x, y) {
    return {
        x: x,
        y: y,
        toString: function () {
            return "x = " + this.x + ", y = " + this.y;
        }
    };
}

function line(point1, point2) {
    return {
        beginning: point1,
        end: point2,
        toString: function () {
            return "Beginning : " + this.beginning + " End : " + this.end;
        },
        CalculateLenght: function () {
            return Math.sqrt(Math.pow((point1.x - point2.x), 2) + Math.pow((point1.y - point2.y), 2));
        }
    };
}

function canFormTriangle(line1, line2, line3) {
    var lineFirst = line1.CalculateLenght();
    var lineSec = line2.CalculateLenght();
    var lineThird = line3.CalculateLenght();

    var canFormTriangleBool = lineFirst + lineSec > lineThird && lineSec + lineThird > lineFirst && lineThird + lineFirst > lineSec;
    console.log("Can form triangle: " + canFormTriangleBool);
    return canFormTriangleBool;
}

function executeTask1() {
    var lineFirst = new line(new point(1, 4), new point(3, 5));
    var lineSec = new line(new point(2, 1), new point(2, 5));
    var lineThird = new line(new point(6, 2), new point(3, 1));

    canFormTriangle(lineFirst, lineSec, lineThird);
}