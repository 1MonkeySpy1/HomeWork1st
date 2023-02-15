//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
int OrdinalNumber = 1;

if (number>1) {
   while (OrdinalNumber<=number)
{
   int rem = OrdinalNumber % 2;
      if (rem == 0) {Console.WriteLine(OrdinalNumber + " ");
         OrdinalNumber =OrdinalNumber+1;}
      else { OrdinalNumber =OrdinalNumber+1;}
} 
}