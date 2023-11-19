using Expendiente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendiente.Repositories
{
    internal class Session
    {
        private static Session _instance;
        private User CurrentUser;

        public Session(User user) {
            CurrentUser = user;
        }

        public static Session Start(User user)
        {
            _instance = new Session(user);
            return _instance;
        }

        private static Session GetInstance() {
            return _instance;
        }

        public static User GetCurrentUser()
        {
            return GetInstance().CurrentUser;
        }
    }
}
