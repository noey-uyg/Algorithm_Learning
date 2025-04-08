using System.Text;

public class Solution {
    public string solution(string phone_number) {
        var builder = new StringBuilder();
        
        int temp = phone_number.Length;
        for(int i=0;i<temp;i++){
            if(i<temp-4)
                builder.Append("*");
            else
                builder.Append(phone_number[i]);
        }
        return builder.ToString();
    }
}