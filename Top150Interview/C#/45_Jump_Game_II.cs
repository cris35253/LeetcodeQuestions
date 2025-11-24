public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length;
        int jumps = 0;
        int l = 0, r = 0;

        // keep expanding window until we can reach the last index
        while (r < n - 1) {
            int farthest = 0;

            // explore all indices in the current window [l, r]
            for (int i = l; i <= r; i++) {
                farthest = Math.Max(farthest, i + nums[i]);
            }

            // move to the next window
            l = r + 1;
            r = farthest;
            jumps++;
        }

        return jumps;
    }
}
