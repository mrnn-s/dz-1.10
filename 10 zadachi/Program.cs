Console.Write("введите трёхзначное числo:"); 
int n= int.Parse(Console.ReadLine()?? "0"); 
string str = n.ToString(); 
Console.WriteLine ("число с удаленной второй цифрой трёхзначного числа");
Console.Write(str[0]);
Console.Write(str[2]);