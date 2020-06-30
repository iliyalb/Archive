main() {
  var number = null, objectNumber = Number();

  // A condition to prevent error of assigning null
  if (objectNumber.num != null) {
    number = objectNumber.num;
  }

  // A condition to assign values to objects (??) if they are null (?.)
  number = objectNumber?.num ?? 123;

  // Same as above
  print(number ??= 555);
}

class Number {
  int num = 10;
}
