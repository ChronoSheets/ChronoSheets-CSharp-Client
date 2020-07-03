
# ChronoSheetsAPI.ChronoSheetsClientLibModel.AggregateJobCode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AvailableTasks** | [**List&lt;AggregateJobTask&gt;**](AggregateJobTask.md) | The list of available tasks under this job code | [optional] 
**PermittedEmployees** | **List&lt;int&gt;** | The list of employee IDs that are permitted to record timesheets with this job code (empty means everyone) | [optional] 
**Id** | **int** | The ID of the job code (not the code itself) | [optional] 
**Code** | **string** | The job code itself | [optional] 
**_Client** | **string** | The name of the client | [optional] 
**ClientId** | **int** | The ID of the client | [optional] 
**Project** | **string** | The name of the project | [optional] 
**ProjectId** | **int** | The ID of the project | [optional] 
**OrganisationId** | **int** | Your organisation ID | [optional] 
**IsDeleted** | **bool** | A flag indicating whether or not the job code has been marked as deleted | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

