using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsWithOrchestrator
{
    public class Documento
    {
        public DocumentDetails documentDetails { get; set; }
        public object Signature { get; set; }
        public object SignatureTwo { get; set; }
        public object Authority { get; set; }
        public double Version { get; set; }
    }

    public class DocumentDetails
    {
        public string Name { get; set; }
        public bool Info  { get; set; }
        public int Type { get; set; }
    }
}
