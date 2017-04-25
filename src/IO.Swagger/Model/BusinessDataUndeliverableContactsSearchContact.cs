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
    /// Contact object within response of successful transformation request for /business-data/undeliverable-contacts/search Collection of multiple information about the person found (e.g. the new postal address if known) gender: The person&#39;s gender (M or F) title: The person&#39;s title title_of_nobility: The person&#39;s title of nobility country_code: The ISO 3166-1 alpha-2 code of the country the person lives in zip: The postal code of the city/region the person lives in city: The city the person lives in street: The street the person lives in street_addition: Additional information about the street house_number: The house number of the building the person lives in house_number_addition: Additional information about the house number date_of_birth: The person&#39;s date of birth (yyyy-mm-dd) if available and deceased timestamp: The timestamp (yyyy-mm-dd) when the database entry was created 
    /// </summary>
    [DataContract]
    public partial class BusinessDataUndeliverableContactsSearchContact :  IEquatable<BusinessDataUndeliverableContactsSearchContact>, IValidatableObject
    {
        /// <summary>
        /// The person's gender (**M** or **F**)
        /// </summary>
        /// <value>The person's gender (**M** or **F**)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            
            /// <summary>
            /// Enum M for "M"
            /// </summary>
            [EnumMember(Value = "M")]
            M,
            
            /// <summary>
            /// Enum F for "F"
            /// </summary>
            [EnumMember(Value = "F")]
            F
        }

        /// <summary>
        /// The person's gender (**M** or **F**)
        /// </summary>
        /// <value>The person's gender (**M** or **F**)</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessDataUndeliverableContactsSearchContact" /> class.
        /// </summary>
        /// <param name="Gender">The person&#39;s gender (**M** or **F**).</param>
        /// <param name="Title">The person&#39;s title.</param>
        /// <param name="TitleOfNobility">The person&#39;s title of nobility.</param>
        /// <param name="Street">The street the person lives in.</param>
        /// <param name="StreetAddition">Additional street information.</param>
        /// <param name="HouseNumber">The house number of the building the person lives in.</param>
        /// <param name="HouseNumberAddition">Additional information about the house number.</param>
        /// <param name="Zip">The postal code of the city/region the person lives in.</param>
        /// <param name="City">The city the person lives in.</param>
        /// <param name="CountryCode">The ISO 3166-1 alpha-2 code of the country the person lives in.</param>
        /// <param name="DateOfBirth">The person&#39;s date of birth (yyyy-mm-dd) if available and deceased.</param>
        /// <param name="Timestamp">The timestamp (yyyy-mm-dd) when the database entry was created.</param>
        public BusinessDataUndeliverableContactsSearchContact(GenderEnum? Gender = null, string Title = null, string TitleOfNobility = null, string Street = null, string StreetAddition = null, string HouseNumber = null, string HouseNumberAddition = null, string Zip = null, string City = null, string CountryCode = null, DateTime? DateOfBirth = null, DateTime? Timestamp = null)
        {
            this.Gender = Gender;
            this.Title = Title;
            this.TitleOfNobility = TitleOfNobility;
            this.Street = Street;
            this.StreetAddition = StreetAddition;
            this.HouseNumber = HouseNumber;
            this.HouseNumberAddition = HouseNumberAddition;
            this.Zip = Zip;
            this.City = City;
            this.CountryCode = CountryCode;
            this.DateOfBirth = DateOfBirth;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// The person&#39;s title
        /// </summary>
        /// <value>The person&#39;s title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// The person&#39;s title of nobility
        /// </summary>
        /// <value>The person&#39;s title of nobility</value>
        [DataMember(Name="title_of_nobility", EmitDefaultValue=false)]
        public string TitleOfNobility { get; set; }
        /// <summary>
        /// The street the person lives in
        /// </summary>
        /// <value>The street the person lives in</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
        /// <summary>
        /// Additional street information
        /// </summary>
        /// <value>Additional street information</value>
        [DataMember(Name="street_addition", EmitDefaultValue=false)]
        public string StreetAddition { get; set; }
        /// <summary>
        /// The house number of the building the person lives in
        /// </summary>
        /// <value>The house number of the building the person lives in</value>
        [DataMember(Name="house_number", EmitDefaultValue=false)]
        public string HouseNumber { get; set; }
        /// <summary>
        /// Additional information about the house number
        /// </summary>
        /// <value>Additional information about the house number</value>
        [DataMember(Name="house_number_addition", EmitDefaultValue=false)]
        public string HouseNumberAddition { get; set; }
        /// <summary>
        /// The postal code of the city/region the person lives in
        /// </summary>
        /// <value>The postal code of the city/region the person lives in</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }
        /// <summary>
        /// The city the person lives in
        /// </summary>
        /// <value>The city the person lives in</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// The ISO 3166-1 alpha-2 code of the country the person lives in
        /// </summary>
        /// <value>The ISO 3166-1 alpha-2 code of the country the person lives in</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// The person&#39;s date of birth (yyyy-mm-dd) if available and deceased
        /// </summary>
        /// <value>The person&#39;s date of birth (yyyy-mm-dd) if available and deceased</value>
        [DataMember(Name="date_of_birth", EmitDefaultValue=false)]
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// The timestamp (yyyy-mm-dd) when the database entry was created
        /// </summary>
        /// <value>The timestamp (yyyy-mm-dd) when the database entry was created</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessDataUndeliverableContactsSearchContact {\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleOfNobility: ").Append(TitleOfNobility).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  StreetAddition: ").Append(StreetAddition).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  HouseNumberAddition: ").Append(HouseNumberAddition).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(obj as BusinessDataUndeliverableContactsSearchContact);
        }

        /// <summary>
        /// Returns true if BusinessDataUndeliverableContactsSearchContact instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessDataUndeliverableContactsSearchContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessDataUndeliverableContactsSearchContact other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.TitleOfNobility == other.TitleOfNobility ||
                    this.TitleOfNobility != null &&
                    this.TitleOfNobility.Equals(other.TitleOfNobility)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.StreetAddition == other.StreetAddition ||
                    this.StreetAddition != null &&
                    this.StreetAddition.Equals(other.StreetAddition)
                ) && 
                (
                    this.HouseNumber == other.HouseNumber ||
                    this.HouseNumber != null &&
                    this.HouseNumber.Equals(other.HouseNumber)
                ) && 
                (
                    this.HouseNumberAddition == other.HouseNumberAddition ||
                    this.HouseNumberAddition != null &&
                    this.HouseNumberAddition.Equals(other.HouseNumberAddition)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.DateOfBirth == other.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.TitleOfNobility != null)
                    hash = hash * 59 + this.TitleOfNobility.GetHashCode();
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                if (this.StreetAddition != null)
                    hash = hash * 59 + this.StreetAddition.GetHashCode();
                if (this.HouseNumber != null)
                    hash = hash * 59 + this.HouseNumber.GetHashCode();
                if (this.HouseNumberAddition != null)
                    hash = hash * 59 + this.HouseNumberAddition.GetHashCode();
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.DateOfBirth != null)
                    hash = hash * 59 + this.DateOfBirth.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
