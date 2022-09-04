/*
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Intacct.SDK.Functions.Company;
using Intacct.SDK.Xml;
using Intacct.SDK.Functions; 

using [UsingModel];

namespace SapSageIntegration.Mappers
{
    public class [TargetName]Mapper : AbstractFunction
    {
        private readonly [Model] model;
        public [TargetName]Mapper([Model] model, string controlId = null)
            : base(controlId)
        {
            this.model = model;
        }

        public override void WriteXml(ref IaXmlWriter xml)
        {
            xml.WriteStartElement("function");
            xml.WriteAttribute("controlid", base.ControlId, writeNull: true);
            xml.WriteStartElement("create");

            [Body]       

            xml.WriteEndElement();
            xml.WriteEndElement();
        }
    }
}
*/