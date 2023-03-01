

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

        string result = CalcSignDecider(sign, numOne, numTwo);
        Console.WriteLine($"result: {result}");
    }

    /// <summary>
    /// Calculates the numbers based on what sign was put in.
    /// </summary>
    /// <param name="sign">The math sign to decide calculation method</param>
    /// <param name="numOne">First Number</param>
    /// <param name="numTwo">Second Number</param>
    /// <returns>The result based on what sign</returns>
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

    /// <summary>
    /// Method to have two numbers be plused. 
    /// </summary>
    /// <param name="numOne">First Number</param>
    /// <param name="numTwo">Second Number</param>
    /// <returns>The sum of two numbers</returns>
    static double Plus(double numOne, double numTwo) => numOne + numTwo;
    /// <summary>
    /// Method to have two numbers be minused. 
    /// </summary>
    /// <param name="numOne">First Number</param>
    /// <param name="numTwo">Second Number</param>
    /// <returns>The subtraction of two numbers</returns>
    static double Minus(double numOne, double numTwo) => numOne - numTwo;
    
    static double Multiplication(double numOne, double numTwo) => numOne * numTwo;
    static double Divide(double numOne, double numTwo) => numOne / numTwo;
}
