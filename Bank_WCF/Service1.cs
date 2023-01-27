using BankBL;
using BankDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Bank_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        CustomerBl customerBl;
        UserBl userBl;
        BankAccountBl accountBl;
        public Service1()
        {
            userBl = new UserBl(new BankContext());
            accountBl = new BankAccountBl(new BankContext());
            customerBl = new CustomerBl(new BankContext());
        }

        public void AddMoney(int id, decimal money)
        {
            accountBl.AddMoney(id, money);
        }

        public void CreatBankAccount(BankAccount account)
        {
            accountBl.CreateBankAccount(account);
        }

        public User LoginUser(string mail, string password)
        {
            return userBl.LoginUser(mail, password);
        }

        public Customer RegisterCustomer(Customer customer)
        {
            return customerBl.RegisterCustomer(customer);
        }

        public void RegisterUser(User user)
        {
             userBl.RegisterUser(user);
        }

        public void RemoveMoney(int id, decimal money)
        {
            accountBl.RemoveMoney(id, money);
        }

        public void TransferMoney(int sender, int receiver, decimal money)
        {
            accountBl.TransferMoney(sender, receiver, money);
        }
    }
}
