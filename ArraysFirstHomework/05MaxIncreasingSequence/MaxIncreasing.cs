using System;
 //Write a program that finds the maximal increasing sequence in an array.


using System.Collections.Generic;

class maxIncreasingSequence
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[]{','},StringSplitOptions.None);
        int[] array = new int[input.Length];
        List<int> maxSequence = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            array[i] = int.Parse(input[i]);
        }

        int maxLength = 0;
        int currentLength = 0;
        List<int> currentSequence = new List<int>();
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                currentSequence.Add(array[i]);
                
                currentLength++;
            }
            else
            {
                currentSequence.Add(array[i]);
                if (maxLength < currentLength)
                {
                    maxLength = currentLength;
                    maxSequence = new List<int>(currentSequence);
                }

                currentSequence.Clear();
                currentLength = 0;
            }
        }

        currentSequence.Add(array[array.Length-1]);
        if (maxLength < currentLength)
        {
            maxLength = currentLength;
            maxSequence = new List<int>(currentSequence);
            currentSequence.Clear();
        }

        Console.WriteLine(String.Join(" ,", maxSequence));
    }
}