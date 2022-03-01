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
    /// SalaryCreated
    /// </summary>
    [DataContract(Name = "salaryCreated")]
    public partial class SalaryCreated : IEquatable<SalaryCreated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalaryCreated" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SalaryCreated() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalaryCreated" /> class.
        /// </summary>
        /// <param name="title">Human readable string (required).</param>
        /// <param name="resourceUrl">resourceUrl (required).</param>
        /// <param name="tenantId">tenantId (required).</param>
        public SalaryCreated(string title = default(string), string resourceUrl = default(string), string tenantId = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null) {
                throw new ArgumentNullException("title is a required property for SalaryCreated and cannot be null");
            }
            this.Title = title;
            // to ensure "resourceUrl" is required (not null)
            if (resourceUrl == null) {
                throw new ArgumentNullException("resourceUrl is a required property for SalaryCreated and cannot be null");
            }
            this.ResourceUrl = resourceUrl;
            // to ensure "tenantId" is required (not null)
            if (tenantId == null) {
                throw new ArgumentNullException("tenantId is a required property for SalaryCreated and cannot be null");
            }
            this.TenantId = tenantId;
        }

        /// <summary>
        /// Human readable string
        /// </summary>
        /// <value>Human readable string</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ResourceUrl
        /// </summary>
        [DataMember(Name = "resourceUrl", IsRequired = true, EmitDefaultValue = false)]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalaryCreated {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ResourceUrl: ").Append(ResourceUrl).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as SalaryCreated);
        }

        /// <summary>
        /// Returns true if SalaryCreated instances are equal
        /// </summary>
        /// <param name="input">Instance of SalaryCreated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalaryCreated input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.ResourceUrl == input.ResourceUrl ||
                    (this.ResourceUrl != null &&
                    this.ResourceUrl.Equals(input.ResourceUrl))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.ResourceUrl != null)
                    hashCode = hashCode * 59 + this.ResourceUrl.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
