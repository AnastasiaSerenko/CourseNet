using System;

namespace PingPong
{
    abstract class PlayBall
    {
        public string Name { get; protected set; }

        public EventHandler<string> PushBallEvent { get; set; }

        public void GetBall(object sender, string BallFrom)
        {
            Random rand = new();
            if (rand.Next(0, 10) > 2)
            {
                Console.WriteLine($"{Name} получил {BallFrom}");
                PushBall();
            }            
            else
                Console.WriteLine($"{BallFrom} промахнулся! Победил {Name}");            
        }

        public void PushBall()
        {
            PushBallEvent?.Invoke(this, Name);
        }
    }
}
