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
    /// CompanyAddress
    /// </summary>
    [DataContract]
    public partial class CompanyAddress : IEquatable<CompanyAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyAddress" /> class.
        /// </summary>
        /// <param name="address1">Line 1 of the street address..</param>
        /// <param name="address2">Line 2 of the street address.</param>
        /// <param name="address3">Line 3 of the street address.</param>
        /// <param name="city">The name of the city..</param>
        /// <param name="countryCode">The country code..</param>
        /// <param name="name">The name given to the company location..</param>
        /// <param name="postalCode">The postal / zip code..</param>
        /// <param name="state">The state code..</param>
        public CompanyAddress(string address1 = default(string), string address2 = default(string), string address3 = default(string), string city = default(string), string countryCode = default(string), string name = default(string), string postalCode = default(string), string state = default(string))
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.Address3 = address3;
            this.City = city;
            this.CountryCode = countryCode;
            this.Name = name;
            this.PostalCode = postalCode;
            this.State = state;
        }

        /// <summary>
        /// Line 1 of the street address.
        /// </summary>
        /// <value>Line 1 of the street address.</value>
        [DataMember(Name = "Address1", EmitDefaultValue = false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Line 2 of the street address
        /// </summary>
        /// <value>Line 2 of the street address</value>
        [DataMember(Name = "Address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Line 3 of the street address
        /// </summary>
        /// <value>Line 3 of the street address</value>
        [DataMember(Name = "Address3", EmitDefaultValue = false)]
        public string Address3 { get; set; }

        /// <summary>
        /// The name of the city.
        /// </summary>
        /// <value>The name of the city.</value>
        [DataMember(Name = "City", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The country code.
        /// </summary>
        /// <value>The country code.</value>
        [DataMember(Name = "CountryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The name given to the company location.
        /// </summary>
        /// <value>The name given to the company location.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The postal / zip code.
        /// </summary>
        /// <value>The postal / zip code.</value>
        [DataMember(Name = "PostalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The state code.
        /// </summary>
        /// <value>The state code.</value>
        [DataMember(Name = "State", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyAddress {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Address3: ").Append(Address3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as CompanyAddress);
        }

        /// <summary>
        /// Returns true if CompanyAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyAddress input)
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
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) &&
                (
                    this.Address3 == input.Address3 ||
                    (this.Address3 != null &&
                    this.Address3.Equals(input.Address3))
                ) &&
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) &&
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.Address3 != null)
                    hashCode = hashCode * 59 + this.Address3.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
