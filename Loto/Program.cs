using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loto
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Loto7_Script _loto7 = new Loto7_Script();
           
            while (true)
            {
                _loto7.loto7Ans(6,43);
                _loto7.AnsWrite();

                Console.Write("やめるなら[1]を続けるならそれ以外を入力：");
                string s = Console.ReadLine();
                Console.WriteLine();
                
                if(s == "1")
                {
                    break;
                }

            }
        }
    }
}
