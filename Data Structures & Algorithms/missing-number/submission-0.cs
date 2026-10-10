public class Solution {
    public int MissingNumber(int[] nums) {

        int sum=0;
        int missing=0;
        
        
        {
            for(int i=0;i<nums.Length;i++)
            {
                sum+=nums[i];

                
            }

            int n=nums.Length;
            
            int expectedsum=n*(n+1)/2;

             missing=expectedsum-sum;

             return missing;
        }
        
    }
}
