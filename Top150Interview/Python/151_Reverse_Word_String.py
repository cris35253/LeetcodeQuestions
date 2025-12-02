class Solution(object):
    def reverseWords(self, s):
        # Split the string by spaces (split() automatically handles multiple spaces)
        words = s.split()
        # Reverse the list of words
        words.reverse()
        # Join the words back with a single space

        reverse = ' '.join(words)
        return reverse