/*2.Write a function that removes all elements with a given value
    var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
    arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];
Attach it to the array type
Read about prototype and how to attach methods
*/
function executeTask2() {
    Array.prototype.removeElement = function (element) {
            for (var index = 0; index < arr.length; index++) {
                if (arr[index] == element) {
                    arr.splice(index, 1);
                }
            }
        }

    var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1];
    var elementToRemove = 1;

    arr.removeElement(elementToRemove);
    console.log(arr);
}