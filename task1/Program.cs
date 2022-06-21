// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// 
// [345, 897, 568, 234] -> 2

using System;
using static System.Console;
Clear();

Write("Массив: ");
int[] initArray =  fillArray(8, 100, 999);
printArray(initArray);
Write($" -> {countEvenNumber(initArray)}");

int countEvenNumber(int[] searcHere)
{
    int count = 0;
    for (int i = 0; i < searcHere.Length; i++)
    {
        if (searcHere[i] % 2 == 0) count++;
    }
    return count;
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

