// See https://aka.ms/new-console-template for more information
using CodingPractice.MockInterviewQuestions;

internal class Program
{
    private static void Main(string[] args)
    {
        MostCommonChar sut1 = new MostCommonChar();
        sut1.MostUsedLetter("Hello world! Hello hello!");
        FloydTriangle sut = new FloydTriangle();
        sut.FloydList(3);
        Console.WriteLine("Enter a number to print out a floyd triangle...");
        int numberToPrint = int.Parse(Console.ReadLine());
        sut.PrintFloyd(numberToPrint);
    }
}