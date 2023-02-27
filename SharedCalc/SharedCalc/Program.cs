

public class Program
{
    public static void Main()
    {
        Console.WriteLine("First Number");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Sign");
        string sign = Console.ReadLine();
        Console.WriteLine("Second Number");
        double secondNum = double.Parse(Console.ReadLine());
    }

    string CalcSignDecider(string sign, double numOne, double numTwo)
    {
        double result = sign switch
        {
            "+" => Plus(numOne, numTwo),
            "-" => Minus(numOne, numTwo),
        };
    }

    double Plus(double numOne, double numTwo) => numOne + numTwo;
    double Minus(double numOne, double numTwo) => numOne - numTwo;
}
