public class Solution {
    public string IntToRoman(int num) {
        Dictionary<int,string> dict = new Dictionary<int,string>(){
            {1000,"M"},{900,"CM"},{500,"D"},{400,"CD"},{100,"C"},{90,"XC"},
            {50,"L"},{40,"XL"},{10,"X"},{9,"IX"},{5,"V"},{4,"IV"},{1,"I"}
        };

        StringBuilder sb = new StringBuilder();

        while(num>0){
            foreach(var v in dict){
                if(num>=v.Key){
                    sb.Append(v.Value);
                    num-=v.Key;
                    break;
                }
            }
        }

        return sb.ToString();
    }
}