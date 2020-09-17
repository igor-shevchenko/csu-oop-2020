using Payroll.EmployeeCategory;

namespace Payroll.Employee
{
    class Driver : Employee, IHourlyEmployee
    {
        public decimal Rate { get; }
        public Category Category { get; }

        public Driver(string name, decimal rate, Category category) : base(name)
        {
            Rate = rate;
            Category = category;
        }

        public override decimal GetCoefficient()
        {
            return CategoryRateMapper.GetRate(Category);
        }
    }
}