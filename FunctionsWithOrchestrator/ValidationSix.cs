using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionsWithOrchestrator
{
    public static class ValidationSix
    {
        [FunctionName("ValidationSix")]
        public static async Task<string> Run([ActivityTrigger] Documento doc)
        {
            // await Task.Delay(5000);
            if (doc.documentDetails.Name != null)
            {
                return "ValidationSix Passed it has a name";
            }
            else
            {
                return "ValidationSix Falied it does not have a name";
            }

        }
    }
}
