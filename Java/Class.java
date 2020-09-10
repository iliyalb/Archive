public class Class {
    public static void main(String[] args){
        Person john = new Person("John");
        System.out.println(john.name);
    }

    static class Person {
        String name;

        Person(String name){
            this.name = name;
        }
    }
}