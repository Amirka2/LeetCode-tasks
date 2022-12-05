namespace RomanToInt_easy_;
class Program
{
    static void Main(string[] args)
    {
        var x = Solution.RomanToInt("III");
        Console.WriteLine(x);
        x = Solution.RomanToInt("IV");
        Console.WriteLine(x);
        x = Solution.RomanToInt("LVIII");
        Console.WriteLine(x);
    }
}

