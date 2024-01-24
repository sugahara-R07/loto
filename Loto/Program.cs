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
            Loto_Script _loto = new Loto_Script();
            const int LOTO6_MAX = 44;
            const int LOTO7_MAX = 38;
            const int LOTO6 = 6;
            const int LOTO7 = 7;

            while (true)
            {
                while (true)
                {                  
                    Console.Write("ロト6 or ロト7：");
                    string loto = Console.ReadLine();

                    if(loto == "6" || loto == "６")
                    {
                        _loto.lotoAns(LOTO6, LOTO6_MAX);
                        break;
                    }
                    else if (loto == "7" || loto == "７")
                    {
                        _loto.lotoAns(LOTO7, LOTO7_MAX);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("6 or 7 を入力してください。");
                    }
                }

                Console.ForegroundColor = ConsoleColor.Red;              
                _loto.AnsWrite();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("やめるなら[1]を続けるならそれ以外を入力：");
                string s = Console.ReadLine();
                Console.WriteLine();
                
                if(s == "1" || s == "１")
                {
                    break;
                }

            }
        }
    }
}
