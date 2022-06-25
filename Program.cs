// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] InitArray(int length, int min, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    return array;
}
void PrintArray(double[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        System.Console.Write($"{arrA[i]:f2} ");
    }
    System.Console.WriteLine();
}

void FindDiffMaxMin(double[] arrA)
{
    double max = arrA[0];
    double min = arrA[0];
    double diff = 0;
    for (var i = 0; i < arrA.Length; i++)
    {
        if (arrA[i] > max)
        {
            max = arrA[i];
        }
        else
        if (arrA[i] < min)
        {
            min = arrA[i];
        }
    }
    diff = max - min;
    System.Console.WriteLine($"Разница между максимальным и минимальным элементами = {diff:f2}");
}

double[] myArray = InitArray(5,1,9);
PrintArray(myArray);
FindDiffMaxMin(myArray);
