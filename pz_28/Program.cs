namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wait wait200 = new Wait(200);
            Wait wait800 = new Wait(800);
            Counter counter = new Counter();
            counter.CountToThousand(wait200);
            counter.CountToThousand(wait800);
        }
    }
}