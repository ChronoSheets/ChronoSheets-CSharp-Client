# ChronoSheetsAPI.ChronoSheetsClientLibModel.CSInsertUserRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailAddress** | **string** | The Email Address of the employee | [optional] 
**FirstName** | **string** | The First Name of the employee | [optional] 
**LastName** | **string** | The Last Name of the employee | [optional] 
**IsSubscribedToNewsletter** | **bool?** | Whether or not the employee is subscribed to ChronoSheets newsletters | [optional] 
**Roles** | **long?** | A BIT field designating which Roles/Permissions the employee will have when they sign in.  See the {timesheets.types.Enums.UserRoles} Enum for more details | [optional] 
**AlertSettings** | **long?** | A BIT field designating which Alerts the employee will receive.  See the {timesheets.types.Enums.AlertSettings} Enum for more details | [optional] 
**UserName** | **string** | The UserName of the employee.  This can be used when logging into ChronoSheets | [optional] 
**HourlyPayRate** | **double?** | Set the starting usual Hourly Pay Rate with this value.  This is the Pay Rate the employee receives for working during Rostered Hours | [optional] 
**HourlyOvertimePayRate** | **double?** | Set the starting usual Overtime Hourly Pay Rate with this value.  This is the Pay Rate the employee receives for working outside of Rostered Hours | [optional] 
**CurrentDate** | **DateTime?** | The Current date time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

