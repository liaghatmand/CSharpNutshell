public class Person : IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public  Gender Gender { get; set; }
}

public enum Gender : byte
{
    male,
    female,
    other
}