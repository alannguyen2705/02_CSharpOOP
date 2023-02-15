Student s1 = new()
{
    Id = 1,
    Name = "A",
    Mark = 10f,
    HomeAddress = new() 
    { 
        City = "Ho Chi Minh", District = "Quan Binh Thanh", Street = "Bach Dang" 
    }
};

Student s2 = new() { Id = 2, Name = "B", Mark = 9f};
s2.HomeAddress = s1.HomeAddress;
Console.WriteLine("Before");
Console.WriteLine(s1);
Console.WriteLine(s2);

s2.HomeAddress.City = "Ha Noi";
s2.HomeAddress.Street = "Tran Duy Hung";
s2.HomeAddress.District = "Cau Giay District";
Console.WriteLine("\nAfter first time");
Console.WriteLine(s1);
Console.WriteLine(s2);

s2.HomeAddress = new Address
{
    City = "Lam Dong",
    Street = "Duong vao tim em",
    District = "Hoai Duc"
};
Console.WriteLine("\nAfter second time");
Console.WriteLine(s1);
Console.WriteLine(s2);

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Mark { get; set; }
    public Address HomeAddress { get; set; }
    public override string ToString() => $"Id: {Id} - Name = {Name} - Mark = {Mark} - Address = {HomeAddress}";
}
class Address
{
    public string City { get; set; }
    public string District { get; set; }
    public string Street { get; set; }
    public override string ToString() => $"City: {City} - District: {District} - Street: {Street}";

}