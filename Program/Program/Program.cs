using System;

namespace Program
{
    class Program
    {
        public static double Balance = 200;

        static void Main(string[] args)
        {
            UserInterface();
        }

        static void UserInterface()
        {
            Console.WriteLine(@"
      BIG JOES 
        _             
       | |            
   __ _| |_ _ __ ___  
  / _` | __| '_ ` _ \ 
 | (_| | |_| | | | | |
  \__,_|\__|_| |_| |_|");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine(@"
   (0) View Balance
   (1) Withdraw
   (2) Deposit
   (3) Exit");
            try
            {
                int menuInput = Convert.ToInt32(Console.ReadLine());
                MenuOptions(menuInput);
            }
            catch (Exception)
            {
                Console.Write("You broke it. Try again");
                Console.ReadKey();
                Console.Clear();
            }
                    // View Balance 
            finally
            {
                UserInterface();
            }
            
        }
        static void MenuOptions(int menuInput)
        {
            switch (menuInput)
            {
                case 0:
                    ViewBalance(Balance);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 1:
                    WithdrawBalance(Balance);
                    Console.ReadKey();
                    Console.Clear();
                    
                    //Withdraw Money
                    break;
                case 2:
                    Console.Write("Test2");
                    Console.ReadKey();
                    Console.Clear();
                    // Deposit Money Method
                    break;
                case 3:
                    Console.Write("Test3");
                    Console.ReadKey();
                    Console.Clear();
                    // Exit Method
                    break;
                default:
                    Console.Write("You broke it. Try again");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        public static double ViewBalance(double Balance)
        {
            Console.WriteLine($"Your current balance is: ${Balance}");
            return Balance;
        }
        public static double WithdrawBalance(double Balance)
        {
            Console.WriteLine("Type an amount of money to withdraw: ");
            string userInput = Console.ReadLine();
            double sysInput = Convert.ToDouble(userInput);
            if (sysInput > Balance)
            {
                Console.WriteLine("Insignificant funds.");
            }
            else if (sysInput < 0)
            {
                Console.WriteLine("Cheater");
            } 
            else
	        {
                Balance = Balance - sysInput;
                Console.WriteLine($"Your remaining balance is: ${Balance}");
            }
            
            return Balance;
        }
    }

}
