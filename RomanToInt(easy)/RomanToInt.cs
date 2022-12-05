namespace RomanToInt_easy_
{
    public static class Solution
    {
        public static int RomanToInt(string s)
        {
            int res = 0, index = 0;

            do
            {
                if (index + 1 == s.Length)
                {
                    res += GetInt(s[index]);
                    break;
                }
                int temp = GetInt(s[index], s[index + 1]);
                if (temp == 0)
                {
                    temp = GetInt(s[index]);
                    index--;
                }

                res += temp;
                index += 2;
            } while (index < s.Length);

            return res;
        }
        private static int GetInt(char c1, char c2)
        {
            if (c1 == 'I' && c2 == 'V') return 4;
            else if (c1 == 'I' && c2 == 'X') return 9;
            if (c1 == 'X' && c2 == 'L') return 40;
            else if (c1 == 'X' && c2 == 'C') return 90;
            if (c1 == 'C' && c2 == 'D') return 400;
            else if (c1 == 'C' && c2 == 'M') return 900;

            return 0;
        }
        private static int GetInt(char c1)
        {
            if (c1 == 'I') return 1;
            else if (c1 == 'V') return 5;
            else if (c1 == 'X') return 10;
            else if (c1 == 'L') return 50;
            else if (c1 == 'C') return 100;
            else if (c1 == 'D') return 500;
            else if (c1 == 'M') return 1000;

            return 0;
        }
    }
}

