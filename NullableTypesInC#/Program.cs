using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypesInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {//  int a = null; // syntax error 
            int? b = null; //now b can store null value

            string c = null; // its not a problem beause 
            // string is by default nullable type 

            //string? d = null; // syntax error 

            bool d = false;

        }
    }
}
