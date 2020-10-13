using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string pm = "p.m.";
            string am = "a.m.";
            string dateFormatFrom = "30/12/2020 05:00:00 p.m.";
            DateTime currectDate = DateTime.Now;

            if (dateFormatFrom.Contains(pm))
            {
                dateFormatFrom = dateFormatFrom.Replace(pm, "");
                currectDate = DateTime.Parse(dateFormatFrom);
                Console.WriteLine(currectDate.ToString("M/d/yyyy hh:mm:ss") + " pm");
            }
            else if (dateFormatFrom.Contains(am))
            {
                dateFormatFrom = dateFormatFrom.Replace(am, "");
                currectDate = DateTime.Parse(dateFormatFrom);
                Console.WriteLine(currectDate.ToString("M/d/yyyy hh:mm:ss") + " am");
            }

            Console.ReadLine();
        }
    }
}
