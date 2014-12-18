/// <reference path="../libs/jquery.min.js" />
/// <reference path="../libs/require.js" />
define(['jquery'], function () {
    'use strict';
    // check - hold a set of items - array 
    var controls = (function () {
        function ComboBox(items) {
            //console.log('Inside ComboBox');
            var itemsLenght = Object.keys(items).length;
            var rootDir = $('#root');
            //can be made with Document Fragment for larger count of items
            for (var i = 0; i < itemsLenght; i++) {
                //console.dir(items[i]);
                var currentItem = items[i];
                var $currentDiv =
                    $('<div>').text(currentItem).appendTo(rootDir).hide();
                // check - the first item is visible
                // made this way the implementation always makes the first item in 
                // the collection 'selected'
                if (i === 0) {
                    $currentDiv.attr('id', 'selected').show();
                }
            }

            var $selectedDiv = $('#selected');
            var $selectedsParent = $selectedDiv.parent();
            // check - when clicked, all items are shown
            $selectedsParent.on('click', function (event) {
                // change selected
                var $eventTarget = $(event.target);
                var $isSelected = $eventTarget.attr('id') === $selectedDiv.attr('id');
                //console.log($isSelected);

                // check - if an item is clicked it becomes selected
                if (!$isSelected) {
                    $eventTarget.attr('id', 'selected');
                    $eventTarget.css('border', '1px solid black');
                    $eventTarget.siblings().hide();
                }
                else {
                    $eventTarget.siblings().show();
                }
            });

            function clearIDs(selected) {
                var $lastSelected = $(selected);
                $lastSelected.siblings().removeAttr('id');
            }

            // bug - all items are left with id = 'selected' after being selected once
            // and double click event work only on the first 'selected' from the collection
            $selectedDiv.on('dblclick', function () {
                clearIDs($selectedDiv);
                $selectedDiv.siblings().hide();
            });
        }
        
        // each item can contain a valid html code - so it must be escaped

        //controls.ComboBox(items)
        //template
        //comboBox.render(template) - additional method using handlebars compile

        controls = {
            ComboBox: ComboBox
        };

        return controls;
    }());

    return controls;
});