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
    /// OrgReportTrip
    /// </summary>
    [DataContract]
    public partial class OrgReportTrip :  IEquatable<OrgReportTrip>, IValidatableObject
    {
        /// <summary>
        /// Defines MobilePlatform
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MobilePlatformEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum IOS for value: iOS
            /// </summary>
            [EnumMember(Value = "iOS")]
            IOS = 2,

            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 3

        }

        /// <summary>
        /// Gets or Sets MobilePlatform
        /// </summary>
        [DataMember(Name="MobilePlatform", EmitDefaultValue=false)]
        public MobilePlatformEnum? MobilePlatform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgReportTrip" /> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="tripId">tripId.</param>
        /// <param name="timesheetId">timesheetId.</param>
        /// <param name="vehicleId">vehicleId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="orgId">orgId.</param>
        /// <param name="mobilePlatform">mobilePlatform.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="vehicleName">vehicleName.</param>
        /// <param name="vehicleMake">vehicleMake.</param>
        /// <param name="vehicleModel">vehicleModel.</param>
        /// <param name="vehicleYear">vehicleYear.</param>
        /// <param name="costPerKilometer">costPerKilometer.</param>
        /// <param name="tripTotalCost">tripTotalCost.</param>
        /// <param name="totalTripDistanceMeters">totalTripDistanceMeters.</param>
        /// <param name="startAddress">startAddress.</param>
        /// <param name="endAddress">endAddress.</param>
        /// <param name="pathCoordinates">pathCoordinates.</param>
        /// <param name="cacheExpiryDate">cacheExpiryDate.</param>
        public OrgReportTrip(string username = default(string), string emailAddress = default(string), string firstName = default(string), string lastName = default(string), int tripId = default(int), int timesheetId = default(int), int vehicleId = default(int), int userId = default(int), int orgId = default(int), MobilePlatformEnum? mobilePlatform = default(MobilePlatformEnum?), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), string vehicleName = default(string), string vehicleMake = default(string), string vehicleModel = default(string), string vehicleYear = default(string), double costPerKilometer = default(double), double tripTotalCost = default(double), double totalTripDistanceMeters = default(double), string startAddress = default(string), string endAddress = default(string), List<TripCoordinate> pathCoordinates = default(List<TripCoordinate>), DateTime cacheExpiryDate = default(DateTime))
        {
            this.Username = username;
            this.EmailAddress = emailAddress;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TripId = tripId;
            this.TimesheetId = timesheetId;
            this.VehicleId = vehicleId;
            this.UserId = userId;
            this.OrgId = orgId;
            this.MobilePlatform = mobilePlatform;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.VehicleName = vehicleName;
            this.VehicleMake = vehicleMake;
            this.VehicleModel = vehicleModel;
            this.VehicleYear = vehicleYear;
            this.CostPerKilometer = costPerKilometer;
            this.TripTotalCost = tripTotalCost;
            this.TotalTripDistanceMeters = totalTripDistanceMeters;
            this.StartAddress = startAddress;
            this.EndAddress = endAddress;
            this.PathCoordinates = pathCoordinates;
            this.CacheExpiryDate = cacheExpiryDate;
        }
        
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
        /// Gets or Sets TripId
        /// </summary>
        [DataMember(Name="TripId", EmitDefaultValue=false)]
        public int TripId { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetId
        /// </summary>
        [DataMember(Name="TimesheetId", EmitDefaultValue=false)]
        public int TimesheetId { get; set; }

        /// <summary>
        /// Gets or Sets VehicleId
        /// </summary>
        [DataMember(Name="VehicleId", EmitDefaultValue=false)]
        public int VehicleId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets OrgId
        /// </summary>
        [DataMember(Name="OrgId", EmitDefaultValue=false)]
        public int OrgId { get; set; }


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
        /// Gets or Sets VehicleName
        /// </summary>
        [DataMember(Name="VehicleName", EmitDefaultValue=false)]
        public string VehicleName { get; set; }

        /// <summary>
        /// Gets or Sets VehicleMake
        /// </summary>
        [DataMember(Name="VehicleMake", EmitDefaultValue=false)]
        public string VehicleMake { get; set; }

        /// <summary>
        /// Gets or Sets VehicleModel
        /// </summary>
        [DataMember(Name="VehicleModel", EmitDefaultValue=false)]
        public string VehicleModel { get; set; }

        /// <summary>
        /// Gets or Sets VehicleYear
        /// </summary>
        [DataMember(Name="VehicleYear", EmitDefaultValue=false)]
        public string VehicleYear { get; set; }

        /// <summary>
        /// Gets or Sets CostPerKilometer
        /// </summary>
        [DataMember(Name="CostPerKilometer", EmitDefaultValue=false)]
        public double CostPerKilometer { get; set; }

        /// <summary>
        /// Gets or Sets TripTotalCost
        /// </summary>
        [DataMember(Name="TripTotalCost", EmitDefaultValue=false)]
        public double TripTotalCost { get; set; }

        /// <summary>
        /// Gets or Sets TotalTripDistanceMeters
        /// </summary>
        [DataMember(Name="TotalTripDistanceMeters", EmitDefaultValue=false)]
        public double TotalTripDistanceMeters { get; set; }

        /// <summary>
        /// Gets or Sets StartAddress
        /// </summary>
        [DataMember(Name="StartAddress", EmitDefaultValue=false)]
        public string StartAddress { get; set; }

        /// <summary>
        /// Gets or Sets EndAddress
        /// </summary>
        [DataMember(Name="EndAddress", EmitDefaultValue=false)]
        public string EndAddress { get; set; }

        /// <summary>
        /// Gets or Sets PathCoordinates
        /// </summary>
        [DataMember(Name="PathCoordinates", EmitDefaultValue=false)]
        public List<TripCoordinate> PathCoordinates { get; set; }

        /// <summary>
        /// Gets or Sets CacheExpiryDate
        /// </summary>
        [DataMember(Name="CacheExpiryDate", EmitDefaultValue=false)]
        public DateTime CacheExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgReportTrip {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  TripId: ").Append(TripId).Append("\n");
            sb.Append("  TimesheetId: ").Append(TimesheetId).Append("\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  OrgId: ").Append(OrgId).Append("\n");
            sb.Append("  MobilePlatform: ").Append(MobilePlatform).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  VehicleName: ").Append(VehicleName).Append("\n");
            sb.Append("  VehicleMake: ").Append(VehicleMake).Append("\n");
            sb.Append("  VehicleModel: ").Append(VehicleModel).Append("\n");
            sb.Append("  VehicleYear: ").Append(VehicleYear).Append("\n");
            sb.Append("  CostPerKilometer: ").Append(CostPerKilometer).Append("\n");
            sb.Append("  TripTotalCost: ").Append(TripTotalCost).Append("\n");
            sb.Append("  TotalTripDistanceMeters: ").Append(TotalTripDistanceMeters).Append("\n");
            sb.Append("  StartAddress: ").Append(StartAddress).Append("\n");
            sb.Append("  EndAddress: ").Append(EndAddress).Append("\n");
            sb.Append("  PathCoordinates: ").Append(PathCoordinates).Append("\n");
            sb.Append("  CacheExpiryDate: ").Append(CacheExpiryDate).Append("\n");
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
            return this.Equals(input as OrgReportTrip);
        }

        /// <summary>
        /// Returns true if OrgReportTrip instances are equal
        /// </summary>
        /// <param name="input">Instance of OrgReportTrip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgReportTrip input)
        {
            if (input == null)
                return false;

            return 
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
                    this.TripId == input.TripId ||
                    (this.TripId != null &&
                    this.TripId.Equals(input.TripId))
                ) && 
                (
                    this.TimesheetId == input.TimesheetId ||
                    (this.TimesheetId != null &&
                    this.TimesheetId.Equals(input.TimesheetId))
                ) && 
                (
                    this.VehicleId == input.VehicleId ||
                    (this.VehicleId != null &&
                    this.VehicleId.Equals(input.VehicleId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.OrgId == input.OrgId ||
                    (this.OrgId != null &&
                    this.OrgId.Equals(input.OrgId))
                ) && 
                (
                    this.MobilePlatform == input.MobilePlatform ||
                    (this.MobilePlatform != null &&
                    this.MobilePlatform.Equals(input.MobilePlatform))
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
                    this.VehicleName == input.VehicleName ||
                    (this.VehicleName != null &&
                    this.VehicleName.Equals(input.VehicleName))
                ) && 
                (
                    this.VehicleMake == input.VehicleMake ||
                    (this.VehicleMake != null &&
                    this.VehicleMake.Equals(input.VehicleMake))
                ) && 
                (
                    this.VehicleModel == input.VehicleModel ||
                    (this.VehicleModel != null &&
                    this.VehicleModel.Equals(input.VehicleModel))
                ) && 
                (
                    this.VehicleYear == input.VehicleYear ||
                    (this.VehicleYear != null &&
                    this.VehicleYear.Equals(input.VehicleYear))
                ) && 
                (
                    this.CostPerKilometer == input.CostPerKilometer ||
                    (this.CostPerKilometer != null &&
                    this.CostPerKilometer.Equals(input.CostPerKilometer))
                ) && 
                (
                    this.TripTotalCost == input.TripTotalCost ||
                    (this.TripTotalCost != null &&
                    this.TripTotalCost.Equals(input.TripTotalCost))
                ) && 
                (
                    this.TotalTripDistanceMeters == input.TotalTripDistanceMeters ||
                    (this.TotalTripDistanceMeters != null &&
                    this.TotalTripDistanceMeters.Equals(input.TotalTripDistanceMeters))
                ) && 
                (
                    this.StartAddress == input.StartAddress ||
                    (this.StartAddress != null &&
                    this.StartAddress.Equals(input.StartAddress))
                ) && 
                (
                    this.EndAddress == input.EndAddress ||
                    (this.EndAddress != null &&
                    this.EndAddress.Equals(input.EndAddress))
                ) && 
                (
                    this.PathCoordinates == input.PathCoordinates ||
                    this.PathCoordinates != null &&
                    input.PathCoordinates != null &&
                    this.PathCoordinates.SequenceEqual(input.PathCoordinates)
                ) && 
                (
                    this.CacheExpiryDate == input.CacheExpiryDate ||
                    (this.CacheExpiryDate != null &&
                    this.CacheExpiryDate.Equals(input.CacheExpiryDate))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.TripId != null)
                    hashCode = hashCode * 59 + this.TripId.GetHashCode();
                if (this.TimesheetId != null)
                    hashCode = hashCode * 59 + this.TimesheetId.GetHashCode();
                if (this.VehicleId != null)
                    hashCode = hashCode * 59 + this.VehicleId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.OrgId != null)
                    hashCode = hashCode * 59 + this.OrgId.GetHashCode();
                if (this.MobilePlatform != null)
                    hashCode = hashCode * 59 + this.MobilePlatform.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.VehicleName != null)
                    hashCode = hashCode * 59 + this.VehicleName.GetHashCode();
                if (this.VehicleMake != null)
                    hashCode = hashCode * 59 + this.VehicleMake.GetHashCode();
                if (this.VehicleModel != null)
                    hashCode = hashCode * 59 + this.VehicleModel.GetHashCode();
                if (this.VehicleYear != null)
                    hashCode = hashCode * 59 + this.VehicleYear.GetHashCode();
                if (this.CostPerKilometer != null)
                    hashCode = hashCode * 59 + this.CostPerKilometer.GetHashCode();
                if (this.TripTotalCost != null)
                    hashCode = hashCode * 59 + this.TripTotalCost.GetHashCode();
                if (this.TotalTripDistanceMeters != null)
                    hashCode = hashCode * 59 + this.TotalTripDistanceMeters.GetHashCode();
                if (this.StartAddress != null)
                    hashCode = hashCode * 59 + this.StartAddress.GetHashCode();
                if (this.EndAddress != null)
                    hashCode = hashCode * 59 + this.EndAddress.GetHashCode();
                if (this.PathCoordinates != null)
                    hashCode = hashCode * 59 + this.PathCoordinates.GetHashCode();
                if (this.CacheExpiryDate != null)
                    hashCode = hashCode * 59 + this.CacheExpiryDate.GetHashCode();
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
