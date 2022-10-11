namespace Lecture6
{
	class RegularEmployee : Employee
	{
		public Company Company { get; private set; }

		public string Name { get; private set; }


		public RegularEmployee(Company company, string name)
		{
			this.Company = company;
			this.Name = name;
		}
	}
}