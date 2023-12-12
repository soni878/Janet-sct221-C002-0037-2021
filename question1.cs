using System;
class program{
    static void Main()
    {
        Random rand = new Random();
        int n = rand.Next(); // This code generates random numbers 

        if (n > 0)
        {
            Console.WriteLine("This number " + n + " is positive.");
        } 
        else if (n < 0)
        {
            Console.WriteLine("This number " + n + " is negative.");
        }
        else
        {
            Console.WriteLine("This number is zero.");
        }
    } 
} 
