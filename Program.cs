//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a");
int a = Convert.ToInt32 ( Console.ReadLine ());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32 ( Console.ReadLine ());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32 ( Console.ReadLine ());

int max = a;
if ( a>b)
 max = a;
else
 max = b;

if (max < c)
max = c;

   Console.Write("Max =");
   Console.Write(max); 

