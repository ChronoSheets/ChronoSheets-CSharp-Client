
# ChronoSheetsAPI.ChronoSheetsClientLibModel.CreateGeoFenceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the geo fence | [optional] 
**FenceCoordinates** | [**List&lt;BasicCoordinate&gt;**](BasicCoordinate.md) | A list of coordinates specifying the geofence region | [optional] 
**TriggerJobCodeId** | **int** | The job code to be used when the person enters/leaves the geofence | [optional] 
**TriggerTaskId** | **int** | The task to be used when the person enters/leaves the geofence | [optional] 
**SendAlertToOrgGroupId** | **int** | Send an alert to a user, specified by their user ID | [optional] 
**AlertSettings** | **string** | Define when you want the alerts to be sent | [optional] 
**TriggerSettings** | **string** | Define how to you want to trigger the timesheet automation | [optional] 
**StartTimeHour** | **int** | The start hour in which this geofence should apply.  After this time, the geofence will be active. | [optional] 
**StartTimeMinute** | **int** | The start minute in which this geofence should apply.  After this time, the geofence will be active. | [optional] 
**EndTimeHour** | **int** | The end hour in which this geofence will stop applying.  After this time, the geofence will be inactive. | [optional] 
**EndTimeMinute** | **int** | The end minute in which this geofence will stop applying.  After this time, the geofence will be inactive. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

