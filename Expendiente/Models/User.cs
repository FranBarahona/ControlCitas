using Expendiente.conn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendiente.Models
{
    internal class User
    {
        public const string DOCTOR  = "Doctor";
        public const string NURSE   = "Nurse";
        public const string PATIENT = "Patient";

        public string Name { get; }
        public string Email { get; }
        private string Role;
        private string Password;

        public User(usuarios user)
        { 
            this.Name     = user.nombre;
            this.Email    = user.correo;
            this.Password = user.contrasena;
            this.Role     = user.roles.nombre;
        }

        public bool IsValidPassword(string Password) {
            return this.Password == Password;
        }

        public bool IsDoctor() { return Role == DOCTOR; }
        public bool IsNurse() { return Role == NURSE; }
        public bool IsPatient() { return Role == PATIENT; }
    }
}
