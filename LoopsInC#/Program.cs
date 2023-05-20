using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            while (count < 10)
            {
                count++;
                Console.WriteLine(count);
            }
            string equation = "10 200";        
            int index = 0;
            int spacePosition = -1;
            while (index < equation.Length)
            {
                if (equation.Substring(index, 1) == " ")
                {
                    spacePosition = index;
                    break; 
                }
                index++;
            }
            Console.ReadLine();

        }
    }
}
