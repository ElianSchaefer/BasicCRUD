using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models.ViewModels
{
    public class ViewUser
    {
        public ViewUser(int id, string fullName, string tel, string email, DateTime birthDate)
        {
            Id = id;
            FullName = fullName;
            Tel = tel;
            Email = email;
            BirthDate = birthDate;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
    }
}
