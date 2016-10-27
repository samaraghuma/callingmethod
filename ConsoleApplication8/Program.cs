using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = sum(4,8);
            
            Console.WriteLine(result);
            
            
        }


        static int sum(int min,int max)
        {
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        static int sum(int max)
        {
            int sum = 0;
            for (int i = 0; i <= max; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        static int sum()
        {
            int sum = 0;
            for (int i = 0; i<=10; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
