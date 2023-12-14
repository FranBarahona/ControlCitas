using Expendiente.conn;
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

        public InMemoryUsersRepository()
        {
            using (masterEntities db = new masterEntities())
            {

                db.usuarios.ToList().ForEach((item) =>
                {
                    users.Add(new User(item));
                });
            }
        }

        public User FindByEmail(string Email)
        {
            return users.Find(x => x.Email == Email);
        }

        public User FindById(int id)
        {
            using (masterEntities db = new masterEntities())
            {
                return  new User(db.usuarios.Find(id));
            }
        }

        public void Update(int id, string nombre, string correo)
        {
            using(masterEntities db = new masterEntities()){
                var usuario = db.usuarios.Find(id);
                db.usuarios.Attach(usuario);

                usuario.correo = correo;
                usuario.nombre = nombre;

                db.Entry(usuario).Property(e => e.correo).IsModified = true;
                db.Entry(usuario).Property(e => e.nombre).IsModified = true;

                // Guarda los cambios en la base de datos.
                db.SaveChanges();
            }
        }
    }
}
