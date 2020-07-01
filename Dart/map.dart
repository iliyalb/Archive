main() {
  Map<String, String> elements = {
    'H': 'Hydrogen',
    'He': 'Helium',
    'Li': 'Lithium',
    'Be': 'Beryllium'
  };

  elements['B'] = 'Boron';

  elements.forEach((key, value) => print('$key : $value'));
}
