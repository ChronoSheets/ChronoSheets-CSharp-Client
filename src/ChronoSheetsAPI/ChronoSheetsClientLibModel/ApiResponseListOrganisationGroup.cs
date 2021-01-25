/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 3 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = ChronoSheetsAPI.Client.OpenAPIDateConverter;

namespace ChronoSheetsAPI.ChronoSheetsClientLibModel
{
    /// <summary>
    /// A standard API response
    /// </summary>
    [DataContract]
    public partial class ApiResponseListOrganisationGroup :  IEquatable<ApiResponseListOrganisationGroup>, IValidatableObject
    {
        /// <summary>
        /// The API response status. Indicates if the request was successful, failed or was unauthorised.
        /// </summary>
        /// <value>The API response status. Indicates if the request was successful, failed or was unauthorised.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Succeeded for value: Succeeded
            /// </summary>
            [EnumMember(Value = "Succeeded")]
            Succeeded = 1,

            /// <summary>
            /// Enum FatalException for value: FatalException
            /// </summary>
            [EnumMember(Value = "FatalException")]
            FatalException = 2,

            /// <summary>
            /// Enum GeneralError for value: GeneralError
            /// </summary>
            [EnumMember(Value = "GeneralError")]
            GeneralError = 3,

            /// <summary>
            /// Enum ValidationError for value: ValidationError
            /// </summary>
            [EnumMember(Value = "ValidationError")]
            ValidationError = 4,

            /// <summary>
            /// Enum UnAuthorized for value: UnAuthorized
            /// </summary>
            [EnumMember(Value = "UnAuthorized")]
            UnAuthorized = 5,

            /// <summary>
            /// Enum SessionExpired for value: SessionExpired
            /// </summary>
            [EnumMember(Value = "SessionExpired")]
            SessionExpired = 6

        }

        /// <summary>
        /// The API response status. Indicates if the request was successful, failed or was unauthorised.
        /// </summary>
        /// <value>The API response status. Indicates if the request was successful, failed or was unauthorised.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseListOrganisationGroup" /> class.
        /// </summary>
        /// <param name="data">The main Data of the response.</param>
        /// <param name="status">The API response status. Indicates if the request was successful, failed or was unauthorised..</param>
        /// <param name="message">A message to accompany the response status.  If the Status is failed, this message will hint why it failed and what you need to do..</param>
        public ApiResponseListOrganisationGroup(List<OrganisationGroup> data = default(List<OrganisationGroup>), StatusEnum? status = default(StatusEnum?), string message = default(string))
        {
            this.Data = data;
            this.Status = status;
            this.Message = message;
        }
        
        /// <summary>
        /// The main Data of the response
        /// </summary>
        /// <value>The main Data of the response</value>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public List<OrganisationGroup> Data { get; set; }


        /// <summary>
        /// A message to accompany the response status.  If the Status is failed, this message will hint why it failed and what you need to do.
        /// </summary>
        /// <value>A message to accompany the response status.  If the Status is failed, this message will hint why it failed and what you need to do.</value>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseListOrganisationGroup {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as ApiResponseListOrganisationGroup);
        }

        /// <summary>
        /// Returns true if ApiResponseListOrganisationGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseListOrganisationGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseListOrganisationGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
