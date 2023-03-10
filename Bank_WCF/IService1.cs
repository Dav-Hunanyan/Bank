using BankDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Bank_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void TransferMoney(int sender, int receiver, decimal money);

        [OperationContract]
        void AddMoney(int id, decimal money);

        [OperationContract]
        void RemoveMoney(int id, decimal money);

        [OperationContract]
        Customer RegisterCustomer(Customer customer);
        [OperationContract]
        void RegisterUser(User user);
        [OperationContract]
        User LoginUser(string mail, string password);
        [OperationContract]
        BankAccount CreatBankAccount(BankAccount account);

        [OperationContract]
        BankAccount GetBankAccount(int id);

        [OperationContract]
        Customer GetCustomer(int id);

    }

}
