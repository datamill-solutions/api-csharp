# IO.Swagger.Api.FirstNameApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFirstNames**](FirstNameApi.md#getfirstnames) | **POST** /firstname/get | Recognize and extract first names


<a name="getfirstnames"></a>
# **GetFirstNames**
> FirstNameGetResponse GetFirstNames (string license, string guid, string name)

Recognize and extract first names

Detects all first names in a given sting (e.g. a person's name) and extracts them. (Works only with common first names in Germany, Austria and Switzerland) 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFirstNamesExample
    {
        public void main()
        {
            
            var apiInstance = new FirstNameApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var name = name_example;  // string | Full name to detect all first names and extract them

            try
            {
                // Recognize and extract first names
                FirstNameGetResponse result = apiInstance.GetFirstNames(license, guid, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirstNameApi.GetFirstNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **license** | **string**| The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request.  | 
 **guid** | **string**| The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request.  | 
 **name** | **string**| Full name to detect all first names and extract them | 

### Return type

[**FirstNameGetResponse**](FirstNameGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

