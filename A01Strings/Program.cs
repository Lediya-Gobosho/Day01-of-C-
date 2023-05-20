using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
         
            int stringLength = sentence.Length;

            Console.WriteLine(stringLength);

            string s1 = sentence.Substring(4); 
            Console.WriteLine(s1);

            string s2 = sentence.Substring(4, 5);

            Console.WriteLine(s2);

            bool containsWord = sentence.Contains("jumps");

            Console.WriteLine(containsWord);

            bool b1 = true;
            bool b2 = false;


            string loweCase = sentence.ToLower();
            string upperCase = sentence.ToUpper();

            string s3 = "the" + "qucik" + "brown";

            string s4 = sentence + " again";

            string s5 = "quick".ToUpper();

            string s6 = sentence.Replace("jumps", "leaps"); 

            int position = sentence.IndexOf("quick");
            Console.ReadLine();
        }
    }
}
