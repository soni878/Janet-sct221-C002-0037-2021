using System;
class LastDigit{
    static void Main()
    {
        Random rand = new Random();
        int n = rand.Next();        // This code generates random numbers. 
        int lastDigit = n % (10);  //  This code gets the last digit of the random variable.
        
        Console.WriteLine("The number is: " +n+ " The last digit is: "+lastDigit); //Prints the random number and last digit
} 
}
