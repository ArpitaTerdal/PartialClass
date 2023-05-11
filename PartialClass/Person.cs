using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    [TestClass]
    public partial class Person
    {
        public string Name { get; private set; }
        
        
        public string Introduce()
        {
            return $"Hi, my name is {Name} and I'm {CalculateAge()} years old";
        }
        private int CalculateAge()
        {
            var today = DateTime.Today;
            var years = today.Year - BirthDate.Year;
            if (BirthDate.AddYears(years).Date > today)
                years--;
            return years;
        }
        public Person(string name, DateTime birthdate)
        {
            Name = name;
            BirthDate = birthdate;
        }
    }
}
