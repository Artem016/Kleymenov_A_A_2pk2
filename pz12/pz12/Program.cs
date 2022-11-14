namespace pz12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            long n = long.Parse(Console.ReadLine());
            long result = 1;
            FindFactorial(out result, n);
            Console.WriteLine("Результат: " + result);
        }

        static void FindFactorial(out long result, long n = 0)
        {
            long foctor = 1;
            long internResult = 0;

            for (long i = 1; i <= n; i++)
            {
                for (long j = 1; j <= i; j++)
                {
                    foctor = foctor * j;
                }
                internResult = internResult + foctor;
                foctor = 1;
            }
            result = internResult;
        }
    }
}