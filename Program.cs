//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве

// int[] array = new int[4];
// FillArray(array);
// PrintArray(array);
// int result = FindEvenNumbers(array);
// Console.Write($"Количество четных чисел в массиве: {result} ");
// // выводим массив
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// //заполняем массив
// void FillArray(int[] array)
// {
//     Random rnd = new Random();
//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(100, 999);
//     }
// }
// //находим четные числа
// int FindEvenNumbers(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) 
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] arr = new int[4];
// FillArray(arr);
// PrintArray(arr);
// int result = FindOddPositions(arr);
// Console.Write($"сумма элементов, стоящих на нечётных позициях = {result} ");
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// //заполняем массив
// void FillArray(int[] array)
// {
//     Random rnd = new Random();
//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(-30, 30);
//     }
// }
// //находим сумму 
// int FindOddPositions(int[] array)
// {
//      int sum = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1)
//         {
//             sum += array[i]; //
//         }
//     }
//     return sum;
// }



// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

int[] arr = new int[5];
FillArray(arr);
PrintArray(arr);
int result1 = FindMaxValue(arr);
int result2 = FindMinValue(arr);
Console.Write($"Больший элемент массива = {result1} ");
Console.Write($"Меньший элемент массива = {result2} ");

//выводим массив
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

//заполняем массив
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (var i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 101);
    }
}

int FindMinValue(int[] arr)
{
    int minValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minValue)
        {
            minValue = arr[i];

        }

    }
    return minValue;

}

int FindMaxValue(int[] arr)
{
    int maxValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxValue)
        {
            maxValue = arr[i];

        }

    }
    return maxValue;

}





















// int Range(int[] array)
// {
//     int count = default;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] = )
//             count++;

//     }
//     return count;

// }