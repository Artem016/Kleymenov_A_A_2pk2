namespace Distant28._01
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            ComplexNumber c_num1 = new ComplexNumber();
            c_num1.a = 5;
            c_num1.b = 23;

            ComplexNumber c_num2 = new ComplexNumber(3, 13);

            ComplexNumber.ChangeComplexNumber(c_num1);
            ComplexNumber.PrintComplexNumber(c_num1);

            ComplexNumber c_num3 = ComplexNumber.GetMultiplicationByNumber(5, c_num1);
            ComplexNumber.PrintComplexNumber(c_num2);

            Console.WriteLine($"Количестов созданных комплесных чисел: {ComplexNumber.GetAmountComplexNumber()}");
        }
    }
}