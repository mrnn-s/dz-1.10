int numberA = new Random().Next(10, 99);
Console.WriteLine($"Chislo {numberA}");
int number1 = (numberA % 10);
int number2 = (numberA / 10);
Console.WriteLine($"pervoe chislo {number1}, vtoroe chislo {number2}");
Console.WriteLine("Max: " + Math.Max(number1, number2));
