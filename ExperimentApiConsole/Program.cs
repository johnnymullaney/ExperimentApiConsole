using System.Net;
using ExperimentApiConsole.Models;
using Newtonsoft.Json;
using RestSharp;

string projectId = "<Insert Project Id>";
string restAuthToken = "Bearer <Insert Bearer Token>";
string environmentName = "<Insert Environment Name>";

var client = GetRestClient(restAuthToken, true);

GetFlagsRequest(client, projectId);

GetFlagsWithABTests(client, projectId, environmentName);

return 1;

static OptiListResponse<Flag> GetFlagsRequest(RestClient client, string projectId)
{
    var request = new RestRequest($"/flags/v1/projects/{projectId}/flags", Method.Get);

    var serialisedResponse = client.GetAsync(request).Result;

    var response = JsonConvert.DeserializeObject<OptiListResponse<Flag>>(serialisedResponse.Content);

    return response;
}

static OptiListResponse<Flag> GetFlagsWithABTests(RestClient client, string projectId, string environmentName)
{
    var flagRequest = new RestRequest($"/flags/v1/projects/{projectId}/flags?rule_type=a/b", Method.Get);

    var serialisedResponse = client.GetAsync(flagRequest).Result;

    var flagResponse = JsonConvert.DeserializeObject<OptiListResponse<Flag>>(serialisedResponse.Content);

    var rules = new List<Rule>();

    foreach (var flag in flagResponse.Items)
    {
        // TODO how do we choose environment
        // Naming convention and app setting?
        var ruleRequest = new RestRequest($"/flags/v1/projects/{projectId}/flags/{flag.Key}/environments/{environmentName}/ruleset", Method.Get);

        var serialisedRuleResponse = client.GetAsync(ruleRequest).Result;

        var ruleResponse = JsonConvert.DeserializeObject<RuleResponse>(serialisedRuleResponse.Content);

        rules.AddRange(ruleResponse.Rules.Values);
    }

    return flagResponse;
}

static RestClient GetRestClient(string restAuthToken, bool v1Api = false)
{
    string apiUrl = "https://api.optimizely.com/v2";
    if (v1Api)
    {
        apiUrl = "https://api.optimizely.com";
    }

    var client = new RestClient(apiUrl);
    client.AddDefaultHeader("Authorization", restAuthToken);

    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

    return client;
}