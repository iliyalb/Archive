void main() {
  List stuff = ['John', 30, '😂', true];
  List<String> names = ['Foo', 'Bar', 'Baz'];
  List<int> numbers = [10, 20, 30, 50];

  stuff.remove('😂');
  numbers.add(40);
  numbers.sort();

  print(stuff);
  print(names);
  print(numbers);
}
