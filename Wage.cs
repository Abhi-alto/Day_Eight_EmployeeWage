using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_1
{
    internal class Wage
    {
        public static int Rndm()
        {
            Random ran = new Random();
            return (ran.Next(0, 2));
        }
        public static int wagee()
        {
            int WaPhr = 20;
            int P_DaHr = 4;
            return (WaPhr * P_DaHr);

        }
    }
}
