namespace Basic;
public class CountryMaster
{
    public string CountryCode { get; set; }
    public string CountryName { get; set; }
    private string ComputerName
    {
        get {
            return System.Environment.MachineName;
        }
    }
    public void Insert()
    {
        
    }
}