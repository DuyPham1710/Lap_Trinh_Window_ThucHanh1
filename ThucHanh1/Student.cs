﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class Student : Person
    {
        //private string iD, name, address, cmnd, phoneNumber, gioiTinh, email;
        //private DateTime bornYear;

        //public string ID { get => iD; set => iD = value; }
        //public string Name { get => name; set => name = value; }
        //public string Address { get => address; set => address = value; }
        //public string Cmnd { get => cmnd; set => cmnd = value; }
        //public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        //public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        //public string Email { get => email; set => email = value; }
        //public DateTime BornYear { get => bornYear; set => bornYear = value; }

        public Student(string iDValue) : base(iDValue) { }
        //{
        //    ID = iDValue;
        //}

        public Student(string iDValue, string nameValue, string addressValue, string cmndValue, DateTime bornYearValue, string phone, string gt, string emailValue)
        : base(iDValue, nameValue, addressValue, cmndValue, bornYearValue, phone, gt, emailValue)
        {
            //ID = iDValue;
            //Name = nameValue;
            //Address = addressValue;
            //Cmnd = cmndValue;
            //BornYear = bornYearValue;
            //PhoneNumber = phone;
            //GioiTinh = gt;
            //Email = emailValue;
        }
    }
}
