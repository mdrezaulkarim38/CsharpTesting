using System;

class Program
{
    static int MinimizeStringLength(string s)
    {
        int n = s.Length;
        bool changed;
        do
        {
            changed = false;
            for (int i = 0; i < n - 1;)
            {
                if (s[i] == s[i + 1])
                {
                    s = s.Remove(i, 1).Insert(i, "a");
                    s = s.Remove(i + 1, 1);
                    changed = true;
                    if (i > 0) i--; 
                }
                else
                {
                    i++;
                }
            }
        } while (changed);
        return s.Length;
    }

    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            Console.WriteLine(MinimizeStringLength(s));
        }
    }
}