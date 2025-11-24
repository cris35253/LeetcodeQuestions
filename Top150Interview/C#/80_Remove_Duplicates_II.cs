public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 0;
        foreach (int i in nums)
        {
            if (k < 2 || i != nums[k - 2])
            {
                nums[k] = i;
                k++;
            }
        }
        return k;
    }
}