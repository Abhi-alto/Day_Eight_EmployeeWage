using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_1
{
    internal class Wage
    {
        public int rndm()               //for geting a random number
        {
            Random ran = new Random();
            return (ran.Next(0, 2));               //randomly checking present or absent
        }
        public static int wage(int ch)                //for calculating the daily wage through switch case
        {
            int WaPhr = 20;
            int day_hr = 0;
            switch (ch)
            {
                case 1:
                    day_hr = 4;
                    break;
                case 2:
                    day_hr = 8;
                    break;
                default:
                    day_hr = 0;
                    break;
            }
            return (WaPhr * day_hr);
        }
        public static void compute(int ch)                //for calculating the monthly wage 
        {
            int ToMonWag = 0;                  //Monthly working days
            for (int x = 1; x <= 20; x++)           //for every day asked if the person is absent or present ....total working days 20
            {
                Wage random = new Wage();         //creating object for class wage for non-static functions
                int r = random.rndm();            //Calling a non-static function
                switch (r)
                {
                    case 1:
                        int wa = Wage.wage(ch);                                 //called static method wage
                        Console.WriteLine("Employee is Present on day " + x);
                        Console.WriteLine("Daily wage of the employee is = " + wa);
                        ToMonWag = ToMonWag + wa;
                    break;
                    default:
                        Console.WriteLine("Employee is Absent on day " + x);
                    break;
                }
            }
            Console.WriteLine("Total wage of the employee for the month is = Rs." + ToMonWag);  //total monthly wage of the employee
        }
    }
}
