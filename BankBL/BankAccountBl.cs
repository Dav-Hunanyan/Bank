using BankDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBL
{
    public class BankAccountBl : BankBl
    {
        public BankAccountBl(BankContext db) : base(db) { }

        public BankAccount CreateBankAccount(BankAccount account)
        {
            if (validation.BankAccountValid(account))
            {
                db.BankAccounts.Add(account);
                db.SaveChanges();
                return account;
            }
            return null;
        }

        public BankAccount GetBankAccountId(int id)
        {
            var bankaccount = db.BankAccounts.FirstOrDefault(x => x.Id == id);
            return bankaccount;
        }

        public void TransferMoney(int senderID, int receiverID, decimal money)
        {
            var sender = db.BankAccounts.FirstOrDefault(x => x.Id == senderID);
            var receiver = db.BankAccounts.FirstOrDefault(x => x.Id == receiverID);

            if (sender != null && receiver != null && money > 0)
            {
                sender.CurrentAmount -= money;
                receiver.CurrentAmount += money;
                db.SaveChanges();
            }
        }

        public void AddMoney(int id, decimal money)
        {
            var account = db.BankAccounts.FirstOrDefault(x => x.Id == id);
            if (account != null && money > 0)
            {
                account.CurrentAmount += money;
                db.SaveChanges();
            }
        }

        public void RemoveMoney(int id, decimal money)
        {
            var account = db.BankAccounts.FirstOrDefault(x => x.Id == id);
            if (account != null && money > 0 && money < account.CurrentAmount)
            {
                account.CurrentAmount -= money;
                db.SaveChanges();
            }
        }
    }
}
