
using AutoMapper;
using WebApplication9.Interfaces;
using WebApplication9.Model;

namespace WebApplication9.Services
{



    public class ApiUser : IUser
    {
 

        public List<User> myuser = new List<User>()
                 {
                    new User(){ Name = "User1",Address="Address1",Id=1 },
                    new User(){ Name = "User2",Address="Address2",Id=2 },
                    new User(){ Name = "User3",Address="Address3",Id=3 }
          };



        public (bool isok, List<UserSelected> user, string ErrorMsg) GetSelectedUser()
        {
            var users = myuser.ToList();

            if (users != null)
            {
                var selecteduser = from userTable in users
                                   select new
                                   {
                                       userTable.Name
                                   };

                return (true, selecteduser, null);
            }

              return (false, null, "No Data");

         
        }



        public (bool isok, List<User> user, string ErrorMsg) GetAll()
        {
            var users =   myuser.ToList();

            if (users != null)
            {
                return (true, users, null);
            }

            return (false, null, "No Data");
        }

         

    }
}
