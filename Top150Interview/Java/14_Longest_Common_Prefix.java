class Solution {
    public String longestCommonPrefix(String[] strs) {
        if (strs == null || strs.length == 0) return "";
        if (strs[0].length() == 0) return "";
        
        

        String res = "";
        for (int i = 0; i < strs[0].length(); i++) {
            char c = strs[0].charAt(i);
            for (String s : strs) {
                if (i == s.length() || s.charAt(i) != c) {
                    return res.toString();
                }
                res.append(c);
            }
        }
        return res.toString();
    }
}