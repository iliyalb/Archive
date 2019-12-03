// Old method
/*
let box = document.querySelector(".box");
let newElement = document.createElement("a");
let newContent = document.createTextNode("This is a link!");

newElement.appendChild(newContent);
box.appendChild(newElement);
newElement.setAttribute("href","www.google.com"); 
 */

// New method
let box = document.querySelector(".box");
let newElement = document.createElement("a");

newElement.append("This is a link!");
newElement.setAttribute("href","www.google.com"); 