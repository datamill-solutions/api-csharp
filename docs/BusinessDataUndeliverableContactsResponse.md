# DataMill.Model.BusinessDataUndeliverableContactsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Undeliverable** | **string** | Flag if sending a mail would result in an undeliverable state [**0**, **1**] | 
**Deceased** | **string** | Flag if the person is deceased [**0**, **1**] | 
**Moved** | **string** | Flag if the person has moved to a new address but we do not know the new address [**0**, **1**] | 
**NewAddressAvailable** | **string** | Flag if the person has moved to a new address and we know the new address [**0**, **1**] | 
**Contact** | [**BusinessDataUndeliverableContactsSearchContact**](BusinessDataUndeliverableContactsSearchContact.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

