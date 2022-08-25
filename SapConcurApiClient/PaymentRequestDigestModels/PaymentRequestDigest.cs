/* 
 * Payment Request Digest
 *
 * A payment request digest is a collection of payment requests to invoice vendors. This API provides methods to view all payment requests corresponding to search parameters, or view a payment request digest by ID.
 *
 * OpenAPI spec version: 3.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace SapConcurApiClient.PaymentRequestDigestModels
{
    /// <summary>
    /// PaymentRequestDigest
    /// </summary>
    [DataContract]
    public partial class PaymentRequestDigest : IEquatable<PaymentRequestDigest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequestDigest" /> class.
        /// </summary>
        /// <param name="approvalStatusCode">A code indicating the request&#39;s approval status..</param>
        /// <param name="createDate">The date the request was created..</param>
        /// <param name="currencyCode">The 3-letter ISO 4217 currency code for the request currency. Examples: USD - US dollars; BRL - Brazilian real; CAD - Canadian dollar; CHF - Swiss franc; EUR - Euro; GBO - Pound sterling; HKD - Hong Kong dollar; INR - Indian rupee; MXN - Mexican peso; NOK - Norwegian krone; SEK - Swedish krona..</param>
        /// <param name="iD">The unique identifier of the resource..</param>
        /// <param name="invoiceNumber">The invoice number of the Payment Request..</param>
        /// <param name="isDeleted">A true/false value which indicates whether the request has been deleted. (Deleted requests are retained in the system for historical purposes.)..</param>
        /// <param name="ownerLoginID">The login ID of the Payment Request owner..</param>
        /// <param name="ownerName">The name of the Payment Request owner..</param>
        /// <param name="paidDate">The date when all journal entries in the request were integrated with or extracted to the financial system..</param>
        /// <param name="paymentRequestId">The unique identifier of the Payment Request summarized in this digest..</param>
        /// <param name="paymentRequestUri">The URI of the Payment Request summarized in this digest..</param>
        /// <param name="paymentStatusCode">A code indicating the request&#39;s payment status..</param>
        /// <param name="purchaseOrderNumber">The purchase order number for the purchase order associated with the invoice..</param>
        /// <param name="total">The total amount of the request..</param>
        /// <param name="uRI">The URI to the resource..</param>
        /// <param name="userDefinedDate">The invoice date as assigned by the user..</param>
        /// <param name="vendorName">The name of the vendor..</param>
        public PaymentRequestDigest(string approvalStatusCode = default(string), string createDate = default(string), string currencyCode = default(string), string iD = default(string), string invoiceNumber = default(string), string isDeleted = default(string), string ownerLoginID = default(string), string ownerName = default(string), string paidDate = default(string), string paymentRequestId = default(string), string paymentRequestUri = default(string), string paymentStatusCode = default(string), string purchaseOrderNumber = default(string), string total = default(string), string uRI = default(string), string userDefinedDate = default(string), string vendorName = default(string))
        {
            this.ApprovalStatusCode = approvalStatusCode;
            this.CreateDate = createDate;
            this.CurrencyCode = currencyCode;
            this.ID = iD;
            this.InvoiceNumber = invoiceNumber;
            this.IsDeleted = isDeleted;
            this.OwnerLoginID = ownerLoginID;
            this.OwnerName = ownerName;
            this.PaidDate = paidDate;
            this.PaymentRequestId = paymentRequestId;
            this.PaymentRequestUri = paymentRequestUri;
            this.PaymentStatusCode = paymentStatusCode;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.Total = total;
            this.URI = uRI;
            this.UserDefinedDate = userDefinedDate;
            this.VendorName = vendorName;
        }

        /// <summary>
        /// A code indicating the request&#39;s approval status.
        /// </summary>
        /// <value>A code indicating the request&#39;s approval status.</value>
        [DataMember(Name = "ApprovalStatusCode", EmitDefaultValue = false)]
        public string ApprovalStatusCode { get; set; }

        /// <summary>
        /// The date the request was created.
        /// </summary>
        /// <value>The date the request was created.</value>
        [DataMember(Name = "CreateDate", EmitDefaultValue = false)]
        public string CreateDate { get; set; }

        /// <summary>
        /// The 3-letter ISO 4217 currency code for the request currency. Examples: USD - US dollars; BRL - Brazilian real; CAD - Canadian dollar; CHF - Swiss franc; EUR - Euro; GBO - Pound sterling; HKD - Hong Kong dollar; INR - Indian rupee; MXN - Mexican peso; NOK - Norwegian krone; SEK - Swedish krona.
        /// </summary>
        /// <value>The 3-letter ISO 4217 currency code for the request currency. Examples: USD - US dollars; BRL - Brazilian real; CAD - Canadian dollar; CHF - Swiss franc; EUR - Euro; GBO - Pound sterling; HKD - Hong Kong dollar; INR - Indian rupee; MXN - Mexican peso; NOK - Norwegian krone; SEK - Swedish krona.</value>
        [DataMember(Name = "CurrencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        /// <value>The unique identifier of the resource.</value>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; }

        /// <summary>
        /// The invoice number of the Payment Request.
        /// </summary>
        /// <value>The invoice number of the Payment Request.</value>
        [DataMember(Name = "InvoiceNumber", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// A true/false value which indicates whether the request has been deleted. (Deleted requests are retained in the system for historical purposes.).
        /// </summary>
        /// <value>A true/false value which indicates whether the request has been deleted. (Deleted requests are retained in the system for historical purposes.).</value>
        [DataMember(Name = "IsDeleted", EmitDefaultValue = false)]
        public string IsDeleted { get; set; }

        /// <summary>
        /// The login ID of the Payment Request owner.
        /// </summary>
        /// <value>The login ID of the Payment Request owner.</value>
        [DataMember(Name = "OwnerLoginID", EmitDefaultValue = false)]
        public string OwnerLoginID { get; set; }

        /// <summary>
        /// The name of the Payment Request owner.
        /// </summary>
        /// <value>The name of the Payment Request owner.</value>
        [DataMember(Name = "OwnerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// The date when all journal entries in the request were integrated with or extracted to the financial system.
        /// </summary>
        /// <value>The date when all journal entries in the request were integrated with or extracted to the financial system.</value>
        [DataMember(Name = "PaidDate", EmitDefaultValue = false)]
        public string PaidDate { get; set; }

        /// <summary>
        /// The unique identifier of the Payment Request summarized in this digest.
        /// </summary>
        /// <value>The unique identifier of the Payment Request summarized in this digest.</value>
        [DataMember(Name = "PaymentRequestId", EmitDefaultValue = false)]
        public string PaymentRequestId { get; set; }

        /// <summary>
        /// The URI of the Payment Request summarized in this digest.
        /// </summary>
        /// <value>The URI of the Payment Request summarized in this digest.</value>
        [DataMember(Name = "PaymentRequestUri", EmitDefaultValue = false)]
        public string PaymentRequestUri { get; set; }

        /// <summary>
        /// A code indicating the request&#39;s payment status.
        /// </summary>
        /// <value>A code indicating the request&#39;s payment status.</value>
        [DataMember(Name = "PaymentStatusCode", EmitDefaultValue = false)]
        public string PaymentStatusCode { get; set; }

        /// <summary>
        /// The purchase order number for the purchase order associated with the invoice.
        /// </summary>
        /// <value>The purchase order number for the purchase order associated with the invoice.</value>
        [DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The total amount of the request.
        /// </summary>
        /// <value>The total amount of the request.</value>
        [DataMember(Name = "Total", EmitDefaultValue = false)]
        public string Total { get; set; }

        /// <summary>
        /// The URI to the resource.
        /// </summary>
        /// <value>The URI to the resource.</value>
        [DataMember(Name = "URI", EmitDefaultValue = false)]
        public string URI { get; set; }

        /// <summary>
        /// The invoice date as assigned by the user.
        /// </summary>
        /// <value>The invoice date as assigned by the user.</value>
        [DataMember(Name = "UserDefinedDate", EmitDefaultValue = false)]
        public string UserDefinedDate { get; set; }

        /// <summary>
        /// The name of the vendor.
        /// </summary>
        /// <value>The name of the vendor.</value>
        [DataMember(Name = "VendorName", EmitDefaultValue = false)]
        public string VendorName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentRequestDigest {\n");
            sb.Append("  ApprovalStatusCode: ").Append(ApprovalStatusCode).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  OwnerLoginID: ").Append(OwnerLoginID).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  PaidDate: ").Append(PaidDate).Append("\n");
            sb.Append("  PaymentRequestId: ").Append(PaymentRequestId).Append("\n");
            sb.Append("  PaymentRequestUri: ").Append(PaymentRequestUri).Append("\n");
            sb.Append("  PaymentStatusCode: ").Append(PaymentStatusCode).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  URI: ").Append(URI).Append("\n");
            sb.Append("  UserDefinedDate: ").Append(UserDefinedDate).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentRequestDigest);
        }

        /// <summary>
        /// Returns true if PaymentRequestDigest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentRequestDigest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentRequestDigest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ApprovalStatusCode == input.ApprovalStatusCode ||
                    (this.ApprovalStatusCode != null &&
                    this.ApprovalStatusCode.Equals(input.ApprovalStatusCode))
                ) &&
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) &&
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) &&
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) &&
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) &&
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) &&
                (
                    this.OwnerLoginID == input.OwnerLoginID ||
                    (this.OwnerLoginID != null &&
                    this.OwnerLoginID.Equals(input.OwnerLoginID))
                ) &&
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) &&
                (
                    this.PaidDate == input.PaidDate ||
                    (this.PaidDate != null &&
                    this.PaidDate.Equals(input.PaidDate))
                ) &&
                (
                    this.PaymentRequestId == input.PaymentRequestId ||
                    (this.PaymentRequestId != null &&
                    this.PaymentRequestId.Equals(input.PaymentRequestId))
                ) &&
                (
                    this.PaymentRequestUri == input.PaymentRequestUri ||
                    (this.PaymentRequestUri != null &&
                    this.PaymentRequestUri.Equals(input.PaymentRequestUri))
                ) &&
                (
                    this.PaymentStatusCode == input.PaymentStatusCode ||
                    (this.PaymentStatusCode != null &&
                    this.PaymentStatusCode.Equals(input.PaymentStatusCode))
                ) &&
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) &&
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) &&
                (
                    this.URI == input.URI ||
                    (this.URI != null &&
                    this.URI.Equals(input.URI))
                ) &&
                (
                    this.UserDefinedDate == input.UserDefinedDate ||
                    (this.UserDefinedDate != null &&
                    this.UserDefinedDate.Equals(input.UserDefinedDate))
                ) &&
                (
                    this.VendorName == input.VendorName ||
                    (this.VendorName != null &&
                    this.VendorName.Equals(input.VendorName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ApprovalStatusCode != null)
                    hashCode = hashCode * 59 + this.ApprovalStatusCode.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.OwnerLoginID != null)
                    hashCode = hashCode * 59 + this.OwnerLoginID.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.PaidDate != null)
                    hashCode = hashCode * 59 + this.PaidDate.GetHashCode();
                if (this.PaymentRequestId != null)
                    hashCode = hashCode * 59 + this.PaymentRequestId.GetHashCode();
                if (this.PaymentRequestUri != null)
                    hashCode = hashCode * 59 + this.PaymentRequestUri.GetHashCode();
                if (this.PaymentStatusCode != null)
                    hashCode = hashCode * 59 + this.PaymentStatusCode.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.URI != null)
                    hashCode = hashCode * 59 + this.URI.GetHashCode();
                if (this.UserDefinedDate != null)
                    hashCode = hashCode * 59 + this.UserDefinedDate.GetHashCode();
                if (this.VendorName != null)
                    hashCode = hashCode * 59 + this.VendorName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
