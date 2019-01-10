using System;

namespace Program
{
    class Program
    {
        public static double Balance = 200;

        public static void Main(string[] args)
        {
            UserInterface();
        }
        static void UserInterface()
        {
            Console.WriteLine($@"
        _             
       | |            
   __ _| |_ _ __ ___  
  / _` | __| '_ ` _ \ 
 | (_| | |_| | | | | |
  \__,_|\__|_| |_| |_|

 Current Balance: ${Balance}
 ----------------------

   (0) View Balance
   (1) Withdraw
   (2) Deposit
   (3) Exit
");
            try
            {
                int menuInput = Convert.ToInt32(Console.ReadLine());
                MenuOptions(menuInput);
            }
            catch (Exception)
            {
                Console.Write("Sorry something went wrong. Try again.\nPress Enter to Continue . . .");
                Console.ReadKey();
                Console.Clear();
            }
            finally
            {
                UserInterface();
            }
            
        }
        public static void MenuOptions(int menuInput)
        {
            switch (menuInput)
            {
                case 0:
                    ViewBalance(Balance);
                    Console.ReadKey();
                    Console.Clear();
                    // View Balance 
                    break;
                case 1:
                   Balance = WithdrawBalance(Balance);
                    Console.ReadKey();
                    Console.Clear();
                    
                    //Withdraw Money
                    break;
                case 2:
                    Balance = DepositToBalance(Balance);
                    Console.ReadKey();
                    Console.Clear();
                    // Deposit Money Method
                    break;
                case 3:
                    ExitProgram();
                    Console.ReadKey();
                    Console.Clear();
                    // Exit Method
                    break;
                default:
                    Console.Write("Sorry something went wrong. Try again.\nPress any key to continue . . .");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        public static double ViewBalance(double Balance)
        {
            Console.WriteLine($"Your current balance is: ${Balance}\nPress any key to continue . . .");
            return Balance;
        }
        public static double WithdrawBalance(double Balance)
        {
            Console.Write("Type an amount of money to withdraw: $");
            string userInput = Console.ReadLine();
            double sysInput = Convert.ToDouble(userInput);
            if (sysInput > Balance)
            {
                Console.WriteLine("Insignificant funds.\nPress any key to continue . . .");
            }
            else if (sysInput < 0)
            {
                Console.WriteLine("Cheater.\nPress any key to continue . . .");
            } 
            else
	        {
                Balance = Balance - sysInput;
                Console.WriteLine($"Your remaining balance is: ${Balance}\nPress Enter to continue . . .");
            }
            
            return Balance;
        }
        public static double DepositToBalance(double Balance)
        {
            Console.Write("Type an amount of money to deposit: $");
            string userInput = Console.ReadLine();
            double sysInput = Convert.ToDouble(userInput);
             if (sysInput < 0)
            {
                Console.WriteLine("Invalid.\nPress any key to continue . . .");
            }
            else
            {
                Balance = Balance + sysInput;
                Console.WriteLine($"Your new balance is: ${Balance}\nPress any key to continue . . .");
            }

            return Balance;
        }
        public static void ExitProgram()
        {
            Environment.Exit(0);
        }

    }
}
