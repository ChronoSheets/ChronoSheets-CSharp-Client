/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 3 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
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
    /// CSAggregateJobCode
    /// </summary>
    [DataContract]
    public partial class CSAggregateJobCode :  IEquatable<CSAggregateJobCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSAggregateJobCode" /> class.
        /// </summary>
        /// <param name="availableTasks">The list of available tasks under this job code.</param>
        /// <param name="permittedEmployees">The list of employee IDs that are permitted to record timesheets with this job code (empty means everyone).</param>
        /// <param name="id">The ID of the job code (not the code itself).</param>
        /// <param name="code">The job code itself.</param>
        /// <param name="_client">The name of the client.</param>
        /// <param name="clientId">The ID of the client.</param>
        /// <param name="project">The name of the project.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="organisationId">Your organisation ID.</param>
        /// <param name="isDeleted">A flag indicating whether or not the job code has been marked as deleted.</param>
        public CSAggregateJobCode(List<CSAggregateJobTask> availableTasks = default(List<CSAggregateJobTask>), List<int?> permittedEmployees = default(List<int?>), int? id = default(int?), string code = default(string), string _client = default(string), int? clientId = default(int?), string project = default(string), int? projectId = default(int?), int? organisationId = default(int?), bool? isDeleted = default(bool?))
        {
            this.AvailableTasks = availableTasks;
            this.PermittedEmployees = permittedEmployees;
            this.Id = id;
            this.Code = code;
            this._Client = _client;
            this.ClientId = clientId;
            this.Project = project;
            this.ProjectId = projectId;
            this.OrganisationId = organisationId;
            this.IsDeleted = isDeleted;
        }
        
        /// <summary>
        /// The list of available tasks under this job code
        /// </summary>
        /// <value>The list of available tasks under this job code</value>
        [DataMember(Name="AvailableTasks", EmitDefaultValue=false)]
        public List<CSAggregateJobTask> AvailableTasks { get; set; }

        /// <summary>
        /// The list of employee IDs that are permitted to record timesheets with this job code (empty means everyone)
        /// </summary>
        /// <value>The list of employee IDs that are permitted to record timesheets with this job code (empty means everyone)</value>
        [DataMember(Name="PermittedEmployees", EmitDefaultValue=false)]
        public List<int?> PermittedEmployees { get; set; }

        /// <summary>
        /// The ID of the job code (not the code itself)
        /// </summary>
        /// <value>The ID of the job code (not the code itself)</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The job code itself
        /// </summary>
        /// <value>The job code itself</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The name of the client
        /// </summary>
        /// <value>The name of the client</value>
        [DataMember(Name="Client", EmitDefaultValue=false)]
        public string _Client { get; set; }

        /// <summary>
        /// The ID of the client
        /// </summary>
        /// <value>The ID of the client</value>
        [DataMember(Name="ClientId", EmitDefaultValue=false)]
        public int? ClientId { get; set; }

        /// <summary>
        /// The name of the project
        /// </summary>
        /// <value>The name of the project</value>
        [DataMember(Name="Project", EmitDefaultValue=false)]
        public string Project { get; set; }

        /// <summary>
        /// The ID of the project
        /// </summary>
        /// <value>The ID of the project</value>
        [DataMember(Name="ProjectId", EmitDefaultValue=false)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Your organisation ID
        /// </summary>
        /// <value>Your organisation ID</value>
        [DataMember(Name="OrganisationId", EmitDefaultValue=false)]
        public int? OrganisationId { get; set; }

        /// <summary>
        /// A flag indicating whether or not the job code has been marked as deleted
        /// </summary>
        /// <value>A flag indicating whether or not the job code has been marked as deleted</value>
        [DataMember(Name="IsDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSAggregateJobCode {\n");
            sb.Append("  AvailableTasks: ").Append(AvailableTasks).Append("\n");
            sb.Append("  PermittedEmployees: ").Append(PermittedEmployees).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  _Client: ").Append(_Client).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CSAggregateJobCode);
        }

        /// <summary>
        /// Returns true if CSAggregateJobCode instances are equal
        /// </summary>
        /// <param name="input">Instance of CSAggregateJobCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSAggregateJobCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailableTasks == input.AvailableTasks ||
                    this.AvailableTasks != null &&
                    this.AvailableTasks.SequenceEqual(input.AvailableTasks)
                ) && 
                (
                    this.PermittedEmployees == input.PermittedEmployees ||
                    this.PermittedEmployees != null &&
                    this.PermittedEmployees.SequenceEqual(input.PermittedEmployees)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this._Client == input._Client ||
                    (this._Client != null &&
                    this._Client.Equals(input._Client))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.OrganisationId == input.OrganisationId ||
                    (this.OrganisationId != null &&
                    this.OrganisationId.Equals(input.OrganisationId))
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
                if (this.AvailableTasks != null)
                    hashCode = hashCode * 59 + this.AvailableTasks.GetHashCode();
                if (this.PermittedEmployees != null)
                    hashCode = hashCode * 59 + this.PermittedEmployees.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this._Client != null)
                    hashCode = hashCode * 59 + this._Client.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.OrganisationId != null)
                    hashCode = hashCode * 59 + this.OrganisationId.GetHashCode();
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
