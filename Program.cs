// Задача 34: Задайте массив,
//  заполненный случайными положительными трёхзначными числами.
//   Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int QuontEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}



int[] myArray = GenerateArray(10);
PrintArray(myArray);
System.Console.WriteLine($"количество чётных чисел в массиве равно {QuontEven(myArray)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-100, 100);
    }
    return array;
}

void ShowArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int SumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i% 2!= 0)
        {
            sum=sum+array[i];
        }
    }
    return sum;
}



int[] Array1 = CreateArray(4);
ShowArray(Array1);
System.Console.WriteLine($"сумма элементов, стоящих на нечётных позициях равна {SumOddPosition(Array1)}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// // [3 7 22 2 78] -> 76
