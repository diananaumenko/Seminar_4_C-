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

// void Zapoinenie(int[] array)
// {
//   for(int i = 0; i < array.Length - 1; i++)
//   {
//     array[i] = new Random().Next(-10, 10);
//   }
// }
// void Pechat(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }


// int[] array = new int[8];
// Zapoinenie(array);
// Pechat(array);
 
int Prompt(string message);//Вводим число с экрана
{
  System.Console.Write(message);//Выводим приглашение ко вводу
  string ReadInput = System.Console.ReadLine();//
  int result = int.Parse(ReadInput);//приводим к числу
  return result;//возвращаем результат
}
//метод для полученияслучайных значений массива
int [] GenerateArray(int Length, int minValue, int maxValue)
{
  int [] array = new int[Length];// обьявляем массив
  Random random = new Random ();
  for (int i = 0; i < Length; i++)
  {
    array[i] = random.Next(minValue, maxValue + 1);//заполняем случайными числами 
    //из диапозона SatrArr до EndArr
  }
  return array;
}
void PrintArray(int[] array)
{
  System.Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    System.Console.Write($"{array[i]}, ");//вывоз значения массива
  }
  System.Console.WriteLine("]");
}

int Length = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение, для диапозона случайного числа: ");
int max = Prompt("Конечное значение, для диапозона случайного числа: ");
int [] array = GenerateArray(Length, min, max);//заполнение массива случайными числами
PrintArray(array);//вывод массива