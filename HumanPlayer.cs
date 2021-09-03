using System;


namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {

          public override int Roll()
        {
           Console.WriteLine("Please enter a number for your roll");
           string response = Console.ReadLine();
           try
           {
           int responseAsNumb =  int.Parse(response);
           }
           catch
           {
               Console.WriteLine($"Please enter a whole number up to {DiceSize}");
               Roll();
           }

           return int.Parse(response);
        }
    }
}