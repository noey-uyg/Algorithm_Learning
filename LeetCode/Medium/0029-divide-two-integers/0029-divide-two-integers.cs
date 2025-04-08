public class Solution {
    public int Divide(int dividend, int divisor) {
        if(dividend == int.MinValue && divisor == -1){
            return int.MaxValue;
        }

        bool isNegative = !((dividend>0 && divisor>0) || (dividend<0 && divisor<0));
        int count = 0;

        long divid = Math.Abs((long)dividend);
        long divis = Math.Abs((long)divisor);

        while (divid >= divis) {
            long temp = divis;
            long multiple = 1;
            
            while (divid >= (temp << 1)) {
                temp <<= 1;
                multiple <<= 1;
            }
            divid -= temp;
            count += (int)multiple;
        }
        
        return isNegative ? -count : count;
    }
}