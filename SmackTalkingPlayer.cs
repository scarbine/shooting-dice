using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }
        
        public SmackTalkingPlayer()
        {
            Taunt = "Yo You no cool.";
        }

       

        public void SingleTaunt()
        {
            Console.WriteLine(taunt);
        }
    }
}