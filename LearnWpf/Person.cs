using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWpf
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public override string ToString()
        {
            return string.Format($"{FirstName} {LastName} {Age}");
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
