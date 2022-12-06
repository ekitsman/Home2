


// Д.З. Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456%100
//56/10

// int CutNumber(int number)
//  {
//  int result = number % 100 / 10;
//  return result;
//  }

// Console.Write("Enter a three-digit number:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 999 || num<= 100)
// {
//     Console.WriteLine("introduction error");
// }
// else
// {
//     int newNum = CutNumber (num);
// Console.WriteLine($"Result is {newNum}");
// }


// Задача 2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Метод неоднозначно реализуется
// Возвращает всегда int=-1
// третья цифра слева направо.
// Цикл-отсекать последние цифры

// int Search(int number)
// {
//     int result = -1;
//     if(number>=100) 
//     {
//          while (number>999)
//              {
//                  number=number/10;
//                 }
//        result = number%10;
//       }       
//     return result;
// }

// Console.Write("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int newNum = Search(num);
// if (Search(num) == -1)
// Console.WriteLine("третьей цифры нет");
// else
// Console.WriteLine($"Third digit is {newNum}");

// Задача 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Аргумент-цифра
// bool

// bool Day (int num)
// {
// if (num >= 6 && num <= 7)
//      return true;
// else
//     return false;
// }
// Console.Write("Введите день недели (цифру от 1 до 7)");
// int num = Convert.ToInt32(Console.ReadLine());

// bool result=Day(num);
// Console.WriteLine($"Результат проверки {result}");
