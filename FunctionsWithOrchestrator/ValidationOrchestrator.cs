using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FunctionsWithOrchestrator
{
    public static class ValidationOrchestrator
    {
        [FunctionName("ValidationOrchestrator")]
        public static async Task<List<string>> Run([OrchestrationTrigger] DurableOrchestrationContext context)
        {
            var outputs = new List<string>();

            var ValidateMe = context.GetInput<string>();
            JObject stuff = JObject.Parse(ValidateMe);
            Documento doc = JsonConvert.DeserializeObject<Documento>(ValidateMe); 

            outputs.Add(await context.CallActivityAsync<string>("ValidationOne", doc));
            outputs.Add(await context.CallActivityAsync<string>("ValidationTwo", doc));
            outputs.Add(await context.CallActivityAsync<string>("ValidationThree", doc));
            outputs.Add(await context.CallActivityAsync<string>("ValidationFour", doc));
            outputs.Add(await context.CallActivityAsync<string>("ValidationFive", doc));
            outputs.Add(await context.CallActivityAsync<string>("ValidationSix", doc));

            outputs.Add(ValidateMe);
            return outputs;
        }
    }
}
