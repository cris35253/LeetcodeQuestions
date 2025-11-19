public class Solution
{
    public string IntToRoman(int num)
    {
        (string sym, int val)[] symlist = {
            ("I", 1), ("IV", 4), ("V", 5), ("IX", 9),
            ("X", 10), ("XL", 40), ("L", 50), ("XC", 90),
            ("C", 100), ("CD", 400), ("D", 500), ("CM", 900),
            ("M", 1000)
        };

        StringBuilder res = new StringBuilder();

        for (int i = symlist.Length - 1; i >= 0; i--)
        {
            string sym = symlist[i].sym;
            int val = symlist[i].val;

            if (num / val > 0)
            {
                int count = num / val;

                for (int j = 0; j < count; j++)
                {
                    res.Append(sym);
                }
                num %= val;
            }
        }

        return res.ToString();
    }

    public static void main(string[] args)
    {
        Solution sol = new Solution();
        System.out.println(sol.intToRoman(34214)
    }
}