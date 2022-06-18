int fahrenheit = 94;
decimal celcius = (fahrenheit - 32) * (5m / 9m);
celcius = decimal.Round(celcius, 1);

Console.WriteLine("The temperature is " + celcius + " Celcius.");