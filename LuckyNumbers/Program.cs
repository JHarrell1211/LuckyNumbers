using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, x = 0, y = 0;
            int play = 0;
            double jackpot = 32000000;
            Random r = new Random();
            int[] rJackpotNum = new int[6];
            int[] userNum = new int[6];
            int winNum = 0;
            double winnings;
            int userPick;

            do
            {
                Console.WriteLine("Welcome to Lucky Numbers the jackpot is $32,000,000");
                Console.WriteLine("Please Make a Selection");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Exit");
                play = int.Parse(Console.ReadLine());

                if (play == 1)
                {

                    Console.Write("You can choose the range of numbers for the lottery generator.   Selections for the lottery generator must be a minimum of 20 numbers apart,");
                    Console.WriteLine(" For Example,you can choose for the lottery numbers to fall between 0 and 100 or between 2 and 22.");
                    Console.WriteLine("After choosing the range, you will then make your selections.");
                    Console.WriteLine("The larger the range, the larger the winnings. \n " );

                    Console.WriteLine("Enter lower number of the range for the Lottery Generator");
                    x = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter next number for your range (must be a minimum of 20 numbers larger than   previous entry)");
                    y = int.Parse(Console.ReadLine());


                    while ((y - x) < 20)  // Loop prevents user from entering numbers that are less than 20 numbers apart
                    {
                        Console.WriteLine("ERROR!! Choices not at least 20 numbers apart \n");

                        Console.WriteLine("Enter lower number of your range");
                        x = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter next number for your range (must be a minimum of 20 numbers larger than previous entry)");
                        y = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Think hard..... Now choose your numbers between " + x + " and " + y + "\n");
                    userPick = 0; // resets choice counter to 0 if user continues playing

                    for (i = 0; i < userNum.Length; i++) //Loop for user input of numbers
                    {
                        userPick = userPick + 1;
                        Console.WriteLine("Enter Choice " + userPick);
                        userNum[i] = int.Parse(Console.ReadLine());

                        while ((userNum[i] > y) || (userNum[i] < x))
                        // Loop prevents user from entering a number that is too large or too small
                        {
                            Console.WriteLine("Error!!, Number is out of range");
                            Console.WriteLine("Enter Choice " + userPick);
                            userNum[i] = int.Parse(Console.ReadLine());
                        }   
                        
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Jackpot Numbers are as follows");
                    for (i = 0; i < rJackpotNum.Length; i++)    //Generates random jackpot numbers
                    {
                        rJackpotNum[i] = r.Next(x, (y + 1));
                        // Larger is not included in the generator so 1 is added to y to include it

                        Console.WriteLine("Lucky Number: " + rJackpotNum[i]);
                    }

                    Console.WriteLine("");

                    winNum = 0; // Resets count of winning numbers to zero if game is restarted
  
                        for (i = 0; i < userNum.Length; i++) //Loop tells users which numbers they matched
                        {
                            for (int j = 0; j < rJackpotNum.Length; j++)
                            {
                            if (userNum[i] == rJackpotNum[j])
                            {
                                Console.WriteLine(userNum[i]);
                                winNum = winNum + 1;  //Counts the number of winning numbers to be used in calculating winnings
                            }

                            }
                        }
                    }
                        Console.WriteLine("You guessed  " + winNum + " numbers correctly! \n");


                    if ((y - x) <= 30) // winnings if lucky numbers are 30 digits apart or less
                    {
                        if (winNum == 0)
                        {
                            winnings = 0 * jackpot;
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 1)
                        {
                            winnings = (.00002 * jackpot);
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 2)
                        {
                            winnings = (.0002 * jackpot);
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 3)
                        {
                            winnings = (.002 * jackpot);
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 4)
                        {
                            winnings = (.005 * jackpot);
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 5)
                        {
                            winnings = (.02 * jackpot);
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 6)
                        {
                            Console.WriteLine("You won $" + jackpot + "!\n");
                        }
                        
                        }
                        
                    else if ((y - x) > 30) // winnings if user chooses numbers greater than 30 numbers apart
                    {

                        if (winNum == 0)
                        {
                            winnings = 0 * jackpot;
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 1)
                        {
                            winnings = (.000033 * jackpot);
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 2)
                        {
                            winnings = (.00033 * jackpot);
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 3)
                        {
                            winnings = (.0033 * jackpot);
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 4)
                        {
                            winnings = (.0067 * jackpot);
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 5)
                        {
                            winnings = (.0285 * jackpot);
                            Console.WriteLine("You won $" + winnings + "!\n");
                        }
                        else if (winNum == 6)
                        {
                            Console.WriteLine("Jackpot!! You won $" + jackpot + "!\n");
                        }

                    }

                if (play == 2)
                {
                    Console.WriteLine("Thanks For Playing! \n");
                }
            }
            while (play != 2);

        }
    }
}
