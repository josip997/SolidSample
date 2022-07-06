using System;

namespace ArdalisRating
{
    class Program
    {
        private static ConsoleLogger logger = new ConsoleLogger();
        static void Main(string[] args)
        {
            logger.Log("Ardalis Insurance Rating System Starting...");

            var engine = new RatingEngine();
            engine.Rate();

            if (engine.Rating > 0)
            {
                logger.Log($"Rating: {engine.Rating}");
            }
            else
            {
                logger.Log("No rating produced.");
            }

        }
    }
}
