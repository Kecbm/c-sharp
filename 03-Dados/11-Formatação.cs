string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);

Console.WriteLine(result);

Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

decimal price = 123.45m;
int discount = 50;

Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;

Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;

Console.WriteLine($"Tax rate: {tax:P2}");