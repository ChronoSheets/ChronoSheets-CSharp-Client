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
    /// RawReportItem
    /// </summary>
    [DataContract]
    public partial class RawReportItem :  IEquatable<RawReportItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RawReportItem" /> class.
        /// </summary>
        /// <param name="organisationId">organisationId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="username">username.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="jobCode">jobCode.</param>
        /// <param name="taskName">taskName.</param>
        /// <param name="clientName">clientName.</param>
        /// <param name="projectName">projectName.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="spanSeconds">spanSeconds.</param>
        /// <param name="description">description.</param>
        /// <param name="payAmount">payAmount.</param>
        /// <param name="payOvertimeAmount">payOvertimeAmount.</param>
        /// <param name="tripCost">tripCost.</param>
        /// <param name="tripDistanceMeters">tripDistanceMeters.</param>
        /// <param name="spanSecondsNormalTime">spanSecondsNormalTime.</param>
        /// <param name="spanSecondsOvertime">spanSecondsOvertime.</param>
        public RawReportItem(int organisationId = default(int), int userId = default(int), string username = default(string), string emailAddress = default(string), string jobCode = default(string), string taskName = default(string), string clientName = default(string), string projectName = default(string), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), int spanSeconds = default(int), string description = default(string), double payAmount = default(double), double payOvertimeAmount = default(double), double tripCost = default(double), double tripDistanceMeters = default(double), int spanSecondsNormalTime = default(int), int spanSecondsOvertime = default(int))
        {
            this.OrganisationId = organisationId;
            this.UserId = userId;
            this.Username = username;
            this.EmailAddress = emailAddress;
            this.JobCode = jobCode;
            this.TaskName = taskName;
            this.ClientName = clientName;
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.SpanSeconds = spanSeconds;
            this.Description = description;
            this.PayAmount = payAmount;
            this.PayOvertimeAmount = payOvertimeAmount;
            this.TripCost = tripCost;
            this.TripDistanceMeters = tripDistanceMeters;
            this.SpanSecondsNormalTime = spanSecondsNormalTime;
            this.SpanSecondsOvertime = spanSecondsOvertime;
        }
        
        /// <summary>
        /// Gets or Sets OrganisationId
        /// </summary>
        [DataMember(Name="OrganisationId", EmitDefaultValue=false)]
        public int OrganisationId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="Username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets JobCode
        /// </summary>
        [DataMember(Name="JobCode", EmitDefaultValue=false)]
        public string JobCode { get; set; }

        /// <summary>
        /// Gets or Sets TaskName
        /// </summary>
        [DataMember(Name="TaskName", EmitDefaultValue=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// Gets or Sets ClientName
        /// </summary>
        [DataMember(Name="ClientName", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name="ProjectName", EmitDefaultValue=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets SpanSeconds
        /// </summary>
        [DataMember(Name="SpanSeconds", EmitDefaultValue=false)]
        public int SpanSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets PayAmount
        /// </summary>
        [DataMember(Name="PayAmount", EmitDefaultValue=false)]
        public double PayAmount { get; set; }

        /// <summary>
        /// Gets or Sets PayOvertimeAmount
        /// </summary>
        [DataMember(Name="PayOvertimeAmount", EmitDefaultValue=false)]
        public double PayOvertimeAmount { get; set; }

        /// <summary>
        /// Gets or Sets TripCost
        /// </summary>
        [DataMember(Name="TripCost", EmitDefaultValue=false)]
        public double TripCost { get; set; }

        /// <summary>
        /// Gets or Sets TripDistanceMeters
        /// </summary>
        [DataMember(Name="TripDistanceMeters", EmitDefaultValue=false)]
        public double TripDistanceMeters { get; set; }

        /// <summary>
        /// Gets or Sets SpanSecondsNormalTime
        /// </summary>
        [DataMember(Name="SpanSecondsNormalTime", EmitDefaultValue=false)]
        public int SpanSecondsNormalTime { get; set; }

        /// <summary>
        /// Gets or Sets SpanSecondsOvertime
        /// </summary>
        [DataMember(Name="SpanSecondsOvertime", EmitDefaultValue=false)]
        public int SpanSecondsOvertime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RawReportItem {\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  JobCode: ").Append(JobCode).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  SpanSeconds: ").Append(SpanSeconds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PayAmount: ").Append(PayAmount).Append("\n");
            sb.Append("  PayOvertimeAmount: ").Append(PayOvertimeAmount).Append("\n");
            sb.Append("  TripCost: ").Append(TripCost).Append("\n");
            sb.Append("  TripDistanceMeters: ").Append(TripDistanceMeters).Append("\n");
            sb.Append("  SpanSecondsNormalTime: ").Append(SpanSecondsNormalTime).Append("\n");
            sb.Append("  SpanSecondsOvertime: ").Append(SpanSecondsOvertime).Append("\n");
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
            return this.Equals(input as RawReportItem);
        }

        /// <summary>
        /// Returns true if RawReportItem instances are equal
        /// </summary>
        /// <param name="input">Instance of RawReportItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RawReportItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganisationId == input.OrganisationId ||
                    (this.OrganisationId != null &&
                    this.OrganisationId.Equals(input.OrganisationId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.JobCode == input.JobCode ||
                    (this.JobCode != null &&
                    this.JobCode.Equals(input.JobCode))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
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
                ) && 
                (
                    this.SpanSeconds == input.SpanSeconds ||
                    (this.SpanSeconds != null &&
                    this.SpanSeconds.Equals(input.SpanSeconds))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PayAmount == input.PayAmount ||
                    (this.PayAmount != null &&
                    this.PayAmount.Equals(input.PayAmount))
                ) && 
                (
                    this.PayOvertimeAmount == input.PayOvertimeAmount ||
                    (this.PayOvertimeAmount != null &&
                    this.PayOvertimeAmount.Equals(input.PayOvertimeAmount))
                ) && 
                (
                    this.TripCost == input.TripCost ||
                    (this.TripCost != null &&
                    this.TripCost.Equals(input.TripCost))
                ) && 
                (
                    this.TripDistanceMeters == input.TripDistanceMeters ||
                    (this.TripDistanceMeters != null &&
                    this.TripDistanceMeters.Equals(input.TripDistanceMeters))
                ) && 
                (
                    this.SpanSecondsNormalTime == input.SpanSecondsNormalTime ||
                    (this.SpanSecondsNormalTime != null &&
                    this.SpanSecondsNormalTime.Equals(input.SpanSecondsNormalTime))
                ) && 
                (
                    this.SpanSecondsOvertime == input.SpanSecondsOvertime ||
                    (this.SpanSecondsOvertime != null &&
                    this.SpanSecondsOvertime.Equals(input.SpanSecondsOvertime))
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
                if (this.OrganisationId != null)
                    hashCode = hashCode * 59 + this.OrganisationId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.JobCode != null)
                    hashCode = hashCode * 59 + this.JobCode.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.SpanSeconds != null)
                    hashCode = hashCode * 59 + this.SpanSeconds.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PayAmount != null)
                    hashCode = hashCode * 59 + this.PayAmount.GetHashCode();
                if (this.PayOvertimeAmount != null)
                    hashCode = hashCode * 59 + this.PayOvertimeAmount.GetHashCode();
                if (this.TripCost != null)
                    hashCode = hashCode * 59 + this.TripCost.GetHashCode();
                if (this.TripDistanceMeters != null)
                    hashCode = hashCode * 59 + this.TripDistanceMeters.GetHashCode();
                if (this.SpanSecondsNormalTime != null)
                    hashCode = hashCode * 59 + this.SpanSecondsNormalTime.GetHashCode();
                if (this.SpanSecondsOvertime != null)
                    hashCode = hashCode * 59 + this.SpanSecondsOvertime.GetHashCode();
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
