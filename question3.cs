using System;
public class swapping_two_numbers
{
   static void swap(ref int a, ref int b)
    {
        int c;    
        c = a;
        a = b;
        b = c;
    }
    public static void Main()
    {
      int a,b;
      a=5;
      b=10;
	  Console.WriteLine("\n\nFunction : To swap the values of two integer numbers :\n");
      Console.WriteLine("Before the swap");
      Console.WriteLine("The value of the first number is " +a);
      Console.WriteLine("The value of the second number is: " +b);
      Console.WriteLine("After the swap");
      swap( ref a, ref b );
      Console.WriteLine( "Now the first number is : " +a+ "\nAnd the second number is: " +b);
    }
}