public class Solution {
    public int LengthOfLongestSubstring(string s) {

        int left=0;

        int maxlength=0;

        var set=new HashSet<char>();

        if(s==" ")
        return 1;

        for(int right=0;right<=s.Length-1;right++)
        {
            while(set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[right]);
            maxlength=Math.Max(maxlength,right-left+1);
        }
        return maxlength;

    }
}
