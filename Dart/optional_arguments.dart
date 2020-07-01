main() {
  print(sum(2));
  print(sum(2, 2.5));
}

dynamic sum(var num1, [var num2 = 0]) => num1 + num2;
