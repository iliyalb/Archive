for (int i = 1; i <= 100; i++) {
    Console.WriteLine ((i % 15 == 0) ? "FizzBuzz" :((i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString()));
}