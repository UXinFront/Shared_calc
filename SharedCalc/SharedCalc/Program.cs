

public class Program
{
    public static void Main()
    {
        Console.WriteLine("First Number");
        double numOne = double.Parse(Console.ReadLine());
        Console.WriteLine("Sign");
        string sign = Console.ReadLine();
        Console.WriteLine("Second Number");
        double numTwo = double.Parse(Console.ReadLine());
        string result = CalcSignDecider(sign, firstNum, numTwo);
        Console.WriteLine($"result: {result}");
        double numTwo = double.Parse(Console.ReadLine());
>>>>>>> b563a0885eee78523a79d3de0be1a3fad4e7a216
    }
    static string CalcSignDecider(string sign, double numOne, double numTwo)
    {
        double result = sign switch
        {
            "+" => Plus(numOne, numTwo),
            "-" => Minus(numOne, numTwo),
            "*" => Multiplication(numOne, numTwo),
            "/" => Divide(numOne, numTwo)
        };
        return result.ToString();
    }

    static double Plus(double numOne, double numTwo) => numOne + numTwo;
    static double Minus(double numOne, double numTwo) => numOne - numTwo;
    
    static double Multiplication(double numOne, double numTwo) => numOne * numTwo;
    static double Divide(double numOne, double numTwo) => numOne / numTwo;
}
