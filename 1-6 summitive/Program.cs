using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Die
{
    internal class Program
    {
        public static void loading()
        {
            Console.Clear();
            string loading = "Loading";
            int loadingTime = 250;
            loading = "Loading";
            Console.WriteLine(loading);
            Thread.Sleep(loadingTime);
            loading = "Loading.";
            Console.Clear();
            Console.WriteLine(loading);
            Thread.Sleep(loadingTime);
            loading = "Loading..";

            Thread.Sleep(loadingTime);
            loading = "Loading...";
            Console.Clear();
            Console.WriteLine(loading);

            Thread.Sleep(loadingTime);
            loading = "Loading";
            Console.Clear();
            Console.WriteLine(loading);

            Thread.Sleep(loadingTime);
            loading = "Loading.";
            Console.Clear();
            Console.WriteLine(loading);

            Thread.Sleep(loadingTime);
            loading = "Loading..";
            Console.Clear();
            Console.WriteLine(loading);

            Thread.Sleep(loadingTime);
            loading = "Loading...";
            Console.Clear();
            Console.WriteLine(loading);
            Thread.Sleep(loadingTime);
            Console.Clear();
        }

        static void Main(string[] args)
        {
            bool lobby, playing;
            double balence = 50;
            lobby = true;
            playing = false;
            double betAmount;

            while (true)
            {

                Console.WriteLine("Welcome to Sky High Casino!");
                Console.WriteLine();
                Console.WriteLine("Your balance is: $" + balence + " USD");
                Console.WriteLine();
                Console.WriteLine("Enter how much you would like to bet: ");
                while (!double.TryParse(Console.ReadLine(), out betAmount) || (betAmount <= 0) || (betAmount > balence))
                {
                    Console.WriteLine("Invalid.");
                }
                    
               

                balence -= betAmount;
                Console.Clear();
                loading();
             
                ////////////////////////////////////////////////////

                die die1, die2;
                die1 = new die();
                die2 = new die();

                Console.WriteLine(die1);
                die1.DrawDie();
                Console.WriteLine(die2);
                die2.DrawDie();

                if (die1.Roll == die2.Roll)
                {
                    Console.WriteLine("Doubles");
                    Console.WriteLine("You win double you bet");
                    balence += (betAmount * 2);
                }
                else if (die1.Roll != die2.Roll)
                {
                    Console.WriteLine("Not doubles");
                    Console.WriteLine("You win half of your bet");
                    balence += (betAmount * 0.5);
                }
                else if ((die1.Roll + die2.Roll) % 2 == 0)
                {
                    Console.WriteLine("The numbers are even");
                    Console.WriteLine("You win your bet back");
                    balence += betAmount;
                }
                else if ((die1.Roll + die2.Roll) % 2 == 1)
                {
                    Console.WriteLine("The numbers are odd");
                    Console.WriteLine("You win your bet back");
                    balence += betAmount;
                }
                else
                {
                    Console.WriteLine("You lose xd");
                }

                Console.WriteLine("New Balence: " + balence);
                Thread.Sleep(2500);
                loading();
            
            }
            
           
            


          
        }
    }

}
