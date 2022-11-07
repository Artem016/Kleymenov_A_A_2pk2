namespace pz10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userText = Console.ReadLine();
            string[] userTextArray = userText.Split();
            int counter = 0;
            for (int i = 0; i < userText.Split().Length; i++)
            {
                if (userTextArray[i][0] == 'С' || userTextArray[i][0] == 'с')
                {
                    counter++;
                }
            }
            Console.WriteLine("Слов которые начинаются с буквы C: " + counter);
        }

    }
}
