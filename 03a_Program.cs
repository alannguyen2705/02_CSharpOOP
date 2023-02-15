#region Struct
Console.WriteLine("-----Struct-----");
EmployeeStruct se1 = new() { Id = 1, Name = "A", Salary = 10_000m };
EmployeeStruct se2 = se1;
Console.WriteLine("Before");
Console.WriteLine(se1);
Console.WriteLine(se2);
Console.WriteLine(se1.Equals(se2));

se2.Id = 2;
se2.Name = "B";
se2.Salary = 12_000m;
Console.WriteLine("\nAfter");
Console.WriteLine(se1);
Console.WriteLine(se2);
Console.WriteLine(se1.Equals(se2));
#endregion

#region Class
Console.WriteLine("-----Class-----");
EmployeeClass ce1 = new() { Id = 11, Name = "C", Salary = 20_000m };
EmployeeClass ce2 = ce1;
Console.WriteLine("Before");
Console.WriteLine(ce1);
Console.WriteLine(ce2);
Console.WriteLine(ce1.Equals(ce2));

Console.WriteLine("\nAfter");
ce2.Id = 12;
ce2.Name = "Joy";
ce2.Salary = 22_000m;
Console.WriteLine(ce1);
Console.WriteLine(ce2);
Console.WriteLine(ce1.Equals(ce2));
#endregion

struct EmployeeStruct
{
	#region Properties
	public int Id { get; set; }
	public string Name { get; set; }
	public decimal Salary { get; set; }
	#endregion

	#region Methods
	public override string ToString()
		=> $"Struct - ({Id}, {Name}, {Salary})";
	#endregion
}

class EmployeeClass
{
	#region Properties
	public int Id { get; set; }
	public string Name { get; set; }
	public decimal Salary { get; set; }
	#endregion

	#region Methods
	public override string ToString()
		=> $"Class - ({Id}, {Name}, {Salary})";
    #endregion
}