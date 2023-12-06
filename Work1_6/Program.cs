// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

using System;

class Program
{
    static void Main()
    {
        // Задаю двумерный массив символов
        char[,] charArray = {
            {'G', 'o', 'o', 'd'},
            {'D', 'a', 'y', 's'}
        };

        // Создаю строку из символов массива
        string resultString = ArrayToString(charArray);

        // Вывожу результат
        Console.WriteLine(resultString);
    }

    static string ArrayToString(char[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        // Использую StringBuilder для  объединения двух строк в одну строку
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Добавляю символ в строку
                sb.Append(array[i, j]);
            }
        }

        // Преобразую StringBuilder в строку
        return sb.ToString();
    }
}

