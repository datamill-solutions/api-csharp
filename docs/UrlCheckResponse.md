# DataMill.Model.UrlCheckResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Valid** | **long?** | Flag if the root resource (website) is valid or not [0, 1] | 
**Url** | **string** | The final url of the resource | 
**HttpCode** | **long?** | The HTTP status code according to https://en.wikipedia.org/wiki/List_of_HTTP_status_codes | 
**TotalTime** | **float?** | Total time of the request in seconds | 
**NamelookupTime** | **float?** | Time until host name resolved in seconds | 
**ConnectTime** | **float?** | Time until connection established in seconds | 
**PretransferTime** | **float?** | Time until file transfer began in seconds | 
**StarttransferTime** | **float?** | Time to first byte in seconds | 
**PrimaryIp** | **string** | IP address of the most recent connection | 
**PrimaryPort** | **long?** | Destination port of the connection | 
**DownloadContentLength** | **long?** | Number of bytes to download from the resource (-1 means no information available; will be removed in future versions / deprecated) | 
**ContentType** | **string** | Content type of the requested resource | 
**Redirects** | **List&lt;Object&gt;** | Array collection of all urls including redirects | 
**Parameters** | **List&lt;Object&gt;** | Array collection of all url parameters | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

