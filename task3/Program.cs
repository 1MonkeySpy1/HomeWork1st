// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Input number");
int Number = Convert.ToInt32(Console.ReadLine());
int Rem = Number % 2;

if (Rem==0) {Console.WriteLine(Number + "->" + "yes");}
else {Console.WriteLine(Number +"->" + "no");}