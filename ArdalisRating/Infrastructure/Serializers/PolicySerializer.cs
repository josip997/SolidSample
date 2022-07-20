using ArdalisRating.Core.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating.Infrastructure.Serializers
{
    public class PolicySerializer
    {
        public Policy GetPolicyFromJsonString(string policyJson)
        {
            return JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());
        }
    }
}
