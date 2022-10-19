using Lib;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Write("Введите числа M,N: ");
        int[] arg = Parser.GetUserInput(",");

        if (arg[0] < 0 || arg[1] < 0) throw new System.Exception("Ожидается M >= 0, N >= 0");
        if (arg[0] > 3)
        {
            string answer = string.Empty;
            do
            {
                Write("[M > 3] Вы уверены, что хотите продолжить?.. (y/n) ");
                answer = ReadLine()!.Trim();
                if (answer == "n")
                    return;
                else if (answer == "y")
                    WriteLine("Откиньтесь на спинку стула и подождите...");
            } while (answer != "y" && answer != "n");
        }
        WriteLine($"A(m,n) = {Ackermann(arg[0], arg[1])}");

        static int Ackermann(int m, int n)
        {
            if (m == 0) return n + 1;
            else if ((m > 0) && (n == 0)) return Ackermann(m - 1, 1);
            else return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}