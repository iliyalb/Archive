function greet(name, lastName) {

    let temp = null;

    if (typeof name == "undefined") { temp = 'Hello stranger!'; }
    if (typeof name !== "undefined") { temp = 'Hello ' + name; }
    if (typeof lastName !== "undefined") { temp = 'Hello ' + name + ' ' + lastName; }

    return temp;
}

console.log(greet());
console.log(greet('Alice'));
console.log(greet('John', 'Smith'));