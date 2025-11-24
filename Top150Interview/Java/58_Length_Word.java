class Solution {
    public int lengthOfLastWord(String s) {
        int length = 0;
        boolean in_word = false;

        for (int i = s.length() - 1; i >= 0; i--) {
            char c = s.charAt(i);
            
            if (c != ' ') {
                length++;
                in_word = true;
            }

            else if (in_word) {
                break;
            }
        }

        return length;
        
    }
}