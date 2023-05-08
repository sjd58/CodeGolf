// See https://aka.ms/new-console-template for more information
using CodingPractice;
using CodingPractice.MockInterviewQuestions;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] input1 = new string[9] { "hi", "hi", "hi", "hi", "hi", "hi", "hi", "hi", "hi" };
        string[] input2 = new string[5] { "yo", "yo", "yo", "yo", "yo" };
        MergeArrays sut2 = new MergeArrays();
        string[] testing = sut2.CombineStringArrays(input1, input2);
        MostCommonChar sut1 = new MostCommonChar();
        sut1.MostUsedLetter("Hello world! Hello hello!");
        FloydTriangle sut = new FloydTriangle();
        sut.FloydList(3);
        Console.WriteLine("Enter a number to print out a floyd triangle...");
        int numberToPrint = int.Parse(Console.ReadLine());
        sut.PrintFloyd(numberToPrint);
    }
}