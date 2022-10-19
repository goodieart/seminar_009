using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Write("Введите число N: ");
        int n = int.Parse(ReadLine()!);

        if (n < 1) throw new System.Exception("Ожидается N > 0");

        WriteLine(NumToString(n));

        static string NumToString(int n)
        {
            return n > 1 ? $"{n},{NumToString(n - 1)}" : $"{n}";
        }
    }
}