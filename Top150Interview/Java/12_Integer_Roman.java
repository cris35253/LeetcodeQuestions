public class Solution
{
    public String intToRoman(int num)
    {
        String[][] symlist = {
            {"I", "1"}, {"IV", "4"}, {"V", "5"}, {"IX", "9"},
            {"X", "10"}, {"XL", "40"}, {"L", "50"}, {"XC", "90"},
            {"C", "100"}, {"CD", "400"}, {"D", "500"}, {"CM", "900"},
            {"M", "1000"}
        };

        StringBuilder res = new StringBuilder();

        for (int i = symlist.length - 1; i >= 0; i--)
        {
            string sym = symlist[i][0];
            int val = Integer.parseInt(symList[i][1]);

            if (num / val > 0)
            {
                int count = num / val;

                for (int j = 0; j < count; j++)
                {
                    res.append(sym);
                }
                num %= val;
            }
        }

        return res.toString();
    }

    public static void main(string[] args)
    {
        Solution sol = new Solution();
        System.out.println(sol.intToRoman(34214)
    }
}