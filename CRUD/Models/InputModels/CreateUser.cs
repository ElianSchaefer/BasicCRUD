using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models.InputModels
{
    public class CreateUser
    {
        public CreateUser(string fullName, string email, string tel, DateTime birthDate)
        {
            FullName = fullName;
            Email = email;
            Tel = tel;
            BirthDate = birthDate;
        }

        public string FullName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public object Id { get; internal set; }
    }
}
