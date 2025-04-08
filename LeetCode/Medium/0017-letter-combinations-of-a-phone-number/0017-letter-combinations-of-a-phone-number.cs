public class Solution {
    public IList<string> LetterCombinations(string digits) {
        Dictionary<char, string> dict = new Dictionary<char,string>
        {
            {'2',"abc"},
            {'3',"def"},
            {'4',"ghi"},
            {'5',"jkl"},
            {'6',"mno"},
            {'7',"pqrs"},
            {'8',"tuv"},
            {'9',"wxyz"}
        };

        List<string> result = new List<string>();

        if(digits.Length == 0){
            return new List<string>();
        }
        else if(digits.Length == 1){
            result.AddRange(dict[digits[0]].Select(c => c.ToString()));
            return result;
        }

        result.Add("");

        for(int i=0;i<digits.Length;i++){
            string str = dict[digits[i]];

            List<string> temp = new List<string>();
            for(int j=0;j<str.Length;j++){
                for(int k=0;k<result.Count;k++){
                    temp.Add(result[k]+str[j]);
                }
            }

            result = temp;
        }

        return result;
    }
}