namespace pz23
{
    class MainCode
    {
        static void Main(string[] args)
        {   
            NiggativCN n_cn1 = new NiggativCN();
            ComplexNumber c_num1 = new ComplexNumber();
            c_num1.a = 5;
            c_num1.b = 23;

            ComplexNumber.PrintComplexNumber(c_num1.GhangeCN());
            ComplexNumber.PrintComplexNumber(n_cn1.GhangeCN());

            ComplexNumber c_num2 = new ComplexNumber(3, 13);
            ComplexNumber.PrintComplexNumber(c_num1);

            ComplexNumber c_num3 = ComplexNumber.GetMultiplicationByNumber(5, c_num1);
            ComplexNumber.PrintComplexNumber(c_num2);

        }
    }
}