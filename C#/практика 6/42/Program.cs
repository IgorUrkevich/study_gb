using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = ConvertDecimalToBinary(decimalNumber);
        Console.WriteLine($"Binary representation: {binaryNumber}");
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        string binaryNumber = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder + binaryNumber;
            decimalNumber /= 2;
        }

        return binaryNumber;
    }
}