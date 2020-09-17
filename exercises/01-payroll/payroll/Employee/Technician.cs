using Payroll.EmployeeCategory;

namespace Payroll.Employee
{
    class Technician : Employee, ISalaryEmployee
    {
        public decimal Salary { get; }
        public Category Category { get; }

        public Technician(string name, decimal salary, Category category) : base(name)
        {
            Salary = salary;
            Category = category;
        }

        public override decimal GetCoefficient()
        {
            return CategoryRateMapper.GetRate(Category);
        }
    }
}