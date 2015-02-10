using System;
/*Problem 2. Compare arrays
Write a program that reads two integer arrays from the console and compares them element by element.*/

class IntAarrCompare
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter lenghts of the arrays -> :  ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] firstArray = new int[arrayLenght];
        int[] secondArray = new int[arrayLenght];
        Console.WriteLine("Now fill up the first array: ");
        for (int i = 0; i < arrayLenght; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Okay, a little more :), NOW fill up the second array: ");
        for (int i = 0; i < arrayLenght; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());

        }
        Console.Clear();
        bool areEqual = true;

        for (int i = 0; i < arrayLenght; i++)
        {

            if (firstArray[i] == secondArray[i])
            {
                areEqual = true;
                Console.WriteLine("Element of the first array {0} : element of the second array  {1}", secondArray[i], firstArray[i]);
            }
            else
            {
                areEqual = false;
                break;

            }

        }
        Console.WriteLine("The elements of the arrays are equal : {0}", areEqual);
    }
}

