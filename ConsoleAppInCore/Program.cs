using System;

namespace ConsoleAppInCore
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee Emp = new Employee(1001, "Chandan", "Developer", 25000, "Team Leader", "Noida");
			Console.WriteLine("Emp[0]: " + Emp[0]);
			Console.WriteLine("Emp[1]: " + Emp[1]);
			Console.WriteLine("Emp[2]: " + Emp[2]);
			Console.WriteLine("Emp[3]: " + Emp[3]);
			Console.WriteLine("Emp[4]: " + Emp[4]);
			Console.WriteLine("Emp[5]: " + Emp[5]);

			Emp[0] = 1002;
			Emp[1] = "Kundan";


			Console.WriteLine("Emp[0]: " + Emp[0]);
			Console.WriteLine("Emp[1]: " + Emp[1]);
			Console.WriteLine("Emp[2]: " + Emp[2]);
			Console.WriteLine("Emp[3]: " + Emp[3]);
			Console.WriteLine("Emp[4]: " + Emp[4]);
			Console.WriteLine("Emp[5]: " + Emp[5]);

			Employee Emp1 = new Employee();

			Emp1[0] = 00001;
			Emp1[1] = "Anmol";
			Emp1[2] = "Student";
			Emp1[3] = 15000.00;
			Emp1[4] = "Class Monitor";
			Emp1[5] = "Jhanjharpur";
			Emp1[6] = "XXXXXXXXXXXXXXXXXXXXX";

			Console.WriteLine("Emp1[0]: " + Emp1[0]);
			Console.WriteLine("Emp1[1]: " + Emp1[1]);
			Console.WriteLine("Emp1[2]: " + Emp1[2]);
			Console.WriteLine("Emp1[3]: " + Emp1[3]);
			Console.WriteLine("Emp1[4]: " + Emp1[4]);
			Console.WriteLine("Emp1[5]: " + Emp1[5]);
			Console.WriteLine("Emp1[6]: " + Emp1[6]);

		}
	}
}
