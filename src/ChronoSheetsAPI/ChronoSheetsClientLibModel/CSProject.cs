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
    /// CSProject
    /// </summary>
    [DataContract]
    public partial class CSProject :  IEquatable<CSProject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSProject" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="OrganisationId">OrganisationId.</param>
        /// <param name="ProjectName">ProjectName.</param>
        /// <param name="CostEstimation">CostEstimation.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        public CSProject(int? Id = default(int?), int? ClientId = default(int?), int? OrganisationId = default(int?), string ProjectName = default(string), double? CostEstimation = default(double?), DateTime? StartDate = default(DateTime?), DateTime? EndDate = default(DateTime?))
        {
            this.Id = Id;
            this.ClientId = ClientId;
            this.OrganisationId = OrganisationId;
            this.ProjectName = ProjectName;
            this.CostEstimation = CostEstimation;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="ClientId", EmitDefaultValue=false)]
        public int? ClientId { get; set; }

        /// <summary>
        /// Gets or Sets OrganisationId
        /// </summary>
        [DataMember(Name="OrganisationId", EmitDefaultValue=false)]
        public int? OrganisationId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name="ProjectName", EmitDefaultValue=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or Sets CostEstimation
        /// </summary>
        [DataMember(Name="CostEstimation", EmitDefaultValue=false)]
        public double? CostEstimation { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSProject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  CostEstimation: ").Append(CostEstimation).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as CSProject);
        }

        /// <summary>
        /// Returns true if CSProject instances are equal
        /// </summary>
        /// <param name="input">Instance of CSProject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSProject input)
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
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.OrganisationId == input.OrganisationId ||
                    (this.OrganisationId != null &&
                    this.OrganisationId.Equals(input.OrganisationId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.CostEstimation == input.CostEstimation ||
                    (this.CostEstimation != null &&
                    this.CostEstimation.Equals(input.CostEstimation))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.OrganisationId != null)
                    hashCode = hashCode * 59 + this.OrganisationId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.CostEstimation != null)
                    hashCode = hashCode * 59 + this.CostEstimation.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
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
