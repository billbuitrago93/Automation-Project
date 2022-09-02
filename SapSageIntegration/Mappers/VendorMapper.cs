using Intacct.SDK.Functions.AccountsPayable;
using SapConcurApiClient.VendorModels;
using Xml2CSharp;

namespace SapSageIntegration.Mappers
{
    public static class VendorMapper
    {
        public static VendorCreate Map(Vendor vendor)
        {
            return new VendorCreate
            {
                VendorId = vendor.ID,
                VendorName = vendor.VendorName,
                OneTime = default,
                Active = default,
                LastName = default,
                FirstName = default,
                MiddleName = default,
                Prefix = default,
                CompanyName = default,
                PrintAs = default,
                PrimaryPhoneNo = default,
                SecondaryPhoneNo = default,
                CellularPhoneNo = default,
                PagerNo = default,
                FaxNo = default,
                PrimaryEmailAddress = default,
                SecondaryEmailAddress = default,
                PrimaryUrl = default,
                SecondaryUrl = default,
                AddressLine1 = default,
                AddressLine2 = default,
                City = vendor.City,
                StateProvince = default,
                ZipPostalCode = default,
                Country = vendor.Country,
                IsoCountryCode = default,
                ExcludedFromContactList = default,
                VendorTypeId = default,
                ParentVendorId = default,
                GlGroupName = default,
                TaxId = vendor.TaxID,
                Form1099Name = default,
                Form1099Type = default,
                Form1099Box = default,
                AttachmentsId = default,
                DefaultExpenseGlAccountNo = default,
                Taxable = default,
                ContactTaxGroupName = default,
                CreditLimit = default,
                OnHold = default,
                DoNotPay = default,
                Comments = default,
                DefaultCurrency = default,
                PrimaryContactName = default,
                PayToContactName = default,
                ReturnToContactName = default,
                ContactList = default,
                PreferredPaymentMethod = default,
                SendAutomaticPaymentNotification = default,
                MergePaymentRequests = default,
                VendorBillingType = default,
                PaymentPriority = default,
                PaymentTerm = default,
                TermDiscountDisplayedOnCheckStub = default,
                AchEnabled = default,
                AchBankRoutingNo = default,
                AchBankAccountNo = default,
                AchBankAccountType = default,
                AchBankAccountClass = default,
                VendorAccountNo = default,
                LocationAssignedAccountNoDisplayedOnCheckStub = default,
                RestrictionType = default,
                RestrictedLocations = default,
                RestrictedDepartments = default,
                CustomFields = default,
                ControlId = default
                // TODO: ??? = vendor.AccountNumber
                // TODO: ??? = vendor.Address1
                // TODO: ??? = vendor.Address2
                // TODO: ??? = vendor.Address3
                // TODO: ??? = vendor.AddressCode
                // TODO: ??? = vendor.AddressImportSyncID
                // TODO: ??? = vendor.Approved
                // TODO: ??? = vendor.ContactEmail
                // TODO: ??? = vendor.ContactFirstName
                // TODO: ??? = vendor.ContactLastName
                // TODO: ??? = vendor.ContactPhoneNumber
                // TODO: ??? = vendor.CountryCode
                // TODO: ??? = vendor.CurrencyCode
                // TODO: ??? = vendor.Custom1
                // TODO: ??? = vendor.Custom10
                // TODO: ??? = vendor.Custom11
                // TODO: ??? = vendor.Custom12
                // TODO: ??? = vendor.Custom13
                // TODO: ??? = vendor.Custom14
                // TODO: ??? = vendor.Custom15
                // TODO: ??? = vendor.Custom16
                // TODO: ??? = vendor.Custom17
                // TODO: ??? = vendor.Custom18
                // TODO: ??? = vendor.Custom19
                // TODO: ??? = vendor.Custom2
                // TODO: ??? = vendor.Custom20
                // TODO: ??? = vendor.Custom3
                // TODO: ??? = vendor.Custom4
                // TODO: ??? = vendor.Custom5
                // TODO: ??? = vendor.Custom6
                // TODO: ??? = vendor.Custom7
                // TODO: ??? = vendor.Custom8
                // TODO: ??? = vendor.Custom9
                // TODO: ??? = vendor.DefaultEmployeeID
                // TODO: ??? = vendor.DefaultExpenseTypeName
                // TODO: ??? = vendor.DiscountPercentage
                // TODO: ??? = vendor.DiscountTermsDays
                // TODO: ??? = vendor.IsLineItemVatIncld
                // TODO: ??? = vendor.IsVisibleForContentExtraction
                // TODO: ??? = vendor.PaymentMethodType
                // TODO: ??? = vendor.PaymentTerms
                // TODO: ??? = vendor.PostalCode
                // TODO: ??? = vendor.ProvincialTaxID
                // TODO: ??? = vendor.PurchaseOrderContactEmail
                // TODO: ??? = vendor.PurchaseOrderContactFirstName
                // TODO: ??? = vendor.PurchaseOrderContactLastName
                // TODO: ??? = vendor.PurchaseOrderContactPhoneNumber
                // TODO: ??? = vendor.ShippingMethod
                // TODO: ??? = vendor.ShippingTerms
                // TODO: ??? = vendor.State
                // TODO: ??? = vendor.StatusList
                // TODO: ??? = vendor.TaxType
                // TODO: ??? = vendor.URI
                // TODO: ??? = vendor.VendorBankList
                // TODO: ??? = vendor.VendorCode
                // TODO: ??? = vendor.VendorFormName
                // TODO: ??? = vendor.VendorGroupList
                // TODO: ??? = vendor.VoucherNotes
            };
        }

        public static VendorCreate Map(VENDOR vendor)
        {
            return new VendorCreate
            {
                VendorId = vendor.VENDORID,
                VendorName = vendor.NAME,
                OneTime = bool.Parse(vendor.ONETIME),
                Active = default,
                LastName = default,
                FirstName = default,
                MiddleName = default,
                Prefix = default,
                CompanyName = default,
                PrintAs = default,
                PrimaryPhoneNo = default,
                SecondaryPhoneNo = default,
                CellularPhoneNo = default,
                PagerNo = default,
                FaxNo = default,
                PrimaryEmailAddress = default,
                SecondaryEmailAddress = default,
                PrimaryUrl = default,
                SecondaryUrl = default,
                AddressLine1 = default,
                AddressLine2 = default,
                City = default,
                StateProvince = default,
                ZipPostalCode = default,
                Country = default,
                IsoCountryCode = default,
                ExcludedFromContactList = default,
                VendorTypeId = default,
                ParentVendorId = default,
                GlGroupName = default,
                TaxId = vendor.TAXID,
                Form1099Name = default,
                Form1099Type = vendor.FORM1099TYPE,
                Form1099Box = vendor.FORM1099BOX,
                AttachmentsId = default,
                DefaultExpenseGlAccountNo = default,
                Taxable = default,
                ContactTaxGroupName = default,
                CreditLimit = decimal.Parse(vendor.CREDITLIMIT),
                OnHold = bool.Parse(vendor.ONHOLD),
                DoNotPay = default,
                Comments = vendor.COMMENTS,
                DefaultCurrency = default,
                PrimaryContactName = default,
                PayToContactName = vendor.PAYTO.CONTACTNAME,
                ReturnToContactName = vendor.RETURNTO.CONTACTNAME,
                ContactList = default,
                PreferredPaymentMethod = default,
                SendAutomaticPaymentNotification = default,
                MergePaymentRequests = default,
                VendorBillingType = vendor.BILLINGTYPE,
                PaymentPriority = vendor.PAYMENTPRIORITY,
                PaymentTerm = default,
                TermDiscountDisplayedOnCheckStub = default,
                AchEnabled = bool.Parse(vendor.ACHENABLED),
                AchBankRoutingNo = default,
                AchBankAccountNo = default,
                AchBankAccountType = default,
                AchBankAccountClass = default,
                VendorAccountNo = vendor.VENDORACCOUNTNO,
                LocationAssignedAccountNoDisplayedOnCheckStub = default,
                RestrictionType = default,
                RestrictedLocations = vendor.RESTRICTEDLOCATIONS,
                RestrictedDepartments = vendor.RESTRICTEDDEPARTMENTS,
                CustomFields = default,
                ControlId = default
                // TODO: ??? = vendor.DISPLAYCONTACT
                // TODO: ??? = vendor.STATUS
                // TODO: ??? = vendor.HIDEDISPLAYCONTACT
                // TODO: ??? = vendor.VENDTYPE
                // TODO: ??? = vendor.PARENTID
                // TODO: ??? = vendor.GLGROUP
                // TODO: ??? = vendor.NAME1099
                // TODO: ??? = vendor.SUPDOCID
                // TODO: ??? = vendor.APACCOUNT
                // TODO: ??? = vendor.DONOTCUTCHECK
                // TODO: ??? = vendor.CURRENCY
                // TODO: ??? = vendor.CONTACTINFO
                // TODO: ??? = vendor.PAYMETHODKEY
                // TODO: ??? = vendor.MERGEPAYMENTREQ
                // TODO: ??? = vendor.PAYMENTNOTIFY
                // TODO: ??? = vendor.TERMNAME
                // TODO: ??? = vendor.DISPLAYTERMDISCOUNT
                // TODO: ??? = vendor.ACHBANKROUTINGNUMBER
                // TODO: ??? = vendor.ACHACCOUNTNUMBER
                // TODO: ??? = vendor.ACHACCOUNTTYPE
                // TODO: ??? = vendor.ACHREMITTANCETYPE
                // TODO: ??? = vendor.DISPLAYACCTNOCHECK
                // TODO: ??? = vendor.OBJECTRESTRICTION
                // TODO: ??? = vendor.CUSTOMFIELD1
            };
        }
    }
}
