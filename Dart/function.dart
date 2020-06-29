void main() {
  dynamic result = mul(2, 5);
  print('2 times 5 is $result');
  print('4 times 4 is ${squareNumber(4)}');
  print('2 times 2 times 2 is ${runTwice(2, timesTwo)}');
}

// Typical function
int mul(int a, int b) {
  return a * b;
}

// Shorthand function where Arrow means '{return __;}'
int timesTwo(int x) => (x * 2);
int squareNumber(int x) => (x * x);

// Pass functions as objects
int runTwice(int x, Function f) {
  for (var i = 0; i < 2; i++) {
    x = f(x);
  }
  return x;
}
