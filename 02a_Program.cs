Console.WriteLine("-----Basic-----");
string name = "Manh";
int age = 18;
Console.WriteLine($"Name: {name} - Age: {18} ");

Console.WriteLine("\n------");
Employee mike = new() { Id = 1, Name = "Mike", Salary = 1000m };
Console.WriteLine($"Id = {mike.Id} - Name = {mike.Name} - Salary = {mike.Salary}");

Console.WriteLine("-----Copy Value-----");
string name2 = name;
Console.WriteLine($"name: {name} - name2 = {name2}");
name2 = "Kha";
Console.WriteLine($"name: {name} - name2 = {name2}");

int age2 = age;
Console.WriteLine($"age: {age} - age2: {age2}");
age2 = 16;
Console.WriteLine($"age: {age} - age2: {age2}");

Console.WriteLine("\n------");
Employee pole = mike;
Console.WriteLine("Before");
Console.WriteLine($"Id: {mike.Id} - Name: {mike.Name} - Salary: {mike.Salary}");
Console.WriteLine($"Id: {pole.Id} - Name: {pole.Name} - Salary: {pole.Salary}");

pole.Id = 2;
pole.Name = "Pole";
pole.Salary = 2000m;
Console.WriteLine("After");
Console.WriteLine($"Id: {mike.Id} - Name: {mike.Name} - Salary: {mike.Salary}");
Console.WriteLine($"Id: {pole.Id} - Name: {pole.Name} - Salary: {pole.Salary}");

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}