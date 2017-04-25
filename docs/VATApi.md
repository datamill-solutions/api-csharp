# DataMill.Api.VATApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckVAT**](VATApi.md#checkvat) | **POST** /vat/check | Check vat number for correctness
[**ResolveVAT**](VATApi.md#resolvevat) | **POST** /vat/resolve | Try to resolve VAT number to company information
[**SearchVAT**](VATApi.md#searchvat) | **POST** /vat/search | Find VAT number and company information by name


<a name="checkvat"></a>
# **CheckVAT**
> VatCheckResponse CheckVAT (string license, string guid, string vatnumber)

Check vat number for correctness

Checks if a given VAT (Value Added Tax) identification number is valid or not. Only VAT numbers of companies within the European Union can be verified. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class CheckVATExample
    {
        public void main()
        {
            
            var apiInstance = new VATApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var vatnumber = vatnumber_example;  // string | The VAT number of a company within the European Union

            try
            {
                // Check vat number for correctness
                VatCheckResponse result = apiInstance.CheckVAT(license, guid, vatnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VATApi.CheckVAT: " + e.Message );
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
 **vatnumber** | **string**| The VAT number of a company within the European Union | 

### Return type

[**VatCheckResponse**](VatCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolvevat"></a>
# **ResolveVAT**
> VatResolveResponse ResolveVAT (string license, string guid, string vatnumber, string locale = null)

Try to resolve VAT number to company information

Resolves company information (company name and postal address) based on the company's VAT (Value Added Tax) identification number. Only VAT numbers of companies within the European Union can be verified and resolved. Some countries have access restrictions and may not deliver the full company information. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class ResolveVATExample
    {
        public void main()
        {
            
            var apiInstance = new VATApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var vatnumber = vatnumber_example;  // string | The VAT number of a company within the European Union
            var locale = locale_example;  // string | The preferred language of address elements in the result. The locale must be provided according to RFC 4647 standard (language code). (optional) 

            try
            {
                // Try to resolve VAT number to company information
                VatResolveResponse result = apiInstance.ResolveVAT(license, guid, vatnumber, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VATApi.ResolveVAT: " + e.Message );
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
 **vatnumber** | **string**| The VAT number of a company within the European Union | 
 **locale** | **string**| The preferred language of address elements in the result. The locale must be provided according to RFC 4647 standard (language code). | [optional] 

### Return type

[**VatResolveResponse**](VatResolveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchvat"></a>
# **SearchVAT**
> VatSearchResponse SearchVAT (string license, string guid, string company, string city = null, string countryCode = null, string limit = null, string minScore = null)

Find VAT number and company information by name

Finds the VAT number and additional company information by the company's name and headquarters location. The function returns multiple results if similar companies are found in the same city. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class SearchVATExample
    {
        public void main()
        {
            
            var apiInstance = new VATApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var company = company_example;  // string | The name of an company. You may enter the fully qualified name or only partial information.
            var city = city_example;  // string | The city where the company's headquarters is located. (optional) 
            var countryCode = countryCode_example;  // string | ISO 3166-1 alpha-2 country code to specify in which country to look for. Possible countries are: **AT, BE, CZ, DK, FI, GB, GR, HU, IT, LU, MT, SI**  (optional) 
            var limit = limit_example;  // string | The maximum amount of results returned if multiple companies are found. Default value is **10**.  (optional)  (default to 10)
            var minScore = minScore_example;  // string | Threshold to set the minimum score rate of results being returned. Default: **0.8**  (optional)  (default to 0.8)

            try
            {
                // Find VAT number and company information by name
                VatSearchResponse result = apiInstance.SearchVAT(license, guid, company, city, countryCode, limit, minScore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VATApi.SearchVAT: " + e.Message );
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
 **company** | **string**| The name of an company. You may enter the fully qualified name or only partial information. | 
 **city** | **string**| The city where the company&#39;s headquarters is located. | [optional] 
 **countryCode** | **string**| ISO 3166-1 alpha-2 country code to specify in which country to look for. Possible countries are: **AT, BE, CZ, DK, FI, GB, GR, HU, IT, LU, MT, SI**  | [optional] 
 **limit** | **string**| The maximum amount of results returned if multiple companies are found. Default value is **10**.  | [optional] [default to 10]
 **minScore** | **string**| Threshold to set the minimum score rate of results being returned. Default: **0.8**  | [optional] [default to 0.8]

### Return type

[**VatSearchResponse**](VatSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

