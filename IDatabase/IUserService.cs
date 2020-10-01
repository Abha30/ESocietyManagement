using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
  public interface IUserService
    {
      
            IEnumerable<UserServiceDetails> GetUserService();



            UserServiceDetails GetByIdUserService(int id);



            bool PostUserService(UserServiceDetails u);



        string PutUserService(int id, UserServiceDetails u);
        }
    }

