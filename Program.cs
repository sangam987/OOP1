using System.Security.Cryptography.X509Certificates;

namespace OOP1
{
    internal class Program
    {
        public static void checkBalance(double currentBalance)
        {
            Console.WriteLine("The total balance in your acccout is {0}", currentBalance);
        }
        public static string takeInput(string input="")
        {
            Console.WriteLine(input);
            string t = Console.ReadLine().ToLower();
            return t;
        }

        static void Main(string[] args)
        {
            double currentBalance = 0, temp = 0;
            int i = 1;  
            string choice,temp1 ;
            do
            {   Console.Clear();
                Console.WriteLine("Please choose from the following choices:\n1.Deposit\n2.Check Balance\n3.Withdraw\nEnter choice(1,2,3) : ");
                choice = takeInput();
                switch(Convert.ToInt32(choice))
                {
                    //case "deposit"
                    case 1:temp1 = takeInput("Enter money to deposit");
                        //temp1 = Console.ReadLine();
                        temp =Convert.ToDouble(temp1);
                        if (temp < 0)
                        {
                            string t2 = takeInput("Reenter the amount as amount cannot be negative. Press enter to continue");
                            continue;
                        }
                        else
                        {
                            currentBalance += temp;
                        }
                        break;
                   // case "check balance"
                    case 2: //temp1 = takeInput("Do you want to check balance(Y/N)?");
                       // temp1 = Console.ReadLine();
                        //if(temp1=="y" || temp1=="Y" || temp1.ToLower()=="yes") 
                        {
                            checkBalance(currentBalance);
                            string t = takeInput("Do you want to continue(Y/N)?");
                            if (t=="n" || t=="no")
                            {
                                i = 6;
                                break;
                            }
                            else
                            {
                                checkBalance(currentBalance);
                               // continue;
                            }
                        }
                        //else
                        //{
                        //    continue;
                        //}
                        break;
                    case 3: temp1 = takeInput("Enter the amount to withdraw:"); // "withdraw"
                        //temp1 = Console.ReadLine();
                        temp = Convert.ToDouble(temp1);
                        if (temp < 0)
                        {
                            string t2 = takeInput("Reenter the amount as amount cannot be negative. Press any key to continue");         
                            continue;
                        }
                        else
                        {
                            if (currentBalance > temp) currentBalance -= temp;
                            else takeInput("Insufficient amt..Press any key to continue");
                        }
                        break;
                    default: Console.WriteLine("Please enter the text or enumerate the choice between 1,2,3");break;

                }
                i++;
            } while (i <= 5);
            if (i > 5)
            {
                checkBalance(currentBalance);
            }
        }
        
    }
}