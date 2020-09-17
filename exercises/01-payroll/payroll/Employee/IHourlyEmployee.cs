namespace Payroll.Employee
{
    interface IHourlyEmployee : IEmployee
    {
        decimal Rate { get; }
    }
}