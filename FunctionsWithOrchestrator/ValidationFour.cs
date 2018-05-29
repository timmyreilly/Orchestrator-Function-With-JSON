using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionsWithOrchestrator
{
    public static class ValidationFour
    {
        [FunctionName("ValidationFour")]
        public static async Task<string> Run([ActivityTrigger] Documento doc)
        {
            await Task.Delay(1000);
            if (doc.Version != 0)
            {
                return "ValidationFour Passed we have a doc version";
            }
            else
            {
                return "ValidationFour Falied we do not have a legitimate doc version";
            }

        }
    }
}
