namespace Distant28._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c_num1 = new ComplexNumber();
            c_num1.a = 5;
            c_num1.b = 23;
            ComplexNumber.PrintComplexNumber(c_num1);
            ComplexNumber c_num2 = ComplexNumber.GetMultiplicationByNumber(5, c_num1);
            ComplexNumber.PrintComplexNumber(c_num2);
        }
    }
}