public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1;        // last valid in nums1
        int j = n - 1;        // last in nums2
        int k = m + n - 1;    // write index at end of nums1

        // Fill nums1 from the back with the larger of nums1[i] and nums2[j]
        while (i >= 0 && j >= 0) {
            if (nums1[i] > nums2[j]) {
                nums1[k--] = nums1[i--];
            } else {
                nums1[k--] = nums2[j--];
            }
        }

        // Copy any leftovers from nums2 (nums1 leftovers already in place)
        while (j >= 0) {
            nums1[k--] = nums2[j--];
        }
    }
}
