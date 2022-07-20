using ArdalisRating.Core;
using ArdalisRating.Core.Interfaces;
using ArdalisRating.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Core.Raters
{
    public class RaterFactory
    {
        public IRater Create(Policy policy, RatingEngine engine)
        {
            switch (policy.Type)
            {
                case PolicyType.Life:
                    return new LifePolicyRater(engine, engine.logger);
                case PolicyType.Land:
                    return new LandPolicyRater(engine, engine.logger);
                case PolicyType.Auto:
                    return new AutoPolicyRater(engine, engine.logger);
                default:
                    return new UnknownPolicyRater(engine, engine.logger);
            }
        }
    }
}
