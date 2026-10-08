public class Solution {
    public int[] CountBits(int n) {

        
        var list=new List<int>();
        for(int i=0;i<=n;i++)
        {
            int count=0;
            var check=Convert.ToString(i,2);

            foreach(var c in check)
            {
                if(c=='1')
                {
                    count++;
                }
                
            }
            list.Add(count);
        }
        return list.ToArray();
    }
}
