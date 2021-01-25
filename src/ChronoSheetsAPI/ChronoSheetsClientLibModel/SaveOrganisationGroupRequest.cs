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
    /// Fields used to save an OrganisationGroup
    /// </summary>
    [DataContract]
    public partial class SaveOrganisationGroupRequest :  IEquatable<SaveOrganisationGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveOrganisationGroupRequest" /> class.
        /// </summary>
        /// <param name="id">The Id of the Organisation Group you want to update/save.</param>
        /// <param name="organisationGroupName">The updated name of the Organisation Group.</param>
        /// <param name="isDeleted">Whether or not the Organisation Group is to be marked as deleted.</param>
        public SaveOrganisationGroupRequest(int id = default(int), string organisationGroupName = default(string), bool isDeleted = default(bool))
        {
            this.Id = id;
            this.OrganisationGroupName = organisationGroupName;
            this.IsDeleted = isDeleted;
        }
        
        /// <summary>
        /// The Id of the Organisation Group you want to update/save
        /// </summary>
        /// <value>The Id of the Organisation Group you want to update/save</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The updated name of the Organisation Group
        /// </summary>
        /// <value>The updated name of the Organisation Group</value>
        [DataMember(Name="OrganisationGroupName", EmitDefaultValue=false)]
        public string OrganisationGroupName { get; set; }

        /// <summary>
        /// Whether or not the Organisation Group is to be marked as deleted
        /// </summary>
        /// <value>Whether or not the Organisation Group is to be marked as deleted</value>
        [DataMember(Name="IsDeleted", EmitDefaultValue=false)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveOrganisationGroupRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganisationGroupName: ").Append(OrganisationGroupName).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(input as SaveOrganisationGroupRequest);
        }

        /// <summary>
        /// Returns true if SaveOrganisationGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveOrganisationGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveOrganisationGroupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrganisationGroupName == input.OrganisationGroupName ||
                    (this.OrganisationGroupName != null &&
                    this.OrganisationGroupName.Equals(input.OrganisationGroupName))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OrganisationGroupName != null)
                    hashCode = hashCode * 59 + this.OrganisationGroupName.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
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
