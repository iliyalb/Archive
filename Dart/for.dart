main() {
  List<String> names = ['John', 'Jill', 'Jack', 'Judy'];

  // for loop
  for (int i = 0; i < names.length; i++) {
    print(names[i]);
  }

  // for-in loop
  for (var name in names) {
    print(name);
  }

  // foreach loop
  names.forEach((name) => print(name));
}
