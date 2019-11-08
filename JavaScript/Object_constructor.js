function Person(name, age) {
    this.name = name;
    this.age = age;

    this.updateAge = function(){
        return ++this.age;
    };
}

let person = new Person("John", 15);

console.log(person.updateAge());