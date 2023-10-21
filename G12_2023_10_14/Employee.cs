namespace G12_2023_10_14;

public class Employee
{
	public int ID { get; set; }
	public string Name { get; set; }
	public int Salary { get; set; }
	public string Department { get; set; }

	public static List<Employee> GetAllEmployees()
	{
		List<Employee> listEmployees = new List<Employee>()
		{
			new Employee{ID = 101, Name = "Pooja", Salary = 10000, Department = "IT"},
			new Employee{ID = 102, Name = "Priyanka", Salary = 15000, Department = "Sales"},
			new Employee{ID = 103, Name = "Manoj", Salary = 25000, Department = "Sales"},
			new Employee{ID = 104, Name = "Santosh", Salary = 20000, Department = "IT"},
			new Employee{ID = 105, Name = "Vishal", Salary = 30000, Department = "IT"},
			new Employee{ID = 106, Name = "Sandhya", Salary = 25000, Department = "IT"},
			new Employee{ID = 107, Name = "Mahesh", Salary = 35000, Department = "IT"},
			new Employee{ID = 108, Name = "Manoj", Salary = 11000, Department = "Sales"},
			new Employee{ID = 109, Name = "Pradeep", Salary = 20000, Department = "Sales"},
			new Employee{ID = 110, Name = "Saurav", Salary = 25000, Department = "Sales"}
		};
		return listEmployees;
	}

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
			return false;
        }

        if (obj is Employee)
        {
			var employee = (Employee)obj;
			return employee.ID == this.ID;
        }

		return false;
    }

    public override string ToString()
	{
		return $"ID: {ID}, Name: {Name}, Salary: {Salary}, Departament: {Department}";
	}
}