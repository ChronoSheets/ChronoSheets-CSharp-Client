
# ChronoSheetsAPI.ChronoSheetsClientLibModel.OrgReportTimesheetFileAttachment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Username** | **string** |  | [optional] 
**EmailAddress** | **string** |  | [optional] 
**FirstName** | **string** |  | [optional] 
**LastName** | **string** |  | [optional] 
**TimesheetId** | **int** | The ID of the timesheet this attachment is attached to. | [optional] 
**DocumentS3SignedUrl** | **string** | The limited use signed URL for the document (if it&#39;s not an image).  This URL is unique and will eventually expire.  If the attachment is an image, then this won&#39;t be set. | [optional] 
**ImageLargeS3SignedUrl** | **string** | The limited use signed URL for the large version of the image.  This URL is unique and will eventually expire.  Only set when the attachment is actually an image. | [optional] 
**ImageMediumS3SignedUrl** | **string** | The limited use signed URL for the medium version of the image.  This URL is unique and will eventually expire.  Only set when the attachment is actually an image. | [optional] 
**ImageSmallS3SignedUrl** | **string** | The limited use signed URL for the small version of the image.  This URL is unique and will eventually expire.  Only set when the attachment is actually an image. | [optional] 
**TimesheetStart** | **DateTime** | The start date and time of the timesheet that this attachment is attached to | [optional] 
**TimesheetEnd** | **DateTime** | The end date and time of the timesheet that this attachment is attached to | [optional] 
**FileAttachmentId** | **int** | The ID of the file attachment | [optional] 
**UserId** | **int** | The ID of the user who attached the file | [optional] 
**OrgId** | **int** | The ID of the organisation that owns the file and employs the employee | [optional] 
**MobilePlatform** | **string** | The mobile platform that was used to attach the file | [optional] 
**AttachmentType** | **string** | The type of file attachment | [optional] 
**Notes** | **string** | Any notes regarding the file attachment | [optional] 
**NonImageFilePath** | **string** | The path to the file attachment as hosted by ChronoSheets storage, if it&#39;s not an image.  If the attachment is an image then this won&#39;t be set. | [optional] 
**ImageLargeFilePath** | **string** | The path to the file attachment as hosted by ChronoSheets storage, only set if it&#39;s an image.  This is regarding the large version of the image. | [optional] 
**ImageMediumFilePath** | **string** | The path to the file attachment as hosted by ChronoSheets storage, only set if it&#39;s an image.  This is regarding the medium version of the image. | [optional] 
**ImageSmallFilePath** | **string** | The path to the file attachment as hosted by ChronoSheets storage, only set if it&#39;s an image.  This is regarding the small version of the image. | [optional] 
**OriginalFileName** | **string** | The original file name of the attachment | [optional] 
**Latitude** | **double** | Meta-data indicating the latitude of the file attachment.  If the attachment is an image, this data originates from the meta data inside the image file. | [optional] 
**Longitude** | **double** | Meta-data indicating the longitude of the file attachment.  If the attachment is an image, this data originates from the meta data inside the image file. | [optional] 
**DateUploaded** | **DateTime** | The date and time the attachment was uploaded.  Time is in UTC. | [optional] 
**DateImageCaptured** | **DateTime** | The original date and time the image was captured, if it was an image.  This data originates from the meta data inside the image file. | [optional] 
**StorageAllocationBytes** | **long** | The number of bytes allocated for storing the file attachment. | [optional] 
**AudioDurationSeconds** | **int** | If the attachment was an audio file, this field indicates the duration of the audio file in seconds.  This data originates from the meta data inside the audio file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

