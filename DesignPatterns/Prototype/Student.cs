using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Student : Person
    {
        private int grade;
        public void SetGrade(int grade)
        {
            if (grade > 4)
                throw new ArgumentException("Grade must be equal or smaller than 4");
            this.grade = grade;
        }
        public string GroupName { get; set; }
        public Course Course { get; set; }
        public override Person Clone()
        {
            return (Student)MemberwiseClone();
        }

        public override Person DeepClone()
        {
            return DeepCloneHelper.DeepClone(this);
        }

        public override string ToString()
        {
            return $"Name:{this.Name},Surname:{this.Surname},Age:{Age},Course:{this.Course?.Name},Grade:{grade}";
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public int Credit { get; set; }
    }
}
