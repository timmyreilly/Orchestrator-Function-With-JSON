using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionsWithOrchestrator
{
    public static class ValidationThree
    {
        [FunctionName("ValidationThree")]
        public static async Task<string> Run([ActivityTrigger] Documento doc)
        {
            await Task.Delay(5000);
            if (doc.documentDetails.Type % 2 == 0 )
            {
                return "ValidationThree Passed details type is even";
            }
            else
            {
                return "ValidationThree Falied details type is not even";
            }

        }
    }

}
