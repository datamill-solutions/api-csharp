# DataMill.Api.URLApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckUrl**](URLApi.md#checkurl) | **POST** /url/check | Information about web resources


<a name="checkurl"></a>
# **CheckUrl**
> UrlCheckResponse CheckUrl (string license, string guid, string url, string maxRedirects = null)

Information about web resources

Fetches the resource of a given url and checks if it is available. Only websites using HTTP/HTTPS are allowed. IP addresses and ports other than 80/443 are not permitted and will be ignored. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class CheckUrlExample
    {
        public void main()
        {
            
            var apiInstance = new URLApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var url = url_example;  // string | The url to be checked (e.g. any website)
            var maxRedirects = maxRedirects_example;  // string | The maximum amount of redirects until the lookup for the root resource will be stopped (default **10**) (optional)  (default to 10)

            try
            {
                // Information about web resources
                UrlCheckResponse result = apiInstance.CheckUrl(license, guid, url, maxRedirects);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling URLApi.CheckUrl: " + e.Message );
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
 **url** | **string**| The url to be checked (e.g. any website) | 
 **maxRedirects** | **string**| The maximum amount of redirects until the lookup for the root resource will be stopped (default **10**) | [optional] [default to 10]

### Return type

[**UrlCheckResponse**](UrlCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

