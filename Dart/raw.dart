main() {
  var multiline = '''
  This string
  is split into
  several lines
  ''';

  print(r"In a raw string, characters such as \n and $ can't escape." +
      multiline);
}
