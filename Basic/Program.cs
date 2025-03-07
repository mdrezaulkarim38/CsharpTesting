namespace Basic;
public class Program
{
    public static void Main(string[] args)
    {
        List<string> nameList = new List<string>();
        nameList.Add("shuvo");
        nameList.Add("Superman");
        foreach(string name in nameList)
        {
            Console.WriteLine(name);
        }
    }
}