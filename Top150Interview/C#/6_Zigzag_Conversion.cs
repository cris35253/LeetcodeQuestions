public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;

        StringBuilder res = new StringBuilder();
        int cycleLen = 2 * (numRows - 1);

        for (int r = 0; r < numRows; r++)
        {
            for (int i = r; i < s.Length; i += cycleLen)
            {
                res.Append(s[i]);

                int diag = i + cycleLen - 2 * r;

                if (r > 0 && r < numRows - 1 && diag < s.Length)
                {
                    res.Append(s[diag]);
                }
            }
        }

        return res.ToString();
    }
}