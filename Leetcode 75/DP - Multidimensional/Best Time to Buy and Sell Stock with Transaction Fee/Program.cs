namespace Best_Time_to_Buy_and_Sell_Stock_with_Transaction_Fee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int MaxProfit(int[] prices, int fee)
        {
            int sell = 0;
            int buy = int.MinValue;

            foreach (int price in prices)
            {
                buy = int.Max(buy, sell - price);                
                sell = int.Max(sell, buy + price - fee);                                                       
            }

            return sell;
        }
    }
}
