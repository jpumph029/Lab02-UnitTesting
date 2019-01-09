using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterFace();
        }

        static void UserInterFace()
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
            int menuInput = Convert.ToInt32(Console.ReadLine());
            MenuOptions(menuInput);
        }
        static void MenuOptions(int menuInput)
        {
            switch (menuInput)
            {
                case 0:
                    Console.WriteLine("Test0");
                    // View Balance Method
                    break;
                case 1:
                    Console.WriteLine("Test1");
                    //Withdraw Money Method
                    break;
                case 2:
                    Console.WriteLine("Test2");
                    // Deposit Money Method
                    break;
                case 3:
                    Console.WriteLine("Test3");
                    // Exit Method
                    break;
                default:
                    Console.WriteLine("Test4");
                    break;

            }

        }
    }

}
