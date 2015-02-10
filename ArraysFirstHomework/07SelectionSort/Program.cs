using System;
//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.Problem 7. Selection sort
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

class Program
{
    static void Main()
    {
        int lenght = int.Parse(Console.ReadLine());
        int j,i,z;
        int min = 0;
        int[] arrayToSort = new int[lenght];
        for (int k = 0; k < arrayToSort.Length; k++)
        {
            arrayToSort[k] = int.Parse(Console.ReadLine());
        }
        for (i = 0; i < arrayToSort.Length - 1; i++)
        {
            min = i;
            for (j = i + 1; j < arrayToSort.Length; j++)
            {

                if (arrayToSort[j] < arrayToSort[min])
                {

                    min = j;
                }
            }

            if (min != i)        
            {
                z = arrayToSort[i];
                arrayToSort[i] = arrayToSort[min];
                arrayToSort[min] = z;

            }
        }
        for (int g = 0; g < arrayToSort.Length; g++)
        {
            Console.WriteLine(arrayToSort[g]);
        }
    }
}

