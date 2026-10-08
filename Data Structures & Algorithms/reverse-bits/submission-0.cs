public class Solution {
    public uint ReverseBits(uint n) {

        var value=Convert.ToString(n,2).PadLeft(32,'0');
        string reversed="";

        for(int i=value.Length-1;i>=0;i--)
        {
            reversed+=value[i];
        }

        var final=Convert.ToUInt32(reversed,2);
        return final;
    }
}
