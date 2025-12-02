public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;


        while (left < right) {
            int current_sum = numbers[left] + numbers[right]; 

            if (current_sum == target) {
                return new int[] {left + 1, right + 1};
            } 
            else if (current_sum < target) {
                left += 1;
            }  
            else {
                right -= 1;
            } 
        } 
    
        return new int[] { -1, -1 };
    }
}