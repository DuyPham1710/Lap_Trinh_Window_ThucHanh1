using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class PersonDao
    {
        public void Add(Person person, string job)
        {
            string sqlStr = string.Format("INSERT INTO {8}(ID, Name, Address, Cmnd, BornYear, Gender, Email, PhoneNumber) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                person.ID, person.Name, person.Address, person.Cmnd, person.BornYear.ToString(), person.Gender, person.Email, person.PhoneNumber, job);
            DBConnection.Execute(sqlStr);
        }

        public void Update(Person person, string job)
        {
            string SQL = string.Format("UPDATE {8} SET Name = '{0}', Address = '{1}', Cmnd = '{2}', BornYear = '{3}', Gender = '{4}', Email = '{5}', PhoneNumber = '{6}' WHERE ID = '{7}'",
                person.Name, person.Address, person.Cmnd, person.BornYear.ToString(), person.Gender, person.Email, person.PhoneNumber, person.ID, job);
            DBConnection.Execute(SQL);
        }

        public void Delete(Person person, string job)
        {
            string SQL = string.Format("DELETE FROM {1} WHERE id = '{0}'", person.ID, job);
            DBConnection.Execute(SQL);
        }
    }
}
