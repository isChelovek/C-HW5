// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// 
// [3, 7, 23, 12] -> 19
// 
// [-4, -6, 89, 6] -> 0

using System;
using static System.Console;
Clear();

Write("Массив: ");
int[] initArray =  fillArray(4, 0, 5);
printArray(initArray);
Write($" -> {adderEvenNumber(initArray)}");

int adderEvenNumber(int[] searcHere)
{
    int sumOddElements = 0;
    for (int i = 1; i < searcHere.Length; i+=2)
    {
        sumOddElements += searcHere[i];
    }
    return sumOddElements;
}

int[] fillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(min, max +1);
    }
    return array;
}

void printArray(int[] array)
 {
    Write("[");
     for (int i = 0; i < array.Length; i++)
     {
        Write(array[i]);
        Write(i < array.Length-1 ? ", " : "");
     }
     Write("]");
 }

