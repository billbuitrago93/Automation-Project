/* 
 * Payment Request
 *
 * A payment request is a request for payment (partial or full) of an invoice. This API provides methods to create or update a payment request, or view a payment request by ID.
 *
 * OpenAPI spec version: 3.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace SapConcurApiClient.PaymentRequestModels
{
    /// <summary>
    /// VendorIdentifier
    /// </summary>
    [DataContract]
    public partial class VendorIdentifier : IEquatable<VendorIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorIdentifier" /> class.
        /// </summary>
        /// <param name="address1">Line 1 of the street address..</param>
        /// <param name="addressCode">The code which identifies a particular vendor location..</param>
        /// <param name="name">The name of the vendor..</param>
        /// <param name="postalCode">The postal / zip code..</param>
        /// <param name="vendorCode">The code which identifies a particular vendor..</param>
        public VendorIdentifier(string address1 = default(string), string addressCode = default(string), string name = default(string), string postalCode = default(string), string vendorCode = default(string))
        {
            this.Address1 = address1;
            this.AddressCode = addressCode;
            this.Name = name;
            this.PostalCode = postalCode;
            this.VendorCode = vendorCode;
        }

        /// <summary>
        /// Line 1 of the street address.
        /// </summary>
        /// <value>Line 1 of the street address.</value>
        [DataMember(Name = "Address1", EmitDefaultValue = false)]
        public string Address1 { get; set; }

        /// <summary>
        /// The code which identifies a particular vendor location.
        /// </summary>
        /// <value>The code which identifies a particular vendor location.</value>
        [DataMember(Name = "AddressCode", EmitDefaultValue = false)]
        public string AddressCode { get; set; }

        /// <summary>
        /// The name of the vendor.
        /// </summary>
        /// <value>The name of the vendor.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The postal / zip code.
        /// </summary>
        /// <value>The postal / zip code.</value>
        [DataMember(Name = "PostalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The code which identifies a particular vendor.
        /// </summary>
        /// <value>The code which identifies a particular vendor.</value>
        [DataMember(Name = "VendorCode", EmitDefaultValue = false)]
        public string VendorCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VendorIdentifier {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  AddressCode: ").Append(AddressCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  VendorCode: ").Append(VendorCode).Append("\n");
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
            return this.Equals(input as VendorIdentifier);
        }

        /// <summary>
        /// Returns true if VendorIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorIdentifier input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) &&
                (
                    this.AddressCode == input.AddressCode ||
                    (this.AddressCode != null &&
                    this.AddressCode.Equals(input.AddressCode))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) &&
                (
                    this.VendorCode == input.VendorCode ||
                    (this.VendorCode != null &&
                    this.VendorCode.Equals(input.VendorCode))
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
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.AddressCode != null)
                    hashCode = hashCode * 59 + this.AddressCode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.VendorCode != null)
                    hashCode = hashCode * 59 + this.VendorCode.GetHashCode();
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
