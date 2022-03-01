/*
 * TransPA Public API
 *
 * # This API exposes functionality in Visma TransPA. ## Authentication The API can be tested without authentication against the mock server in the **Servers** pulldown list. To test against the actual backend you have to register a user on the *Visma Developer Portal* and request access to the API along with the required scopes. The scopes required are documented under each endpoint. For more information about *Visma Developer Portal* see <https://developer.visma.com>. <br/> <br/>  Authentication uses OAuth tokens from *Visma Connect*. Authorization is done on tenant level, so one OAuth token is needed per tenant.<br/> <br/> The scope `transpaapi:api` grants basic access to the API and is required for all routes. Additional scopes might be required and are described inside each route description. <br/> ## Details All monetary amounts are in the organizations local currency unless otherwise specified. <br/> <br/> ```[Not Ready]``` This is an endpoint where development has not completed and is therefore subject to change. 
 *
 * The version of the OpenAPI document: 0.1.20
 * Contact: utveckling.transpa@visma.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = transpa.api.generated.Client.OpenAPIDateConverter;

namespace transpa.api.generated.Model
{
    /// <summary>
    /// SalaryDetails
    /// </summary>
    [DataContract(Name = "salary_details")]
    public partial class SalaryDetails : IEquatable<SalaryDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalaryDetails" /> class.
        /// </summary>
        /// <param name="fromDate">fromDate.</param>
        /// <param name="toDate">toDate.</param>
        /// <param name="quantity">Number expressed as a decimal number.</param>
        /// <param name="unitPrice">unitPrice.</param>
        public SalaryDetails(DateTime fromDate = default(DateTime), DateTime toDate = default(DateTime), decimal quantity = default(decimal), Money unitPrice = default(Money))
        {
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }

        /// <summary>
        /// Gets or Sets FromDate
        /// </summary>
        [DataMember(Name = "fromDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime FromDate { get; set; }

        /// <summary>
        /// Gets or Sets ToDate
        /// </summary>
        [DataMember(Name = "toDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ToDate { get; set; }

        /// <summary>
        /// Number expressed as a decimal number
        /// </summary>
        /// <value>Number expressed as a decimal number</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        public Money UnitPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalaryDetails {\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  ToDate: ").Append(ToDate).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SalaryDetails);
        }

        /// <summary>
        /// Returns true if SalaryDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SalaryDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalaryDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FromDate == input.FromDate ||
                    (this.FromDate != null &&
                    this.FromDate.Equals(input.FromDate))
                ) && 
                (
                    this.ToDate == input.ToDate ||
                    (this.ToDate != null &&
                    this.ToDate.Equals(input.ToDate))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
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
                if (this.FromDate != null)
                    hashCode = hashCode * 59 + this.FromDate.GetHashCode();
                if (this.ToDate != null)
                    hashCode = hashCode * 59 + this.ToDate.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
