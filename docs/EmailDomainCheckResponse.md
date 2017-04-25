# IO.Swagger.Model.EmailDomainCheckResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Valid** | **string** | Flag if the email address is valid or not. &#39;0&#39; for invalid and &#39;1&#39; for valid email address. | 
**Description** | **string** | Error description if syntax or mail server are invalid. Empty value means no error. | 
**StatusCode** | **string** | Unique status code for each possible validation state. &#39;10&#39; for invalid syntax, &#39;20&#39; for missing MX record, &#39;21&#39; for disposable email and &#39;1&#39; for valid email address. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

