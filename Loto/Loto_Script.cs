using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Loto
{
    internal class Loto_Script
    {
        public List<int> ans = new List<int>();

        Random rnd = new Random();

        public void lotoAns(int loto , int max)
        {
            ans.Clear();

           while (ans.Count < loto) 
           {
                if (ans.Count == loto)
                    return;
                
                int num = rnd.Next(1,max);//ランダム作成
                bool flag = false;
                
                for(int i= 0; i< ans.Count;i++)//重複チェック
                {
                    if (ans[i] != num)
                    {
                        continue;
                    }

                    flag = true;
                }

                if (flag)
                    continue;

                ans.Add(num);//リストに追加
           }

            Console.WriteLine(ans.Count);
        }

        public void AnsWrite()//作成
        {
            ans.Sort();
            for (int i = 0; i < ans.Count; i++)
            {
                Console.Write(ans[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
