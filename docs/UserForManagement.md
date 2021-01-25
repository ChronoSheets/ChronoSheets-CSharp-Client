
# ChronoSheetsAPI.ChronoSheetsClientLibModel.UserForManagement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsAccountActive** | **bool** |  | [optional] 
**Id** | **int** | The ID of the user | [optional] 
**OrganisationId** | **int** | The ID of the organisation | [optional] 
**UserName** | **string** | The username of the user | [optional] 
**FirstName** | **string** | The first name of the user | [optional] 
**LastName** | **string** | The last name of the user | [optional] 
**EmailAddress** | **string** | The email address of the user | [optional] 
**Roles** | **long** | A BIT field designating which Roles/Permissions the employee will have when they sign in.  See the {timesheets.types.Enums.UserRoles} Enum for more details | [optional] 
**AlertSettings** | **long** | A BIT field designating which Alerts the employee will receive.  See the {timesheets.types.Enums.AlertSettings} Enum for more details | [optional] 
**SetupWizardRequired** | **bool** | Whether or not the setup wizard is required | [optional] 
**IsSubscribedToNewsletter** | **bool** | Whether or not the user is subscribed to the user | [optional] 
**Organisation** | [**Organisation**](Organisation.md) |  | [optional] 
**IsPrimaryAccount** | **bool** | Whether or not this account is the organisation&#39;s primary account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

