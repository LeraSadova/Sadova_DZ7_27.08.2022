// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
//Задаем размер двумерного массива
Console.WriteLine("введите число строк двумерно массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов двумерно массива n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] new_array = new double[m, n]; // наш массив будет размера m на n

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

FillArray(new_array); // заполнение массива
Console.WriteLine($"Двумерный массива размера m={m} на n={n} имеет вид: ");
PrintArray(new_array); // вывод массива на экран
