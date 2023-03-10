using BankDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankBL
{
    public class Validation
    {
        public bool CustomerRegisterValid(Customer customer)
        {
            return MailValid(customer.Mail) && PhoneValid(customer.Phone)
            && NameValid(customer.Name) && NameValid(customer.Surname);
        }

        public bool UserRegisterValid(User user)
        {
            return MailValid(user.Mail) && PhoneValid(user.Phone)
             && NameValid(user.Name) && NameValid(user.Surname)
             && PasswordValid(user.Password) ;
        }

        public bool BankAccountValid(BankAccount account)
        {
            return true;
        }
        private bool MailValid(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");
        }

        private bool PhoneValid(string phone)
        {
            return Regex.IsMatch(phone, @"^\+374[1-9][0-9]{7}");
        }

        private bool PasswordValid(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

        }
        private bool NameValid(string name)
        {
            return Regex.IsMatch(name, @"^[A-Z][a-zA-Z]*$");

        }

        private bool DateValid(DateTime date)
        {
            return Regex.IsMatch(date.ToString(), @"^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$");
        }


        private bool PassportValid(string number)
        {
            return Regex.IsMatch(number, @"^[A - PR - WYa - pr - wy][A - PR - WYa - pr - wy][1 - 9]\\d\\s ?\\d{ 4} [1 - 9]$");
        }
    }
}
