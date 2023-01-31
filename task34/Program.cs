﻿// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}


int CountChet(int[] arr)
{
    int count = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        {
            count = count+1;
        }
    }
    return count;
}



int[] array = GetArray(10, 100, 1000);
Console.WriteLine(String.Join(" ", array));
int count = CountChet(array);
Console.WriteLine(count);
