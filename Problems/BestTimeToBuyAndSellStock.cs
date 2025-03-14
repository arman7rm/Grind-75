public partial class Solution{
    public int MaxProfit(int[] prices){
        int maxProfit = 0;
        int minPriceSeen = prices[0];
        for(int i=1; i<prices.Length; i++){
            if(prices[i]-minPriceSeen>maxProfit){
                maxProfit = prices[i]-minPriceSeen;
            }
            if(prices[i]<minPriceSeen){
                minPriceSeen = prices[i];
            }
        }
        return maxProfit;
    }
}