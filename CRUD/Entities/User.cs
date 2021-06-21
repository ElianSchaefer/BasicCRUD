using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string tel, string email, DateTime birthDate)
        {
            FullName = fullName;
            Tel = tel;
            Email = email;
            BirthDate = birthDate;
        }

        public string FullName { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }

        

        public void Update(string tel, string email)
        {
            Tel = tel;
            Email = email;
        }
    }
}
