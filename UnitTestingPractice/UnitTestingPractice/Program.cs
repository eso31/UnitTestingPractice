using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            string letters = "leepadg";
            Console.WriteLine(Hash(letters));
            Console.Read();
        }

        public static Int64 Hash(string s)
        {

            Int64 h = 7;
            Int64 inc=0;
            Int64 index=0;


            for (int i = 0; i < s.Length; i++)
            {
                string letters = "acdegilmnoprstuw";
                inc = h * 37;
                index = letters.IndexOf((char)s[i]);
                h = inc + index;
            }

            return h;
        }
    }
}
