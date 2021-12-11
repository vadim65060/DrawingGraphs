using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawing_graphs
{
    class MyConvert
    {
        public static double StrToDouble(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            str = str.Replace(".", ",");
            string newStr = "";
            int k = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',') k++;
                if ((str[i] >= '0' && str[i] <= '9') || (str[i] == ',' && k < 2) || (str[i] == '-' && i == 0))
                {
                    newStr += str[i];
                }
            }

            if (string.IsNullOrEmpty(newStr)) return 0;
            return Convert.ToDouble(newStr);
        }
    }
}
