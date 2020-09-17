namespace Payroll.Employee
{
    interface IEmployee
    {
        string Name { get; }
        decimal GetCoefficient();
    }
}