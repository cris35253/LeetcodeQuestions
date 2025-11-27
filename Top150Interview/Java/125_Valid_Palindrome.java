class Solution {
    public boolean isPalidrome(String s) {
        StringBuilder newStr = new StringBuilder();

        
        for (char c : s.toCharArray()) {
            if (Character.isLetterOrDigit(c)) {
                newStr.append(Character.toLowerCase(c));
            }
        }
        
        String cleaned = newStr.toString();
        
        if(cleaned.length() <= 1) {
            return true;
        }

        for (int i = 0; i < cleaned.length() / 2; i++) {
            if (cleaned.charAt(i) != cleaned.charAt(cleaned.length() - 1 - i)) {
                return false;
            }
        }

        return true;

    }
}