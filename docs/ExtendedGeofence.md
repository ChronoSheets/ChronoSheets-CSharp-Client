
# ChronoSheetsAPI.ChronoSheetsClientLibModel.ExtendedGeofence

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobCode** | **string** | The Job code used when the employee enters/exits the geofence | [optional] 
**TaskName** | **string** | The name of the task used when the employee enters/exits the geofence | [optional] 
**CreatedBy** | **string** | The name of the employee who created the geofence | [optional] 
**UpdatedBy** | **string** | The name of the employee who last updated the geofence | [optional] 
**AlertOrganisation** | **string** | The name of the organisation group who will be notified when the geofence is triggered | [optional] 
**GeoFencingId** | **int** | The ID of the geofence | [optional] 
**OrgId** | **int** | The ID of the organisation owning the geofence record | [optional] 
**CreatedByUserId** | **int** | The ID of the user/employee who created the geofence | [optional] 
**LastUpdatedByUserId** | **int** | The ID of the user/employee who last updated the geofence | [optional] 
**Name** | **string** | A descriptive name of the geofence | [optional] 
**LocationName** | **string** | The name of the approx. location of the geofence | [optional] 
**Coordinates** | [**List&lt;BasicCoordinate&gt;**](BasicCoordinate.md) | A list of co-ordinates specifying the geofence | [optional] 
**CreatedAt** | **DateTime** | The date and time the geofence was created.  Time is in UTC. | [optional] 
**UpdatedAt** | **DateTime** | The date and time the geofence was updated last.  Time is in UTC. | [optional] 
**TriggerJobCodeId** | **int** | The ID of the job code used when the employee enters/exits the geofence | [optional] 
**TriggerTaskId** | **int** | The ID of the task used when the employee enters/exits the geofence | [optional] 
**TriggerSettings** | **string** | The settings for triggering actions | [optional] 
**AlertToOrgGroupId** | **int** | The organisation group that will be notified when the geofence is triggered | [optional] 
**AlertSettings** | **string** | The settings for trigger alerts | [optional] 
**StartTimeHour** | **int** | The hour start time. E.g. 13 would be 1pm.  Time is in 24hr format. | [optional] 
**StartTimeMinute** | **int** | The minute start time.  E.g. 46 would be the 46th minute of the hour. | [optional] 
**EndTimeHour** | **int** | The hour end time. E.g. 21 would be 9pm.  Time is in 24hr format. | [optional] 
**EndTimeMinute** | **int** | The minute end time.  E.g. 13 would be the 13th minute of the hour. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

