﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAndContinueInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string equation = "10 200";
            int index = 0;
            int spacePosition = -1;
            while (index < equation.Length)
            {
                if (equation.Substring(index, 1) == " ")
                {
                    spacePosition = index;

                    if (index == 2)
                        continue;
                }
                index++;
            }
        }
    }
}
