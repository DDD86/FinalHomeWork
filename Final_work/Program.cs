﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] array = new string[5] { "One", "Two", "Three", "Four", "Five" };
string[] array2 = new string[array.Length];
int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[index] = array[i];
            index++;
        }
    } 
    
Array.Resize(ref array2, index); //это метод, который изменяет размер массива array2 на index элементов.
Console.WriteLine($"Первоначальный массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Новый массив из строк, длина которых меньше, либо равна 3 символам: [{String.Join("; ", array2)}]");

