main() {
  var intvar = int.parse('1');
  // stop execution if it's not correct
  assert(intvar == 1);

  String stringvar = 123.toString();
  assert(stringvar == '123');

  print(stringvar.runtimeType);
}
