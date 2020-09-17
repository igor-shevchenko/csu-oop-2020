using Payroll.Employee;

namespace Payroll.EmployeePayroll
{
    class SalaryEmployeePayroll : IEmployeePayroll
    {
        private readonly ISalaryEmployee _employee;
        private readonly decimal _bonus;

        public SalaryEmployeePayroll(ISalaryEmployee employee, decimal bonus)
        {
            _employee = employee;
            _bonus = bonus;
        }

        public decimal GetTotalPay()
        {
            return _employee.Salary * _employee.GetCoefficient() + _bonus;
        }
    }
}