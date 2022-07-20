using System.IO;

namespace ArdalisRating.Infrastructure.PolicySources
{
    public class FilePolicySource
    {
        public string GetPolicyFromSource()
        {
            // load policy - open file policy.json
            return File.ReadAllText("policy.json");
        }
    }
}
