using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Ecommerce.Data;

namespace Ecommerce.Service
{
   public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);
    }
}
