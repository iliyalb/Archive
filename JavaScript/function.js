// Immediate function
(function() {
    console.log("Function loaded!");
}())

// Anonymouse function
var anonymouseVariable = function anonymouseFunction(index){
    var items = ["good", "bad", true];
    return items[index].toString();
}

// User-defined function
function namedFunction(){
    return "This is some " + anonymouseVariable(0) + " content";
}

document.body.innerHTML = namedFunction();