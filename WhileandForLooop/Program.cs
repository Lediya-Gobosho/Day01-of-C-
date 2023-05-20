using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileandForLooop
{
    internal class Program
    {
        static void Main(string[] args)
        {string sentence = "The quick brown fox jumps over the lazy dog";
            int index =0;


            //while (index < sentence.Length)
            //{
            //    Console.WriteLine(sentence.Substring(index,1));
            //    index++;
            //}

            do
            {
                Console.WriteLine(sentence.Substring(index, 1));
                index++;

            } while (index < sentence.Length);

            for (int i = 0; i < sentence.Length; i++)
                Console.WriteLine(sentence.Substring(index, 1));
            Console.ReadLine();


        }
    }
}
