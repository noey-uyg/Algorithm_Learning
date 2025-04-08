public class Solution {
    public int MyAtoi(string s) {
        if(string.IsNullOrWhiteSpace(s)){
            return 0;
        }
        
        bool isNegative = false;
        int idx = 0;

        while(s.Length > idx && s[idx] == ' '){
            idx++;
        }

        if(s[idx] == '-'){
            isNegative = true;
            idx++;
        }
        else if(s[idx]== '+'){
            isNegative = false;
            idx++;
        }

        int result = 0;

        for(int i=idx; i<s.Length;i++){
            int num = s[i] - '0';
            if(num < 0 || num > 9){
                break;
            }

            if((int.MaxValue - num) / 10 < result){
                return isNegative ? int.MinValue : int.MaxValue;
            }

            result = result * 10 + num;
        }
        return isNegative ? -result : result;
    }
}