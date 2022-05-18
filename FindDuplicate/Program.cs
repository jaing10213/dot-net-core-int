using System;
using System.Collections.Generic;


namespace FindDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "check duplicate characters";

            var res = GetDuplicateCount(str);
            
            foreach(var item in res)
            {
                Console.WriteLine($"{item.Key}  \t  {item.Value}");
            }
        }

        private static List<KeyValuePair<char, int>> GetDuplicateCount(string str)
        {
            var res = new List<KeyValuePair<char, int>>();

            //Q: write an efficient algorithm that will count the duplicate characters in the str and store them in the res object

            return res;

        }
    }
  
}
