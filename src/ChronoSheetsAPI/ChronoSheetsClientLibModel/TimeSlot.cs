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
    /// TimeSlot
    /// </summary>
    [DataContract]
    public partial class TimeSlot :  IEquatable<TimeSlot>, IValidatableObject
    {
        /// <summary>
        /// Defines DayType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayTypeEnum
        {
            /// <summary>
            /// Enum Monday for value: Monday
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday = 1,

            /// <summary>
            /// Enum Tuesday for value: Tuesday
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday = 2,

            /// <summary>
            /// Enum Wednesday for value: Wednesday
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday = 3,

            /// <summary>
            /// Enum Thursday for value: Thursday
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday = 4,

            /// <summary>
            /// Enum Friday for value: Friday
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday = 5,

            /// <summary>
            /// Enum Saturday for value: Saturday
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday = 6,

            /// <summary>
            /// Enum Sunday for value: Sunday
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday = 7

        }

        /// <summary>
        /// Gets or Sets DayType
        /// </summary>
        [DataMember(Name="DayType", EmitDefaultValue=false)]
        public DayTypeEnum? DayType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlot" /> class.
        /// </summary>
        /// <param name="dayType">dayType.</param>
        /// <param name="usualHourId">usualHourId.</param>
        /// <param name="startHour">startHour.</param>
        /// <param name="startMinute">startMinute.</param>
        /// <param name="endHour">endHour.</param>
        /// <param name="endMinute">endMinute.</param>
        /// <param name="isValid">isValid.</param>
        public TimeSlot(DayTypeEnum? dayType = default(DayTypeEnum?), int usualHourId = default(int), int startHour = default(int), int startMinute = default(int), int endHour = default(int), int endMinute = default(int), bool isValid = default(bool))
        {
            this.DayType = dayType;
            this.UsualHourId = usualHourId;
            this.StartHour = startHour;
            this.StartMinute = startMinute;
            this.EndHour = endHour;
            this.EndMinute = endMinute;
            this.IsValid = isValid;
        }
        

        /// <summary>
        /// Gets or Sets UsualHourId
        /// </summary>
        [DataMember(Name="UsualHourId", EmitDefaultValue=false)]
        public int UsualHourId { get; set; }

        /// <summary>
        /// Gets or Sets StartHour
        /// </summary>
        [DataMember(Name="StartHour", EmitDefaultValue=false)]
        public int StartHour { get; set; }

        /// <summary>
        /// Gets or Sets StartMinute
        /// </summary>
        [DataMember(Name="StartMinute", EmitDefaultValue=false)]
        public int StartMinute { get; set; }

        /// <summary>
        /// Gets or Sets EndHour
        /// </summary>
        [DataMember(Name="EndHour", EmitDefaultValue=false)]
        public int EndHour { get; set; }

        /// <summary>
        /// Gets or Sets EndMinute
        /// </summary>
        [DataMember(Name="EndMinute", EmitDefaultValue=false)]
        public int EndMinute { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name="IsValid", EmitDefaultValue=false)]
        public bool IsValid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeSlot {\n");
            sb.Append("  DayType: ").Append(DayType).Append("\n");
            sb.Append("  UsualHourId: ").Append(UsualHourId).Append("\n");
            sb.Append("  StartHour: ").Append(StartHour).Append("\n");
            sb.Append("  StartMinute: ").Append(StartMinute).Append("\n");
            sb.Append("  EndHour: ").Append(EndHour).Append("\n");
            sb.Append("  EndMinute: ").Append(EndMinute).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
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
            return this.Equals(input as TimeSlot);
        }

        /// <summary>
        /// Returns true if TimeSlot instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSlot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DayType == input.DayType ||
                    (this.DayType != null &&
                    this.DayType.Equals(input.DayType))
                ) && 
                (
                    this.UsualHourId == input.UsualHourId ||
                    (this.UsualHourId != null &&
                    this.UsualHourId.Equals(input.UsualHourId))
                ) && 
                (
                    this.StartHour == input.StartHour ||
                    (this.StartHour != null &&
                    this.StartHour.Equals(input.StartHour))
                ) && 
                (
                    this.StartMinute == input.StartMinute ||
                    (this.StartMinute != null &&
                    this.StartMinute.Equals(input.StartMinute))
                ) && 
                (
                    this.EndHour == input.EndHour ||
                    (this.EndHour != null &&
                    this.EndHour.Equals(input.EndHour))
                ) && 
                (
                    this.EndMinute == input.EndMinute ||
                    (this.EndMinute != null &&
                    this.EndMinute.Equals(input.EndMinute))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    (this.IsValid != null &&
                    this.IsValid.Equals(input.IsValid))
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
                if (this.DayType != null)
                    hashCode = hashCode * 59 + this.DayType.GetHashCode();
                if (this.UsualHourId != null)
                    hashCode = hashCode * 59 + this.UsualHourId.GetHashCode();
                if (this.StartHour != null)
                    hashCode = hashCode * 59 + this.StartHour.GetHashCode();
                if (this.StartMinute != null)
                    hashCode = hashCode * 59 + this.StartMinute.GetHashCode();
                if (this.EndHour != null)
                    hashCode = hashCode * 59 + this.EndHour.GetHashCode();
                if (this.EndMinute != null)
                    hashCode = hashCode * 59 + this.EndMinute.GetHashCode();
                if (this.IsValid != null)
                    hashCode = hashCode * 59 + this.IsValid.GetHashCode();
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
