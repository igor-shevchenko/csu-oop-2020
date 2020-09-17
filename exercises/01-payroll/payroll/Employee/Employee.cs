namespace Payroll.Employee
{
    abstract class Employee : IEmployee
    {
        protected Employee(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public virtual decimal GetCoefficient()
        {
            return 1;
        }
    }
}