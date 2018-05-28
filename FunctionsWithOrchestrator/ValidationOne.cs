using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json.Linq;

namespace FunctionsWithOrchestrator
{
    public static class ValidationOne
    {
        [FunctionName("ValidationOne")]
        public static async Task<string> Run([ActivityTrigger] JObject data) 
        {
            var x = data["valid"];

            if (x.ToString() == "true")
            {
                return "ValidationOne Passed";
            } else
            {
                return "ValidationOne Falied"; 
            }

        }
    }
}
