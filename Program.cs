// int a = new Random().Next(100,1000);
// Console.WriteLine(a);
// int c = a/100;
// int b = a%10;

// Console.Write(c);Console.Write(b);

  
// Console.WriteLine( "введите число c");
// int c = Convert.ToInt32( Console.ReadLine());

// // if ( c%7 == 0 && c%23 ==0 )
// // {
// //    Console.Write ( "Кратно");
// // }
// // else
// // {
// //    Console.Write ( "No");
// // }



// // if ( i == 0)
// // {
// //    Console.WriteLine(i);
// // }
// // else
// // {
// // Console.WriteLine("Кратно");
// // }

// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// // Console.WriteLine ("введите трехзначное целое число c");
// // int c = Convert.ToInt32( Console.ReadLine());

// // int a = c/10;
// // int b = a%10;

// // Console.Write ( b );

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine ("введите число c от 1 до 7");
// int c = Convert.ToInt32( Console.ReadLine());

// if ( c < 6 )
// {
//    Console.WriteLine ( " На работу ");
// }
//    else
// {
//    Console.WriteLine ( " Выходной ");
// }



string text = "Вы так красноречивы. Вы дадите мне чаю?" ;

// string s = "qwerty"
//             012
// s[3] // r

string Replace ( string text, char oldValue, char newValue)
{
   string result = string.Empty;
   int lenght = text.Length;
   for ( int i = 0; i < lenght; i++)
   {
       if( text[i] == oldValue) result = result + $"{newValue}";
       else result = result + $"{text[i]}";
   }
   return result;
}

string newText = Replace ( text, ' ', '|');
Console.WriteLine(newText);