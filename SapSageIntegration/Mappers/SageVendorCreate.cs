using Intacct.SDK.Functions;
using Intacct.SDK.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapSageIntegration.Mappers
{
    internal class SageVendorCreate : AbstractFunction
    {
        public SageVendorCreate(string controlId = null) : base(controlId)
        {
 
        }

        public override void WriteXml(ref IaXmlWriter xml)
        {
            throw new NotImplementedException();
        }
    }
}
