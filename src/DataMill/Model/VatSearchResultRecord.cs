/* 
 * /data.mill for applications
 *
 * **&#47;data.mill for applications** is the most versatile and powerful API for all aspects of data quality in your business application.  Use **&#47;data.mill** to check, correct and enrich personal data and business information. The internationally applicable functions can be integrated easily into existing applications, whether desktop, online or mobile and thus enable you to professionally improve your customer or supplier database, directly in your system. Due to **&#47;data.mill**'s pay-per-use credit model there are no setup fees or fixed monthly subscription fees.  **&#47;data.mill** is constantly evolving and upgraded with the latest technology and data services available on the market.  GitHub for SDKs: https://github.com/datamill-solutions 
 *
 * OpenAPI spec version: 1.6.5
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

namespace DataMill.Model
{
    /// <summary>
    /// Single record of successful VatSearchResponse
    /// </summary>
    [DataContract]
    public partial class VatSearchResultRecord :  IEquatable<VatSearchResultRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VatSearchResultRecord" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VatSearchResultRecord() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VatSearchResultRecord" /> class.
        /// </summary>
        /// <param name="Vatnumber">The VAT numbers including the country code as prefix separated by a newline [only if uglify is set to 1] (required).</param>
        /// <param name="Company">Name of the company (required).</param>
        /// <param name="Address">Address of the company (required).</param>
        public VatSearchResultRecord(string Vatnumber = null, string Company = null, string Address = null)
        {
            // to ensure "Vatnumber" is required (not null)
            if (Vatnumber == null)
            {
                throw new InvalidDataException("Vatnumber is a required property for VatSearchResultRecord and cannot be null");
            }
            else
            {
                this.Vatnumber = Vatnumber;
            }
            // to ensure "Company" is required (not null)
            if (Company == null)
            {
                throw new InvalidDataException("Company is a required property for VatSearchResultRecord and cannot be null");
            }
            else
            {
                this.Company = Company;
            }
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for VatSearchResultRecord and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
        }
        
        /// <summary>
        /// The VAT numbers including the country code as prefix separated by a newline [only if uglify is set to 1]
        /// </summary>
        /// <value>The VAT numbers including the country code as prefix separated by a newline [only if uglify is set to 1]</value>
        [DataMember(Name="vatnumber", EmitDefaultValue=false)]
        public string Vatnumber { get; set; }
        /// <summary>
        /// Name of the company
        /// </summary>
        /// <value>Name of the company</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
        /// <summary>
        /// Address of the company
        /// </summary>
        /// <value>Address of the company</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VatSearchResultRecord {\n");
            sb.Append("  Vatnumber: ").Append(Vatnumber).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(obj as VatSearchResultRecord);
        }

        /// <summary>
        /// Returns true if VatSearchResultRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of VatSearchResultRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VatSearchResultRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Vatnumber == other.Vatnumber ||
                    this.Vatnumber != null &&
                    this.Vatnumber.Equals(other.Vatnumber)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
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
                if (this.Vatnumber != null)
                    hash = hash * 59 + this.Vatnumber.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
