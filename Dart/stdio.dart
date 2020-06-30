import 'dart:io';

main() {
  stdout.write('Enter name: ');
  String name = stdin.readLineSync();
  print('Hey there $name!\n');
}
