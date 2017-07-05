using FourSSecurity.Entity;
using FourSSecurity.Repository;
using FourSSecurity.UnitOfWork.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSSecurity.UnitOfWork.Business
{
    public class BSUser : IUser, IDisposable
    {
        public void Dispose()
        {
            this.Dispose();
        }

        public User loginUser(string loginname, string password)
        {
            IRepositoryBase<User> _rep = new RepositoryBase<User>();

            User u = _rep.Get(p => p.LoginName == loginname && p.Password == password);
            
            return u;
        }
    }
}
