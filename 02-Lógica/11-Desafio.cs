int[] numbers = new int[100];

// Popula o array com os numeros de 1 a 100
for (int i = 0; i < numbers.Length; i++) {
  numbers[i] = i + 1;
}

foreach (int number in numbers) {
  bool firstCondition = number % 3 == 0;
  bool secondCondition = number % 5 == 0;

  if (firstCondition) Console.WriteLine(number + " - Fizz");
  else if (secondCondition) Console.WriteLine(number + " - Buzz");
  else if (firstCondition && secondCondition) Console.WriteLine(number + " - FizzBuzz");
  else Console.WriteLine(number);
}