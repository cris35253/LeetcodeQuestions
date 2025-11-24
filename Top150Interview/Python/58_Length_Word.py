class Solution(object):
    def lengthOfLastWord(self, s):
        length = 0
        in_word = False

        for char in reversed(s):
            if char != ' ':
                length += 1
                in_word = True
            elif in_word:
                break

        return length