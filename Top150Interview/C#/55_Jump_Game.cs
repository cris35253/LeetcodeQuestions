public class Solution
{
    public bool CandJump(int[] nums)
    {
        int goal = nums.Length - 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= goal)
            {
                goal = i;
            }
        }

        return goal == 0;
    }
}