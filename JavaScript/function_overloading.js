function greet(name, lastName) {

    let temp = null;

    if (typeof name == "undefined") { temp = 'Hello stranger!'; }
    if (typeof name !== "undefined") { temp = 'Hello ' + name; }
    if (typeof lastName !== "undefined") { temp = 'Hello ' + name + ' ' + lastName; }

    console.log(temp);
}

greet();
greet('Alice');
greet('John', 'Smith');