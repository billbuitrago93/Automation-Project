
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Intacct.SDK.Functions.Company;
using Intacct.SDK.Xml;
using Intacct.SDK.Functions;

using SapConcurApiClient.VendorModels;

namespace SapSageIntegration.Mappers
{
    public class VendorMapper : AbstractFunction
    {
        private readonly Vendor model;
        public VendorMapper(Vendor model, string controlId = null)
            : base(controlId)
        {
            this.model = model;
        }

        public override void WriteXml(ref IaXmlWriter xml)
        {
            xml.WriteStartElement("function");
            xml.WriteAttribute("controlid", base.ControlId, writeNull: true);
            xml.WriteStartElement("create");


            xml.WriteStartElement("VENDOR");

            // Unique ID for the vendor. Required if company does not use document sequencing, or you can provide a value to use instead of the document sequence value.
            xml.WriteElement("VENDORID", model.VendorCode);

            // Name
            xml.WriteElement("NAME", model.VendorName);


            xml.WriteStartElement("DISPLAYCONTACT");

            // Contact tax group name
            xml.WriteElement("TAXGROUP", model.TaxType);

            // First name
            xml.WriteElement("FIRSTNAME", model.ContactFirstName);

            // Last name
            xml.WriteElement("LASTNAME", model.ContactLastName);

            // Primary phone number
            xml.WriteElement("PHONE1", model.ContactPhoneNumber);

            // Primary email address
            xml.WriteElement("EMAIL1", model.ContactEmail);

            // Secondary email address
            xml.WriteElement("EMAIL2", model.PurchaseOrderContactEmail);

            // Primary URL
            xml.WriteElement("URL1", model.URI);


            xml.WriteStartElement("MAILADDRESS");

            // Address line 1
            xml.WriteElement("ADDRESS1", model.Address1);

            // Address line 2
            xml.WriteElement("ADDRESS2", model.Address2);

            // City
            xml.WriteElement("CITY", model.City);

            // State/province
            xml.WriteElement("STATE", model.State);

            // Zip/postal code
            xml.WriteElement("ZIP", model.PostalCode);

            // Country
            xml.WriteElement("COUNTRY", model.Country);

            // End of MAILADDRESS
            xml.WriteEndElement();

            // End of DISPLAYCONTACT
            xml.WriteEndElement();

            // Status. Use active for Active or inactive for Inactive (Default: active)
            xml.WriteElement("STATUS", model.Approved);

            // Tax ID
            xml.WriteElement("TAXID", model.TaxID);

            // Default expense GL account number
            xml.WriteElement("APACCOUNT", model.AccountNumber);

            // Default currency code
            xml.WriteElement("CURRENCY", model.CurrencyCode);

            // Preferred payment method
            xml.WriteElement("PAYMETHODKEY", model.PaymentMethodType);

            // Payment term
            xml.WriteElement("TERMNAME", model.PaymentTerms);

            // End of VENDOR
            xml.WriteEndElement();


            xml.WriteEndElement();
            xml.WriteEndElement();
        }
    }
}
