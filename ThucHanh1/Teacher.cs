using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class Teacher : Person
    {
        public Teacher(string iDValue) : base(iDValue) { }

        public Teacher(string iDValue, string nameValue, string addressValue, string cmndValue, DateTime bornYearValue, string phone, string genderValue, string emailValue)
        : base(iDValue, nameValue, addressValue, cmndValue, bornYearValue, phone, genderValue, emailValue)
        {
        }
    }
}
