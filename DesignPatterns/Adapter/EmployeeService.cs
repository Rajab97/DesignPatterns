using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class EmployeeService : IEmployeeService
    {
        //For storing empoyee data just for example
        public static string[,] Employees;
        private readonly ISalaryServiceAdapter _salaryService;

        public EmployeeService(ISalaryServiceAdapter salaryService)
        {
            Employees = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };
            _salaryService = salaryService;

        }

        public void PaySalaries()
        {
            _salaryService.PaySalariesAdapter(Employees);
        }
    }
}
