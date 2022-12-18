using System;

class array
{
    static void Main (String [] args)
    {
        // Declaration
        int [] array1 = new int[5];

        Console.WriteLine("Seperate Declaration and Initialization");

        // Initialization
        for (int i = 0; i < 5; i++)
            array1[i] = i+1;

        foreach (int pass in array1)
            Console.Write((pass) + " ");

        // Combined Declaration and Initialization
        Console.WriteLine("\n\nCombined Declaration and Initialization\n");
        
        // Method 1
        Console.WriteLine("Method 1");
        int [] array2 = new int[] {1, 2, 3, 4, 5};
        foreach (int pass in array2)
            Console.Write((pass) + " ");

        // Method 2
        Console.WriteLine("\n\nMethod 2");
        int [] array3 = {1, 2, 3, 4, 5};
        foreach (int pass in array3)
            Console.Write((pass) + " ");
    }
} 