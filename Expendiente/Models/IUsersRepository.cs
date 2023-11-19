using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendiente.Models
{
    internal interface IUsersRepository
    {
        User FindByEmail(string Email);
    }
}
