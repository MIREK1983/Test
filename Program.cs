using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadGaebFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines(@"C:\Users\Mirek\Desktop\Neubau_KITA_Wismarer_Werkstaett_1923095.p93");
        
            foreach (string line in file)
	        {
                if (line=="#begin[GAEB]")
	            {
                    

	            }
                Console.WriteLine(line);
	        }

        }
    }
}
