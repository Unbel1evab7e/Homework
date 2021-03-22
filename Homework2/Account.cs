using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework2
{
    public class Account : Client 
    {
        public int _accountID;
        public int _balance;
        public DateTime _dateTime;
        public List<string> History = new List<string>();
        List<Account> array = new List<Account>();
        public int AccountID
        {
            get
            {
                return _accountID;
            }
            set 
            {
                _accountID = value;
            } 
        }
        public int Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                    _balance= value;
            }
        }
        public DateTime DateTime 
        { 
            get
            {
                return _dateTime;
            } 
            set 
            {
                _dateTime = value;
            } 
        }
        
        public bool Equals(Account other)
        {
            return (AccountID.Equals(other.AccountID));
        }
        public override string ToString()
        {
            return "ID: " + AccountID + "  Balance: " + Balance;

        }
        public void GetHistory()
        {
            foreach (string aHistory in History)
            {
                Console.WriteLine(aHistory);
            }
        }
        public void CreateAccount(int accountid)
        {
            Balance = 0;
            AccountID = accountid;
            History.Add("Account Created: " + DateTime.Now);
        }
        public void BalanceChange()
        {
            bool flag = true;
            int value = 0;
            while (flag == true)
            {
                Console.WriteLine("Снять деньги (1)");
                Console.WriteLine("Положить деньги (2)");
                Console.WriteLine("Выход (3)");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.WriteLine("Введите сумму для снятия ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Balance -= value;
                        History.Add($"Payout: {value} Time: {DateTime.Now} Balance: {Balance}");
                        break;
                    case "2":
                        Console.WriteLine("Введите сумму для пополнения ");
                        value = Convert.ToInt32(Console.ReadLine());
                        Balance += value;
                        History.Add($"Refill: {value} Time: {DateTime.Now} Balance: {Balance}");
                        break;
                    case "3":
                    default:
                        flag = false;
                        break;
                }
            }

        }
        public void AccountIDCheck(List<Account> accounts,int n)
        {
            accounts.CopyTo(array);
        }
    }
}
