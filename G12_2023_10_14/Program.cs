using G12_2023_10_14.Linq;

namespace G12_2023_10_14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var myList = Employee.GetAllEmployees();
			var myIenumerable = myList.All(x => x.ID > 5);
		}
	}
}