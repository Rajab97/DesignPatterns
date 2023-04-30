using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class SalaryServiceAdapter : SalaryService, ISalaryServiceAdapter
    {
        public void PaySalariesAdapter(string[,] employess)
        {
            string Id = null;
            string Name = null;
            string Department = null;
            string Salary = null;
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < employess.GetLength(0); i++)
            {
                for (int j = 0; j < employess.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employess[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employess[i, j];
                    }
                    else if (j == 2)
                    {
                        Department = employess[i, j];
                    }
                    else
                    {
                        Salary = employess[i, j];
                    }
                }
                listEmployee.Add(new Employee() { Id = Convert.ToInt32(Id),Name = Name, Department = Department,Salary = Convert.ToDecimal(Salary) });
            }
            base.PaySalaries(listEmployee);
        }
    }
}
