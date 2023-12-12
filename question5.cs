using System;
    class reverse_string
        {
       public void reverse()
       {
            string word = "hello world";
            string reverseString = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseString += word[i];
            }
            Console.WriteLine($"The original word is : {word} ");
            Console.Write($"The reversed word is : {reverseString} ");
            
       }
        }
        class Program

    {
        static void Main(string[] args)
        {
            var r = new  reverse_string();
            r.reverse();
            Console.ReadKey();
            
           
        }      
    }