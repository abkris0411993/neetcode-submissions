public class Solution {
    public bool IsPalindrome(string s) {
        
        string cleaned="";
        string reversed="";

        for(int i=0;i<s.Length;i++)
        {
            if(char.IsLetterOrDigit(s[i]))
            {
                cleaned+=char.ToLower(s[i]);
            }
        }

        for(int j=cleaned.Length-1;j>=0;j--)
        {
            reversed+=cleaned[j];
        }

        if(reversed!=cleaned)
        {
            return false;
        }
     return true;
    }
    
}
