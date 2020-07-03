
# ChronoSheetsAPI.ChronoSheetsClientLibModel.UpdateUserRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **int** | The Id of the User that is to be updated | [optional] 
**EmailAddress** | **string** | The Email Address of the employee | [optional] 
**FirstName** | **string** | The First Name of the employee | [optional] 
**LastName** | **string** | The Last Name of the employee | [optional] 
**IsSubscribedToNewsletter** | **bool** | Whether or not the employee is subscribed to ChronoSheets newsletters | [optional] 
**IsAccountActive** | **bool** | Whether or not the employee account is active | [optional] 
**Roles** | **long** | A BIT field designating which Roles/Permissions the employee will have when they sign in.  See the {timesheets.types.Enums.UserRoles} Enum for more details | [optional] 
**AlertSettings** | **long** | A BIT field designating which Alerts the employee will receive.  See the {timesheets.types.Enums.AlertSettings} Enum for more details | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

