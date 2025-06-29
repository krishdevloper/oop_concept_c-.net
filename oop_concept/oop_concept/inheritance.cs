using System;

class Bank
{
    protected double Balance = 500;
    public int acNo;

    public virtual void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("BALANCE: " + Balance);
    }

    public virtual void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine("BALANCE: " + Balance);
        }
        else
        {
            Console.WriteLine("INVALID BALANCE");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("CURRENT BALANCE: " + Balance);
    }
}

class SavingAcc : Bank
{
    private double interestRate = 0.04;

    public void AddInterest()
    {
        double interest = Balance * interestRate;
        Balance += interest;
        Console.WriteLine("INTEREST ADDED. BALANCE: " + Balance);
    }
}

class CurrentAcc : Bank
{
    private double overdraftLimit = 500;

    public override void Withdraw(double amount)
    {
        if (amount > 0 && (Balance + overdraftLimit) >= amount)
        {
            Balance -= amount;
            Console.WriteLine("Withdraw Successful (Overdraft Allowed). BALANCE: " + Balance);
        }
        else
        {
            Console.WriteLine("Overdraft Limit Exceeded or Invalid amount.");
        }
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("Choose Account Type:");
        Console.WriteLine("1. Saving Account");
        Console.WriteLine("2. Current Account");
        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            SavingAcc sa = new SavingAcc();

            Console.Write("ENTER YOUR DEPOSIT: ");
            double deposit1 = Convert.ToDouble(Console.ReadLine());
            sa.Deposit(deposit1);

            Console.Write("ENTER YOUR WITHDRAW: ");
            double withdraw1 = Convert.ToDouble(Console.ReadLine());
            sa.Withdraw(withdraw1);

            sa.CheckBalance();
            Console.WriteLine("ADDING INTEREST...");
            sa.AddInterest();
            sa.CheckBalance();
        }
        else if (choice == 2)
        {
            CurrentAcc ca = new CurrentAcc();

            Console.Write("ENTER YOUR DEPOSIT: ");
            double deposit1 = Convert.ToDouble(Console.ReadLine());
            ca.Deposit(deposit1);

            Console.Write("ENTER YOUR WITHDRAW: ");
            double withdraw1 = Convert.ToDouble(Console.ReadLine());
            ca.Withdraw(withdraw1);  // Overdraft logic applied here

            ca.CheckBalance();

            // No interest for current account
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
