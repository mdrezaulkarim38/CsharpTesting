using System;
namespace Basic;

public class Animal
{
    public virtual void AnimalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Pig : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The pig makes a sound: wee wee");
    }
}

public class Dog : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The dog makes a sound: bow wow");
    }
} 

public class SomeClass
{
    private int someValue;

    public SomeClass(int val)
    {
        someValue = val;
    }
    public static SomeClass operator +(SomeClass arg1, SomeClass arg2)
    {
        return new SomeClass(arg1.someValue + arg2.someValue);
    }
}

public class Program
{
    static int LongestSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        int start = 0;
        HashSet<char> seenChar = new HashSet<char>();
        for (int end = 0; end < n; end++)
        {
            while (seenChar.Contains(s[end]))
            {
                seenChar.Remove(s[start]);
                start++;
            }

            seenChar.Add(s[end]);
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(LongestSubstring("geeksforgeeks")); // Output: 7
        Console.WriteLine(LongestSubstring("aaa")); // Output: 1
        Console.WriteLine(LongestSubstring("abcdefabcbb"));
    }
}