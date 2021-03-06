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
    /// An object that can be used to set the Usual Hours (Rostered Hours) of an employee user account
    /// </summary>
    [DataContract]
    public partial class SetUsualHoursRequest :  IEquatable<SetUsualHoursRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetUsualHoursRequest" /> class.
        /// </summary>
        /// <param name="usualHoursData">A Collection of days (Mon-Sun) with updated Roster timeslots.</param>
        /// <param name="userId">The Id of the User that these updated Rostered Hours will be applied to.</param>
        public SetUsualHoursRequest(List<UsualHoursDay> usualHoursData = default(List<UsualHoursDay>), int userId = default(int))
        {
            this.UsualHoursData = usualHoursData;
            this.UserId = userId;
        }
        
        /// <summary>
        /// A Collection of days (Mon-Sun) with updated Roster timeslots
        /// </summary>
        /// <value>A Collection of days (Mon-Sun) with updated Roster timeslots</value>
        [DataMember(Name="UsualHoursData", EmitDefaultValue=false)]
        public List<UsualHoursDay> UsualHoursData { get; set; }

        /// <summary>
        /// The Id of the User that these updated Rostered Hours will be applied to
        /// </summary>
        /// <value>The Id of the User that these updated Rostered Hours will be applied to</value>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetUsualHoursRequest {\n");
            sb.Append("  UsualHoursData: ").Append(UsualHoursData).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as SetUsualHoursRequest);
        }

        /// <summary>
        /// Returns true if SetUsualHoursRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetUsualHoursRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetUsualHoursRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UsualHoursData == input.UsualHoursData ||
                    this.UsualHoursData != null &&
                    input.UsualHoursData != null &&
                    this.UsualHoursData.SequenceEqual(input.UsualHoursData)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.UsualHoursData != null)
                    hashCode = hashCode * 59 + this.UsualHoursData.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
