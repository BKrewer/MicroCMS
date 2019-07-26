using System;
using System.Collections.Generic;
using System.Text;

namespace MicroCMS.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Post> Posts { get; set; }

        public User()
        {

        }

        public User(string name, string cPF, string email, string gender, DateTime birthDate)
        {
            Name = name;
            CPF = cPF;
            Email = email;
            Gender = gender;
            BirthDate = birthDate;
        }
    }
}
