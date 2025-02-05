using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Student
    {
        public string Name { get; set; }

        public Student(string _Name)
        {
            Name = _Name;
        }

        public void NotifyExamStart(object sender, string message)
        {
            Console.WriteLine($"{Name} Prepare your self the exam starts soon: {message}");
        }
    }
}
