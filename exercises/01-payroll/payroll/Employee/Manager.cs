namespace Payroll.Employee
{
    class Manager : Employee, ISalaryEmployee
    {
        public decimal Salary { get; }

        public Manager(string name, decimal salary) : base(name)
        {
            Salary = salary;
        }
    }
}