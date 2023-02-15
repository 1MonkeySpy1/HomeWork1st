// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int max=0;

Console.WriteLine("Input number a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number c");
int c = Convert.ToInt32(Console.ReadLine());

if (a>max)  {max=a;}
if (b>max)  {max=b;}
if (c>max)  {max=c;}
 
Console.WriteLine("maximum=" + max);
 