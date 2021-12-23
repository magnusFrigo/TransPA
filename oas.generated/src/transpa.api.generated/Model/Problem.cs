/*
 * TransPA Public API
 *
 * # This API exposes functionality in Visma TransPA. ## Authentication The API can be tested without authentication against the mock server in the **Servers** pulldown list. To test against the actual backend you have to register a user on the *Visma Developer Portal* and request access to the API along with the required scopes. The scopes required are documented under each endpoint. For more information about *Visma Developer Portal* see <https://developer.visma.com>. <br/> <br/>  Authentication uses OAuth tokens from *Visma Connect*. Authorization is done on tenant level, so one OAuth token is needed per tenant.<br/> <br/> The scope `transpaapi:api` grants basic access to the API and is required for all routes. Additional scopes might be required and are described inside each route description. <br/> ## Details All monetary amounts are in the organizations local currency unless otherwise specified. <br/> <br/> ```[Not Ready]``` This is an endpoint where development has not completed and is therefore subject to change. 
 *
 * The version of the OpenAPI document: 0.1.17
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
    /// Problem
    /// </summary>
    [DataContract(Name = "problem")]
    public partial class Problem : IEquatable<Problem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Problem" /> class.
        /// </summary>
        /// <param name="type">An absolute URI that identifies the problem type.  When dereferenced, it SHOULD provide human-readable documentation for the problem type (e.g., using HTML).  (default to &quot;about:blank&quot;).</param>
        /// <param name="title">A short, summary of the problem type. Written in english and readable for engineers (usually not suited for non technical stakeholders and not localized); example: Service Unavailable .</param>
        /// <param name="status">The HTTP status code generated by the origin server for this occurrence of the problem. .</param>
        /// <param name="detail">A human readable explanation specific to this occurrence of the problem. .</param>
        /// <param name="instance">An absolute URI that identifies the specific occurrence of the problem. It may or may not yield further information if dereferenced. .</param>
        public Problem(string type = "about:blank", string title = default(string), int status = default(int), string detail = default(string), string instance = default(string))
        {
            // use default value if no "type" provided
            this.Type = type ?? "about:blank";
            this.Title = title;
            this.Status = status;
            this.Detail = detail;
            this.Instance = instance;
        }

        /// <summary>
        /// An absolute URI that identifies the problem type.  When dereferenced, it SHOULD provide human-readable documentation for the problem type (e.g., using HTML). 
        /// </summary>
        /// <value>An absolute URI that identifies the problem type.  When dereferenced, it SHOULD provide human-readable documentation for the problem type (e.g., using HTML). </value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// A short, summary of the problem type. Written in english and readable for engineers (usually not suited for non technical stakeholders and not localized); example: Service Unavailable 
        /// </summary>
        /// <value>A short, summary of the problem type. Written in english and readable for engineers (usually not suited for non technical stakeholders and not localized); example: Service Unavailable </value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The HTTP status code generated by the origin server for this occurrence of the problem. 
        /// </summary>
        /// <value>The HTTP status code generated by the origin server for this occurrence of the problem. </value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// A human readable explanation specific to this occurrence of the problem. 
        /// </summary>
        /// <value>A human readable explanation specific to this occurrence of the problem. </value>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public string Detail { get; set; }

        /// <summary>
        /// An absolute URI that identifies the specific occurrence of the problem. It may or may not yield further information if dereferenced. 
        /// </summary>
        /// <value>An absolute URI that identifies the specific occurrence of the problem. It may or may not yield further information if dereferenced. </value>
        [DataMember(Name = "instance", EmitDefaultValue = true)]
        public string Instance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Problem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
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
            return this.Equals(input as Problem);
        }

        /// <summary>
        /// Returns true if Problem instances are equal
        /// </summary>
        /// <param name="input">Instance of Problem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Problem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Instance != null)
                    hashCode = hashCode * 59 + this.Instance.GetHashCode();
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
            // Status (int) maximum
            if(this.Status > (int)600)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, must be a value less than or equal to 600.", new [] { "Status" });
            }

            // Status (int) minimum
            if(this.Status < (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, must be a value greater than or equal to 100.", new [] { "Status" });
            }

            yield break;
        }
    }

}
