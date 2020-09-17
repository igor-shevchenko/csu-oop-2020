using System;
using Payroll.Employee;
using Payroll.EmployeeCategory;
using Payroll.EmployeePayroll;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            var ivan = new Manager("Ivan", 10000);
            var masha = new Driver("Masha", 200, Category.A);

            var ivanPayroll = new SalaryEmployeePayroll(ivan, 0);
            var mashaPayroll = new HourlyEmployeePayroll(masha, 100, 10000);

            Console.WriteLine(mashaPayroll.GetTotalPay());
        }
    }
}
