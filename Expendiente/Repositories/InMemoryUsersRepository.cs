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

        public InMemoryUsersRepository() {
            using ( masterEntities db = new masterEntities()) {

                 db.usuarios.ToList().ForEach((item)=>{
                     users.Add(new User(item));
                 });
                }
        }

        public User FindByEmail(string Email)
        {
            return users.Find(x => x.Email == Email);
        }
    }
}
