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
    /// CSExtendedGeofence
    /// </summary>
    [DataContract]
    public partial class CSExtendedGeofence :  IEquatable<CSExtendedGeofence>, IValidatableObject
    {
        /// <summary>
        /// Defines TriggerSettings
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TriggerSettingsEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum StartTimesheetWhenEntering for value: StartTimesheetWhenEntering
            /// </summary>
            [EnumMember(Value = "StartTimesheetWhenEntering")]
            StartTimesheetWhenEntering = 2,
            
            /// <summary>
            /// Enum StopTimesheetWhenEntering for value: StopTimesheetWhenEntering
            /// </summary>
            [EnumMember(Value = "StopTimesheetWhenEntering")]
            StopTimesheetWhenEntering = 3,
            
            /// <summary>
            /// Enum StartOnEnterStopOnLeave for value: StartOnEnterStopOnLeave
            /// </summary>
            [EnumMember(Value = "StartOnEnterStopOnLeave")]
            StartOnEnterStopOnLeave = 4
        }

        /// <summary>
        /// Gets or Sets TriggerSettings
        /// </summary>
        [DataMember(Name="TriggerSettings", EmitDefaultValue=false)]
        public TriggerSettingsEnum? TriggerSettings { get; set; }
        /// <summary>
        /// Defines AlertSettings
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlertSettingsEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum SendWhenEntering for value: SendWhenEntering
            /// </summary>
            [EnumMember(Value = "SendWhenEntering")]
            SendWhenEntering = 2,
            
            /// <summary>
            /// Enum SendWhenExiting for value: SendWhenExiting
            /// </summary>
            [EnumMember(Value = "SendWhenExiting")]
            SendWhenExiting = 3,
            
            /// <summary>
            /// Enum SendWhenEnteringOrExiting for value: SendWhenEnteringOrExiting
            /// </summary>
            [EnumMember(Value = "SendWhenEnteringOrExiting")]
            SendWhenEnteringOrExiting = 4
        }

        /// <summary>
        /// Gets or Sets AlertSettings
        /// </summary>
        [DataMember(Name="AlertSettings", EmitDefaultValue=false)]
        public AlertSettingsEnum? AlertSettings { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CSExtendedGeofence" /> class.
        /// </summary>
        /// <param name="jobCode">jobCode.</param>
        /// <param name="taskName">taskName.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="alertOrganisation">alertOrganisation.</param>
        /// <param name="geoFencingId">geoFencingId.</param>
        /// <param name="orgId">orgId.</param>
        /// <param name="createdByUserId">createdByUserId.</param>
        /// <param name="lastUpdatedByUserId">lastUpdatedByUserId.</param>
        /// <param name="name">name.</param>
        /// <param name="locationName">locationName.</param>
        /// <param name="coordinates">coordinates.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="triggerJobCodeId">triggerJobCodeId.</param>
        /// <param name="triggerTaskId">triggerTaskId.</param>
        /// <param name="triggerSettings">triggerSettings.</param>
        /// <param name="alertToOrgGroupId">alertToOrgGroupId.</param>
        /// <param name="alertSettings">alertSettings.</param>
        /// <param name="startTimeHour">startTimeHour.</param>
        /// <param name="startTimeMinute">startTimeMinute.</param>
        /// <param name="endTimeHour">endTimeHour.</param>
        /// <param name="endTimeMinute">endTimeMinute.</param>
        public CSExtendedGeofence(string jobCode = default(string), string taskName = default(string), string createdBy = default(string), string updatedBy = default(string), string alertOrganisation = default(string), int? geoFencingId = default(int?), int? orgId = default(int?), int? createdByUserId = default(int?), int? lastUpdatedByUserId = default(int?), string name = default(string), string locationName = default(string), List<CSBasicCoordinate> coordinates = default(List<CSBasicCoordinate>), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), int? triggerJobCodeId = default(int?), int? triggerTaskId = default(int?), TriggerSettingsEnum? triggerSettings = default(TriggerSettingsEnum?), int? alertToOrgGroupId = default(int?), AlertSettingsEnum? alertSettings = default(AlertSettingsEnum?), int? startTimeHour = default(int?), int? startTimeMinute = default(int?), int? endTimeHour = default(int?), int? endTimeMinute = default(int?))
        {
            this.JobCode = jobCode;
            this.TaskName = taskName;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
            this.AlertOrganisation = alertOrganisation;
            this.GeoFencingId = geoFencingId;
            this.OrgId = orgId;
            this.CreatedByUserId = createdByUserId;
            this.LastUpdatedByUserId = lastUpdatedByUserId;
            this.Name = name;
            this.LocationName = locationName;
            this.Coordinates = coordinates;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TriggerJobCodeId = triggerJobCodeId;
            this.TriggerTaskId = triggerTaskId;
            this.TriggerSettings = triggerSettings;
            this.AlertToOrgGroupId = alertToOrgGroupId;
            this.AlertSettings = alertSettings;
            this.StartTimeHour = startTimeHour;
            this.StartTimeMinute = startTimeMinute;
            this.EndTimeHour = endTimeHour;
            this.EndTimeMinute = endTimeMinute;
        }
        
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
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name="UpdatedBy", EmitDefaultValue=false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or Sets AlertOrganisation
        /// </summary>
        [DataMember(Name="AlertOrganisation", EmitDefaultValue=false)]
        public string AlertOrganisation { get; set; }

        /// <summary>
        /// Gets or Sets GeoFencingId
        /// </summary>
        [DataMember(Name="GeoFencingId", EmitDefaultValue=false)]
        public int? GeoFencingId { get; set; }

        /// <summary>
        /// Gets or Sets OrgId
        /// </summary>
        [DataMember(Name="OrgId", EmitDefaultValue=false)]
        public int? OrgId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserId
        /// </summary>
        [DataMember(Name="CreatedByUserId", EmitDefaultValue=false)]
        public int? CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedByUserId
        /// </summary>
        [DataMember(Name="LastUpdatedByUserId", EmitDefaultValue=false)]
        public int? LastUpdatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name="LocationName", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name="Coordinates", EmitDefaultValue=false)]
        public List<CSBasicCoordinate> Coordinates { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="CreatedAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="UpdatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets TriggerJobCodeId
        /// </summary>
        [DataMember(Name="TriggerJobCodeId", EmitDefaultValue=false)]
        public int? TriggerJobCodeId { get; set; }

        /// <summary>
        /// Gets or Sets TriggerTaskId
        /// </summary>
        [DataMember(Name="TriggerTaskId", EmitDefaultValue=false)]
        public int? TriggerTaskId { get; set; }


        /// <summary>
        /// Gets or Sets AlertToOrgGroupId
        /// </summary>
        [DataMember(Name="AlertToOrgGroupId", EmitDefaultValue=false)]
        public int? AlertToOrgGroupId { get; set; }


        /// <summary>
        /// Gets or Sets StartTimeHour
        /// </summary>
        [DataMember(Name="StartTimeHour", EmitDefaultValue=false)]
        public int? StartTimeHour { get; set; }

        /// <summary>
        /// Gets or Sets StartTimeMinute
        /// </summary>
        [DataMember(Name="StartTimeMinute", EmitDefaultValue=false)]
        public int? StartTimeMinute { get; set; }

        /// <summary>
        /// Gets or Sets EndTimeHour
        /// </summary>
        [DataMember(Name="EndTimeHour", EmitDefaultValue=false)]
        public int? EndTimeHour { get; set; }

        /// <summary>
        /// Gets or Sets EndTimeMinute
        /// </summary>
        [DataMember(Name="EndTimeMinute", EmitDefaultValue=false)]
        public int? EndTimeMinute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSExtendedGeofence {\n");
            sb.Append("  JobCode: ").Append(JobCode).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  AlertOrganisation: ").Append(AlertOrganisation).Append("\n");
            sb.Append("  GeoFencingId: ").Append(GeoFencingId).Append("\n");
            sb.Append("  OrgId: ").Append(OrgId).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  LastUpdatedByUserId: ").Append(LastUpdatedByUserId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  TriggerJobCodeId: ").Append(TriggerJobCodeId).Append("\n");
            sb.Append("  TriggerTaskId: ").Append(TriggerTaskId).Append("\n");
            sb.Append("  TriggerSettings: ").Append(TriggerSettings).Append("\n");
            sb.Append("  AlertToOrgGroupId: ").Append(AlertToOrgGroupId).Append("\n");
            sb.Append("  AlertSettings: ").Append(AlertSettings).Append("\n");
            sb.Append("  StartTimeHour: ").Append(StartTimeHour).Append("\n");
            sb.Append("  StartTimeMinute: ").Append(StartTimeMinute).Append("\n");
            sb.Append("  EndTimeHour: ").Append(EndTimeHour).Append("\n");
            sb.Append("  EndTimeMinute: ").Append(EndTimeMinute).Append("\n");
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
            return this.Equals(input as CSExtendedGeofence);
        }

        /// <summary>
        /// Returns true if CSExtendedGeofence instances are equal
        /// </summary>
        /// <param name="input">Instance of CSExtendedGeofence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSExtendedGeofence input)
        {
            if (input == null)
                return false;

            return 
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
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.AlertOrganisation == input.AlertOrganisation ||
                    (this.AlertOrganisation != null &&
                    this.AlertOrganisation.Equals(input.AlertOrganisation))
                ) && 
                (
                    this.GeoFencingId == input.GeoFencingId ||
                    (this.GeoFencingId != null &&
                    this.GeoFencingId.Equals(input.GeoFencingId))
                ) && 
                (
                    this.OrgId == input.OrgId ||
                    (this.OrgId != null &&
                    this.OrgId.Equals(input.OrgId))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.LastUpdatedByUserId == input.LastUpdatedByUserId ||
                    (this.LastUpdatedByUserId != null &&
                    this.LastUpdatedByUserId.Equals(input.LastUpdatedByUserId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && 
                (
                    this.Coordinates == input.Coordinates ||
                    this.Coordinates != null &&
                    this.Coordinates.SequenceEqual(input.Coordinates)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.TriggerJobCodeId == input.TriggerJobCodeId ||
                    (this.TriggerJobCodeId != null &&
                    this.TriggerJobCodeId.Equals(input.TriggerJobCodeId))
                ) && 
                (
                    this.TriggerTaskId == input.TriggerTaskId ||
                    (this.TriggerTaskId != null &&
                    this.TriggerTaskId.Equals(input.TriggerTaskId))
                ) && 
                (
                    this.TriggerSettings == input.TriggerSettings ||
                    (this.TriggerSettings != null &&
                    this.TriggerSettings.Equals(input.TriggerSettings))
                ) && 
                (
                    this.AlertToOrgGroupId == input.AlertToOrgGroupId ||
                    (this.AlertToOrgGroupId != null &&
                    this.AlertToOrgGroupId.Equals(input.AlertToOrgGroupId))
                ) && 
                (
                    this.AlertSettings == input.AlertSettings ||
                    (this.AlertSettings != null &&
                    this.AlertSettings.Equals(input.AlertSettings))
                ) && 
                (
                    this.StartTimeHour == input.StartTimeHour ||
                    (this.StartTimeHour != null &&
                    this.StartTimeHour.Equals(input.StartTimeHour))
                ) && 
                (
                    this.StartTimeMinute == input.StartTimeMinute ||
                    (this.StartTimeMinute != null &&
                    this.StartTimeMinute.Equals(input.StartTimeMinute))
                ) && 
                (
                    this.EndTimeHour == input.EndTimeHour ||
                    (this.EndTimeHour != null &&
                    this.EndTimeHour.Equals(input.EndTimeHour))
                ) && 
                (
                    this.EndTimeMinute == input.EndTimeMinute ||
                    (this.EndTimeMinute != null &&
                    this.EndTimeMinute.Equals(input.EndTimeMinute))
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
                if (this.JobCode != null)
                    hashCode = hashCode * 59 + this.JobCode.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                if (this.AlertOrganisation != null)
                    hashCode = hashCode * 59 + this.AlertOrganisation.GetHashCode();
                if (this.GeoFencingId != null)
                    hashCode = hashCode * 59 + this.GeoFencingId.GetHashCode();
                if (this.OrgId != null)
                    hashCode = hashCode * 59 + this.OrgId.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.LastUpdatedByUserId != null)
                    hashCode = hashCode * 59 + this.LastUpdatedByUserId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LocationName != null)
                    hashCode = hashCode * 59 + this.LocationName.GetHashCode();
                if (this.Coordinates != null)
                    hashCode = hashCode * 59 + this.Coordinates.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.TriggerJobCodeId != null)
                    hashCode = hashCode * 59 + this.TriggerJobCodeId.GetHashCode();
                if (this.TriggerTaskId != null)
                    hashCode = hashCode * 59 + this.TriggerTaskId.GetHashCode();
                if (this.TriggerSettings != null)
                    hashCode = hashCode * 59 + this.TriggerSettings.GetHashCode();
                if (this.AlertToOrgGroupId != null)
                    hashCode = hashCode * 59 + this.AlertToOrgGroupId.GetHashCode();
                if (this.AlertSettings != null)
                    hashCode = hashCode * 59 + this.AlertSettings.GetHashCode();
                if (this.StartTimeHour != null)
                    hashCode = hashCode * 59 + this.StartTimeHour.GetHashCode();
                if (this.StartTimeMinute != null)
                    hashCode = hashCode * 59 + this.StartTimeMinute.GetHashCode();
                if (this.EndTimeHour != null)
                    hashCode = hashCode * 59 + this.EndTimeHour.GetHashCode();
                if (this.EndTimeMinute != null)
                    hashCode = hashCode * 59 + this.EndTimeMinute.GetHashCode();
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
