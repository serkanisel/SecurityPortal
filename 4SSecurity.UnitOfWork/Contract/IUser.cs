using FourSSecurity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSSecurity.UnitOfWork.Contract
{
    public interface IUser
    {
        User loginUser(string loginname, string password);

    }
}
