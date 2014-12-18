/// <reference path="../libs/underscore.js" />
/// <reference path="life-forms.js" />
(function () {
    var animals = new LifeForms.getCollectionOfAnimals();
    _.each(animals, function (animal) {
        //animal.getInfo();
    })

    var sortedAndGroupedAnimals = _.chain(animals).groupBy(function (animal) {
        return animal._species;
    }).value();

    sortedAndGroupedAnimals = _.map(sortedAndGroupedAnimals, function (species) {
        species = _.sortBy(species, function (animal) {
            return animal._numberOfLegs;
        });
        
        return species;
    });

    _.each(sortedAndGroupedAnimals, function (species) {
        _.each(species, function (animal) {
            animal.getInfo();
        });
    });

    function countLegs(animals) {
        var totalLegsCount = 0;
        _.each(animals, function (animal) {
            totalLegsCount += animal._numberOfLegs;
        });

        console.log('Total number of legs is ' + totalLegsCount);
    }
    
    countLegs(animals);
    
}());