 
using WebApplication9.Model;
using WebApplication9.Services;

namespace WebApplication9.Interfaces
{
   public interface IUser
    {
       (bool isok, List<User> user, string ErrorMsg) GetAll();
       (bool isok, List<UserSelected> user, string ErrorMsg) GetSelectedUser();
  
    }
}
