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
    /// TimesheetAutomationWithOrgAndGeofence
    /// </summary>
    [DataContract]
    public partial class TimesheetAutomationWithOrgAndGeofence :  IEquatable<TimesheetAutomationWithOrgAndGeofence>, IValidatableObject
    {
        /// <summary>
        /// Defines AutomationActionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AutomationActionTypeEnum
        {
            /// <summary>
            /// Enum EnterGeofence for value: EnterGeofence
            /// </summary>
            [EnumMember(Value = "EnterGeofence")]
            EnterGeofence = 1,

            /// <summary>
            /// Enum ExitGeofence for value: ExitGeofence
            /// </summary>
            [EnumMember(Value = "ExitGeofence")]
            ExitGeofence = 2,

            /// <summary>
            /// Enum TapOnNfc for value: TapOnNfc
            /// </summary>
            [EnumMember(Value = "TapOnNfc")]
            TapOnNfc = 3

        }

        /// <summary>
        /// Gets or Sets AutomationActionType
        /// </summary>
        [DataMember(Name="AutomationActionType", EmitDefaultValue=false)]
        public AutomationActionTypeEnum? AutomationActionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimesheetAutomationWithOrgAndGeofence" /> class.
        /// </summary>
        /// <param name="orgId">orgId.</param>
        /// <param name="geofenceName">geofenceName.</param>
        /// <param name="coordinates">coordinates.</param>
        /// <param name="userId">userId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="automationId">automationId.</param>
        /// <param name="automationActionType">automationActionType.</param>
        /// <param name="created">created.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="isProcessed">isProcessed.</param>
        /// <param name="expires">expires.</param>
        /// <param name="clientDateTime">clientDateTime.</param>
        public TimesheetAutomationWithOrgAndGeofence(int orgId = default(int), string geofenceName = default(string), List<BasicCoordinate> coordinates = default(List<BasicCoordinate>), int userId = default(int), string userName = default(string), string firstName = default(string), string lastName = default(string), int automationId = default(int), AutomationActionTypeEnum? automationActionType = default(AutomationActionTypeEnum?), DateTime created = default(DateTime), double latitude = default(double), double longitude = default(double), bool isProcessed = default(bool), DateTime expires = default(DateTime), DateTime clientDateTime = default(DateTime))
        {
            this.OrgId = orgId;
            this.GeofenceName = geofenceName;
            this.Coordinates = coordinates;
            this.UserId = userId;
            this.UserName = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AutomationId = automationId;
            this.AutomationActionType = automationActionType;
            this.Created = created;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.IsProcessed = isProcessed;
            this.Expires = expires;
            this.ClientDateTime = clientDateTime;
        }
        
        /// <summary>
        /// Gets or Sets OrgId
        /// </summary>
        [DataMember(Name="OrgId", EmitDefaultValue=false)]
        public int OrgId { get; set; }

        /// <summary>
        /// Gets or Sets GeofenceName
        /// </summary>
        [DataMember(Name="GeofenceName", EmitDefaultValue=false)]
        public string GeofenceName { get; set; }

        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name="Coordinates", EmitDefaultValue=false)]
        public List<BasicCoordinate> Coordinates { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets AutomationId
        /// </summary>
        [DataMember(Name="AutomationId", EmitDefaultValue=false)]
        public int AutomationId { get; set; }


        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="Created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="Latitude", EmitDefaultValue=false)]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="Longitude", EmitDefaultValue=false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or Sets IsProcessed
        /// </summary>
        [DataMember(Name="IsProcessed", EmitDefaultValue=false)]
        public bool IsProcessed { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name="Expires", EmitDefaultValue=false)]
        public DateTime Expires { get; set; }

        /// <summary>
        /// Gets or Sets ClientDateTime
        /// </summary>
        [DataMember(Name="ClientDateTime", EmitDefaultValue=false)]
        public DateTime ClientDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimesheetAutomationWithOrgAndGeofence {\n");
            sb.Append("  OrgId: ").Append(OrgId).Append("\n");
            sb.Append("  GeofenceName: ").Append(GeofenceName).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  AutomationId: ").Append(AutomationId).Append("\n");
            sb.Append("  AutomationActionType: ").Append(AutomationActionType).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  IsProcessed: ").Append(IsProcessed).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  ClientDateTime: ").Append(ClientDateTime).Append("\n");
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
            return this.Equals(input as TimesheetAutomationWithOrgAndGeofence);
        }

        /// <summary>
        /// Returns true if TimesheetAutomationWithOrgAndGeofence instances are equal
        /// </summary>
        /// <param name="input">Instance of TimesheetAutomationWithOrgAndGeofence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimesheetAutomationWithOrgAndGeofence input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrgId == input.OrgId ||
                    (this.OrgId != null &&
                    this.OrgId.Equals(input.OrgId))
                ) && 
                (
                    this.GeofenceName == input.GeofenceName ||
                    (this.GeofenceName != null &&
                    this.GeofenceName.Equals(input.GeofenceName))
                ) && 
                (
                    this.Coordinates == input.Coordinates ||
                    this.Coordinates != null &&
                    input.Coordinates != null &&
                    this.Coordinates.SequenceEqual(input.Coordinates)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.AutomationId == input.AutomationId ||
                    (this.AutomationId != null &&
                    this.AutomationId.Equals(input.AutomationId))
                ) && 
                (
                    this.AutomationActionType == input.AutomationActionType ||
                    (this.AutomationActionType != null &&
                    this.AutomationActionType.Equals(input.AutomationActionType))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.IsProcessed == input.IsProcessed ||
                    (this.IsProcessed != null &&
                    this.IsProcessed.Equals(input.IsProcessed))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.ClientDateTime == input.ClientDateTime ||
                    (this.ClientDateTime != null &&
                    this.ClientDateTime.Equals(input.ClientDateTime))
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
                if (this.OrgId != null)
                    hashCode = hashCode * 59 + this.OrgId.GetHashCode();
                if (this.GeofenceName != null)
                    hashCode = hashCode * 59 + this.GeofenceName.GetHashCode();
                if (this.Coordinates != null)
                    hashCode = hashCode * 59 + this.Coordinates.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.AutomationId != null)
                    hashCode = hashCode * 59 + this.AutomationId.GetHashCode();
                if (this.AutomationActionType != null)
                    hashCode = hashCode * 59 + this.AutomationActionType.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.IsProcessed != null)
                    hashCode = hashCode * 59 + this.IsProcessed.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.ClientDateTime != null)
                    hashCode = hashCode * 59 + this.ClientDateTime.GetHashCode();
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
