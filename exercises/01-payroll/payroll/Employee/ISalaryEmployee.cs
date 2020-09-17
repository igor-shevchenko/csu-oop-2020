namespace Payroll.Employee
{
    interface ISalaryEmployee : IEmployee
    {
        decimal Salary { get; }
    }
}