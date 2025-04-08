public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        bool[] reversePrime = new bool[right+1];
        reversePrime[0] = true;
        reversePrime[1] = true;

        List<int> list = new List<int>();
        int[] result = new int[]{-1,-1};

        for(int i=2;i<=right;i++){
            if(reversePrime[i]) continue;

            for(int j=i*2;j<=right;j+=i){
                reversePrime[j] = true;
            }
        }

        for(int i=left;i<=right;i++){
            if(!reversePrime[i]) list.Add(i);
        }

        if(list.Count < 2) return result;

        int minDist = int.MaxValue;
        for(int i=0;i<list.Count-1;i++){
            int tempDist = list[i+1]-list[i];

            if(tempDist<minDist){
                minDist = tempDist;
                result[0] = list[i];
                result[1] = list[i+1];
            }
        }
        return result;
    }
}