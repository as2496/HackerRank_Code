using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Codding_Challange
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("h");
            //Console.ReadLine();

            /*
             * 
             */
            OrgChart obj = new OrgChart();
            obj.Add("1", "Johnson Drye","-1");
            obj.Add("2", "Cristy Sprow", "-1");
            obj.Add("3", "Natacha Seligman", "-1");
            obj.Add("4", "Brittny Wicks", "-1");
            obj.Add("5", "Crissy Carden", "-1");
            obj.Add("6", "Maribel Lettieri", "-1");
            obj.Add("7", "Patrice Seawood", "-1");
            obj.Add("8", "Audrea Deshazo","-1");
            obj.Add("9", "Emely Skoglund", "-1");
            obj.Add("10", "Krista Dugan", "-1");
            obj.Add("11", "Marilu Foos", "-1");
            obj.Add("12", "Cherilyn Brinegar", "-1");
            obj.Add("13", "Linn Caroll","-1");
            obj.Add("14", "Sang Coffer","-1");
            obj.Add("15", "Hilma Mehan", "-1");

            obj.Remove("3");
            obj.Remove("4");
            obj.Remove("5");

            obj.Add("3", "Natacha Seligman", "-1");
            obj.Add("4", "Brittny Wicks", "-1");
            obj.Add("5", "Crissy Carden", "-1");

            obj.Print();

            Console.ReadLine();

        }
        

    }
}
