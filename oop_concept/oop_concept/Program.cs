//using System;

//class Oop
//{
//    private double Balance = 500;

//    public void Deposit(double amount)
//    {
//        if (amount > 0)
//        {
//            Balance += amount;
//            Console.WriteLine("Balance after Deposit: " + Balance);
//        }
//        else
//        {
//            Console.WriteLine("Invalid deposit amount!");
//        }
//    }

//    public void Withdraw(double amount)
//    {
//        if (amount > 0 && amount <= Balance)
//        {
//            Balance -= amount;
//            Console.WriteLine("Balance after Withdrawal: " + Balance);
//        }
//        else if (amount > Balance)
//        {
//            Console.WriteLine("Insufficient balance!");
//        }
//        else
//        {
//            Console.WriteLine("Invalid withdrawal amount!");
//        }
//    }

//    public void CheckBalance()
//    {
//        Console.WriteLine("Current Balance: " + Balance);
//    }

//    class Program
//    {
//        public static void Main()
//        {
//            Oop oop = new Oop();
//            int choice;

//            do
//            {
//                Console.WriteLine("\n<-------- Enter Your Choice -------->");
//                Console.WriteLine("1. Deposit");
//                Console.WriteLine("2. Withdraw");
//                Console.WriteLine("3. Check Balance");
//                Console.WriteLine("4. Exit");
//                Console.Write("Choice: ");

//                choice = Convert.ToInt32(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        Console.Write("Enter your deposit amount: ");
//                        double depositAmount = Convert.ToDouble(Console.ReadLine());
//                        oop.Deposit(depositAmount);
//                        break;

//                    case 2:
//                        Console.Write("Enter your withdrawal amount: ");
//                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
//                        oop.Withdraw(withdrawAmount);
//                        break;

//                    case 3:
//                        oop.CheckBalance();
//                        break;

//                    case 4:
//                        Console.WriteLine("Exiting...");
//                        break;

//                    default:
//                        Console.WriteLine("Invalid input");
//                        break;
//                }

//            } while (choice != 4);
//        }
//    }
//}
