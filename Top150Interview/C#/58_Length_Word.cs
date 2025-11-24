class Solution {
    public int LengthOfLastWord(string s) {
        int length = 0;
        bool in_word = false;

        for (int i = s.Length - 1; i >= 0; i--) {
            char c = s[i];
            
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