using System;
    class print_string
        {
       public void print()
       {
            Console.WriteLine("Today is a good day ");
            Console.WriteLine("I hope the sun will be out");
       }
    }
        class Program

    {
        static void Main(string[] args)
        {
            var p = new  print_string();
            p.print();
            Console.ReadKey();      
        }      
    }
