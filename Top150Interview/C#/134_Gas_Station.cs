class Solution
{
    public int canCompleteCircuit(int[] gas, int[] cost)
    {
        if (gas.Sum() < cost.Sum())
        {
            return -1;
        }

        int total = 0;
        int start = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            total += gas[i] - cost[i];

            if (total < 0)
            {
                total = 0;
                start = i + 1;
            }
        }

        return start;
    }
}