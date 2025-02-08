namespace Basic;

public class Patient
{
    public string Name { get; set; }
    public string Address { get; set; }
    public Doctor doctor{ get; set; }
}

public class Doctor
{
    public string Name { get; set;}
}