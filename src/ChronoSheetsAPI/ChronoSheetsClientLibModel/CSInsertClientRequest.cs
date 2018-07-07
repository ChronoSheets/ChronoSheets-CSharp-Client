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
    /// Fields for inserting a new Client
    /// </summary>
    [DataContract]
    public partial class CSInsertClientRequest :  IEquatable<CSInsertClientRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSInsertClientRequest" /> class.
        /// </summary>
        /// <param name="ClientName">The name of the Client.</param>
        /// <param name="ClientAddressLine1">Address line 1 of the Client.</param>
        /// <param name="ClientAddressLine2">Address line 2 of the Client.</param>
        /// <param name="ClientSuburb">The suburb of the Client&#39;s address.</param>
        /// <param name="ClientState">The state of the Client&#39;s address.</param>
        /// <param name="ClientPostCode">The post code of the Client&#39;s address.</param>
        /// <param name="PersonOfContact">The name of the contact working with the Client.</param>
        /// <param name="ClientPhoneNumber">The phone number of the Client.</param>
        /// <param name="ClientMobileNumber">The mobile phone number of the Client.</param>
        /// <param name="ClientEmailAddress">The email address of the Client.</param>
        /// <param name="ClientWebURL">The Client&#39;s website URL.</param>
        public CSInsertClientRequest(string ClientName = default(string), string ClientAddressLine1 = default(string), string ClientAddressLine2 = default(string), string ClientSuburb = default(string), string ClientState = default(string), string ClientPostCode = default(string), string PersonOfContact = default(string), string ClientPhoneNumber = default(string), string ClientMobileNumber = default(string), string ClientEmailAddress = default(string), string ClientWebURL = default(string))
        {
            this.ClientName = ClientName;
            this.ClientAddressLine1 = ClientAddressLine1;
            this.ClientAddressLine2 = ClientAddressLine2;
            this.ClientSuburb = ClientSuburb;
            this.ClientState = ClientState;
            this.ClientPostCode = ClientPostCode;
            this.PersonOfContact = PersonOfContact;
            this.ClientPhoneNumber = ClientPhoneNumber;
            this.ClientMobileNumber = ClientMobileNumber;
            this.ClientEmailAddress = ClientEmailAddress;
            this.ClientWebURL = ClientWebURL;
        }
        
        /// <summary>
        /// The name of the Client
        /// </summary>
        /// <value>The name of the Client</value>
        [DataMember(Name="ClientName", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Address line 1 of the Client
        /// </summary>
        /// <value>Address line 1 of the Client</value>
        [DataMember(Name="ClientAddressLine1", EmitDefaultValue=false)]
        public string ClientAddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 of the Client
        /// </summary>
        /// <value>Address line 2 of the Client</value>
        [DataMember(Name="ClientAddressLine2", EmitDefaultValue=false)]
        public string ClientAddressLine2 { get; set; }

        /// <summary>
        /// The suburb of the Client&#39;s address
        /// </summary>
        /// <value>The suburb of the Client&#39;s address</value>
        [DataMember(Name="ClientSuburb", EmitDefaultValue=false)]
        public string ClientSuburb { get; set; }

        /// <summary>
        /// The state of the Client&#39;s address
        /// </summary>
        /// <value>The state of the Client&#39;s address</value>
        [DataMember(Name="ClientState", EmitDefaultValue=false)]
        public string ClientState { get; set; }

        /// <summary>
        /// The post code of the Client&#39;s address
        /// </summary>
        /// <value>The post code of the Client&#39;s address</value>
        [DataMember(Name="ClientPostCode", EmitDefaultValue=false)]
        public string ClientPostCode { get; set; }

        /// <summary>
        /// The name of the contact working with the Client
        /// </summary>
        /// <value>The name of the contact working with the Client</value>
        [DataMember(Name="PersonOfContact", EmitDefaultValue=false)]
        public string PersonOfContact { get; set; }

        /// <summary>
        /// The phone number of the Client
        /// </summary>
        /// <value>The phone number of the Client</value>
        [DataMember(Name="ClientPhoneNumber", EmitDefaultValue=false)]
        public string ClientPhoneNumber { get; set; }

        /// <summary>
        /// The mobile phone number of the Client
        /// </summary>
        /// <value>The mobile phone number of the Client</value>
        [DataMember(Name="ClientMobileNumber", EmitDefaultValue=false)]
        public string ClientMobileNumber { get; set; }

        /// <summary>
        /// The email address of the Client
        /// </summary>
        /// <value>The email address of the Client</value>
        [DataMember(Name="ClientEmailAddress", EmitDefaultValue=false)]
        public string ClientEmailAddress { get; set; }

        /// <summary>
        /// The Client&#39;s website URL
        /// </summary>
        /// <value>The Client&#39;s website URL</value>
        [DataMember(Name="ClientWebURL", EmitDefaultValue=false)]
        public string ClientWebURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSInsertClientRequest {\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  ClientAddressLine1: ").Append(ClientAddressLine1).Append("\n");
            sb.Append("  ClientAddressLine2: ").Append(ClientAddressLine2).Append("\n");
            sb.Append("  ClientSuburb: ").Append(ClientSuburb).Append("\n");
            sb.Append("  ClientState: ").Append(ClientState).Append("\n");
            sb.Append("  ClientPostCode: ").Append(ClientPostCode).Append("\n");
            sb.Append("  PersonOfContact: ").Append(PersonOfContact).Append("\n");
            sb.Append("  ClientPhoneNumber: ").Append(ClientPhoneNumber).Append("\n");
            sb.Append("  ClientMobileNumber: ").Append(ClientMobileNumber).Append("\n");
            sb.Append("  ClientEmailAddress: ").Append(ClientEmailAddress).Append("\n");
            sb.Append("  ClientWebURL: ").Append(ClientWebURL).Append("\n");
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
            return this.Equals(input as CSInsertClientRequest);
        }

        /// <summary>
        /// Returns true if CSInsertClientRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CSInsertClientRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSInsertClientRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
                ) && 
                (
                    this.ClientAddressLine1 == input.ClientAddressLine1 ||
                    (this.ClientAddressLine1 != null &&
                    this.ClientAddressLine1.Equals(input.ClientAddressLine1))
                ) && 
                (
                    this.ClientAddressLine2 == input.ClientAddressLine2 ||
                    (this.ClientAddressLine2 != null &&
                    this.ClientAddressLine2.Equals(input.ClientAddressLine2))
                ) && 
                (
                    this.ClientSuburb == input.ClientSuburb ||
                    (this.ClientSuburb != null &&
                    this.ClientSuburb.Equals(input.ClientSuburb))
                ) && 
                (
                    this.ClientState == input.ClientState ||
                    (this.ClientState != null &&
                    this.ClientState.Equals(input.ClientState))
                ) && 
                (
                    this.ClientPostCode == input.ClientPostCode ||
                    (this.ClientPostCode != null &&
                    this.ClientPostCode.Equals(input.ClientPostCode))
                ) && 
                (
                    this.PersonOfContact == input.PersonOfContact ||
                    (this.PersonOfContact != null &&
                    this.PersonOfContact.Equals(input.PersonOfContact))
                ) && 
                (
                    this.ClientPhoneNumber == input.ClientPhoneNumber ||
                    (this.ClientPhoneNumber != null &&
                    this.ClientPhoneNumber.Equals(input.ClientPhoneNumber))
                ) && 
                (
                    this.ClientMobileNumber == input.ClientMobileNumber ||
                    (this.ClientMobileNumber != null &&
                    this.ClientMobileNumber.Equals(input.ClientMobileNumber))
                ) && 
                (
                    this.ClientEmailAddress == input.ClientEmailAddress ||
                    (this.ClientEmailAddress != null &&
                    this.ClientEmailAddress.Equals(input.ClientEmailAddress))
                ) && 
                (
                    this.ClientWebURL == input.ClientWebURL ||
                    (this.ClientWebURL != null &&
                    this.ClientWebURL.Equals(input.ClientWebURL))
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
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.ClientAddressLine1 != null)
                    hashCode = hashCode * 59 + this.ClientAddressLine1.GetHashCode();
                if (this.ClientAddressLine2 != null)
                    hashCode = hashCode * 59 + this.ClientAddressLine2.GetHashCode();
                if (this.ClientSuburb != null)
                    hashCode = hashCode * 59 + this.ClientSuburb.GetHashCode();
                if (this.ClientState != null)
                    hashCode = hashCode * 59 + this.ClientState.GetHashCode();
                if (this.ClientPostCode != null)
                    hashCode = hashCode * 59 + this.ClientPostCode.GetHashCode();
                if (this.PersonOfContact != null)
                    hashCode = hashCode * 59 + this.PersonOfContact.GetHashCode();
                if (this.ClientPhoneNumber != null)
                    hashCode = hashCode * 59 + this.ClientPhoneNumber.GetHashCode();
                if (this.ClientMobileNumber != null)
                    hashCode = hashCode * 59 + this.ClientMobileNumber.GetHashCode();
                if (this.ClientEmailAddress != null)
                    hashCode = hashCode * 59 + this.ClientEmailAddress.GetHashCode();
                if (this.ClientWebURL != null)
                    hashCode = hashCode * 59 + this.ClientWebURL.GetHashCode();
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
