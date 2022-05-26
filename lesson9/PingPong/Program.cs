using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new();
            Pong pong = new();
            ping.PushBallEvent = pong.GetBall;
            pong.PushBallEvent = ping.GetBall;

            ping.PushBall();

            Console.ReadKey();
        }
    }
}
