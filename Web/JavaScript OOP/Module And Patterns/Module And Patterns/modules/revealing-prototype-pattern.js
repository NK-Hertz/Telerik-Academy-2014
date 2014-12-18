var engineType = {
    Gasoline: "Gasoline",
    Diesel: "Diesel"
};

var roofType = {
    Normal: "Normal",
    Removable: "Removable"
};

var Car = function (model) {
    this._model = model;
    this._doors = 2;
    this._engine = 1.4;
    this._engineType = engineType.Gasoline;
    this._roof = roofType.Normal;
};

Car.prototype = (function () {
    function addExtraFamilyCarEditionDoors() {
        this._doors = 4;
    };

    function addExtraRemovableRoof() {
        this._roof = roofType.Removable;
    };

    function showSpecs() {
        for (var prop in this) {
            var isValidPropOfCar = typeof(this[prop]) !== typeof(Car.prototype.ShowSpecs);
            if (isValidPropOfCar) {
                console.log(this[prop]);
            }
        }
    };

    return {
        FamilyDoors: addExtraFamilyCarEditionDoors  ,
        RemovableRoof: addExtraRemovableRoof,
        ShowSpecs: showSpecs
    };
}());