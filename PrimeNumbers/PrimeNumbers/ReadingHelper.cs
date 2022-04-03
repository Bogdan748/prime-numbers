using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class ReadingHelper
    {
        public static int? ReadInput(string label = "Enter number:")
        {
            int result;
            string input= null;
            while(!int.TryParse(input,out result))
            {
                Console.Write(label);
                input = Console.ReadLine();
            }

            return result;
        }
    }
}
