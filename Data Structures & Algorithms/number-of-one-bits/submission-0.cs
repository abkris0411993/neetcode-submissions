public class Solution {
    public int HammingWeight(uint n) {
        
        var value=Convert.ToString(n,2);
        int count=0;

        foreach(var c in value)
        {
          
                if(c=='1')
                {
                    count++;
                }
            
        }
        return count;
    }
}
