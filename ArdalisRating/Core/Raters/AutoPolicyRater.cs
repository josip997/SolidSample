using ArdalisRating.Core.Interfaces;
using ArdalisRating.Core.Model;
using ArdalisRating.Infrastructure.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Core.Raters
{
    public class AutoPolicyRater : IRater
    {
        private readonly RatingEngine _engine;
        private ConsoleLogger _logger;
        public AutoPolicyRater(RatingEngine engine, ConsoleLogger logger)
        {
            _engine = engine;
            _logger = logger;
        }

        public void Rate(Policy policy)
        {
            _logger.Log("Rating AUTO policy...");
            _logger.Log("Validating policy.");
            if (string.IsNullOrEmpty(policy.Make))
            {
                _logger.Log("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _engine.Rating = 1000m;
                }
                _engine.Rating = 900m;
            }
        }
    }
}
