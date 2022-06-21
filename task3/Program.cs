// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// 
// [3 7 22 2 78] -> 76

using System;
using static System.Console;
Clear();

Write("Массив: ");
double[] initArray =  fillArray(8, 1, 10);
printArray(initArray);
Write($" -> {findMax(initArray) - findMin(initArray)}");

double findMax(double[] searcHere)
{
    double max = searcHere[0];
    for (int i = 1; i < searcHere.Length; i++)
    {
        if (max < searcHere[i]) max = searcHere[i];
    }
    return max;
}

double findMin(double[] searcHere)
{
    double min = searcHere[0];
    for (int i = 1; i < searcHere.Length; i++)
    {
        if (min > searcHere[i]) min = searcHere[i];
    }
    return min;
}

double[] fillArray(int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(min, max +1);
    }
    return array;
}

void printArray(double[] array)
 {
    Write("[");
     for (int i = 0; i < array.Length; i++)
     {
        Write(array[i]);
        Write(i < array.Length-1 ? ", " : "");
     }
     Write("]");
 }
