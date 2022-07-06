using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
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
                    return null;
            }
        }
    }
}
