main() {
  // Instantiation
  Car tesla = Car('Tesla Model X', 2015, 100000);
  tesla.show();
}

class Vehicle {
  String model;
  int year;

  // Constructor
  Vehicle(this.model, this.year);

  void show() {
    print(model);
    print(year);
  }
}

class Car extends Vehicle {
  double price;

  Car(model, year, this.price) : super(model, year);

  void show() {
    super.show();
    print('\$$price');
  }
}
