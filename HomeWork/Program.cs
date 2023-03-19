// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// int x1 = 3;
// int y1 = 6;
// int c1 = 8;
// int x2 = 2;
// int y2 = 1;
// int c2 = -7;
// Coord(x1,x2,y1,y2,c1,c2);

// void Coord ( int x1, int x2,int y1,int y2,int c1,int c2)
// {
//    int result1 = (x2-x1)*(x2-x1);
//    int result2 = (y2-y1)*(y2-y1);
//    int result3 = (c2-c1)*(c2-c1);
//    double sum1 = result1+result2+ result3;
//    double sum =  Math.Sqrt(sum1);
//    Console.WriteLine(sum);
// }


// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// try
// {
// Console.WriteLine( "введите число");
// int n = Convert.ToInt32( Console.ReadLine());
// Check(n);

// void Check(int n)
// {
//    int result1 = n%10;
//    int result2 = n/10000;
//    int result3 = (n%100)/10;
//    int result4 = (n%10000)/1000;

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("введите число");
// int n = Convert.ToInt32(Console.ReadLine());


// for(int i = 1; i<= n; i++)
// {
//     Console.Write ( $"{ i*i*i } ");
// }

