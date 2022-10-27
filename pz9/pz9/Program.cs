namespace pz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numMaxSymbolInMass = new int[10];
            char[] myMaxSymbol = new char[10] { Convert.ToChar(0), Convert.ToChar(0), Convert.ToChar(0), Convert.ToChar(0), Convert.ToChar(0), Convert.ToChar(0), Convert.ToChar(0), Convert.ToChar(0), Convert.ToChar(0), Convert.ToChar(0) };
            char[] myMassLastSybol = new char[10];
            Random rnd = new Random();

            char[][] myMass = new char[10][];
            for (int i = 0; i < myMass.Length; i++)
            {
                int colNum = rnd.Next(3, 50);
                myMass[i] = new char[colNum];
                for (int j = 0; j < colNum; j++)
                {
                    myMass[i][j] = Convert.ToChar(rnd.Next(20, 100));
                    Console.Write(myMass[i][j] + " ");
                    if (j == myMass[i].Length - 1)
                    {
                        myMassLastSybol[i] = myMass[i][j];
                    }
                    if (myMass[i][j] < myMaxSymbol[i])
                    {
                        myMaxSymbol[i] = myMass[i][j];
                        numMaxSymbolInMass[i] = j;
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            for (int i = 0; i < myMassLastSybol.Length; i++)
            {
                Console.WriteLine(myMassLastSybol[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                char saveMassFirstSymbol = myMass[i][0];
                myMass[i][0] = myMaxSymbol[i];
                myMass[i][numMaxSymbolInMass[i]] = saveMassFirstSymbol;
            }

            for (int i = 0; i < 10; i++)
            {
                myMass[i].Reverse();
                for (int j = 0; j < myMass[i].Length; j++)
                {
                    Console.Write(myMass[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}