using System;
//Problem 6. Maximal K sum
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter N the size of the array : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter K the quanity of the biggest elements you want to sum : ");
        int k = int.Parse(Console.ReadLine()); 
        long arraySum = 0;
        int[] arrayOfNumbers = new int[n];
        Console.WriteLine("Please fill up the array, by pressing \"Enter\" after each number : ");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrayOfNumbers);
        Array.Reverse(arrayOfNumbers);
        for (int i = 0; i < k; i++)
        {
            arraySum += arrayOfNumbers[i];
        }
        Console.WriteLine(new string('=',43));
        Console.WriteLine("The sum of the {0} biggest elements is  : {1}",k,arraySum);
    }


}
