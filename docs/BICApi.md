# IO.Swagger.Api.BICApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckBIC**](BICApi.md#checkbic) | **POST** /bic/check | Check BIC for spelling


<a name="checkbic"></a>
# **CheckBIC**
> BicCheckResponse CheckBIC (string license, string guid, string bic)

Check BIC for spelling

Checks the spelling of a given BIC (Business Identifier Code), also known as SWIFT code which is defined in the ISO 9362. The function does not verify if the BIC really exists, instead the format is checked for validity only. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CheckBICExample
    {
        public void main()
        {
            
            var apiInstance = new BICApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var bic = bic_example;  // string | BIC to be checked

            try
            {
                // Check BIC for spelling
                BicCheckResponse result = apiInstance.CheckBIC(license, guid, bic);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BICApi.CheckBIC: " + e.Message );
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
 **bic** | **string**| BIC to be checked | 

### Return type

[**BicCheckResponse**](BicCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

