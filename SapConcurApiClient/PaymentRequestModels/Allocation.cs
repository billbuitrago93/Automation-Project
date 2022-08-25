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
    /// Allocation
    /// </summary>
    [DataContract]
    public partial class Allocation : IEquatable<Allocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation" /> class.
        /// </summary>
        /// <param name="allocationAccountCode">The Account Code that the allocation will be assigned to..</param>
        /// <param name="custom1">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom10">A value that can be applied to a custom field 10 that is part of the allocation form..</param>
        /// <param name="custom11">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom12">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom13">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom14">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom15">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom16">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom17">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom18">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom19">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom2">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom20">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom3">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom4">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom5">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom6">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom7">The details from the Custom fields. These may not have data, depending on configuration..</param>
        /// <param name="custom8">A value that can be applied to a custom field 8 that is part of the allocation form..</param>
        /// <param name="custom9">A value that can be applied to a custom field 9 that is part of the allocation form..</param>
        /// <param name="isTestUser">Indication that the Allocation record was created by a test user (this is a true/false)..</param>
        /// <param name="percentage">The percentage of the Request Line Item that the individual allocation record. All Allocations associated to a given Line Item should add up to 100..</param>
        public Allocation(string allocationAccountCode = default(string), string custom1 = default(string), string custom10 = default(string), string custom11 = default(string), string custom12 = default(string), string custom13 = default(string), string custom14 = default(string), string custom15 = default(string), string custom16 = default(string), string custom17 = default(string), string custom18 = default(string), string custom19 = default(string), string custom2 = default(string), string custom20 = default(string), string custom3 = default(string), string custom4 = default(string), string custom5 = default(string), string custom6 = default(string), string custom7 = default(string), string custom8 = default(string), string custom9 = default(string), string isTestUser = default(string), string percentage = default(string))
        {
            this.AllocationAccountCode = allocationAccountCode;
            this.Custom1 = custom1;
            this.Custom10 = custom10;
            this.Custom11 = custom11;
            this.Custom12 = custom12;
            this.Custom13 = custom13;
            this.Custom14 = custom14;
            this.Custom15 = custom15;
            this.Custom16 = custom16;
            this.Custom17 = custom17;
            this.Custom18 = custom18;
            this.Custom19 = custom19;
            this.Custom2 = custom2;
            this.Custom20 = custom20;
            this.Custom3 = custom3;
            this.Custom4 = custom4;
            this.Custom5 = custom5;
            this.Custom6 = custom6;
            this.Custom7 = custom7;
            this.Custom8 = custom8;
            this.Custom9 = custom9;
            this.IsTestUser = isTestUser;
            this.Percentage = percentage;
        }

        /// <summary>
        /// The Account Code that the allocation will be assigned to.
        /// </summary>
        /// <value>The Account Code that the allocation will be assigned to.</value>
        [DataMember(Name = "AllocationAccountCode", EmitDefaultValue = false)]
        public string AllocationAccountCode { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom1", EmitDefaultValue = false)]
        public string Custom1 { get; set; }

        /// <summary>
        /// A value that can be applied to a custom field 10 that is part of the allocation form.
        /// </summary>
        /// <value>A value that can be applied to a custom field 10 that is part of the allocation form.</value>
        [DataMember(Name = "Custom10", EmitDefaultValue = false)]
        public string Custom10 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom11", EmitDefaultValue = false)]
        public string Custom11 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom12", EmitDefaultValue = false)]
        public string Custom12 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom13", EmitDefaultValue = false)]
        public string Custom13 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom14", EmitDefaultValue = false)]
        public string Custom14 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom15", EmitDefaultValue = false)]
        public string Custom15 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom16", EmitDefaultValue = false)]
        public string Custom16 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom17", EmitDefaultValue = false)]
        public string Custom17 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom18", EmitDefaultValue = false)]
        public string Custom18 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom19", EmitDefaultValue = false)]
        public string Custom19 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom2", EmitDefaultValue = false)]
        public string Custom2 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom20", EmitDefaultValue = false)]
        public string Custom20 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom3", EmitDefaultValue = false)]
        public string Custom3 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom4", EmitDefaultValue = false)]
        public string Custom4 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom5", EmitDefaultValue = false)]
        public string Custom5 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom6", EmitDefaultValue = false)]
        public string Custom6 { get; set; }

        /// <summary>
        /// The details from the Custom fields. These may not have data, depending on configuration.
        /// </summary>
        /// <value>The details from the Custom fields. These may not have data, depending on configuration.</value>
        [DataMember(Name = "Custom7", EmitDefaultValue = false)]
        public string Custom7 { get; set; }

        /// <summary>
        /// A value that can be applied to a custom field 8 that is part of the allocation form.
        /// </summary>
        /// <value>A value that can be applied to a custom field 8 that is part of the allocation form.</value>
        [DataMember(Name = "Custom8", EmitDefaultValue = false)]
        public string Custom8 { get; set; }

        /// <summary>
        /// A value that can be applied to a custom field 9 that is part of the allocation form.
        /// </summary>
        /// <value>A value that can be applied to a custom field 9 that is part of the allocation form.</value>
        [DataMember(Name = "Custom9", EmitDefaultValue = false)]
        public string Custom9 { get; set; }

        /// <summary>
        /// Indication that the Allocation record was created by a test user (this is a true/false).
        /// </summary>
        /// <value>Indication that the Allocation record was created by a test user (this is a true/false).</value>
        [DataMember(Name = "IsTestUser", EmitDefaultValue = false)]
        public string IsTestUser { get; set; }

        /// <summary>
        /// The percentage of the Request Line Item that the individual allocation record. All Allocations associated to a given Line Item should add up to 100.
        /// </summary>
        /// <value>The percentage of the Request Line Item that the individual allocation record. All Allocations associated to a given Line Item should add up to 100.</value>
        [DataMember(Name = "Percentage", EmitDefaultValue = false)]
        public string Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Allocation {\n");
            sb.Append("  AllocationAccountCode: ").Append(AllocationAccountCode).Append("\n");
            sb.Append("  Custom1: ").Append(Custom1).Append("\n");
            sb.Append("  Custom10: ").Append(Custom10).Append("\n");
            sb.Append("  Custom11: ").Append(Custom11).Append("\n");
            sb.Append("  Custom12: ").Append(Custom12).Append("\n");
            sb.Append("  Custom13: ").Append(Custom13).Append("\n");
            sb.Append("  Custom14: ").Append(Custom14).Append("\n");
            sb.Append("  Custom15: ").Append(Custom15).Append("\n");
            sb.Append("  Custom16: ").Append(Custom16).Append("\n");
            sb.Append("  Custom17: ").Append(Custom17).Append("\n");
            sb.Append("  Custom18: ").Append(Custom18).Append("\n");
            sb.Append("  Custom19: ").Append(Custom19).Append("\n");
            sb.Append("  Custom2: ").Append(Custom2).Append("\n");
            sb.Append("  Custom20: ").Append(Custom20).Append("\n");
            sb.Append("  Custom3: ").Append(Custom3).Append("\n");
            sb.Append("  Custom4: ").Append(Custom4).Append("\n");
            sb.Append("  Custom5: ").Append(Custom5).Append("\n");
            sb.Append("  Custom6: ").Append(Custom6).Append("\n");
            sb.Append("  Custom7: ").Append(Custom7).Append("\n");
            sb.Append("  Custom8: ").Append(Custom8).Append("\n");
            sb.Append("  Custom9: ").Append(Custom9).Append("\n");
            sb.Append("  IsTestUser: ").Append(IsTestUser).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
            return this.Equals(input as Allocation);
        }

        /// <summary>
        /// Returns true if Allocation instances are equal
        /// </summary>
        /// <param name="input">Instance of Allocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Allocation input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AllocationAccountCode == input.AllocationAccountCode ||
                    (this.AllocationAccountCode != null &&
                    this.AllocationAccountCode.Equals(input.AllocationAccountCode))
                ) &&
                (
                    this.Custom1 == input.Custom1 ||
                    (this.Custom1 != null &&
                    this.Custom1.Equals(input.Custom1))
                ) &&
                (
                    this.Custom10 == input.Custom10 ||
                    (this.Custom10 != null &&
                    this.Custom10.Equals(input.Custom10))
                ) &&
                (
                    this.Custom11 == input.Custom11 ||
                    (this.Custom11 != null &&
                    this.Custom11.Equals(input.Custom11))
                ) &&
                (
                    this.Custom12 == input.Custom12 ||
                    (this.Custom12 != null &&
                    this.Custom12.Equals(input.Custom12))
                ) &&
                (
                    this.Custom13 == input.Custom13 ||
                    (this.Custom13 != null &&
                    this.Custom13.Equals(input.Custom13))
                ) &&
                (
                    this.Custom14 == input.Custom14 ||
                    (this.Custom14 != null &&
                    this.Custom14.Equals(input.Custom14))
                ) &&
                (
                    this.Custom15 == input.Custom15 ||
                    (this.Custom15 != null &&
                    this.Custom15.Equals(input.Custom15))
                ) &&
                (
                    this.Custom16 == input.Custom16 ||
                    (this.Custom16 != null &&
                    this.Custom16.Equals(input.Custom16))
                ) &&
                (
                    this.Custom17 == input.Custom17 ||
                    (this.Custom17 != null &&
                    this.Custom17.Equals(input.Custom17))
                ) &&
                (
                    this.Custom18 == input.Custom18 ||
                    (this.Custom18 != null &&
                    this.Custom18.Equals(input.Custom18))
                ) &&
                (
                    this.Custom19 == input.Custom19 ||
                    (this.Custom19 != null &&
                    this.Custom19.Equals(input.Custom19))
                ) &&
                (
                    this.Custom2 == input.Custom2 ||
                    (this.Custom2 != null &&
                    this.Custom2.Equals(input.Custom2))
                ) &&
                (
                    this.Custom20 == input.Custom20 ||
                    (this.Custom20 != null &&
                    this.Custom20.Equals(input.Custom20))
                ) &&
                (
                    this.Custom3 == input.Custom3 ||
                    (this.Custom3 != null &&
                    this.Custom3.Equals(input.Custom3))
                ) &&
                (
                    this.Custom4 == input.Custom4 ||
                    (this.Custom4 != null &&
                    this.Custom4.Equals(input.Custom4))
                ) &&
                (
                    this.Custom5 == input.Custom5 ||
                    (this.Custom5 != null &&
                    this.Custom5.Equals(input.Custom5))
                ) &&
                (
                    this.Custom6 == input.Custom6 ||
                    (this.Custom6 != null &&
                    this.Custom6.Equals(input.Custom6))
                ) &&
                (
                    this.Custom7 == input.Custom7 ||
                    (this.Custom7 != null &&
                    this.Custom7.Equals(input.Custom7))
                ) &&
                (
                    this.Custom8 == input.Custom8 ||
                    (this.Custom8 != null &&
                    this.Custom8.Equals(input.Custom8))
                ) &&
                (
                    this.Custom9 == input.Custom9 ||
                    (this.Custom9 != null &&
                    this.Custom9.Equals(input.Custom9))
                ) &&
                (
                    this.IsTestUser == input.IsTestUser ||
                    (this.IsTestUser != null &&
                    this.IsTestUser.Equals(input.IsTestUser))
                ) &&
                (
                    this.Percentage == input.Percentage ||
                    (this.Percentage != null &&
                    this.Percentage.Equals(input.Percentage))
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
                if (this.AllocationAccountCode != null)
                    hashCode = hashCode * 59 + this.AllocationAccountCode.GetHashCode();
                if (this.Custom1 != null)
                    hashCode = hashCode * 59 + this.Custom1.GetHashCode();
                if (this.Custom10 != null)
                    hashCode = hashCode * 59 + this.Custom10.GetHashCode();
                if (this.Custom11 != null)
                    hashCode = hashCode * 59 + this.Custom11.GetHashCode();
                if (this.Custom12 != null)
                    hashCode = hashCode * 59 + this.Custom12.GetHashCode();
                if (this.Custom13 != null)
                    hashCode = hashCode * 59 + this.Custom13.GetHashCode();
                if (this.Custom14 != null)
                    hashCode = hashCode * 59 + this.Custom14.GetHashCode();
                if (this.Custom15 != null)
                    hashCode = hashCode * 59 + this.Custom15.GetHashCode();
                if (this.Custom16 != null)
                    hashCode = hashCode * 59 + this.Custom16.GetHashCode();
                if (this.Custom17 != null)
                    hashCode = hashCode * 59 + this.Custom17.GetHashCode();
                if (this.Custom18 != null)
                    hashCode = hashCode * 59 + this.Custom18.GetHashCode();
                if (this.Custom19 != null)
                    hashCode = hashCode * 59 + this.Custom19.GetHashCode();
                if (this.Custom2 != null)
                    hashCode = hashCode * 59 + this.Custom2.GetHashCode();
                if (this.Custom20 != null)
                    hashCode = hashCode * 59 + this.Custom20.GetHashCode();
                if (this.Custom3 != null)
                    hashCode = hashCode * 59 + this.Custom3.GetHashCode();
                if (this.Custom4 != null)
                    hashCode = hashCode * 59 + this.Custom4.GetHashCode();
                if (this.Custom5 != null)
                    hashCode = hashCode * 59 + this.Custom5.GetHashCode();
                if (this.Custom6 != null)
                    hashCode = hashCode * 59 + this.Custom6.GetHashCode();
                if (this.Custom7 != null)
                    hashCode = hashCode * 59 + this.Custom7.GetHashCode();
                if (this.Custom8 != null)
                    hashCode = hashCode * 59 + this.Custom8.GetHashCode();
                if (this.Custom9 != null)
                    hashCode = hashCode * 59 + this.Custom9.GetHashCode();
                if (this.IsTestUser != null)
                    hashCode = hashCode * 59 + this.IsTestUser.GetHashCode();
                if (this.Percentage != null)
                    hashCode = hashCode * 59 + this.Percentage.GetHashCode();
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
