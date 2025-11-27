class Solution(object):
    def isPalindrome(self, s):
        newStr = ""

        condition = False
        for c in s:
            if c.isalnum():
                newStr += c.lower()


        for i in range(len(newStr) / 2 - 1):
            for j in range(len(newStr) -1, -1, -1):
                if newStr[i] == newStr[j]:
                    condition = True
                else:
                    condition = False

        return condition
        
