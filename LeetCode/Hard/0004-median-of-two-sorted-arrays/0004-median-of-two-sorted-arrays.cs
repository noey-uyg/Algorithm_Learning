public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int sumLength = nums1.Length + nums2.Length;
        int mid = sumLength/2;

        int num1Count = 0;
        int num2Count = 0;

        double result = 0;

        for(int i=0;i<=mid;i++){
            int num = 0;
            if(num1Count >= nums1.Length){
                num = nums2[num2Count++];
            }
            else if(num2Count >= nums2.Length){
                num = nums1[num1Count++];
            }
            else{
                num = nums1[num1Count] > nums2[num2Count] ? 
                nums2[num2Count++] :
                nums1[num1Count++]; 
            }

            if(sumLength % 2 == 0){
                if(i>=mid-1){
                    result+=num;
                }
            }
            else{
                if(i==mid){
                    result+=num;
                }
            }
        }

        return sumLength%2 == 0 ? result / 2 : result;
    }
}