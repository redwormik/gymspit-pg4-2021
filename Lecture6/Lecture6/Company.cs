using System.Collections.Generic;


namespace Lecture6
{
	class Company
	{
		public string Name { get; private set; }

		private IList<Employee> employees;


		public Company(string name)
		{
			Name = name;
			employees = new List<Employee>();
		}


		public IEnumerable<Employee> Employees()
		{
			foreach (Employee employee in employees) {
				yield return employee;
			}
		}


		public Employee AddRegularEmployee(string name)
		{
			Employee employee = new RegularEmployee(this, name);
			this.employees.Add(employee);
			return employee;
		}
	}
}
