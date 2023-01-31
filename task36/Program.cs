// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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


int CountNeChet(int[] arr) 
{
    int count = 0;
    int i=1;
    while (i<arr.Length)
    {
        count = count + arr[i];
        i = i+2;
    }
    return count;
}

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));
int nechetnie = CountNeChet(array);
Console.WriteLine(nechetnie);