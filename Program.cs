// See https://aka.ms/new-console-template for more information
//------------------------------------------------------------
//------------------------------------------------------------
// Sort an array of integers in decreasing order without any built in functions
using System;
class GFG
{
    // Main method
    public static void Main()
    {
        // Sort an array of strings
        // function for sorting the array
        static char[] sortArrays(char[] arr2)
        {
            // finding the length of arr
            int length = arr2.Length;

            // sorting
            for (int b = 0; b < arr2.Length - 1; b++)
            {
                // type conversion of char to int
                int d1 = arr2[b];
                int d2 = arr2[b + 1];

                // Comparing the ascii code
                if (d1 > d2)
                {
                    // swapping of the characters
                    char temp3 = arr2[b];
                    arr2[b] = arr2[b + 1];
                    arr2[b + 1] = temp3;
                    b = -1;
                }
            }
            return arr2;
        }

        // declaring a string
        string geeks = "GEEKSFORGEEKS";

        // declaring a character array
        // to store charcters of array in it
        char[] arr3 = geeks.ToCharArray();

        // Printing the original array
        Console.WriteLine("Original array: [" + String.Join(", ", arr3) + "]");

        // sorting the array
        arr3 = sortArrays(arr3);

        // printing the sorted array
        Console.WriteLine("Sorted array: [" + String.Join(", ", arr3) + "]");

        int[] arr = new int[] { 1, 9, 6, 7, 5, 9 }; // declaring and initializing the array
        Console.WriteLine("Original array");
        foreach (int value in arr)
        {
            Console.WriteLine(value + " ");
        }
        Console.WriteLine();
        int temp;   // temporary variable

        for (int i = 0; i < arr.Length - 1; i++)    // iterate from zero to the length of the array

            for (int j = i + 1; j < arr.Length; j++)    // iterate from i+1 to array length in order to keep it one ahead of other loop variable

                // and if it is biggger, swap the two

                if (arr[i] < arr[j])    // compare array element with next element

                {
                    temp = arr[i];  // hold the value of the array element in a temporary variable

                    // we need to swap the value of the first element, with the value of the second

                    arr[i] = arr[j];    // so now arr[i] = arr[j] which is 9 in the first loop

                    arr[j] = temp;  // and here we replace the arr[j] which is 9 with the first elements value of 1 
                }

        // print all elements of the array
        Console.WriteLine("Descending order");
        foreach (int value in arr)
        {
            Console.WriteLine(value + " ");
        }
        Console.WriteLine();

        // taking said array and sorting it the opposite way
        // temporary variable

        int temp2;

        // iterate from zero to the length of the array

        for (int y = 0; y < arr.Length - 1; y++)

            // iterate from y+1 to array length

            for (int t = y + 1; t < arr.Length; t++)

                // compare array element with
                // all next element
                // and if it is smaller, swap the two

                if (arr[y] > arr[t])
                {
                    temp2 = arr[y];
                    arr[y] = arr[t];
                    arr[t] = temp2;
                }

        // print all elements of said array
        Console.WriteLine("Ascending order");
        foreach (int value in arr)
        {
            Console.WriteLine(value + " ");
        }
        Console.WriteLine();


    }
} 
