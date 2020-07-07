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
    /// OrgReportTranscript
    /// </summary>
    [DataContract]
    public partial class OrgReportTranscript :  IEquatable<OrgReportTranscript>, IValidatableObject
    {
        /// <summary>
        /// Defines MediaType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 1,

            /// <summary>
            /// Enum Mp3 for value: Mp3
            /// </summary>
            [EnumMember(Value = "Mp3")]
            Mp3 = 2,

            /// <summary>
            /// Enum Mp4 for value: Mp4
            /// </summary>
            [EnumMember(Value = "Mp4")]
            Mp4 = 3,

            /// <summary>
            /// Enum Wav for value: Wav
            /// </summary>
            [EnumMember(Value = "Wav")]
            Wav = 4,

            /// <summary>
            /// Enum Flac for value: Flac
            /// </summary>
            [EnumMember(Value = "Flac")]
            Flac = 5

        }

        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="MediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Defines TranscriptionStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TranscriptionStatusEnum
        {
            /// <summary>
            /// Enum Saved for value: Saved
            /// </summary>
            [EnumMember(Value = "Saved")]
            Saved = 1,

            /// <summary>
            /// Enum Processing for value: Processing
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing = 2,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 3,

            /// <summary>
            /// Enum FailedWithError for value: FailedWithError
            /// </summary>
            [EnumMember(Value = "FailedWithError")]
            FailedWithError = 4

        }

        /// <summary>
        /// Gets or Sets TranscriptionStatus
        /// </summary>
        [DataMember(Name="TranscriptionStatus", EmitDefaultValue=false)]
        public TranscriptionStatusEnum? TranscriptionStatus { get; set; }
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
        /// Defines AttachmentType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AttachmentTypeEnum
        {
            /// <summary>
            /// Enum Image for value: Image
            /// </summary>
            [EnumMember(Value = "Image")]
            Image = 1,

            /// <summary>
            /// Enum WordDoc for value: WordDoc
            /// </summary>
            [EnumMember(Value = "WordDoc")]
            WordDoc = 2,

            /// <summary>
            /// Enum Pdf for value: Pdf
            /// </summary>
            [EnumMember(Value = "Pdf")]
            Pdf = 3,

            /// <summary>
            /// Enum MSSpreadSheet for value: MSSpreadSheet
            /// </summary>
            [EnumMember(Value = "MSSpreadSheet")]
            MSSpreadSheet = 4,

            /// <summary>
            /// Enum MSPowerPoint for value: MSPowerPoint
            /// </summary>
            [EnumMember(Value = "MSPowerPoint")]
            MSPowerPoint = 5,

            /// <summary>
            /// Enum RichTextFormat for value: RichTextFormat
            /// </summary>
            [EnumMember(Value = "RichTextFormat")]
            RichTextFormat = 6,

            /// <summary>
            /// Enum ZipFile for value: ZipFile
            /// </summary>
            [EnumMember(Value = "ZipFile")]
            ZipFile = 7,

            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 8,

            /// <summary>
            /// Enum Audio for value: Audio
            /// </summary>
            [EnumMember(Value = "Audio")]
            Audio = 9

        }

        /// <summary>
        /// Gets or Sets AttachmentType
        /// </summary>
        [DataMember(Name="AttachmentType", EmitDefaultValue=false)]
        public AttachmentTypeEnum? AttachmentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgReportTranscript" /> class.
        /// </summary>
        /// <param name="finishedJob">finishedJob.</param>
        /// <param name="completedProcessing">completedProcessing.</param>
        /// <param name="created">created.</param>
        /// <param name="startedProcessing">startedProcessing.</param>
        /// <param name="transcriptionId">transcriptionId.</param>
        /// <param name="jobName">jobName.</param>
        /// <param name="contents">contents.</param>
        /// <param name="mediaType">mediaType.</param>
        /// <param name="transcriptionStatus">transcriptionStatus.</param>
        /// <param name="username">username.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="timesheetId">timesheetId.</param>
        /// <param name="documentS3SignedUrl">documentS3SignedUrl.</param>
        /// <param name="imageLargeS3SignedUrl">imageLargeS3SignedUrl.</param>
        /// <param name="imageMediumS3SignedUrl">imageMediumS3SignedUrl.</param>
        /// <param name="imageSmallS3SignedUrl">imageSmallS3SignedUrl.</param>
        /// <param name="timesheetStart">timesheetStart.</param>
        /// <param name="timesheetEnd">timesheetEnd.</param>
        /// <param name="fileAttachmentId">fileAttachmentId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="orgId">orgId.</param>
        /// <param name="mobilePlatform">mobilePlatform.</param>
        /// <param name="attachmentType">attachmentType.</param>
        /// <param name="notes">notes.</param>
        /// <param name="nonImageFilePath">nonImageFilePath.</param>
        /// <param name="imageLargeFilePath">imageLargeFilePath.</param>
        /// <param name="imageMediumFilePath">imageMediumFilePath.</param>
        /// <param name="imageSmallFilePath">imageSmallFilePath.</param>
        /// <param name="originalFileName">originalFileName.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="dateUploaded">dateUploaded.</param>
        /// <param name="dateImageCaptured">dateImageCaptured.</param>
        /// <param name="storageAllocationBytes">storageAllocationBytes.</param>
        /// <param name="audioDurationSeconds">audioDurationSeconds.</param>
        public OrgReportTranscript(bool finishedJob = default(bool), DateTime completedProcessing = default(DateTime), DateTime created = default(DateTime), DateTime startedProcessing = default(DateTime), int transcriptionId = default(int), string jobName = default(string), string contents = default(string), MediaTypeEnum? mediaType = default(MediaTypeEnum?), TranscriptionStatusEnum? transcriptionStatus = default(TranscriptionStatusEnum?), string username = default(string), string emailAddress = default(string), string firstName = default(string), string lastName = default(string), int timesheetId = default(int), string documentS3SignedUrl = default(string), string imageLargeS3SignedUrl = default(string), string imageMediumS3SignedUrl = default(string), string imageSmallS3SignedUrl = default(string), DateTime timesheetStart = default(DateTime), DateTime timesheetEnd = default(DateTime), int fileAttachmentId = default(int), int userId = default(int), int orgId = default(int), MobilePlatformEnum? mobilePlatform = default(MobilePlatformEnum?), AttachmentTypeEnum? attachmentType = default(AttachmentTypeEnum?), string notes = default(string), string nonImageFilePath = default(string), string imageLargeFilePath = default(string), string imageMediumFilePath = default(string), string imageSmallFilePath = default(string), string originalFileName = default(string), double latitude = default(double), double longitude = default(double), DateTime dateUploaded = default(DateTime), DateTime dateImageCaptured = default(DateTime), long storageAllocationBytes = default(long), int audioDurationSeconds = default(int))
        {
            this.FinishedJob = finishedJob;
            this.CompletedProcessing = completedProcessing;
            this.Created = created;
            this.StartedProcessing = startedProcessing;
            this.TranscriptionId = transcriptionId;
            this.JobName = jobName;
            this.Contents = contents;
            this.MediaType = mediaType;
            this.TranscriptionStatus = transcriptionStatus;
            this.Username = username;
            this.EmailAddress = emailAddress;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TimesheetId = timesheetId;
            this.DocumentS3SignedUrl = documentS3SignedUrl;
            this.ImageLargeS3SignedUrl = imageLargeS3SignedUrl;
            this.ImageMediumS3SignedUrl = imageMediumS3SignedUrl;
            this.ImageSmallS3SignedUrl = imageSmallS3SignedUrl;
            this.TimesheetStart = timesheetStart;
            this.TimesheetEnd = timesheetEnd;
            this.FileAttachmentId = fileAttachmentId;
            this.UserId = userId;
            this.OrgId = orgId;
            this.MobilePlatform = mobilePlatform;
            this.AttachmentType = attachmentType;
            this.Notes = notes;
            this.NonImageFilePath = nonImageFilePath;
            this.ImageLargeFilePath = imageLargeFilePath;
            this.ImageMediumFilePath = imageMediumFilePath;
            this.ImageSmallFilePath = imageSmallFilePath;
            this.OriginalFileName = originalFileName;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.DateUploaded = dateUploaded;
            this.DateImageCaptured = dateImageCaptured;
            this.StorageAllocationBytes = storageAllocationBytes;
            this.AudioDurationSeconds = audioDurationSeconds;
        }
        
        /// <summary>
        /// Gets or Sets FinishedJob
        /// </summary>
        [DataMember(Name="FinishedJob", EmitDefaultValue=false)]
        public bool FinishedJob { get; set; }

        /// <summary>
        /// Gets or Sets CompletedProcessing
        /// </summary>
        [DataMember(Name="CompletedProcessing", EmitDefaultValue=false)]
        public DateTime CompletedProcessing { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="Created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets StartedProcessing
        /// </summary>
        [DataMember(Name="StartedProcessing", EmitDefaultValue=false)]
        public DateTime StartedProcessing { get; set; }

        /// <summary>
        /// Gets or Sets TranscriptionId
        /// </summary>
        [DataMember(Name="TranscriptionId", EmitDefaultValue=false)]
        public int TranscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets JobName
        /// </summary>
        [DataMember(Name="JobName", EmitDefaultValue=false)]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [DataMember(Name="Contents", EmitDefaultValue=false)]
        public string Contents { get; set; }



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
        /// Gets or Sets TimesheetId
        /// </summary>
        [DataMember(Name="TimesheetId", EmitDefaultValue=false)]
        public int TimesheetId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentS3SignedUrl
        /// </summary>
        [DataMember(Name="DocumentS3SignedUrl", EmitDefaultValue=false)]
        public string DocumentS3SignedUrl { get; set; }

        /// <summary>
        /// Gets or Sets ImageLargeS3SignedUrl
        /// </summary>
        [DataMember(Name="ImageLargeS3SignedUrl", EmitDefaultValue=false)]
        public string ImageLargeS3SignedUrl { get; set; }

        /// <summary>
        /// Gets or Sets ImageMediumS3SignedUrl
        /// </summary>
        [DataMember(Name="ImageMediumS3SignedUrl", EmitDefaultValue=false)]
        public string ImageMediumS3SignedUrl { get; set; }

        /// <summary>
        /// Gets or Sets ImageSmallS3SignedUrl
        /// </summary>
        [DataMember(Name="ImageSmallS3SignedUrl", EmitDefaultValue=false)]
        public string ImageSmallS3SignedUrl { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetStart
        /// </summary>
        [DataMember(Name="TimesheetStart", EmitDefaultValue=false)]
        public DateTime TimesheetStart { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetEnd
        /// </summary>
        [DataMember(Name="TimesheetEnd", EmitDefaultValue=false)]
        public DateTime TimesheetEnd { get; set; }

        /// <summary>
        /// Gets or Sets FileAttachmentId
        /// </summary>
        [DataMember(Name="FileAttachmentId", EmitDefaultValue=false)]
        public int FileAttachmentId { get; set; }

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
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="Notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets NonImageFilePath
        /// </summary>
        [DataMember(Name="NonImageFilePath", EmitDefaultValue=false)]
        public string NonImageFilePath { get; set; }

        /// <summary>
        /// Gets or Sets ImageLargeFilePath
        /// </summary>
        [DataMember(Name="ImageLargeFilePath", EmitDefaultValue=false)]
        public string ImageLargeFilePath { get; set; }

        /// <summary>
        /// Gets or Sets ImageMediumFilePath
        /// </summary>
        [DataMember(Name="ImageMediumFilePath", EmitDefaultValue=false)]
        public string ImageMediumFilePath { get; set; }

        /// <summary>
        /// Gets or Sets ImageSmallFilePath
        /// </summary>
        [DataMember(Name="ImageSmallFilePath", EmitDefaultValue=false)]
        public string ImageSmallFilePath { get; set; }

        /// <summary>
        /// Gets or Sets OriginalFileName
        /// </summary>
        [DataMember(Name="OriginalFileName", EmitDefaultValue=false)]
        public string OriginalFileName { get; set; }

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
        /// Gets or Sets DateUploaded
        /// </summary>
        [DataMember(Name="DateUploaded", EmitDefaultValue=false)]
        public DateTime DateUploaded { get; set; }

        /// <summary>
        /// Gets or Sets DateImageCaptured
        /// </summary>
        [DataMember(Name="DateImageCaptured", EmitDefaultValue=false)]
        public DateTime DateImageCaptured { get; set; }

        /// <summary>
        /// Gets or Sets StorageAllocationBytes
        /// </summary>
        [DataMember(Name="StorageAllocationBytes", EmitDefaultValue=false)]
        public long StorageAllocationBytes { get; set; }

        /// <summary>
        /// Gets or Sets AudioDurationSeconds
        /// </summary>
        [DataMember(Name="AudioDurationSeconds", EmitDefaultValue=false)]
        public int AudioDurationSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgReportTranscript {\n");
            sb.Append("  FinishedJob: ").Append(FinishedJob).Append("\n");
            sb.Append("  CompletedProcessing: ").Append(CompletedProcessing).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  StartedProcessing: ").Append(StartedProcessing).Append("\n");
            sb.Append("  TranscriptionId: ").Append(TranscriptionId).Append("\n");
            sb.Append("  JobName: ").Append(JobName).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  TranscriptionStatus: ").Append(TranscriptionStatus).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  TimesheetId: ").Append(TimesheetId).Append("\n");
            sb.Append("  DocumentS3SignedUrl: ").Append(DocumentS3SignedUrl).Append("\n");
            sb.Append("  ImageLargeS3SignedUrl: ").Append(ImageLargeS3SignedUrl).Append("\n");
            sb.Append("  ImageMediumS3SignedUrl: ").Append(ImageMediumS3SignedUrl).Append("\n");
            sb.Append("  ImageSmallS3SignedUrl: ").Append(ImageSmallS3SignedUrl).Append("\n");
            sb.Append("  TimesheetStart: ").Append(TimesheetStart).Append("\n");
            sb.Append("  TimesheetEnd: ").Append(TimesheetEnd).Append("\n");
            sb.Append("  FileAttachmentId: ").Append(FileAttachmentId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  OrgId: ").Append(OrgId).Append("\n");
            sb.Append("  MobilePlatform: ").Append(MobilePlatform).Append("\n");
            sb.Append("  AttachmentType: ").Append(AttachmentType).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  NonImageFilePath: ").Append(NonImageFilePath).Append("\n");
            sb.Append("  ImageLargeFilePath: ").Append(ImageLargeFilePath).Append("\n");
            sb.Append("  ImageMediumFilePath: ").Append(ImageMediumFilePath).Append("\n");
            sb.Append("  ImageSmallFilePath: ").Append(ImageSmallFilePath).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  DateUploaded: ").Append(DateUploaded).Append("\n");
            sb.Append("  DateImageCaptured: ").Append(DateImageCaptured).Append("\n");
            sb.Append("  StorageAllocationBytes: ").Append(StorageAllocationBytes).Append("\n");
            sb.Append("  AudioDurationSeconds: ").Append(AudioDurationSeconds).Append("\n");
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
            return this.Equals(input as OrgReportTranscript);
        }

        /// <summary>
        /// Returns true if OrgReportTranscript instances are equal
        /// </summary>
        /// <param name="input">Instance of OrgReportTranscript to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgReportTranscript input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FinishedJob == input.FinishedJob ||
                    (this.FinishedJob != null &&
                    this.FinishedJob.Equals(input.FinishedJob))
                ) && 
                (
                    this.CompletedProcessing == input.CompletedProcessing ||
                    (this.CompletedProcessing != null &&
                    this.CompletedProcessing.Equals(input.CompletedProcessing))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.StartedProcessing == input.StartedProcessing ||
                    (this.StartedProcessing != null &&
                    this.StartedProcessing.Equals(input.StartedProcessing))
                ) && 
                (
                    this.TranscriptionId == input.TranscriptionId ||
                    (this.TranscriptionId != null &&
                    this.TranscriptionId.Equals(input.TranscriptionId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.Contents == input.Contents ||
                    (this.Contents != null &&
                    this.Contents.Equals(input.Contents))
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
                ) && 
                (
                    this.TranscriptionStatus == input.TranscriptionStatus ||
                    (this.TranscriptionStatus != null &&
                    this.TranscriptionStatus.Equals(input.TranscriptionStatus))
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
                    this.TimesheetId == input.TimesheetId ||
                    (this.TimesheetId != null &&
                    this.TimesheetId.Equals(input.TimesheetId))
                ) && 
                (
                    this.DocumentS3SignedUrl == input.DocumentS3SignedUrl ||
                    (this.DocumentS3SignedUrl != null &&
                    this.DocumentS3SignedUrl.Equals(input.DocumentS3SignedUrl))
                ) && 
                (
                    this.ImageLargeS3SignedUrl == input.ImageLargeS3SignedUrl ||
                    (this.ImageLargeS3SignedUrl != null &&
                    this.ImageLargeS3SignedUrl.Equals(input.ImageLargeS3SignedUrl))
                ) && 
                (
                    this.ImageMediumS3SignedUrl == input.ImageMediumS3SignedUrl ||
                    (this.ImageMediumS3SignedUrl != null &&
                    this.ImageMediumS3SignedUrl.Equals(input.ImageMediumS3SignedUrl))
                ) && 
                (
                    this.ImageSmallS3SignedUrl == input.ImageSmallS3SignedUrl ||
                    (this.ImageSmallS3SignedUrl != null &&
                    this.ImageSmallS3SignedUrl.Equals(input.ImageSmallS3SignedUrl))
                ) && 
                (
                    this.TimesheetStart == input.TimesheetStart ||
                    (this.TimesheetStart != null &&
                    this.TimesheetStart.Equals(input.TimesheetStart))
                ) && 
                (
                    this.TimesheetEnd == input.TimesheetEnd ||
                    (this.TimesheetEnd != null &&
                    this.TimesheetEnd.Equals(input.TimesheetEnd))
                ) && 
                (
                    this.FileAttachmentId == input.FileAttachmentId ||
                    (this.FileAttachmentId != null &&
                    this.FileAttachmentId.Equals(input.FileAttachmentId))
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
                    this.AttachmentType == input.AttachmentType ||
                    (this.AttachmentType != null &&
                    this.AttachmentType.Equals(input.AttachmentType))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.NonImageFilePath == input.NonImageFilePath ||
                    (this.NonImageFilePath != null &&
                    this.NonImageFilePath.Equals(input.NonImageFilePath))
                ) && 
                (
                    this.ImageLargeFilePath == input.ImageLargeFilePath ||
                    (this.ImageLargeFilePath != null &&
                    this.ImageLargeFilePath.Equals(input.ImageLargeFilePath))
                ) && 
                (
                    this.ImageMediumFilePath == input.ImageMediumFilePath ||
                    (this.ImageMediumFilePath != null &&
                    this.ImageMediumFilePath.Equals(input.ImageMediumFilePath))
                ) && 
                (
                    this.ImageSmallFilePath == input.ImageSmallFilePath ||
                    (this.ImageSmallFilePath != null &&
                    this.ImageSmallFilePath.Equals(input.ImageSmallFilePath))
                ) && 
                (
                    this.OriginalFileName == input.OriginalFileName ||
                    (this.OriginalFileName != null &&
                    this.OriginalFileName.Equals(input.OriginalFileName))
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
                    this.DateUploaded == input.DateUploaded ||
                    (this.DateUploaded != null &&
                    this.DateUploaded.Equals(input.DateUploaded))
                ) && 
                (
                    this.DateImageCaptured == input.DateImageCaptured ||
                    (this.DateImageCaptured != null &&
                    this.DateImageCaptured.Equals(input.DateImageCaptured))
                ) && 
                (
                    this.StorageAllocationBytes == input.StorageAllocationBytes ||
                    (this.StorageAllocationBytes != null &&
                    this.StorageAllocationBytes.Equals(input.StorageAllocationBytes))
                ) && 
                (
                    this.AudioDurationSeconds == input.AudioDurationSeconds ||
                    (this.AudioDurationSeconds != null &&
                    this.AudioDurationSeconds.Equals(input.AudioDurationSeconds))
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
                if (this.FinishedJob != null)
                    hashCode = hashCode * 59 + this.FinishedJob.GetHashCode();
                if (this.CompletedProcessing != null)
                    hashCode = hashCode * 59 + this.CompletedProcessing.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.StartedProcessing != null)
                    hashCode = hashCode * 59 + this.StartedProcessing.GetHashCode();
                if (this.TranscriptionId != null)
                    hashCode = hashCode * 59 + this.TranscriptionId.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.Contents != null)
                    hashCode = hashCode * 59 + this.Contents.GetHashCode();
                if (this.MediaType != null)
                    hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.TranscriptionStatus != null)
                    hashCode = hashCode * 59 + this.TranscriptionStatus.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.TimesheetId != null)
                    hashCode = hashCode * 59 + this.TimesheetId.GetHashCode();
                if (this.DocumentS3SignedUrl != null)
                    hashCode = hashCode * 59 + this.DocumentS3SignedUrl.GetHashCode();
                if (this.ImageLargeS3SignedUrl != null)
                    hashCode = hashCode * 59 + this.ImageLargeS3SignedUrl.GetHashCode();
                if (this.ImageMediumS3SignedUrl != null)
                    hashCode = hashCode * 59 + this.ImageMediumS3SignedUrl.GetHashCode();
                if (this.ImageSmallS3SignedUrl != null)
                    hashCode = hashCode * 59 + this.ImageSmallS3SignedUrl.GetHashCode();
                if (this.TimesheetStart != null)
                    hashCode = hashCode * 59 + this.TimesheetStart.GetHashCode();
                if (this.TimesheetEnd != null)
                    hashCode = hashCode * 59 + this.TimesheetEnd.GetHashCode();
                if (this.FileAttachmentId != null)
                    hashCode = hashCode * 59 + this.FileAttachmentId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.OrgId != null)
                    hashCode = hashCode * 59 + this.OrgId.GetHashCode();
                if (this.MobilePlatform != null)
                    hashCode = hashCode * 59 + this.MobilePlatform.GetHashCode();
                if (this.AttachmentType != null)
                    hashCode = hashCode * 59 + this.AttachmentType.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.NonImageFilePath != null)
                    hashCode = hashCode * 59 + this.NonImageFilePath.GetHashCode();
                if (this.ImageLargeFilePath != null)
                    hashCode = hashCode * 59 + this.ImageLargeFilePath.GetHashCode();
                if (this.ImageMediumFilePath != null)
                    hashCode = hashCode * 59 + this.ImageMediumFilePath.GetHashCode();
                if (this.ImageSmallFilePath != null)
                    hashCode = hashCode * 59 + this.ImageSmallFilePath.GetHashCode();
                if (this.OriginalFileName != null)
                    hashCode = hashCode * 59 + this.OriginalFileName.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.DateUploaded != null)
                    hashCode = hashCode * 59 + this.DateUploaded.GetHashCode();
                if (this.DateImageCaptured != null)
                    hashCode = hashCode * 59 + this.DateImageCaptured.GetHashCode();
                if (this.StorageAllocationBytes != null)
                    hashCode = hashCode * 59 + this.StorageAllocationBytes.GetHashCode();
                if (this.AudioDurationSeconds != null)
                    hashCode = hashCode * 59 + this.AudioDurationSeconds.GetHashCode();
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