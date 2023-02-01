using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._121_Best_Time_Buy_and_Sell
{
    public class Solution1
    {
        public int MaxProfit(int[] prices)
        {
            int buyPrice = 10000;
            int sellPrice = 0;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (buyPrice > prices[i] && i != prices.Length - 1)
                {
                    buyPrice = prices[i];
                    Console.Write(buyPrice);
                    sellPrice = 0;
                }
                else
                {
                    if (sellPrice < prices[i])
                    {
                        sellPrice = prices[i];
                    }
                }

                int profit = sellPrice < buyPrice ? 0 : sellPrice - buyPrice;
                if (maxProfit < profit)
                {
                    maxProfit = profit;
                }
            }

            return maxProfit;
        }
    }
}
