Console.Write("enter number1:");
double pervoeChislo = double.Parse(Console.ReadLine() ?? "0");
Console.Write("enter number2:");
double vtoroeChislo = double.Parse(Console.ReadLine() ?? "0");
double ostatok = (pervoeChislo % vtoroeChislo);
if (  pervoeChislo % vtoroeChislo == 0)
{
    Console.WriteLine("Chislo cratno");
}
else
{
    Console.WriteLine($" chislo nekratnoe,ostatok ot delenia {ostatok}");
}