using Payroll.Employee;

namespace Payroll.EmployeePayroll
{
    class HourlyEmployeePayroll : IEmployeePayroll
    {
        public int Hours { get; }
        private readonly IHourlyEmployee _employee;
        private readonly decimal _bonus;

        public HourlyEmployeePayroll(IHourlyEmployee employee, int hours, decimal bonus)
        {
            Hours = hours;
            _bonus = bonus;
            _employee = employee;
        }

        public decimal GetTotalPay()
        {
            return Hours * _employee.Rate * _employee.GetCoefficient() + _bonus;
        }
    }
}