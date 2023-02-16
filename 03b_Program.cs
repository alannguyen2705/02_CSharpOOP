//Call constructor 1 and 2
EmployeeStruct se1 = new(1, "Nhung");
Console.WriteLine(se1);

//Call constructor 1
EmployeeClass ce1 = new();
Console.WriteLine(ce1);
struct EmployeeStruct
{
	#region Constructors
	public EmployeeStruct() 
	{
		Console.WriteLine("Struct - Constructor 1");
		Id = 1;
		Name = "John Doe";
		Salary = 1_000m;
	}

	public EmployeeStruct(int id, string name) : this()
	{
        Console.WriteLine("Struct - Constructor 2");
        Id = id;
		Name = name;
	}

	public EmployeeStruct(int id, string name, decimal salary) : this(id, name)
	{
		Console.WriteLine("Struct - Constructor 3");
		Salary = salary;
	}
	#endregion

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
	#region Constructors
	public EmployeeClass()
		=> Console.WriteLine("Class - Constructor 1");

	public EmployeeClass(int id , string name) : this()
		=> Console.WriteLine("Struct - Constructor 2");

	public EmployeeClass(int id, string name, decimal salary) : this(id, name)
		=> Console.WriteLine("Struct - Constructor 3");
	#endregion

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