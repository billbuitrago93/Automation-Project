/* 
 * Vendors
 *
 * An invoice is a bill of sale for goods or services provided by a vendor. This API provides methods to create, update, or delete invoice vendors.
 *
 * OpenAPI spec version: 3.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace SapConcurApiClient.VendorModels
{
    /// <summary>
    /// VendorCollection
    /// </summary>
    [DataContract]
    public partial class VendorCollection : IEquatable<VendorCollection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorCollection" /> class.
        /// </summary>
        /// <param name="vendor">vendor.</param>
        /// <param name="nextPage">The URI of the next page of results, if any..</param>
        /// <param name="requestRunSummary">The URI of the next page of results, if any..</param>
        /// <param name="totalCount">Record Number for create/update request..</param>
        /// <param name="items">items.</param>
        public VendorCollection(Vendor vendor = default(Vendor), string nextPage = default(string), string requestRunSummary = default(string), int? totalCount = default(int?), List<Vendor> items = default(List<Vendor>))
        {
            this.Vendor = vendor;
            this.NextPage = nextPage;
            this.RequestRunSummary = requestRunSummary;
            this.TotalCount = totalCount;
            this.Items = items;
        }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name = "Vendor", EmitDefaultValue = false)]
        public Vendor Vendor { get; set; }

        /// <summary>
        /// The URI of the next page of results, if any.
        /// </summary>
        /// <value>The URI of the next page of results, if any.</value>
        [DataMember(Name = "NextPage", EmitDefaultValue = false)]
        public string NextPage { get; set; }

        /// <summary>
        /// The URI of the next page of results, if any.
        /// </summary>
        /// <value>The URI of the next page of results, if any.</value>
        [DataMember(Name = "RequestRunSummary", EmitDefaultValue = false)]
        public string RequestRunSummary { get; set; }

        /// <summary>
        /// Record Number for create/update request.
        /// </summary>
        /// <value>Record Number for create/update request.</value>
        [DataMember(Name = "TotalCount", EmitDefaultValue = false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "Items", EmitDefaultValue = false)]
        public List<Vendor> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VendorCollection {\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  RequestRunSummary: ").Append(RequestRunSummary).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as VendorCollection);
        }

        /// <summary>
        /// Returns true if VendorCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorCollection input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
                ) &&
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) &&
                (
                    this.RequestRunSummary == input.RequestRunSummary ||
                    (this.RequestRunSummary != null &&
                    this.RequestRunSummary.Equals(input.RequestRunSummary))
                ) &&
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) &&
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.Equals(input.Items))
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
                if (this.Vendor != null)
                    hashCode = hashCode * 59 + this.Vendor.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.RequestRunSummary != null)
                    hashCode = hashCode * 59 + this.RequestRunSummary.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
