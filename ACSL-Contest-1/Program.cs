using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSL_Contest_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"../../Sample.txt");
            String text = file.ReadToEnd().Replace("\r\n","|");
            String[] lines = text.Split('|').ToArray();
            
        }
    }
}
