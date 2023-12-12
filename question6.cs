using System;
class program 
{
    static int subindex_count(string str, int n,int startIndex)
    {
        int count = 0, i = startIndex + 1;
        while (i <= n) {
            if (str.StartsWith(str.Substring(startIndex, i-startIndex)))
            {
                count++;
            }
            else
                break;
            i++;
        }
    return count;
    }
  
    static int countsubindex_count(string str, int n)
    {
        int count = 0;
  
        for (int i = 0; i < n; i++) {
  
            if (str[i] == str[0])
                count += subindex_count(
                                        str, n, i);
        }
  
        return count;
    }
  
  
    static public void Main(string []args)
    {
        String str = "today";
        int n = str.Length;
        Console.WriteLine(countsubindex_count(str, n));
    }}