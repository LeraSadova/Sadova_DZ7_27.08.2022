// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();

void FillArray(int[,] array) //функция для заполнения массива случайными числами
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
void PrintArray(int[,] array) // в качестве аргумента принимает двумерный массив
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

int[,] new_array = new int[m, n]; // наш массив будет размера m на n

FillArray(new_array); // заполнение массива
Console.WriteLine($"Двумерный массива размера m={m} на n={n} имеет вид: ");
PrintArray(new_array); // вывод массива на экран


Console.WriteLine("Введите координаты позиции элемента (первая позиция имеет координаты (1;1) )");
Console.Write("Введите координаты X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x <= m && x > 0 && y <= m && y > 0)
    Console.Write($"{new_array[x - 1, y - 1]} ");
    else Console.Write($"В заданном массиве отсутствует позиция с координатами ({x};{y}) ");

