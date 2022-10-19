using Lib;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Write("Введите числа M,N: ");
        int[] arg = Parser.GetUserInput(",");

        if (arg[0] >= arg[1]) throw new System.Exception("Ожидается M < N");

        WriteLine(NumSum(arg[0], arg[1]));

        static int NumSum(int m, int n)
        {
            return m < n ? n + NumSum(m, n - 1) : n;
        }
    }
}