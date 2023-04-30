using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class SalaryService : ISalaryService
    {
        public void PaySalaries(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"Start pay salary to {emp.Name}");
                //Do payment .....
                Thread.Sleep(1000);
                Console.WriteLine($"Payment finished for {emp.Name}");
            }
        }
    }
}
