/* 
 * /data.mill for applications
 *
 * **&#47;data.mill for applications** is the most versatile and powerful API for all aspects of data quality in your business application.  Use **&#47;data.mill** to check, correct and enrich personal data and business information. The internationally applicable functions can be integrated easily into existing applications, whether desktop, online or mobile and thus enable you to professionally improve your customer or supplier database, directly in your system. Due to **&#47;data.mill**'s pay-per-use credit model there are no setup fees or fixed monthly subscription fees.  **&#47;data.mill** is constantly evolving and upgraded with the latest technology and data services available on the market. 
 *
 * OpenAPI spec version: 1.6.4
 * Contact: info@datamill.solutions
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Response of successful transformation request for /email/domain/check
    /// </summary>
    [DataContract]
    public partial class EmailDomainCheckResponse :  IEquatable<EmailDomainCheckResponse>, IValidatableObject
    {
        /// <summary>
        /// Flag if the email address is valid or not. '0' for invalid and '1' for valid email address.
        /// </summary>
        /// <value>Flag if the email address is valid or not. '0' for invalid and '1' for valid email address.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidEnum
        {
            
            /// <summary>
            /// Enum _0 for "0"
            /// </summary>
            [EnumMember(Value = "0")]
            _0,
            
            /// <summary>
            /// Enum _1 for "1"
            /// </summary>
            [EnumMember(Value = "1")]
            _1
        }

        /// <summary>
        /// Error description if syntax or mail server are invalid. Empty value means no error.
        /// </summary>
        /// <value>Error description if syntax or mail server are invalid. Empty value means no error.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DescriptionEnum
        {
            
            /// <summary>
            /// Enum Syntax for "syntax"
            /// </summary>
            [EnumMember(Value = "syntax")]
            Syntax,
            
            /// <summary>
            /// Enum Domain for "domain"
            /// </summary>
            [EnumMember(Value = "domain")]
            Domain,
            
            /// <summary>
            /// Enum Disposable for "disposable"
            /// </summary>
            [EnumMember(Value = "disposable")]
            Disposable,
            
            /// <summary>
            /// Enum  for ""
            /// </summary>
            [EnumMember(Value = "")]
            
        }

        /// <summary>
        /// Unique status code for each possible validation state. '10' for invalid syntax, '20' for missing MX record, '21' for disposable email and '1' for valid email address.
        /// </summary>
        /// <value>Unique status code for each possible validation state. '10' for invalid syntax, '20' for missing MX record, '21' for disposable email and '1' for valid email address.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusCodeEnum
        {
            
            /// <summary>
            /// Enum _1 for "1"
            /// </summary>
            [EnumMember(Value = "1")]
            _1,
            
            /// <summary>
            /// Enum _10 for "10"
            /// </summary>
            [EnumMember(Value = "10")]
            _10,
            
            /// <summary>
            /// Enum _20 for "20"
            /// </summary>
            [EnumMember(Value = "20")]
            _20,
            
            /// <summary>
            /// Enum _21 for "21"
            /// </summary>
            [EnumMember(Value = "21")]
            _21
        }

        /// <summary>
        /// Flag if the email address is valid or not. '0' for invalid and '1' for valid email address.
        /// </summary>
        /// <value>Flag if the email address is valid or not. '0' for invalid and '1' for valid email address.</value>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public ValidEnum? Valid { get; set; }
        /// <summary>
        /// Error description if syntax or mail server are invalid. Empty value means no error.
        /// </summary>
        /// <value>Error description if syntax or mail server are invalid. Empty value means no error.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public DescriptionEnum? Description { get; set; }
        /// <summary>
        /// Unique status code for each possible validation state. '10' for invalid syntax, '20' for missing MX record, '21' for disposable email and '1' for valid email address.
        /// </summary>
        /// <value>Unique status code for each possible validation state. '10' for invalid syntax, '20' for missing MX record, '21' for disposable email and '1' for valid email address.</value>
        [DataMember(Name="status_code", EmitDefaultValue=false)]
        public StatusCodeEnum? StatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDomainCheckResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailDomainCheckResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDomainCheckResponse" /> class.
        /// </summary>
        /// <param name="Valid">Flag if the email address is valid or not. &#39;0&#39; for invalid and &#39;1&#39; for valid email address. (required).</param>
        /// <param name="Description">Error description if syntax or mail server are invalid. Empty value means no error. (required).</param>
        /// <param name="StatusCode">Unique status code for each possible validation state. &#39;10&#39; for invalid syntax, &#39;20&#39; for missing MX record, &#39;21&#39; for disposable email and &#39;1&#39; for valid email address. (required).</param>
        public EmailDomainCheckResponse(ValidEnum? Valid = null, DescriptionEnum? Description = null, StatusCodeEnum? StatusCode = null)
        {
            // to ensure "Valid" is required (not null)
            if (Valid == null)
            {
                throw new InvalidDataException("Valid is a required property for EmailDomainCheckResponse and cannot be null");
            }
            else
            {
                this.Valid = Valid;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for EmailDomainCheckResponse and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "StatusCode" is required (not null)
            if (StatusCode == null)
            {
                throw new InvalidDataException("StatusCode is a required property for EmailDomainCheckResponse and cannot be null");
            }
            else
            {
                this.StatusCode = StatusCode;
            }
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailDomainCheckResponse {\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EmailDomainCheckResponse);
        }

        /// <summary>
        /// Returns true if EmailDomainCheckResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailDomainCheckResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailDomainCheckResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Valid == other.Valid ||
                    this.Valid != null &&
                    this.Valid.Equals(other.Valid)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Valid != null)
                    hash = hash * 59 + this.Valid.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
