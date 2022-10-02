Console.Write("введите трёхзначное числo:"); 
int n= int.Parse(Console.ReadLine()?? "0"); 
string str = n.ToString(); 
int l = str.Length;
if (l < 3)
{
    Console.WriteLine("error,wrong number");
}
else 
{
Console.WriteLine(str[2]);
}