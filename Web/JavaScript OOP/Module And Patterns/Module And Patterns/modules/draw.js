/// <reference path="../libs/kinetic.min.js" />
var fieldElements = (function () {
    'use strict';
    var FIELD_ELEMENTS_SIZE = 15;

    function drawField(stage) {
        var stageWidth = stage.getWidth(),
            stageHeight = stage.getHeight();

        var field = new Kinetic.Rect({
            width: stageWidth,
            height: stageHeight,
            fill: '#3a4719',
            stroke: '#c96809',
            strokeWidth: FIELD_ELEMENTS_SIZE
        });

        return field;
    }

    function generateFoodAtRandomPosition(stage) {
        var food;

        // generate food within borders
        var xCoord = Math.floor((Math.random() * (stage.getWidth() - 50)) + FIELD_ELEMENTS_SIZE + 15),
            yCoord = Math.floor((Math.random() * (stage.getHeight() - 55)) + FIELD_ELEMENTS_SIZE + 15),
            foodSize = 15;

        food = {
            xCoord: xCoord,
            yCoord: yCoord,
            foodSize: foodSize
        };

        return food;
    }

    function drawFood(stage) {
        // 1 food pls... at a time, after its eaten generate new one
        var generatedFood = generateFoodAtRandomPosition(stage);
        var food = new Kinetic.Arc({
            outerRadius: generatedFood.foodSize,
            stroke: 'black',
            fill: 'red',
            strokeWidth: 1,
            angle: 360,
            rotationDeg: 0,
            x: generatedFood.xCoord,
            y: generatedFood.yCoord
        });

        return food;
    }

    function drawSnake() {
        var snakeLenght = 4,
            snake = {};
        var snakeHead = new Kinetic.Arc({
            outerRadius: FIELD_ELEMENTS_SIZE,
            stroke: 'black',
            fill: 'yellow',
            strokeWidth: 1,
            angle: 360,
            rotationDeg: 0,
            x: 170,
            y: 50
        });

        snake[0] = snakeHead;
        //console.log(snake);
        //console.log(snake[0]);

        for (var i = 1; i < snakeLenght; i++) {
            var snakeXPos = snake[i - 1].x();
            snake[i] = new Kinetic.Circle({
                radius: FIELD_ELEMENTS_SIZE,
                stroke: 'black',
                fill: 'yellow',
                strokeWidth: 1,
                x: snakeXPos - 2 * FIELD_ELEMENTS_SIZE,
                y: 50
            });

            //console.log(snakeXPos);
        }
            
        return snake;
    }

    return {
        drawField: drawField,
        drawFood: drawFood,
        drawSnake: drawSnake
    };

}());

var stage = new Kinetic.Stage({
    container: 'canvas-container',
    width: 700,
    height: 500
});


var baseField = new fieldElements.drawField(stage);
var fieldLayer = new Kinetic.Layer();
fieldLayer.add(baseField);
stage.add(fieldLayer);

var snakeLayer = new Kinetic.Layer();
var snake = new fieldElements.drawSnake();
var snakeLenght = Object.keys(snake).length;
for (var i = 0; i < snakeLenght; i++) {
    snakeLayer.add(snake[i]);
}

var foodLayer = new Kinetic.Layer();
foodLayer.add(new fieldElements.drawFood(stage));
stage.add(foodLayer);


stage.add(snakeLayer);
