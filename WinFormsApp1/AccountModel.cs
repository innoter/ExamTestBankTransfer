using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Account
    {
        public Account(string iBAN, string accountName)
        {
            IBAN = iBAN;
            AccountName = accountName;
        }

        public Account()
        {
        }
        public string IBAN { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

    }
}
