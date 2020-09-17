using System.ComponentModel;

namespace Payroll.EmployeeCategory
{
    static class CategoryRateMapper
    {
        public static decimal GetRate(Category category)
        {
            switch (category)
            {
                case Category.A:
                    return 1.25M;
                case Category.B:
                    return 1.15M;
                case Category.C:
                    return 1M;
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}