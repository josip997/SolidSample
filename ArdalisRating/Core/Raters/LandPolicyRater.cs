using ArdalisRating.Core.Interfaces;
using ArdalisRating.Core.Model;
using ArdalisRating.Infrastructure.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Core.Raters
{
    public class LandPolicyRater : IRater
    {
        private readonly RatingEngine _engine;
        private ConsoleLogger _logger;
        public LandPolicyRater(RatingEngine engine, ConsoleLogger logger)
        {
            _engine = engine;
            _logger = logger;
        }

        public void Rate(Policy policy)
        {
            _logger.Log("Rating LAND policy...");
            _logger.Log("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                _logger.Log("Land policy must specify Bond Amount and Valuation.");
                return;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                _logger.Log("Insufficient bond amount.");
                return;
            }
            _engine.Rating = policy.BondAmount * 0.05m;
        }
    }
}
