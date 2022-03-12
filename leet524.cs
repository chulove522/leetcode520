using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy0520
{
    class leet524
    {
        //943
        public string ShortestSuperstring(string[] words)
        {
            int n = words.Length;

            //overlap
            int[,] overlaps = new int[n,n];
            for (int i = 0; i < n;  ++i)
                for (int j = 0; j < n;  ++j) if( i != j)
                {
                        int m = Math.Min(words[i].Length, words[j].Length);
                        for (int k = 0; k < m; k++)
                        {
                            if (words[i].EndsWith(words[j].Substring(0, k))){
                                overlaps[i, j] = k;   //lcs
                                break;
                            }
                        }
                }
                //dp[mask , i] =most overlap and end with word[i]
                int[,] dp = new int[1<< n, n];   //n/2
                int[,] parent = new int[1 << n, n];
                for (int mask = 0; mask < (1 << n); mask++) {
                    for (int e = 0; e < n; e++)
                        parent[mask, e] = -1;

                    for (int bit = 0; bit < n; ++bit) if (((mask >> bit) & 1) > 0)  //mask右移bit >-1(邊緣牆壁) 又!=0(有值)
                    {                      
                        int pmask = (int)Math.Pow(mask, bit);
                        if (pmask == 0) continue;
                            for (int i = 0; i < n; ++i) if(((pmask >> i) & 1) >0)  //如果pmask往右位移 >-1 (牆壁)又!=0(有值)
                            {
                                //針對pmask每一個檢查如果以word[i]作為結尾
                                //那就補上後面剩餘的
                                int val = dp[pmask, i] + overlaps[i, bit];
                                if (val > dp[mask, bit]) {
                                    dp[mask, bit] = val;
                                    parent[mask, bit] = i;  //做一個紀錄
                                }
                            }
                    }
                }
            //接下來要把解答建構出來
            //word i - max(dp[-1]) //這句是?

            
            string ans="";
            return ans;
        }

    }
}
