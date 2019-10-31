let person = {
    name: 'John',
    age: 30
};

// Dot Notation
person.name = 'Mike';

let selection = 'name';

// Bracket Notation
person[selection] = 'Alice';

console.log(person.name);