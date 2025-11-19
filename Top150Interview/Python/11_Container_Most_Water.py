class Solution:
    def maxArea(self, height):
        res = 0

        for l in range(len(height)):
            for r in range(l + 1, len(height)):
                area = min(height[l], height[r]) * (r - l)
                res = max(res, area)

        
        return res
    
class Solution:
    def maxArea(self, height):
        l, r = 0, len(height) - 1
        leftMax, rightMax = height[l], height[r]

        res = 0

        while l < r:
            area = min(height[l], height[r]) * (r - l)
            res = max(res, area)
            
            if height[l] < height[r]:
                l += 1 
            
            else:
                r += -1

        
        return res