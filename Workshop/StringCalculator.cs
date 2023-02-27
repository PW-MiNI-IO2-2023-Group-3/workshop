﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class StringCalculator
    {
        public static int SumString(string str)
        {
            if (str == String.Empty)
                return 0;

            int result = 0;
            if (int.TryParse(str, out result))
            { 
                if(result < 0) { throw new ArgumentException(); }
                if (result > 1000) return 0;
                return result; 
            }

            char separator;
            string[] numbers;
            
            foreach (var number in numbers)
            {
                int num = int.Parse(number);
                if (num < 0) { throw new ArgumentException(); }
                if (num > 1000) num = 0;
                result += num;
            }
                



            return result;
        }
    }
}
