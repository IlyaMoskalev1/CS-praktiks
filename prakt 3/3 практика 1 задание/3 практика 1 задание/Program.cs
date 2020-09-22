
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _3_практика_1_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "(916)080-9398", "(916) 080-9398", "916-080-9398", "9160809398", "09398", "09398-9398", "19", "111-11-1111" };
            foreach (string s in input)
            {
                if (IsPhone(s))
                    Console.WriteLine(s + " is a phone number");


                else 
                
                if (IsZip(s))
                    
                    Console.WriteLine(s + " is a zip code");


                else 
                    
                    
                    Console.WriteLine(s + " is unknown");
            }
        }

        static bool IsPhone(string s)
        {
            return Regex.IsMatch(s, @"^\(?\d{3}\)?[\s\-]?\d{3}\-?\d{4}$");
        }

        static bool IsZip(string s)
        {
            return Regex.IsMatch(s, @"^\d{5}(\-\d{4})?$");
        }
    }
}
