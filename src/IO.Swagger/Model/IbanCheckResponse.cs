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
    /// Response of successful transformation request for /iban/check
    /// </summary>
    [DataContract]
    public partial class IbanCheckResponse :  IEquatable<IbanCheckResponse>, IValidatableObject
    {
        /// <summary>
        /// Either '1' if IBAN is valid otherwise '0'
        /// </summary>
        /// <value>Either '1' if IBAN is valid otherwise '0'</value>
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
        /// Either '1' if IBAN is valid otherwise '0'
        /// </summary>
        /// <value>Either '1' if IBAN is valid otherwise '0'</value>
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public ValidEnum? Valid { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IbanCheckResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IbanCheckResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IbanCheckResponse" /> class.
        /// </summary>
        /// <param name="Valid">Either &#39;1&#39; if IBAN is valid otherwise &#39;0&#39; (required).</param>
        /// <param name="Iban">The formatted IBAN (required).</param>
        public IbanCheckResponse(ValidEnum? Valid = null, string Iban = null)
        {
            // to ensure "Valid" is required (not null)
            if (Valid == null)
            {
                throw new InvalidDataException("Valid is a required property for IbanCheckResponse and cannot be null");
            }
            else
            {
                this.Valid = Valid;
            }
            // to ensure "Iban" is required (not null)
            if (Iban == null)
            {
                throw new InvalidDataException("Iban is a required property for IbanCheckResponse and cannot be null");
            }
            else
            {
                this.Iban = Iban;
            }
        }
        
        /// <summary>
        /// The formatted IBAN
        /// </summary>
        /// <value>The formatted IBAN</value>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IbanCheckResponse {\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
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
            return this.Equals(obj as IbanCheckResponse);
        }

        /// <summary>
        /// Returns true if IbanCheckResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IbanCheckResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IbanCheckResponse other)
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
                    this.Iban == other.Iban ||
                    this.Iban != null &&
                    this.Iban.Equals(other.Iban)
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
                if (this.Iban != null)
                    hash = hash * 59 + this.Iban.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
