// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;

class Program
{
    static void Main()
    {
        // Задаю произвольную строку
        string inputString = "My mountains";

        // Проверяю, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(inputString);

        // Вывожу результат
        Console.WriteLine($"Строка \"{inputString}\" является палиндромом: {isPalindrome}");
    }

    static bool IsPalindrome(string input)
    {
        // Привожу строку к нижнему регистру и убираю пробелы
        string cleanedString = CleanString(input);

        // Переворачиваю строку
        string reversedString = ReverseString(cleanedString);

        // Сравниваю исходную строку и перевернутую
        return cleanedString == reversedString;
    }

    static string CleanString(string input)
    {
        // Привожу строку к нижнему регистру и убираю пробелы
        return input.ToLower().Replace(" ", "");
    }

    static string ReverseString(string input)
    {
        // Переворачиваю строку
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

