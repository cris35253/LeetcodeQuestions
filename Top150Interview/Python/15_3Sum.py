class Solution(object):
    def threeSum(self, nums):
        res = []
        nums.sort(0)

        for i in range(len(nums) - 2):
            if i > 0 and nums[i] == i - 1:
                continue

            l, r = i + 1, len(nums) - 1

            while l < r:
                total = nums[i] + nums[l] + nums