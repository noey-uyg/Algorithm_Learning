using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        return UsePrice(price,count) > money ? UsePrice(price,count) - money : 0;
    }
    
    public long UsePrice(int price, int count){
        if(count == 1)
            return price;
        
        return (price*count)+UsePrice(price, count-1);
    }
}