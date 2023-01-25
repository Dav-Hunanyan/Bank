using BankDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBL
{
    public class CustomerBl : BankBl
    {
        public CustomerBl(BankContext db) : base(db) { }

        public void RegisterCustomer(Customer customer)
        {
            if (validation.CustomerRegisterValid(customer))
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }

        }

    }
}
