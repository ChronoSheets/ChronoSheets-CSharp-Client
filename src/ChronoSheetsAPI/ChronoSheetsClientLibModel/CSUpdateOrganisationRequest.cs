/* 
 * The ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = ChronoSheetsAPI.Client.SwaggerDateConverter;

namespace ChronoSheetsAPI.ChronoSheetsClientLibModel
{
    /// <summary>
    /// Field for updating your Organisation
    /// </summary>
    [DataContract]
    public partial class CSUpdateOrganisationRequest :  IEquatable<CSUpdateOrganisationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSUpdateOrganisationRequest" /> class.
        /// </summary>
        /// <param name="OrgansationId">The Id of your Organisation.  This is validated based on your current Auth Token.</param>
        /// <param name="OrganisationName">The updated organisation name.</param>
        /// <param name="AddressLine01">The updated Address Line 1 value.</param>
        /// <param name="AddressLine02">The updated Address Line 2 value.</param>
        /// <param name="OrganisationSuburb">The updated address suburb.</param>
        /// <param name="OrganisationState">The updated address state.</param>
        /// <param name="OrganisationPostcode">The updated address postcode.</param>
        /// <param name="OrganisationCountry">The updated address country.</param>
        /// <param name="OrganisationPhone">The updated contact phone number.</param>
        /// <param name="OrganisationEmailAddress">The update organisation email address.</param>
        public CSUpdateOrganisationRequest(int? OrgansationId = default(int?), string OrganisationName = default(string), string AddressLine01 = default(string), string AddressLine02 = default(string), string OrganisationSuburb = default(string), string OrganisationState = default(string), string OrganisationPostcode = default(string), string OrganisationCountry = default(string), string OrganisationPhone = default(string), string OrganisationEmailAddress = default(string))
        {
            this.OrgansationId = OrgansationId;
            this.OrganisationName = OrganisationName;
            this.AddressLine01 = AddressLine01;
            this.AddressLine02 = AddressLine02;
            this.OrganisationSuburb = OrganisationSuburb;
            this.OrganisationState = OrganisationState;
            this.OrganisationPostcode = OrganisationPostcode;
            this.OrganisationCountry = OrganisationCountry;
            this.OrganisationPhone = OrganisationPhone;
            this.OrganisationEmailAddress = OrganisationEmailAddress;
        }
        
        /// <summary>
        /// The Id of your Organisation.  This is validated based on your current Auth Token
        /// </summary>
        /// <value>The Id of your Organisation.  This is validated based on your current Auth Token</value>
        [DataMember(Name="OrgansationId", EmitDefaultValue=false)]
        public int? OrgansationId { get; set; }

        /// <summary>
        /// The updated organisation name
        /// </summary>
        /// <value>The updated organisation name</value>
        [DataMember(Name="OrganisationName", EmitDefaultValue=false)]
        public string OrganisationName { get; set; }

        /// <summary>
        /// The updated Address Line 1 value
        /// </summary>
        /// <value>The updated Address Line 1 value</value>
        [DataMember(Name="AddressLine01", EmitDefaultValue=false)]
        public string AddressLine01 { get; set; }

        /// <summary>
        /// The updated Address Line 2 value
        /// </summary>
        /// <value>The updated Address Line 2 value</value>
        [DataMember(Name="AddressLine02", EmitDefaultValue=false)]
        public string AddressLine02 { get; set; }

        /// <summary>
        /// The updated address suburb
        /// </summary>
        /// <value>The updated address suburb</value>
        [DataMember(Name="OrganisationSuburb", EmitDefaultValue=false)]
        public string OrganisationSuburb { get; set; }

        /// <summary>
        /// The updated address state
        /// </summary>
        /// <value>The updated address state</value>
        [DataMember(Name="OrganisationState", EmitDefaultValue=false)]
        public string OrganisationState { get; set; }

        /// <summary>
        /// The updated address postcode
        /// </summary>
        /// <value>The updated address postcode</value>
        [DataMember(Name="OrganisationPostcode", EmitDefaultValue=false)]
        public string OrganisationPostcode { get; set; }

        /// <summary>
        /// The updated address country
        /// </summary>
        /// <value>The updated address country</value>
        [DataMember(Name="OrganisationCountry", EmitDefaultValue=false)]
        public string OrganisationCountry { get; set; }

        /// <summary>
        /// The updated contact phone number
        /// </summary>
        /// <value>The updated contact phone number</value>
        [DataMember(Name="OrganisationPhone", EmitDefaultValue=false)]
        public string OrganisationPhone { get; set; }

        /// <summary>
        /// The update organisation email address
        /// </summary>
        /// <value>The update organisation email address</value>
        [DataMember(Name="OrganisationEmailAddress", EmitDefaultValue=false)]
        public string OrganisationEmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSUpdateOrganisationRequest {\n");
            sb.Append("  OrgansationId: ").Append(OrgansationId).Append("\n");
            sb.Append("  OrganisationName: ").Append(OrganisationName).Append("\n");
            sb.Append("  AddressLine01: ").Append(AddressLine01).Append("\n");
            sb.Append("  AddressLine02: ").Append(AddressLine02).Append("\n");
            sb.Append("  OrganisationSuburb: ").Append(OrganisationSuburb).Append("\n");
            sb.Append("  OrganisationState: ").Append(OrganisationState).Append("\n");
            sb.Append("  OrganisationPostcode: ").Append(OrganisationPostcode).Append("\n");
            sb.Append("  OrganisationCountry: ").Append(OrganisationCountry).Append("\n");
            sb.Append("  OrganisationPhone: ").Append(OrganisationPhone).Append("\n");
            sb.Append("  OrganisationEmailAddress: ").Append(OrganisationEmailAddress).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CSUpdateOrganisationRequest);
        }

        /// <summary>
        /// Returns true if CSUpdateOrganisationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CSUpdateOrganisationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSUpdateOrganisationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrgansationId == input.OrgansationId ||
                    (this.OrgansationId != null &&
                    this.OrgansationId.Equals(input.OrgansationId))
                ) && 
                (
                    this.OrganisationName == input.OrganisationName ||
                    (this.OrganisationName != null &&
                    this.OrganisationName.Equals(input.OrganisationName))
                ) && 
                (
                    this.AddressLine01 == input.AddressLine01 ||
                    (this.AddressLine01 != null &&
                    this.AddressLine01.Equals(input.AddressLine01))
                ) && 
                (
                    this.AddressLine02 == input.AddressLine02 ||
                    (this.AddressLine02 != null &&
                    this.AddressLine02.Equals(input.AddressLine02))
                ) && 
                (
                    this.OrganisationSuburb == input.OrganisationSuburb ||
                    (this.OrganisationSuburb != null &&
                    this.OrganisationSuburb.Equals(input.OrganisationSuburb))
                ) && 
                (
                    this.OrganisationState == input.OrganisationState ||
                    (this.OrganisationState != null &&
                    this.OrganisationState.Equals(input.OrganisationState))
                ) && 
                (
                    this.OrganisationPostcode == input.OrganisationPostcode ||
                    (this.OrganisationPostcode != null &&
                    this.OrganisationPostcode.Equals(input.OrganisationPostcode))
                ) && 
                (
                    this.OrganisationCountry == input.OrganisationCountry ||
                    (this.OrganisationCountry != null &&
                    this.OrganisationCountry.Equals(input.OrganisationCountry))
                ) && 
                (
                    this.OrganisationPhone == input.OrganisationPhone ||
                    (this.OrganisationPhone != null &&
                    this.OrganisationPhone.Equals(input.OrganisationPhone))
                ) && 
                (
                    this.OrganisationEmailAddress == input.OrganisationEmailAddress ||
                    (this.OrganisationEmailAddress != null &&
                    this.OrganisationEmailAddress.Equals(input.OrganisationEmailAddress))
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
                if (this.OrgansationId != null)
                    hashCode = hashCode * 59 + this.OrgansationId.GetHashCode();
                if (this.OrganisationName != null)
                    hashCode = hashCode * 59 + this.OrganisationName.GetHashCode();
                if (this.AddressLine01 != null)
                    hashCode = hashCode * 59 + this.AddressLine01.GetHashCode();
                if (this.AddressLine02 != null)
                    hashCode = hashCode * 59 + this.AddressLine02.GetHashCode();
                if (this.OrganisationSuburb != null)
                    hashCode = hashCode * 59 + this.OrganisationSuburb.GetHashCode();
                if (this.OrganisationState != null)
                    hashCode = hashCode * 59 + this.OrganisationState.GetHashCode();
                if (this.OrganisationPostcode != null)
                    hashCode = hashCode * 59 + this.OrganisationPostcode.GetHashCode();
                if (this.OrganisationCountry != null)
                    hashCode = hashCode * 59 + this.OrganisationCountry.GetHashCode();
                if (this.OrganisationPhone != null)
                    hashCode = hashCode * 59 + this.OrganisationPhone.GetHashCode();
                if (this.OrganisationEmailAddress != null)
                    hashCode = hashCode * 59 + this.OrganisationEmailAddress.GetHashCode();
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
