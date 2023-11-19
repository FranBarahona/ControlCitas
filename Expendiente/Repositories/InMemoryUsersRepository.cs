using Expendiente.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendiente.Repositories
{
    internal class InMemoryUsersRepository : IUsersRepository
    {
        private List<User> users = new List<User>();

        public InMemoryUsersRepository() {
            users.Add(new User("Doctor Strange", "doctor@gmail.com", "123", User.DOCTOR));
            users.Add(new User("Beautiful Nurse", "nurse@gmail.com", "123", User.NURSE));
            // Role por defecto User.PATIENT
            users.Add(new User("Sick patient", "patient@gmail.com", "123"));
        }

        public User FindByEmail(string Email)
        {
            return users.Find(x => x.Email == Email);
        }
    }
}
