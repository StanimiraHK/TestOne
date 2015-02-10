using System;
///Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.


class maxEqualSequence
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(',');
        int[] NumArray = Array.ConvertAll(numbers, int.Parse);
        int sequenceLenght = 1;
        int currentElement = 0;
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (NumArray[i] == NumArray[i + 1])
            {
                sequenceLenght++;
            }

            if (sequenceLenght > max)
            {
                currentElement = NumArray[i];
                max = sequenceLenght;
            }
            if (NumArray[i] != NumArray[i + 1])
            {
                sequenceLenght = 1;

            }
        }

        Console.WriteLine("The lenght of the sequence is {0} elements.The repeated element is >> {1} <<", max, currentElement);


    }
}

