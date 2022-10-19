using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Write("Введите числа M,N: ");
        int[] arg = GetUserInput(",");

        if (arg[0] >= arg[1]) throw new System.Exception("Ожидается M < N");

        WriteLine(NumSum(arg[0], arg[1]));

        static int NumSum(int m, int n)
        {
            return m < n ? n + NumSum(m, n - 1) : n;
        }

        static int[] GetUserInput(string separator = " ")
        {
            return Console.ReadLine()!.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(item => int.Parse(item))
                                      .ToArray();
        }

    }
}