using System;
//Problem 3. Compare char arrays. 
//Write a program that compares two char arrays lexicographically (letter by letter).

class charArrCompare
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter lenghts of the chars in the arrays -> :  ");
        int arrayLenght = int.Parse(Console.ReadLine());
        char[] firstArray = new char[arrayLenght];
        char[] secondArray = new char[arrayLenght];
        Console.WriteLine("Now fill up the first array with {0} characters : ", arrayLenght);
        for (int i = 0; i < arrayLenght; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Okay, a little more :), NOW fill up the second array with characters: ");
        for (int i = 0; i < arrayLenght; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());

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
        Console.WriteLine("The characters are the same : {0}", areEqual);
    }
}

