using System;
/*Problem 1. Allocate array
Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.*/
 
class ArrayAllocate
{
    static void Main(string[] args)
    {
        int[] newArray = new int[20];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] += i;
            Console.WriteLine("Index of the element = {0} >> the index * 5 = {1}", i, newArray[i] * 5);
        }
    }
}