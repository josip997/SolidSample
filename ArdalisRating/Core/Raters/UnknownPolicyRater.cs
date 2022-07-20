using ArdalisRating.Core.Interfaces;
using ArdalisRating.Core.Model;
using ArdalisRating.Infrastructure.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Core.Raters
{
    public class UnknownPolicyRater : IRater
    {
        private readonly RatingEngine _engine;
        private ConsoleLogger _logger;
        public UnknownPolicyRater(RatingEngine engine, ConsoleLogger logger)
        {
            _engine = engine;
            _logger = logger;
        }
        public void Rate(Policy policy)
        {
            _logger.Log("Unknown policy type");
        }
    }
}
