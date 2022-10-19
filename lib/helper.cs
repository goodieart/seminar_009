namespace Lib;

public class Parser
{
    /// <summary>
    /// Метод возвращает ввод пользователя, преобразованный в целочисленный массив
    /// </summary>
    /// <param name = "separator">Строковый разделитель; символы между ними в исходной строке будут
    /// преобразованы в элементы результирующего массива</param>
    /// <returns>Новый массив, заполненный преобразованными строковыми значениями в целочисленный тип</returns>
    public static int[] GetUserInput(string separator = " ")
    {
        return Console.ReadLine()!.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(item => int.Parse(item))
                                  .ToArray();
    }
}