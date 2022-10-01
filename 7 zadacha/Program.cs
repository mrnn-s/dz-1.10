Console.Write("введите трёхзначное числo:"); 
int n= int.Parse(Console.ReadLine()?? "0"); 
string str = n.ToString(); 
Console.WriteLine(str[2]);