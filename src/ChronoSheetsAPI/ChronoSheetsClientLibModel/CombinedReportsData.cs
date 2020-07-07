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
    /// CombinedReportsData
    /// </summary>
    [DataContract]
    public partial class CombinedReportsData :  IEquatable<CombinedReportsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedReportsData" /> class.
        /// </summary>
        /// <param name="seriesJobCodes">seriesJobCodes.</param>
        /// <param name="seriesTasks">seriesTasks.</param>
        /// <param name="seriesClients">seriesClients.</param>
        /// <param name="seriesProjects">seriesProjects.</param>
        /// <param name="totalsJobCodes">totalsJobCodes.</param>
        /// <param name="totalsTasks">totalsTasks.</param>
        /// <param name="totalsClients">totalsClients.</param>
        /// <param name="totalsProjects">totalsProjects.</param>
        public CombinedReportsData(List<JobSeriesReportItem> seriesJobCodes = default(List<JobSeriesReportItem>), List<TaskSeriesReportItem> seriesTasks = default(List<TaskSeriesReportItem>), List<ClientSeriesReportItem> seriesClients = default(List<ClientSeriesReportItem>), List<ProjectSeriesReportItem> seriesProjects = default(List<ProjectSeriesReportItem>), List<JobTotalsReportItem> totalsJobCodes = default(List<JobTotalsReportItem>), List<TaskTotalsReportItem> totalsTasks = default(List<TaskTotalsReportItem>), List<ClientTotalsReportItem> totalsClients = default(List<ClientTotalsReportItem>), List<ProjectTotalsReportItem> totalsProjects = default(List<ProjectTotalsReportItem>))
        {
            this.SeriesJobCodes = seriesJobCodes;
            this.SeriesTasks = seriesTasks;
            this.SeriesClients = seriesClients;
            this.SeriesProjects = seriesProjects;
            this.TotalsJobCodes = totalsJobCodes;
            this.TotalsTasks = totalsTasks;
            this.TotalsClients = totalsClients;
            this.TotalsProjects = totalsProjects;
        }
        
        /// <summary>
        /// Gets or Sets SeriesJobCodes
        /// </summary>
        [DataMember(Name="SeriesJobCodes", EmitDefaultValue=false)]
        public List<JobSeriesReportItem> SeriesJobCodes { get; set; }

        /// <summary>
        /// Gets or Sets SeriesTasks
        /// </summary>
        [DataMember(Name="SeriesTasks", EmitDefaultValue=false)]
        public List<TaskSeriesReportItem> SeriesTasks { get; set; }

        /// <summary>
        /// Gets or Sets SeriesClients
        /// </summary>
        [DataMember(Name="SeriesClients", EmitDefaultValue=false)]
        public List<ClientSeriesReportItem> SeriesClients { get; set; }

        /// <summary>
        /// Gets or Sets SeriesProjects
        /// </summary>
        [DataMember(Name="SeriesProjects", EmitDefaultValue=false)]
        public List<ProjectSeriesReportItem> SeriesProjects { get; set; }

        /// <summary>
        /// Gets or Sets TotalsJobCodes
        /// </summary>
        [DataMember(Name="TotalsJobCodes", EmitDefaultValue=false)]
        public List<JobTotalsReportItem> TotalsJobCodes { get; set; }

        /// <summary>
        /// Gets or Sets TotalsTasks
        /// </summary>
        [DataMember(Name="TotalsTasks", EmitDefaultValue=false)]
        public List<TaskTotalsReportItem> TotalsTasks { get; set; }

        /// <summary>
        /// Gets or Sets TotalsClients
        /// </summary>
        [DataMember(Name="TotalsClients", EmitDefaultValue=false)]
        public List<ClientTotalsReportItem> TotalsClients { get; set; }

        /// <summary>
        /// Gets or Sets TotalsProjects
        /// </summary>
        [DataMember(Name="TotalsProjects", EmitDefaultValue=false)]
        public List<ProjectTotalsReportItem> TotalsProjects { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CombinedReportsData {\n");
            sb.Append("  SeriesJobCodes: ").Append(SeriesJobCodes).Append("\n");
            sb.Append("  SeriesTasks: ").Append(SeriesTasks).Append("\n");
            sb.Append("  SeriesClients: ").Append(SeriesClients).Append("\n");
            sb.Append("  SeriesProjects: ").Append(SeriesProjects).Append("\n");
            sb.Append("  TotalsJobCodes: ").Append(TotalsJobCodes).Append("\n");
            sb.Append("  TotalsTasks: ").Append(TotalsTasks).Append("\n");
            sb.Append("  TotalsClients: ").Append(TotalsClients).Append("\n");
            sb.Append("  TotalsProjects: ").Append(TotalsProjects).Append("\n");
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
            return this.Equals(input as CombinedReportsData);
        }

        /// <summary>
        /// Returns true if CombinedReportsData instances are equal
        /// </summary>
        /// <param name="input">Instance of CombinedReportsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CombinedReportsData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SeriesJobCodes == input.SeriesJobCodes ||
                    this.SeriesJobCodes != null &&
                    input.SeriesJobCodes != null &&
                    this.SeriesJobCodes.SequenceEqual(input.SeriesJobCodes)
                ) && 
                (
                    this.SeriesTasks == input.SeriesTasks ||
                    this.SeriesTasks != null &&
                    input.SeriesTasks != null &&
                    this.SeriesTasks.SequenceEqual(input.SeriesTasks)
                ) && 
                (
                    this.SeriesClients == input.SeriesClients ||
                    this.SeriesClients != null &&
                    input.SeriesClients != null &&
                    this.SeriesClients.SequenceEqual(input.SeriesClients)
                ) && 
                (
                    this.SeriesProjects == input.SeriesProjects ||
                    this.SeriesProjects != null &&
                    input.SeriesProjects != null &&
                    this.SeriesProjects.SequenceEqual(input.SeriesProjects)
                ) && 
                (
                    this.TotalsJobCodes == input.TotalsJobCodes ||
                    this.TotalsJobCodes != null &&
                    input.TotalsJobCodes != null &&
                    this.TotalsJobCodes.SequenceEqual(input.TotalsJobCodes)
                ) && 
                (
                    this.TotalsTasks == input.TotalsTasks ||
                    this.TotalsTasks != null &&
                    input.TotalsTasks != null &&
                    this.TotalsTasks.SequenceEqual(input.TotalsTasks)
                ) && 
                (
                    this.TotalsClients == input.TotalsClients ||
                    this.TotalsClients != null &&
                    input.TotalsClients != null &&
                    this.TotalsClients.SequenceEqual(input.TotalsClients)
                ) && 
                (
                    this.TotalsProjects == input.TotalsProjects ||
                    this.TotalsProjects != null &&
                    input.TotalsProjects != null &&
                    this.TotalsProjects.SequenceEqual(input.TotalsProjects)
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
                if (this.SeriesJobCodes != null)
                    hashCode = hashCode * 59 + this.SeriesJobCodes.GetHashCode();
                if (this.SeriesTasks != null)
                    hashCode = hashCode * 59 + this.SeriesTasks.GetHashCode();
                if (this.SeriesClients != null)
                    hashCode = hashCode * 59 + this.SeriesClients.GetHashCode();
                if (this.SeriesProjects != null)
                    hashCode = hashCode * 59 + this.SeriesProjects.GetHashCode();
                if (this.TotalsJobCodes != null)
                    hashCode = hashCode * 59 + this.TotalsJobCodes.GetHashCode();
                if (this.TotalsTasks != null)
                    hashCode = hashCode * 59 + this.TotalsTasks.GetHashCode();
                if (this.TotalsClients != null)
                    hashCode = hashCode * 59 + this.TotalsClients.GetHashCode();
                if (this.TotalsProjects != null)
                    hashCode = hashCode * 59 + this.TotalsProjects.GetHashCode();
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