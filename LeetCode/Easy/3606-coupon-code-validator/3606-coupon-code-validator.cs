public class Solution {
    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>{
            ["electronics"] = new(),
            ["grocery"] = new(),
            ["pharmacy"] = new(),
            ["restaurant"] = new()
        };

        List<string> result = new List<string>();

        for(int i=0;i<code.Length;i++){
            if(!isActive[i]) continue;
            if(string.IsNullOrEmpty(code[i])) continue;
            if(!IsValidCode(code[i])) continue;
            if(!dict.ContainsKey(businessLine[i])) continue;

            dict[businessLine[i]].Add(code[i]);
        }

        foreach(var v in dict){
            v.Value.Sort(StringComparer.Ordinal);
            result.AddRange(v.Value);
        }

        return result;
    }

    public bool IsValidCode(string code){
        for(int i=0;i<code.Length;i++){
            if(!char.IsLetterOrDigit(code[i]) && code[i] != '_') return false;
        }

        return true;
    }
}