// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;

class Program
{
    static void Main()
    {
        // Задаю строку с латинскими буквами в обоих регистрах
        string originalString = "Good Days!";

        // Формирую строку, в которой все заглавные буквы заменены на строчные
        string resultString = ConvertToLowerCase(originalString);

        // Вывожу результат
        Console.WriteLine(resultString);
    }

    static string ConvertToLowerCase(string input)
    {
        // Использую метод ToLower() для замены заглавных букв на строчные
        return input.ToLower();
    }
}

