using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(randomWrite(1000));
        }

        static string randomWrite(int count)
        {
            string str = "";
            Random random = new Random();

            for(int i = 0; i < count; i++)
            {
                str += random.Next();
            }

            return str;
        }
    }
}
