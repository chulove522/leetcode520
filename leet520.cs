using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy0520
{
    class leet520
    {
        public static void leetcode520() {
            String str = "";
            str = Console.ReadLine();
            int capCount = 0;
            bool first = false;
            if ((int)str[0] >= 65 && (int)str[0] <= 90)
            {
                first = true;
                capCount++;
            }
            for (var i = 1; i < str.Length; i++)
            {
                var ascii = str[i];
                if (ascii >= 65 && ascii <= 90)
                {
                    capCount++;
                }
            }
            if ((capCount == 1 && first) || capCount == 0 || first == false &&capCount ==0)
                System.Console.WriteLine("true");
            else
            {
                System.Console.WriteLine("false");
            }
        }
    }
}
