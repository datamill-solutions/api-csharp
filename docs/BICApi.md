# DataMill.Api.BICApi

All URIs are relative to *https://api-beta.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckBIC**](BICApi.md#checkbic) | **POST** /bic/check | Check BIC for spelling


<a name="checkbic"></a>
# **CheckBIC**
> BicCheckResponse CheckBIC (string bic)

Check BIC for spelling

Checks the spelling of a given BIC (Business Identifier Code), also known as SWIFT code which is defined in the ISO 9362. The function does not verify if the BIC really exists, instead the format is checked for validity only. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class CheckBICExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BICApi();
            var bic = bic_example;  // string | BIC to be checked

            try
            {
                // Check BIC for spelling
                BicCheckResponse result = apiInstance.CheckBIC(bic);
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
 **bic** | **string**| BIC to be checked | 

### Return type

[**BicCheckResponse**](BicCheckResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

