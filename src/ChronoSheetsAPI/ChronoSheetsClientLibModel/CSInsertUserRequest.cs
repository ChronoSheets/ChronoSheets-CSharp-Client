/* 
 * The ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  </p>  <p>      First Steps:       <ol>          <li>Make sure you've <a href='/HomeV2/App/sign-up'>signed up to ChronoSheets</a> to get yourself a user account</li>          <li>Confirm your account by following the link sent to your email address.  This will activate your account</li>          <li>Use your username and password to obtain an Auth Token by using the DoLogin method inside the UserProfile section below.  Use the Auth Token as an argument to the other methods</li>          <li>Try different methods in the API Playground to learn about the API</li>          <li>If you're stuck, try the full getting started guide on the <a href='/Home/ApiDocs'>API Toolkit</a> page.</li>      </ol>  </p>  <p>      Further Steps:       <ul>          <li>Create a mobile app (iOS, Android or Windows) using one of the ChronoSheets Mobile SDKs</li>          <li>Create a custom integration with your app using one of the ChronoSheets API Client Libraries.</li>      </ul>      Read more about the API Toolkit on the <a href='/Home/ApiDocs'>API Toolkit</a> page.  </p></div>
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
    /// Fields for Inserting a new User account (employee) under your Organisation in ChronoSheets
    /// </summary>
    [DataContract]
    public partial class CSInsertUserRequest :  IEquatable<CSInsertUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSInsertUserRequest" /> class.
        /// </summary>
        /// <param name="EmailAddress">The Email Address of the employee.</param>
        /// <param name="FirstName">The First Name of the employee.</param>
        /// <param name="LastName">The Last Name of the employee.</param>
        /// <param name="IsSubscribedToNewsletter">Whether or not the employee is subscribed to ChronoSheets newsletters.</param>
        /// <param name="Roles">A BIT field designating which Roles/Permissions the employee will have when they sign in.  See the {timesheets.types.Enums.UserRoles} Enum for more details.</param>
        /// <param name="AlertSettings">A BIT field designating which Alerts the employee will receive.  See the {timesheets.types.Enums.AlertSettings} Enum for more details.</param>
        /// <param name="UserName">The UserName of the employee.  This can be used when logging into ChronoSheets.</param>
        /// <param name="HourlyPayRate">Set the starting usual Hourly Pay Rate with this value.  This is the Pay Rate the employee receives for working during Rostered Hours.</param>
        /// <param name="HourlyOvertimePayRate">Set the starting usual Overtime Hourly Pay Rate with this value.  This is the Pay Rate the employee receives for working outside of Rostered Hours.</param>
        /// <param name="CurrentDate">The Current date time.</param>
        public CSInsertUserRequest(string EmailAddress = default(string), string FirstName = default(string), string LastName = default(string), bool? IsSubscribedToNewsletter = default(bool?), long? Roles = default(long?), long? AlertSettings = default(long?), string UserName = default(string), double? HourlyPayRate = default(double?), double? HourlyOvertimePayRate = default(double?), DateTime? CurrentDate = default(DateTime?))
        {
            this.EmailAddress = EmailAddress;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsSubscribedToNewsletter = IsSubscribedToNewsletter;
            this.Roles = Roles;
            this.AlertSettings = AlertSettings;
            this.UserName = UserName;
            this.HourlyPayRate = HourlyPayRate;
            this.HourlyOvertimePayRate = HourlyOvertimePayRate;
            this.CurrentDate = CurrentDate;
        }
        
        /// <summary>
        /// The Email Address of the employee
        /// </summary>
        /// <value>The Email Address of the employee</value>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The First Name of the employee
        /// </summary>
        /// <value>The First Name of the employee</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The Last Name of the employee
        /// </summary>
        /// <value>The Last Name of the employee</value>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Whether or not the employee is subscribed to ChronoSheets newsletters
        /// </summary>
        /// <value>Whether or not the employee is subscribed to ChronoSheets newsletters</value>
        [DataMember(Name="IsSubscribedToNewsletter", EmitDefaultValue=false)]
        public bool? IsSubscribedToNewsletter { get; set; }

        /// <summary>
        /// A BIT field designating which Roles/Permissions the employee will have when they sign in.  See the {timesheets.types.Enums.UserRoles} Enum for more details
        /// </summary>
        /// <value>A BIT field designating which Roles/Permissions the employee will have when they sign in.  See the {timesheets.types.Enums.UserRoles} Enum for more details</value>
        [DataMember(Name="Roles", EmitDefaultValue=false)]
        public long? Roles { get; set; }

        /// <summary>
        /// A BIT field designating which Alerts the employee will receive.  See the {timesheets.types.Enums.AlertSettings} Enum for more details
        /// </summary>
        /// <value>A BIT field designating which Alerts the employee will receive.  See the {timesheets.types.Enums.AlertSettings} Enum for more details</value>
        [DataMember(Name="AlertSettings", EmitDefaultValue=false)]
        public long? AlertSettings { get; set; }

        /// <summary>
        /// The UserName of the employee.  This can be used when logging into ChronoSheets
        /// </summary>
        /// <value>The UserName of the employee.  This can be used when logging into ChronoSheets</value>
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Set the starting usual Hourly Pay Rate with this value.  This is the Pay Rate the employee receives for working during Rostered Hours
        /// </summary>
        /// <value>Set the starting usual Hourly Pay Rate with this value.  This is the Pay Rate the employee receives for working during Rostered Hours</value>
        [DataMember(Name="HourlyPayRate", EmitDefaultValue=false)]
        public double? HourlyPayRate { get; set; }

        /// <summary>
        /// Set the starting usual Overtime Hourly Pay Rate with this value.  This is the Pay Rate the employee receives for working outside of Rostered Hours
        /// </summary>
        /// <value>Set the starting usual Overtime Hourly Pay Rate with this value.  This is the Pay Rate the employee receives for working outside of Rostered Hours</value>
        [DataMember(Name="HourlyOvertimePayRate", EmitDefaultValue=false)]
        public double? HourlyOvertimePayRate { get; set; }

        /// <summary>
        /// The Current date time
        /// </summary>
        /// <value>The Current date time</value>
        [DataMember(Name="CurrentDate", EmitDefaultValue=false)]
        public DateTime? CurrentDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CSInsertUserRequest {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  IsSubscribedToNewsletter: ").Append(IsSubscribedToNewsletter).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  AlertSettings: ").Append(AlertSettings).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  HourlyPayRate: ").Append(HourlyPayRate).Append("\n");
            sb.Append("  HourlyOvertimePayRate: ").Append(HourlyOvertimePayRate).Append("\n");
            sb.Append("  CurrentDate: ").Append(CurrentDate).Append("\n");
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
            return this.Equals(input as CSInsertUserRequest);
        }

        /// <summary>
        /// Returns true if CSInsertUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CSInsertUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CSInsertUserRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
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
                    this.IsSubscribedToNewsletter == input.IsSubscribedToNewsletter ||
                    (this.IsSubscribedToNewsletter != null &&
                    this.IsSubscribedToNewsletter.Equals(input.IsSubscribedToNewsletter))
                ) && 
                (
                    this.Roles == input.Roles ||
                    (this.Roles != null &&
                    this.Roles.Equals(input.Roles))
                ) && 
                (
                    this.AlertSettings == input.AlertSettings ||
                    (this.AlertSettings != null &&
                    this.AlertSettings.Equals(input.AlertSettings))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.HourlyPayRate == input.HourlyPayRate ||
                    (this.HourlyPayRate != null &&
                    this.HourlyPayRate.Equals(input.HourlyPayRate))
                ) && 
                (
                    this.HourlyOvertimePayRate == input.HourlyOvertimePayRate ||
                    (this.HourlyOvertimePayRate != null &&
                    this.HourlyOvertimePayRate.Equals(input.HourlyOvertimePayRate))
                ) && 
                (
                    this.CurrentDate == input.CurrentDate ||
                    (this.CurrentDate != null &&
                    this.CurrentDate.Equals(input.CurrentDate))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.IsSubscribedToNewsletter != null)
                    hashCode = hashCode * 59 + this.IsSubscribedToNewsletter.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.AlertSettings != null)
                    hashCode = hashCode * 59 + this.AlertSettings.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.HourlyPayRate != null)
                    hashCode = hashCode * 59 + this.HourlyPayRate.GetHashCode();
                if (this.HourlyOvertimePayRate != null)
                    hashCode = hashCode * 59 + this.HourlyOvertimePayRate.GetHashCode();
                if (this.CurrentDate != null)
                    hashCode = hashCode * 59 + this.CurrentDate.GetHashCode();
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
