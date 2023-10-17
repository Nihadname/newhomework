// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

Console.WriteLine("Hello, World!");
int increasment = 0;
string number1=Console.ReadLine();
string number2=Console.ReadLine();
int number01=int.Parse(number1);
int number02=int.Parse(number2);    
int result=number01 + number02;
string resultAsString = result.ToString();
//Console.WriteLine(result);
foreach (int num in resultAsString)
{
    increasment++;//kodda ele bilki her birini  goturub hesapliyacaq yeni meslen 123 olacaq '1','2','3'
}
if (increasment == 2)
{
    Console.WriteLine("cem ikireqemli ededdir");
}
else if (increasment == 3)
{
    Console.WriteLine("cem ucreqemli ededdir");
}
else
{
    Console.WriteLine("nezere alinmayıb");
}

Console.WriteLine("hundurluk daxil edin");
int hundurluk=int.Parse(Console.ReadLine());
Console.WriteLine("eni daxil et");
int  eni= int.Parse(Console.ReadLine());
Console.WriteLine("uzunluq");
int uzunluq=int.Parse(Console.ReadLine());

int e = 67;
int h = 350;
if((eni <= e && hundurluk <= h) || (eni <= e && uzunluq <= h) || (uzunluq <= e && hundurluk <= h) || (uzunluq <= e && eni <= h) || (hundurluk <= e && uzunluq <= h) || (hundurluk <= e && eni <= h))
{
    Console.WriteLine("bu kecek");
}
else
{
    Console.WriteLine("kecmeycek");
}