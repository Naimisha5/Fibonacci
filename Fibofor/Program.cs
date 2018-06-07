using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibofor
{
    class FiboLoop
    {
        static void Main(String[] arg)
        {
            int firstnum = 0, secondnum = 1, temp = 0;
            for(int i = 0; i <=10; i++)
            {
                temp = firstnum + secondnum;
                firstnum = secondnum;
                secondnum = temp;

             Console.WriteLine(temp + " ");
            }
            Console.ReadKey();
        }
    }
}
