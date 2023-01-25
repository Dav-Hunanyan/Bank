using BankDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBL
{
    public class BankBl
    {
        protected readonly BankContext db;
        protected Validation validation;

        public BankBl(BankContext db)
        {
            this.db = db;
            validation=new Validation();
        }
    }
}
