namespace LongestCommonPrefix;
class Program
{
    static void Main(string[] args)
    {
        var s = LongestCommonPrefix("flower", "flow", "flight");
    }
    public static string LongestCommonPrefix(params string[] strs)
    {
        string prefix = strs[0];
        foreach (var word in strs)
        {
            string temp = prefix.Length < word.Length ? prefix : word;
            if (prefix.Length > temp.Length) prefix = prefix.Substring(0, temp.Length);
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                if (word[i] != prefix[i]) prefix = prefix.Substring(0, i);
            }
        }
        return prefix;
    }
}

