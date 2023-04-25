// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Vvedite chislo");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Vvedite stepen'");
// int y = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// int factorial = 1;
// while (i <= y)
// {
//     factorial = factorial * x;
//     i++;
// }
// Console.WriteLine(factorial);




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
// в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Preobrazovanie(string str)
// {
//     Console.Write(str);
//     string chislo = Console.ReadLine();
//     int result = Convert.ToInt32(chislo);
//     return (result);
// }

// int SummaCifrVChisle(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//     }
//     return result;
// }

// int number = Preobrazovanie("Vvedite chislo: ");
// Console.WriteLine($"Symma vseh cifr v chisle {number} = {SummaCifrVChisle(number)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов (от -10 до 10)
// и выводит их на экран.
// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]
// 6, 1, 3 -> [6, 1, 3];

 void Zapoinenie(int[] array)
 {
   for(int i = 0; i < array.Length - 1; i++)
   {
     array[i] = new Random().Next(-10, 10);
   }
 }
 void Pechat(int[] array)
 {
     for (int i = 0; i < array.Length - 1; i++)
     {
         Console.Write(array[i] + " ");
     }
 }


 int[] array = new int[8];
 Zapoinenie(array);
 Pechat(array);
 