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
    /// Contains a collection of Timesheet objects that are to be either created or updated.  If the ID of the timesheet is specified in the Timesheet object, then that Timesheet will be updated otherwise it will be created
    /// </summary>
    [DataContract]
    public partial class BatchUpdateTimesheetRequest :  IEquatable<BatchUpdateTimesheetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchUpdateTimesheetRequest" /> class.
        /// </summary>
        /// <param name="timesheets">A collection of Timesheet objects to be either created or updated.</param>
        public BatchUpdateTimesheetRequest(List<Timesheet> timesheets = default(List<Timesheet>))
        {
            this.Timesheets = timesheets;
        }
        
        /// <summary>
        /// A collection of Timesheet objects to be either created or updated
        /// </summary>
        /// <value>A collection of Timesheet objects to be either created or updated</value>
        [DataMember(Name="Timesheets", EmitDefaultValue=false)]
        public List<Timesheet> Timesheets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateTimesheetRequest {\n");
            sb.Append("  Timesheets: ").Append(Timesheets).Append("\n");
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
            return this.Equals(input as BatchUpdateTimesheetRequest);
        }

        /// <summary>
        /// Returns true if BatchUpdateTimesheetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchUpdateTimesheetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchUpdateTimesheetRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timesheets == input.Timesheets ||
                    this.Timesheets != null &&
                    input.Timesheets != null &&
                    this.Timesheets.SequenceEqual(input.Timesheets)
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
                if (this.Timesheets != null)
                    hashCode = hashCode * 59 + this.Timesheets.GetHashCode();
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
