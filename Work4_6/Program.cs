// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
//Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.

using System;

class Program
{
    static void Main()
    {
        // Задаю строку из слов, разделенных пробелами
        string inputString = "Хорошие дни!";

        // Формирую строку с обратным порядком слов
        string reversedString = ReverseWords(inputString);

        // Вывожу результат
        Console.WriteLine($"Исходная строка: \"{inputString}\"");
        Console.WriteLine($"Строка с обратным порядком слов: \"{reversedString}\"");
    }

    static string ReverseWords(string input)
    {
        // Разделяю строку на массив слов
        string[] words = input.Split(' ');

        // Переворачиваю массив слов
        Array.Reverse(words);

        // Объединяю слова в новую строку, разделяя пробелами
        return string.Join(" ", words);
    }
}
