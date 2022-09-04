
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Intacct.SDK.Functions.Company;
using Intacct.SDK.Xml;
using Intacct.SDK.Functions; 

using SapConcurApiClient.PaymentRequestModels;

namespace SapSageIntegration.Mappers
{
    public class InvoiceMapper : AbstractFunction
    {
        private readonly PaymentRequest model;
        public InvoiceMapper(PaymentRequest model, string controlId = null)
            : base(controlId)
        {
            this.model = model;
        }

        public override void WriteXml(ref IaXmlWriter xml)
        {
            xml.WriteStartElement("function");
            xml.WriteAttribute("controlid", base.ControlId, writeNull: true);
            xml.WriteStartElement("create"); 
       

            xml.WriteEndElement();
            xml.WriteEndElement();
        }
    }
}
