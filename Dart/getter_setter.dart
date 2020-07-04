main() {
  // Instantiation
  var rectangle = Rectangle(2, 5, 20, 25);

  // Checking
  assert(rectangle.right == 22);

  // Output
  rectangle.show();
}

class Rectangle {
  // Type of num can include both int and double
  num left, top, width, height;

  // Constructor
  Rectangle(this.left, this.top, this.width, this.height);

  // Properties
  num get right => left + width;
  set right(num value) => left = value - width;

  // Another property
  num get bottom => top + height;
  set bottom(num value) => top = value - height;

  // Method (Function)
  void show() => print('top: $top,right: $right, bottom: $bottom, left: $left');
}
