using System.Linq;

public class Solution {
    public bool solution(string s) {
        return (s.Length == 4 || s.Length == 6) && s.All(char.IsDigit);
    }
}