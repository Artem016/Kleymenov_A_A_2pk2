namespace pz14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задание номер 1 и 2 \n \n");
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int a1 = -95;
            double b1 = 12;

            Console.WriteLine(Arefmeticnumberforn(a1, n));
            Console.WriteLine(ArefmeticNumberForNGeometric(b1, n));

            Console.Write("\nЗадание номер 3 \n \nВведите число а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            AandBWriter(a, b);

            Console.Write("\nЗадание номер 4 \n \nВведите строку: ");
            string s = Console.ReadLine();
            Console.WriteLine(Palindrom(s));
        }

        static int Arefmeticnumberforn(int a1, int n)
        {
            int d = 5;
            if (n == 1)
            {
                return a1;
            }
            else
            {
                return Arefmeticnumberforn(a1 + d, --n);
            }

        }

        static double ArefmeticNumberForNGeometric(double b1, int n)
        {
            double q = 0.01;
            if (n == 1)
            {
                return b1;
            }
            else
            {
                return ArefmeticNumberForNGeometric(b1 * q, --n);
            }
        }

        static void AandBWriter(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine(a);
                ++a;
                AandBWriter(a, b);
            }
            else if (a > b)
            {
                Console.WriteLine(a);
                --a;
                AandBWriter(a, b);
            }
            else
            {
                Console.WriteLine(b);
            }
        }

        static bool Palindrom(string s, int count = 0)
        {
            if (s[count] != s[s.Length - (count + 1)])
            {
                return false;
            }
            // если зеркальные элементы совпадают и их значания не одиноковые или не находятся рядом,
            // то условие будет пропускаться и выдоваться true
            else if (s[count] == s[s.Length - (count + 1)] && count != s.Length - (count + 1) && count + 1 != s.Length - (count + 1))
            {
                return Palindrom(s, ++count);
            }
            else if (s.Length % 2 == 0 && s[s.Length / 2] != s[s.Length / 2 - 1])
            {
                return false;
            }
            return true;
        }
    }
}