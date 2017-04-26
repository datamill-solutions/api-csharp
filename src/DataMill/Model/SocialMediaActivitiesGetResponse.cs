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
    /// Response of successful transformation request for /social-media/activities/get
    /// </summary>
    [DataContract]
    public partial class SocialMediaActivitiesGetResponse :  IEquatable<SocialMediaActivitiesGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Unique status code describing the response  * **1**: Social media activities found and present in the response,  * **-1**: No social media activities found for the requested email address (in this case all following response keys except the status_description are not present),  * **-2**: Your requested is queued and a response will be available within the next 12 hours (in this case all following response keys except the status_description are not present) 
        /// </summary>
        /// <value>Unique status code describing the response  * **1**: Social media activities found and present in the response,  * **-1**: No social media activities found for the requested email address (in this case all following response keys except the status_description are not present),  * **-2**: Your requested is queued and a response will be available within the next 12 hours (in this case all following response keys except the status_description are not present) </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 1,
            
            /// <summary>
            /// Enum NUMBER_MINUS_1 for -1
            /// </summary>
            [EnumMember(Value = "-1")]
            NUMBER_MINUS_1 = -1,
            
            /// <summary>
            /// Enum NUMBER_MINUS_2 for -2
            /// </summary>
            [EnumMember(Value = "-2")]
            NUMBER_MINUS_2 = -2
        }

        /// <summary>
        /// Unique status code describing the response  * **1**: Social media activities found and present in the response,  * **-1**: No social media activities found for the requested email address (in this case all following response keys except the status_description are not present),  * **-2**: Your requested is queued and a response will be available within the next 12 hours (in this case all following response keys except the status_description are not present) 
        /// </summary>
        /// <value>Unique status code describing the response  * **1**: Social media activities found and present in the response,  * **-1**: No social media activities found for the requested email address (in this case all following response keys except the status_description are not present),  * **-2**: Your requested is queued and a response will be available within the next 12 hours (in this case all following response keys except the status_description are not present) </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaActivitiesGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SocialMediaActivitiesGetResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaActivitiesGetResponse" /> class.
        /// </summary>
        /// <param name="Status">Unique status code describing the response  * **1**: Social media activities found and present in the response,  * **-1**: No social media activities found for the requested email address (in this case all following response keys except the status_description are not present),  * **-2**: Your requested is queued and a response will be available within the next 12 hours (in this case all following response keys except the status_description are not present)  (required).</param>
        /// <param name="StatusDescription">Short description of the status code (required).</param>
        /// <param name="Name">First name and last name of the person.</param>
        /// <param name="Email">The requested email address.</param>
        /// <param name="Gender">The person&#39;s gender written in english and all lowercase. Either **female** or **male**.</param>
        /// <param name="Avatar">Profile image (fully qualified url) of the social media profile with the most followers.</param>
        /// <param name="Bio">Biography of the social media profile where the person has the most followers (unless it doesn&#39;t show a biography, then the social media profile with the second most followers is checked).</param>
        /// <param name="MaxFollowers">The maximum number of followers found by any of the social media platforms.</param>
        /// <param name="SumFollowers">The total number of followers of all social media platforms.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Education">Collection of all educations found..</param>
        /// <param name="Employment">Collection of all companies the person worked for..</param>
        /// <param name="Linkedin">Linkedin.</param>
        /// <param name="Xing">Xing.</param>
        /// <param name="Facebook">Facebook.</param>
        /// <param name="Twitter">Twitter.</param>
        /// <param name="Pinterest">Pinterest.</param>
        /// <param name="Instagram">Instagram.</param>
        /// <param name="Youtube">Youtube.</param>
        /// <param name="Googleplus">Googleplus.</param>
        /// <param name="Klout">Klout.</param>
        public SocialMediaActivitiesGetResponse(StatusEnum? Status = null, string StatusDescription = null, string Name = null, string Email = null, string Gender = null, string Avatar = null, string Bio = null, long? MaxFollowers = null, long? SumFollowers = null, SocialMediaActivitiesGetLocation Location = null, List<SocialMediaActivitiesGetEducation> Education = null, List<SocialMediaActivitiesGetEmployment> Employment = null, SocialMediaActivitiesGetLinkedIn Linkedin = null, SocialMediaActivitiesGetXing Xing = null, SocialMediaActivitiesGetFacebook Facebook = null, SocialMediaActivitiesGetTwitter Twitter = null, SocialMediaActivitiesGetPinterest Pinterest = null, SocialMediaActivitiesGetInstagram Instagram = null, SocialMediaActivitiesGetYouTube Youtube = null, SocialMediaActivitiesGetGooglePlus Googleplus = null, SocialMediaActivitiesGetKlout Klout = null)
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for SocialMediaActivitiesGetResponse and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "StatusDescription" is required (not null)
            if (StatusDescription == null)
            {
                throw new InvalidDataException("StatusDescription is a required property for SocialMediaActivitiesGetResponse and cannot be null");
            }
            else
            {
                this.StatusDescription = StatusDescription;
            }
            this.Name = Name;
            this.Email = Email;
            this.Gender = Gender;
            this.Avatar = Avatar;
            this.Bio = Bio;
            this.MaxFollowers = MaxFollowers;
            this.SumFollowers = SumFollowers;
            this.Location = Location;
            this.Education = Education;
            this.Employment = Employment;
            this.Linkedin = Linkedin;
            this.Xing = Xing;
            this.Facebook = Facebook;
            this.Twitter = Twitter;
            this.Pinterest = Pinterest;
            this.Instagram = Instagram;
            this.Youtube = Youtube;
            this.Googleplus = Googleplus;
            this.Klout = Klout;
        }
        
        /// <summary>
        /// Short description of the status code
        /// </summary>
        /// <value>Short description of the status code</value>
        [DataMember(Name="status_description", EmitDefaultValue=false)]
        public string StatusDescription { get; set; }
        /// <summary>
        /// First name and last name of the person
        /// </summary>
        /// <value>First name and last name of the person</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The requested email address
        /// </summary>
        /// <value>The requested email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The person&#39;s gender written in english and all lowercase. Either **female** or **male**
        /// </summary>
        /// <value>The person&#39;s gender written in english and all lowercase. Either **female** or **male**</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
        /// <summary>
        /// Profile image (fully qualified url) of the social media profile with the most followers
        /// </summary>
        /// <value>Profile image (fully qualified url) of the social media profile with the most followers</value>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public string Avatar { get; set; }
        /// <summary>
        /// Biography of the social media profile where the person has the most followers (unless it doesn&#39;t show a biography, then the social media profile with the second most followers is checked)
        /// </summary>
        /// <value>Biography of the social media profile where the person has the most followers (unless it doesn&#39;t show a biography, then the social media profile with the second most followers is checked)</value>
        [DataMember(Name="bio", EmitDefaultValue=false)]
        public string Bio { get; set; }
        /// <summary>
        /// The maximum number of followers found by any of the social media platforms
        /// </summary>
        /// <value>The maximum number of followers found by any of the social media platforms</value>
        [DataMember(Name="max_followers", EmitDefaultValue=false)]
        public long? MaxFollowers { get; set; }
        /// <summary>
        /// The total number of followers of all social media platforms
        /// </summary>
        /// <value>The total number of followers of all social media platforms</value>
        [DataMember(Name="sum_followers", EmitDefaultValue=false)]
        public long? SumFollowers { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public SocialMediaActivitiesGetLocation Location { get; set; }
        /// <summary>
        /// Collection of all educations found.
        /// </summary>
        /// <value>Collection of all educations found.</value>
        [DataMember(Name="education", EmitDefaultValue=false)]
        public List<SocialMediaActivitiesGetEducation> Education { get; set; }
        /// <summary>
        /// Collection of all companies the person worked for.
        /// </summary>
        /// <value>Collection of all companies the person worked for.</value>
        [DataMember(Name="employment", EmitDefaultValue=false)]
        public List<SocialMediaActivitiesGetEmployment> Employment { get; set; }
        /// <summary>
        /// Gets or Sets Linkedin
        /// </summary>
        [DataMember(Name="linkedin", EmitDefaultValue=false)]
        public SocialMediaActivitiesGetLinkedIn Linkedin { get; set; }
        /// <summary>
        /// Gets or Sets Xing
        /// </summary>
        [DataMember(Name="xing", EmitDefaultValue=false)]
        public SocialMediaActivitiesGetXing Xing { get; set; }
        /// <summary>
        /// Gets or Sets Facebook
        /// </summary>
        [DataMember(Name="facebook", EmitDefaultValue=false)]
        public SocialMediaActivitiesGetFacebook Facebook { get; set; }
        /// <summary>
        /// Gets or Sets Twitter
        /// </summary>
        [DataMember(Name="twitter", EmitDefaultValue=false)]
        public SocialMediaActivitiesGetTwitter Twitter { get; set; }
        /// <summary>
        /// Gets or Sets Pinterest
        /// </summary>
        [DataMember(Name="pinterest", EmitDefaultValue=false)]
        public SocialMediaActivitiesGetPinterest Pinterest { get; set; }
        /// <summary>
        /// Gets or Sets Instagram
        /// </summary>
        [DataMember(Name="instagram", EmitDefaultValue=false)]
        public SocialMediaActivitiesGetInstagram Instagram { get; set; }
        /// <summary>
        /// Gets or Sets Youtube
        /// </summary>
        [DataMember(Name="youtube", EmitDefaultValue=false)]
        public SocialMediaActivitiesGetYouTube Youtube { get; set; }
        /// <summary>
        /// Gets or Sets Googleplus
        /// </summary>
        [DataMember(Name="googleplus", EmitDefaultValue=false)]
        public SocialMediaActivitiesGetGooglePlus Googleplus { get; set; }
        /// <summary>
        /// Gets or Sets Klout
        /// </summary>
        [DataMember(Name="klout", EmitDefaultValue=false)]
        public SocialMediaActivitiesGetKlout Klout { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialMediaActivitiesGetResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  MaxFollowers: ").Append(MaxFollowers).Append("\n");
            sb.Append("  SumFollowers: ").Append(SumFollowers).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Education: ").Append(Education).Append("\n");
            sb.Append("  Employment: ").Append(Employment).Append("\n");
            sb.Append("  Linkedin: ").Append(Linkedin).Append("\n");
            sb.Append("  Xing: ").Append(Xing).Append("\n");
            sb.Append("  Facebook: ").Append(Facebook).Append("\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  Pinterest: ").Append(Pinterest).Append("\n");
            sb.Append("  Instagram: ").Append(Instagram).Append("\n");
            sb.Append("  Youtube: ").Append(Youtube).Append("\n");
            sb.Append("  Googleplus: ").Append(Googleplus).Append("\n");
            sb.Append("  Klout: ").Append(Klout).Append("\n");
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
            return this.Equals(obj as SocialMediaActivitiesGetResponse);
        }

        /// <summary>
        /// Returns true if SocialMediaActivitiesGetResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialMediaActivitiesGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialMediaActivitiesGetResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusDescription == other.StatusDescription ||
                    this.StatusDescription != null &&
                    this.StatusDescription.Equals(other.StatusDescription)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.Avatar == other.Avatar ||
                    this.Avatar != null &&
                    this.Avatar.Equals(other.Avatar)
                ) && 
                (
                    this.Bio == other.Bio ||
                    this.Bio != null &&
                    this.Bio.Equals(other.Bio)
                ) && 
                (
                    this.MaxFollowers == other.MaxFollowers ||
                    this.MaxFollowers != null &&
                    this.MaxFollowers.Equals(other.MaxFollowers)
                ) && 
                (
                    this.SumFollowers == other.SumFollowers ||
                    this.SumFollowers != null &&
                    this.SumFollowers.Equals(other.SumFollowers)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Education == other.Education ||
                    this.Education != null &&
                    this.Education.SequenceEqual(other.Education)
                ) && 
                (
                    this.Employment == other.Employment ||
                    this.Employment != null &&
                    this.Employment.SequenceEqual(other.Employment)
                ) && 
                (
                    this.Linkedin == other.Linkedin ||
                    this.Linkedin != null &&
                    this.Linkedin.Equals(other.Linkedin)
                ) && 
                (
                    this.Xing == other.Xing ||
                    this.Xing != null &&
                    this.Xing.Equals(other.Xing)
                ) && 
                (
                    this.Facebook == other.Facebook ||
                    this.Facebook != null &&
                    this.Facebook.Equals(other.Facebook)
                ) && 
                (
                    this.Twitter == other.Twitter ||
                    this.Twitter != null &&
                    this.Twitter.Equals(other.Twitter)
                ) && 
                (
                    this.Pinterest == other.Pinterest ||
                    this.Pinterest != null &&
                    this.Pinterest.Equals(other.Pinterest)
                ) && 
                (
                    this.Instagram == other.Instagram ||
                    this.Instagram != null &&
                    this.Instagram.Equals(other.Instagram)
                ) && 
                (
                    this.Youtube == other.Youtube ||
                    this.Youtube != null &&
                    this.Youtube.Equals(other.Youtube)
                ) && 
                (
                    this.Googleplus == other.Googleplus ||
                    this.Googleplus != null &&
                    this.Googleplus.Equals(other.Googleplus)
                ) && 
                (
                    this.Klout == other.Klout ||
                    this.Klout != null &&
                    this.Klout.Equals(other.Klout)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hash = hash * 59 + this.StatusDescription.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.Avatar != null)
                    hash = hash * 59 + this.Avatar.GetHashCode();
                if (this.Bio != null)
                    hash = hash * 59 + this.Bio.GetHashCode();
                if (this.MaxFollowers != null)
                    hash = hash * 59 + this.MaxFollowers.GetHashCode();
                if (this.SumFollowers != null)
                    hash = hash * 59 + this.SumFollowers.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.Education != null)
                    hash = hash * 59 + this.Education.GetHashCode();
                if (this.Employment != null)
                    hash = hash * 59 + this.Employment.GetHashCode();
                if (this.Linkedin != null)
                    hash = hash * 59 + this.Linkedin.GetHashCode();
                if (this.Xing != null)
                    hash = hash * 59 + this.Xing.GetHashCode();
                if (this.Facebook != null)
                    hash = hash * 59 + this.Facebook.GetHashCode();
                if (this.Twitter != null)
                    hash = hash * 59 + this.Twitter.GetHashCode();
                if (this.Pinterest != null)
                    hash = hash * 59 + this.Pinterest.GetHashCode();
                if (this.Instagram != null)
                    hash = hash * 59 + this.Instagram.GetHashCode();
                if (this.Youtube != null)
                    hash = hash * 59 + this.Youtube.GetHashCode();
                if (this.Googleplus != null)
                    hash = hash * 59 + this.Googleplus.GetHashCode();
                if (this.Klout != null)
                    hash = hash * 59 + this.Klout.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}