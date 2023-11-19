using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendiente.Models
{
    internal class User
    {
        public const string DOCTOR  = "doctor";
        public const string NURSE   = "nurse";
        public const string PATIENT = "patient";

        public string Name { get; }
        public string Email { get; }
        private string Role;
        private string Password;

        public User(string Name, string Email, string Password, string Role = PATIENT)
        { 
            this.Name     = Name;
            this.Email    = Email;
            this.Password = Password;
            this.Role     = Role;
        }

        public bool IsValidPassword(string Password) {
            return this.Password == Password;
        }

        public bool IsDoctor() { return Role == DOCTOR; }
        public bool IsNurse() { return Role == NURSE; }
        public bool IsPatient() { return Role == PATIENT; }
    }
}
