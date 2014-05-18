/*4.Write a function that checks if a given object contains a given property
 * var obj  = …;
 * var hasProp = hasProperty(obj, 'length');
 */
function hasProperty(obj, property) {
    for (var prop in obj) {
        if (prop == property) {
            console.log("The object has the property " + property);
            return true;
        }
    }

    console.log("The object doesn`t have the property " + property);
    return false;
}

function executeTask4() {
    var obj = document;
    var hasProp = 'all';
    hasProperty(obj, hasProp);

    var car = {
        name: "Mazda",
        model: "x3",
        gears: "Stick shitf",
        color: "white",
        toString: function () {
            return "Name " + this.name + ", Model " + this.model;
        }
    }
    
    hasProp = 'color';
    hasProperty(car, hasProp);
    
    //how it should be
    hasProperty(Array, 'length');
}