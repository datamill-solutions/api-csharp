# DataMill.Api.FirstNameApi

All URIs are relative to *https://api-beta.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFirstNames**](FirstNameApi.md#getfirstnames) | **POST** /firstname/get | Recognize and extract first names


<a name="getfirstnames"></a>
# **GetFirstNames**
> FirstNameGetResponse GetFirstNames (string name)

Recognize and extract first names

Detects all first names in a given sting (e.g. a person's name) and extracts them. (Works only with common first names in Germany, Austria and Switzerland) 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class GetFirstNamesExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new FirstNameApi();
            var name = name_example;  // string | Full name to detect all first names and extract them

            try
            {
                // Recognize and extract first names
                FirstNameGetResponse result = apiInstance.GetFirstNames(name);
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
 **name** | **string**| Full name to detect all first names and extract them | 

### Return type

[**FirstNameGetResponse**](FirstNameGetResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

