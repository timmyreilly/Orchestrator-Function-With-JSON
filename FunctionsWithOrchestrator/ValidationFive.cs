using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionsWithOrchestrator
{
    public static class ValidationFive
    {
        [FunctionName("ValidationFive")]
        public static async Task<string> Run([ActivityTrigger] Documento doc)
        {
            // await Task.Delay(5000);
            if (doc.documentDetails.Info == true)
            {
                return "ValidationFive Passed 'Info' is true";
            }
            else
            {
                return "ValidationFive Falied info is not true";
            }

        }
    }
}
