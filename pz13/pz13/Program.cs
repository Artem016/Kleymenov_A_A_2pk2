namespace pz13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] myMass = new int[10];
            for (int i = 0; i < myMass.Length; i++)
            {
                myMass[i] = rnd.Next(0, 25);
                Console.WriteLine($"Элементе массива номер {i} равен: {myMass[i]}");
            }
            Console.WriteLine(SummEvenNumberedValua(myMass)); ;
            
        }

        static int SummEvenNumberedValua(int[] myMass)
        {
            int summ = 0;
            for (int i = 0; i < myMass.Length; i++)
            {
                if (myMass[i]%2 == 0 && i % 2 != 0)
                {
                    summ += myMass[i]; 
                }
            }
            return summ;
        }
    }
}