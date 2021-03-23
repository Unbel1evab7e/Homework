using System;
using System.Collections.Generic;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>();
            Client client = new Client();
            Account account=new Account();
            int clientid;
            int accountid;
            int count = 0;
            bool flag = true;
            bool flagacc;
            string menuacc;
            while (flag==true)
            {
                Console.WriteLine("Добавить клиента (1)");
                Console.WriteLine("Удалить клиента (2)");
                Console.WriteLine("Посмотреть всех клиентов(3)");
                Console.WriteLine("Работа со счетами(4)");
                Console.WriteLine("Выйти(5)");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        client = new Client();
                        client.CreateClient(count);
                        client.CreateListAccount();
                        clients.Add(client);
                        count++;
                        break;
                    case "2":
                            if (clients.Count != 0)
                        {
                            Console.WriteLine("Введите ClientId, который хотите удалить");
                            clientid = Convert.ToInt32(Console.ReadLine());
                            while (client.ClientIDCheck(clients, clientid) == false)
                            {
                                Console.WriteLine("Вы ввели неверный ID клиента, пожалуйста введите снова");
                                clientid = Convert.ToInt32(Console.ReadLine());
                            }
                            clients.RemoveAt(clientid);
                        }
                        else
                            Console.WriteLine("Список клиентов пуст");
                        break;
                    case "3":
                        if (clients.Count != 0)
                            foreach (Client aClient in clients)
                                Console.WriteLine(aClient);
                        else
                            Console.WriteLine("Список клиентов пуст");
                        break;
                    case "4":
                        if (clients.Count != 0)
                        {
                            flagacc = true;
                            Console.WriteLine("Введите ID клиента");
                            clientid = Convert.ToInt32(Console.ReadLine());
                            while (client.ClientIDCheck(clients, clientid) == false)
                            {
                                Console.WriteLine("Вы ввели неверный ID клиента, пожалуйста введите снова");
                                clientid = Convert.ToInt32(Console.ReadLine());
                            }
                            client = clients[clientid];
                            while (flagacc == true)
                                {
                                    Console.WriteLine("Добавить счёт(1)");
                                    Console.WriteLine("Удалить счёт(2)");
                                    Console.WriteLine("Изменение баланса(3)");
                                    Console.WriteLine("Посмотреть историю счёта(4)");
                                    Console.WriteLine("Показать все счета у клиента(5)");
                                    Console.WriteLine("Выйти(6)");
                                    menuacc = Console.ReadLine();
                                switch (menuacc)
                                {
                                    case "1":
                                        account = new Account();
                                        account.CreateAccount(client.CountAccountID);
                                        client.accounts.Add(account);
                                        client.CountAccountID++;
                                        break;
                                    case "2":
                                        Console.WriteLine("Введите AccountId, который хотите удаллить");
                                        accountid = Convert.ToInt32(Console.ReadLine());
                                        while (account.AccountIDCheck(client.accounts, accountid) == false)
                                        {
                                            Console.WriteLine("Вы ввели неверный ID клиента, пожалуйста введите снова");
                                            accountid = Convert.ToInt32(Console.ReadLine());
                                        }
                                        client.accounts.RemoveAt(accountid);
                                        break;
                                    case "3":
                                        Console.WriteLine("Введите AccountId счёта, с которым вы хотите работать");
                                        accountid = Convert.ToInt32(Console.ReadLine());
                                        while (account.AccountIDCheck(client.accounts, accountid) == false)
                                        {
                                            Console.WriteLine("Вы ввели неверный ID клиента, пожалуйста введите снова");
                                            accountid = Convert.ToInt32(Console.ReadLine());
                                        }
                                        account = client.accounts[accountid];
                                        account.BalanceChange();
                                        break;
                                    case "4":
                                        Console.WriteLine("Введите AccountId счёта,историю которого вы хотите получить");
                                        accountid = Convert.ToInt32(Console.ReadLine());
                                        while (account.AccountIDCheck(client.accounts, accountid) == false)
                                        {
                                            Console.WriteLine("Вы ввели неверный ID клиента, пожалуйста введите снова");
                                            accountid = Convert.ToInt32(Console.ReadLine());
                                        }
                                        account = client.accounts[accountid];
                                        account.GetHistory();
                                        break;
                                    case "5":
                                        foreach (Account aAccount in client.accounts)
                                            Console.WriteLine(aAccount);
                                        break;
                                    case "6":
                                    default:
                                        flagacc = false;
                                        break;
                                }
                            }                                                      
                        }
                        break;
                    case "5":
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}