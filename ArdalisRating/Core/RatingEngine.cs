using ArdalisRating.Core.Model;
using ArdalisRating.Core.Raters;
using ArdalisRating.Infrastructure.Loggers;
using ArdalisRating.Infrastructure.PolicySources;
using ArdalisRating.Infrastructure.Serializers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating.Core
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public ConsoleLogger logger { get; set; } = new ConsoleLogger();
        public FilePolicySource policySource { get; set; } = new FilePolicySource();
        public PolicySerializer policySerializer { get; set; } = new PolicySerializer();

        public decimal Rating;

        public void Rate()
        {
            logger.Log("Starting rate.");

            logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyJson = policySource.GetPolicyFromSource();

            Policy policy = policySerializer.GetPolicyFromJsonString(policyJson);

            var raterFactory = new RaterFactory();
            var rater = raterFactory.Create(policy, this);
            rater.Rate(policy);

            logger.Log("Rating completed.");
        }

    }
}
