// Shorthand method
let car = {
    name: "M5",
    color: "White",
    price: 20000,

    updatePrice: function(){
        return ++car.price;
    }
}

// Longer method
let person = new Object();

person.name = "John";
person.lastName = "Doe";
person.age = "30";

person.updateAge = function(){
    return ++person.age;
}

console.log(person.updateAge());