using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMover
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"C:\Users\caryhawkins\Desktop\OOWL_PH_ORDER_DOWN.RESP";
            string destinationfile = @"C:\Users\caryhawkins\Desktop\Books\OOWL_PH_ORDER_DOWN" + DateTime.Now.ToString("dd_MM_YYYY_hhmm") + ".RESP";
            string source2 = @"C:\Users\caryhawkins\Desktop\OOWL_PH_ORDER_DOWN.COMPL";
            string destination2 = @"C:\Users\caryhawkins\Desktop\Books\OOWL_PH_ORDER_DOWN" + DateTime.Now.ToString("dd_MM_YYYY_hhmm") + ".COMPL";

            //Check if Response file exists
            if (File.Exists(sourceFile))
            {
                //Move Response file to a new location with date in name
                System.IO.File.Move(sourceFile, destinationfile);
            }
            //Check if Compl file exists
            if (File.Exists(source2))
            {
                //Move Compl file to new location with date in name
                System.IO.File.Move(source2, destination2);
            }
        }
    }
}
