using System;
using ConsoleBank;


namespace ConsoleBank
{
    class Program
    {

        


        static void Main(string[] args)
        {
            Console.WriteLine("What is your name:");
            string userName = Console.ReadLine();

            Console.WriteLine(" ---------------------------");
            Console.WriteLine("|     Welcome to Mybank      |");
            Console.WriteLine("        "+userName+"       ");
            Console.WriteLine("|   How can we help you?     |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. Balance Enquiry         |");
            Console.WriteLine("| 2. Cash Deposit            |");
            Console.WriteLine("| 3. Withdrawal              |");
            Console.WriteLine("|                            |");
            Console.WriteLine(" ---------------------------");



            var account = new BankAccount(userName, 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Client} with {account.Balance} initial balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
            Console.WriteLine(account.Balance);



            



            //Client objClient = new Client();
            //Console.WriteLine();
            //objClient.clientName = Console.ReadLine();
            //string clientName = Console.ReadLine();
            //objClient.clientName(clientName);
            //type of action
            //Console.WriteLine("Welcome " + clientName + " your Balance is " +  + "  would you like to: check balance, deposit or Withdrawl?");
            //string clientOption = Console.ReadLine();






            // BankAccount objBank = new BankAccount();
            // objBank.makeBankAccount(clientName, 10, "saving account");
            //Console.WriteLine("User name is: " + objBank.Client + "Your balance is " + objBank.Balance + " and is a " + objBank.Type);

            // Console.WriteLine("Welcome " + clientName + " your balance is " + objBank.Balance + " and is a " + objBank.Type + " Would you like to Deposit or Withdrawl?");
            // string clientOption = Console.ReadLine();


            //Console.ReadLine();
        }
    }
}
