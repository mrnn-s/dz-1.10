Console.WriteLine("Введите число ");
int numberA = int.Parse(Console.ReadLine());
int n1=numberA % 2;
if (n1== 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("НеЧетное");
}