# IO.Swagger.Api.IBANApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckIBAN**](IBANApi.md#checkiban) | **POST** /iban/check | Check IBAN for spelling


<a name="checkiban"></a>
# **CheckIBAN**
> IbanCheckResponse CheckIBAN (string license, string guid, string iban)

Check IBAN for spelling

Checks the spelling, country code and checksum of an IBAN (International Bank Account Number). The IBAN is an internationally agreed system of identifying bank accounts across national borders. The function does not verify if the IBAN really exists, instead the format is checked for validity only. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CheckIBANExample
    {
        public void main()
        {
            
            var apiInstance = new IBANApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var iban = iban_example;  // string | IBAN to be checked.

            try
            {
                // Check IBAN for spelling
                IbanCheckResponse result = apiInstance.CheckIBAN(license, guid, iban);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IBANApi.CheckIBAN: " + e.Message );
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
 **iban** | **string**| IBAN to be checked. | 

### Return type

[**IbanCheckResponse**](IbanCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

