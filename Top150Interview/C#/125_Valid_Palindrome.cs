public class Solution
{
    public bool IsPalidrome(string s)
    {
        var newStr = new System.Text.StringBuilder();

        foreach (var c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                newStr.Append(char.ToLower(c));
            }
        }

        string cleaned = newStr.ToString();

        if (cleaned.Length <= 1) return true;

        for (int i = 0; i < cleaned.Length / 2; i++)
        {
            if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}