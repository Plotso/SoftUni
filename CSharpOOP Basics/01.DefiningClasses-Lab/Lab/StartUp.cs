using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        //BankAccount acc = new BankAccount();
        //acc.ID = 1;
        //acc.Deposit(15);
        //acc.Withdraw(5);

        //Console.WriteLine(acc.ToString());

        var accounts = new Dictionary<int, BankAccount>();
        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            var cmdArgs = command.Split();

            var cmdType = cmdArgs[0];
            switch (cmdType)
            {
                case "Create":
                    Create(cmdArgs, accounts);
                    break;
                case "Deposit":
                    Deposit(cmdArgs, accounts);
                    break;
                case "Withdraw":
                    Withdraw(cmdArgs, accounts);
                    break;
                case "Print":
                    Print(cmdArgs, accounts);
                    break;
            }
        }
    }

    private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            var account = accounts[id];
            Console.WriteLine($"Account ID{account.ID}, balance {account.Balance:f2}");
            //Console.WriteLine(accounts[id].ToString());
        }
    }

    private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var value = double.Parse(cmdArgs[2]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            if (accounts[id].Balance < value)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Withdraw(value);
            }
        }
    }

    private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var value = double.Parse(cmdArgs[2]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[id].Deposit(value);
        }
    }

    private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (accounts.ContainsKey(id)) 
        {
            Console.WriteLine("Account already exists");
        }
        else
	{
            var acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id,acc);
        }
    }
}

