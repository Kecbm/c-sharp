Random random = new Random();
int coin = random.Next(1, 5);

Console.WriteLine($"{(coin % 2 == 0 ? "heads" : "tails")}");