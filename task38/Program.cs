// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементов 
// массива.

// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double [size];
    for (int i=0; i<size; i++)
    {
        res[i] = new Random().NextDouble();
        res[i] = res[i]*100;
        res[i] = Math.Round(res[i], 2);
    }
    return res;
}

double FindMax(double [] arrForMax)
{
    double max = arrForMax[0];
    for (int i = 0; i<arrForMax.Length; i++)
    {
        if (arrForMax[i] > max) max = arrForMax[i];
    }
    return max;
}

double FindMin(double [] arrForMin)
{
    double min = arrForMin[0];
    for (int i = 0; i<arrForMin.Length; i++)
    {
        if (arrForMin[i] < min) min = arrForMin[i];
    }
    return min;
}



double[] array = GetArray(10, 0, 5);
Console.WriteLine(String.Join(" | ", array)); // сделал разделение прямой чертой, чтобы более читаемо было
double maximum = FindMax(array);
Console.WriteLine($"Максимальное значение массива = {maximum}");
double minimum = FindMin(array);
Console.WriteLine($"Минимальное значение массива = {minimum}");
double raznost = maximum - minimum;
raznost = Math.Round(raznost, 2);
Console.WriteLine($"Разность между максимальным и минимальным значениями массива = {raznost}");