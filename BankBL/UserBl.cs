using BankDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBL
{
    public class UserBl : BankBl
    {
        public UserBl(BankContext db) : base(db) { }


        public void RegisterUser(User user)
        {
            if (validation.UserRegisterValid(user))
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public User LoginUser(string mail, string password)
        {
            User user = db.Users.FirstOrDefault(x => x.Mail == mail);
            if (user != null && user.Password == password) { return user; }
            return null;
        }
    }
}
