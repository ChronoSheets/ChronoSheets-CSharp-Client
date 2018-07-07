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
    /// CSProjectCostingReportItem
    /// </summary>
    [DataContract]
    public partial class CSProjectCostingReportItem :  IEquatable<CSProjectCostingReportItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSProjectCostingReportItem" /> class.
        /// </summary>
        /// <param name="ProjectId">ProjectId.</param>
        /// <param name="ProjectName">ProjectName.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="OrganisationId">OrganisationId.</param>
        /// <param name="ClientName">ClientName.</param>
        /// <param name="EstimatedCost">EstimatedCost.</param>
        /// <param name="ActualCost">ActualCost.</param>
        public CSProjectCostingReportItem(int? ProjectId = default(int?), string ProjectName = default(string), int? ClientId = default(int?), int? OrganisationId = default(int?), string ClientName = default(string), double? EstimatedCost = default(double?), double? ActualCost = default(double?))
        {
            this.ProjectId = ProjectId;
            this.ProjectName = ProjectName;
            this.ClientId = ClientId;
            this.OrganisationId = OrganisationId;
            this.ClientName = ClientName;
            this.EstimatedCost = EstimatedCost;
            this.ActualCost = ActualCost;
        }
        
        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="ProjectId", EmitDefaultValue=false)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name="ProjectName", EmitDefaultValue=false)]
        public string ProjectName { get; set; }

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
        /// Gets or Sets ClientName
        /// </summary>
        [DataMember(Name="ClientName", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedCost
        /// </summary>
        [DataMember(Name="EstimatedCost", EmitDefaultValue=false)]
        public double? EstimatedCost { get; set; }

        /// <summary>
        /// Gets or Sets ActualCost
        /// </summary>
        [DataMember(Name="ActualCost", EmitDefaultValue=false)]
        public double? ActualCost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSProjectCostingReportItem {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  EstimatedCost: ").Append(EstimatedCost).Append("\n");
            sb.Append("  ActualCost: ").Append(ActualCost).Append("\n");
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
            return this.Equals(input as CSProjectCostingReportItem);
        }

        /// <summary>
        /// Returns true if CSProjectCostingReportItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CSProjectCostingReportItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSProjectCostingReportItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
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
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
                ) && 
                (
                    this.EstimatedCost == input.EstimatedCost ||
                    (this.EstimatedCost != null &&
                    this.EstimatedCost.Equals(input.EstimatedCost))
                ) && 
                (
                    this.ActualCost == input.ActualCost ||
                    (this.ActualCost != null &&
                    this.ActualCost.Equals(input.ActualCost))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.OrganisationId != null)
                    hashCode = hashCode * 59 + this.OrganisationId.GetHashCode();
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.EstimatedCost != null)
                    hashCode = hashCode * 59 + this.EstimatedCost.GetHashCode();
                if (this.ActualCost != null)
                    hashCode = hashCode * 59 + this.ActualCost.GetHashCode();
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
