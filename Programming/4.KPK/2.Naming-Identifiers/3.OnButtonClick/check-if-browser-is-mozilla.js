//Refactor the following examples to produce code with well-named identifiers in JavaScript

function checkIfBrowserIsMozilla() {
    //this is the first option this line to be done
    var CurrentWindowDelegate = window;
    //the other option in my oppinion is without the delegate
    //var browser = window.navigator.appCodeName;
    var browser = CurrentWindowDelegate.navigator.appCodeName;
    var isMozilla = (browser == "Mozilla");

    if (isMozilla) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}
