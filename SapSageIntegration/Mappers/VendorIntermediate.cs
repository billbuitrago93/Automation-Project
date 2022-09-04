/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System.Xml.Serialization;
namespace Xml2CSharp
{
    [XmlRoot(ElementName = "MAILADDRESS")]
    public class MAILADDRESS
    {
        [XmlElement(ElementName = "ADDRESS1")]
        public string ADDRESS1 { get; set; }
        [XmlElement(ElementName = "ADDRESS2")]
        public string ADDRESS2 { get; set; }
        [XmlElement(ElementName = "CITY")]
        public string CITY { get; set; }
        [XmlElement(ElementName = "STATE")]
        public string STATE { get; set; }
        [XmlElement(ElementName = "ZIP")]
        public string ZIP { get; set; }
        [XmlElement(ElementName = "COUNTRY")]
        public string COUNTRY { get; set; }
    }

    [XmlRoot(ElementName = "DISPLAYCONTACT")]
    public class DISPLAYCONTACT
    {
        [XmlElement(ElementName = "PRINTAS")]
        public string PRINTAS { get; set; }
        [XmlElement(ElementName = "COMPANYNAME")]
        public string COMPANYNAME { get; set; }
        [XmlElement(ElementName = "TAXABLE")]
        public string TAXABLE { get; set; }
        [XmlElement(ElementName = "TAXGROUP")]
        public string TAXGROUP { get; set; }
        [XmlElement(ElementName = "TAXSOLUTIONID")]
        public string TAXSOLUTIONID { get; set; }
        [XmlElement(ElementName = "TAXSCHEDULE")]
        public string TAXSCHEDULE { get; set; }
        [XmlElement(ElementName = "PREFIX")]
        public string PREFIX { get; set; }
        [XmlElement(ElementName = "FIRSTNAME")]
        public string FIRSTNAME { get; set; }
        [XmlElement(ElementName = "LASTNAME")]
        public string LASTNAME { get; set; }
        [XmlElement(ElementName = "INITIAL")]
        public string INITIAL { get; set; }
        [XmlElement(ElementName = "PHONE1")]
        public string PHONE1 { get; set; }
        [XmlElement(ElementName = "PHONE2")]
        public string PHONE2 { get; set; }
        [XmlElement(ElementName = "CELLPHONE")]
        public string CELLPHONE { get; set; }
        [XmlElement(ElementName = "PAGER")]
        public string PAGER { get; set; }
        [XmlElement(ElementName = "FAX")]
        public string FAX { get; set; }
        [XmlElement(ElementName = "EMAIL1")]
        public string EMAIL1 { get; set; }
        [XmlElement(ElementName = "EMAIL2")]
        public string EMAIL2 { get; set; }
        [XmlElement(ElementName = "URL1")]
        public string URL1 { get; set; }
        [XmlElement(ElementName = "URL2")]
        public string URL2 { get; set; }
        [XmlElement(ElementName = "MAILADDRESS")]
        public MAILADDRESS MAILADDRESS { get; set; }
    }

    [XmlRoot(ElementName = "CONTACTINFO")]
    public class CONTACTINFO
    {
        [XmlElement(ElementName = "CONTACTNAME")]
        public string CONTACTNAME { get; set; }
    }

    [XmlRoot(ElementName = "PAYTO")]
    public class PAYTO
    {
        [XmlElement(ElementName = "CONTACTNAME")]
        public string CONTACTNAME { get; set; }
    }

    [XmlRoot(ElementName = "RETURNTO")]
    public class RETURNTO
    {
        [XmlElement(ElementName = "CONTACTNAME")]
        public string CONTACTNAME { get; set; }
    }

    [XmlRoot(ElementName = "VENDOR")]
    public class VENDOR
    {
        [XmlElement(ElementName = "VENDORID")]
        public string VENDORID { get; set; }
        [XmlElement(ElementName = "NAME")]
        public string NAME { get; set; }
        [XmlElement(ElementName = "DISPLAYCONTACT")]
        public DISPLAYCONTACT DISPLAYCONTACT { get; set; }
        [XmlElement(ElementName = "ONETIME")]
        public string ONETIME { get; set; }
        [XmlElement(ElementName = "STATUS")]
        public string STATUS { get; set; }
        [XmlElement(ElementName = "HIDEDISPLAYCONTACT")]
        public string HIDEDISPLAYCONTACT { get; set; }
        [XmlElement(ElementName = "VENDTYPE")]
        public string VENDTYPE { get; set; }
        [XmlElement(ElementName = "PARENTID")]
        public string PARENTID { get; set; }
        [XmlElement(ElementName = "GLGROUP")]
        public string GLGROUP { get; set; }
        [XmlElement(ElementName = "TAXID")]
        public string TAXID { get; set; }
        [XmlElement(ElementName = "NAME1099")]
        public string NAME1099 { get; set; }
        [XmlElement(ElementName = "FORM1099TYPE")]
        public string FORM1099TYPE { get; set; }
        [XmlElement(ElementName = "FORM1099BOX")]
        public string FORM1099BOX { get; set; }
        [XmlElement(ElementName = "SUPDOCID")]
        public string SUPDOCID { get; set; }
        [XmlElement(ElementName = "APACCOUNT")]
        public string APACCOUNT { get; set; }
        [XmlElement(ElementName = "CREDITLIMIT")]
        public string CREDITLIMIT { get; set; }
        [XmlElement(ElementName = "ONHOLD")]
        public string ONHOLD { get; set; }
        [XmlElement(ElementName = "DONOTCUTCHECK")]
        public string DONOTCUTCHECK { get; set; }
        [XmlElement(ElementName = "COMMENTS")]
        public string COMMENTS { get; set; }
        [XmlElement(ElementName = "CURRENCY")]
        public string CURRENCY { get; set; }
        [XmlElement(ElementName = "CONTACTINFO")]
        public CONTACTINFO CONTACTINFO { get; set; }
        [XmlElement(ElementName = "PAYTO")]
        public PAYTO PAYTO { get; set; }
        [XmlElement(ElementName = "RETURNTO")]
        public RETURNTO RETURNTO { get; set; }
        [XmlElement(ElementName = "PAYMETHODKEY")]
        public string PAYMETHODKEY { get; set; }
        [XmlElement(ElementName = "MERGEPAYMENTREQ")]
        public string MERGEPAYMENTREQ { get; set; }
        [XmlElement(ElementName = "PAYMENTNOTIFY")]
        public string PAYMENTNOTIFY { get; set; }
        [XmlElement(ElementName = "BILLINGTYPE")]
        public string BILLINGTYPE { get; set; }
        [XmlElement(ElementName = "PAYMENTPRIORITY")]
        public string PAYMENTPRIORITY { get; set; }
        [XmlElement(ElementName = "TERMNAME")]
        public string TERMNAME { get; set; }
        [XmlElement(ElementName = "DISPLAYTERMDISCOUNT")]
        public string DISPLAYTERMDISCOUNT { get; set; }
        [XmlElement(ElementName = "ACHENABLED")]
        public string ACHENABLED { get; set; }
        [XmlElement(ElementName = "ACHBANKROUTINGNUMBER")]
        public string ACHBANKROUTINGNUMBER { get; set; }
        [XmlElement(ElementName = "ACHACCOUNTNUMBER")]
        public string ACHACCOUNTNUMBER { get; set; }
        [XmlElement(ElementName = "ACHACCOUNTTYPE")]
        public string ACHACCOUNTTYPE { get; set; }
        [XmlElement(ElementName = "ACHREMITTANCETYPE")]
        public string ACHREMITTANCETYPE { get; set; }
        [XmlElement(ElementName = "VENDORACCOUNTNO")]
        public string VENDORACCOUNTNO { get; set; }
        [XmlElement(ElementName = "DISPLAYACCTNOCHECK")]
        public string DISPLAYACCTNOCHECK { get; set; }
        [XmlElement(ElementName = "OBJECTRESTRICTION")]
        public string OBJECTRESTRICTION { get; set; }
        [XmlElement(ElementName = "RESTRICTEDLOCATIONS")]
        public string RESTRICTEDLOCATIONS { get; set; }
        [XmlElement(ElementName = "RESTRICTEDDEPARTMENTS")]
        public string RESTRICTEDDEPARTMENTS { get; set; }
        [XmlElement(ElementName = "CUSTOMFIELD1")]
        public string CUSTOMFIELD1 { get; set; }
    }

}
