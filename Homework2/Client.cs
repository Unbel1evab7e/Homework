using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Homework2
{
    public class Client 
    {
        int _id;
        int _accountid;
        string _firstname;
        string _secondname;
        string _lastname;
        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        public string Secondname
        {
            get
            {
                return _secondname;
            }
            set
            {
                _secondname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }
        public int ClientId
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public int AccountID 
        {
            get 
            {
               return _accountid;
            }
            set 
            {
                _accountid = value;
            } 
        }
        public List<Account> accounts;

        public bool Equals(Client other)
        {
            return(ClientId.Equals(other.ClientId));
        }
        public override string ToString()
        {
            return "ID: " + ClientId + "   Name: " + Firstname + "   SecondName: " + Secondname + "   LastName: " + Lastname;
          
        }
        public void CreateClient(int id)
        {
            ClientId = id;
            Console.WriteLine("Имя");
            Firstname = Console.ReadLine();
            Console.WriteLine("Фамилия");
            Secondname = Console.ReadLine();
            Console.WriteLine("Отчество");
            Lastname = Console.ReadLine();
        }
        public void CreateListAccount()
        {
            if (accounts==null)
            {
                Console.WriteLine("Список счетов пуст, будет создан новый");
                accounts = new List<Account>();
            }
        }
    }
}
        
   

        
            
        
  
