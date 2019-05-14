using System;

namespace _2ndAssignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l=0,wrd=1;
            Console.WriteLine("Enter string: ");
            str = Console.ReadLine();

            while (l <= str.Length - 1)
            {
                if(str[l] == '\n' || str[l] == ' ' || str[l] == '\t')
                {
                    wrd++;
                } 
                l++;    
            }

            Console.WriteLine("\nTotal Number of words present in the String is : {0}\n", wrd);
        }
    }
}
