// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
void FillArray(double[,] array) //функция для заполнения массива случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //теперь обращаемся к элементу массива и заполняем случайными вещественными числами:
            array[i, j] = new Random().Next(-99, 100); //это полуинтервал: [-99;99) 
        }

    }
}
//функция для печати массива
void PrintArray(double[,] array) // в качестве аргумента принимает двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Задаем размер двумерного массива
Console.WriteLine("введите число строк двумерно массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов двумерно массива n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] new_array = new double[m, n]; // наш массив будет размера m на n
FillArray(new_array); // заполнение массива
Console.WriteLine($"Двумерный массива размера m={m} на n={n} имеет вид: ");
PrintArray(new_array); // вывод массива на экран

//ищем среднее арифметическое по столбцам //как бы переворачиваем массив
for (int i = 0; i < n; i++) // по количеству столбцов (n)
{
  double sredArifmStolbec = 0;
   for (int j = 0; j < m; j++) // по количеству строк (m)
   {
     sredArifmStolbec = sredArifmStolbec + new_array[j, i];
   }
  sredArifmStolbec = Math.Round(sredArifmStolbec / m, 1); // добавила, чтоб округлять значение, а то выводил 
  //Сред.арифметическое столбца 4 = 27,333333333333332
   
   Console.WriteLine($"Сред.арифметическое столбца {i+1} = {sredArifmStolbec}");
 }
Console.WriteLine();
//ищем среднее арифметическое по строкам
for (int i = 0; i < m; i++) // по количеству строк
{
  double sredArifmStroka = 0;
  for (int j = 0; j < n; j++) // по количеству столбцов
  {
    sredArifmStroka = sredArifmStroka + new_array[i, j];
  }

  sredArifmStroka = Math.Round(sredArifmStroka / n, 1);
  Console.WriteLine($"Сред.арифметическое строки {i+1} = {sredArifmStroka}");
}