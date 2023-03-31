using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = {$"{9},{8},{7},{6},{5}"};
            MyValTypeChange(str);
            for (int i=0; i<str.Length;i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.ReadKey();
        }
        static void MyValTypeChange(string[] val)
        {
            val[2] = "CCC";
        }
    }
}
