using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionsWithOrchestrator
{
    public static class ValidationTwo
    {
        [FunctionName("ValidationTwo")]
        public static async Task<string> Run([ActivityTrigger] Documento doc)
        {
            if (doc.Signature.ToString() == doc.SignatureTwo.ToString())
            {
                return "ValidationTwo Passed... the two signatures are equal";
            }
            else
            {
                return "ValidationTwo Falied... the two signautres are not equal";
            }

        }
    }
}
