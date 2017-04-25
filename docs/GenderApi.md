# DataMill.Api.GenderApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGender**](GenderApi.md#getgender) | **POST** /gender/get | Recognize gender by first name
[**GetGenderExtended**](GenderApi.md#getgenderextended) | **POST** /gender/extended/get | Recognize gender by first name (advanced)


<a name="getgender"></a>
# **GetGender**
> GenderGetResponse GetGender (string license, string guid, string firstname)

Recognize gender by first name

Recognizes the gender of a given first name. (Works only with common first names in Germany, Austria and Switzerland) 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class GetGenderExample
    {
        public void main()
        {
            
            var apiInstance = new GenderApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var firstname = firstname_example;  // string | First name to recognize gender.

            try
            {
                // Recognize gender by first name
                GenderGetResponse result = apiInstance.GetGender(license, guid, firstname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GenderApi.GetGender: " + e.Message );
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
 **firstname** | **string**| First name to recognize gender. | 

### Return type

[**GenderGetResponse**](GenderGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgenderextended"></a>
# **GetGenderExtended**
> GenderExtendedGetResponse GetGenderExtended (string license, string guid, string firstname, string countrycode)

Recognize gender by first name (advanced)

Recognizes the gender of a given first name considering country specific peculiarities.

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class GetGenderExtendedExample
    {
        public void main()
        {
            
            var apiInstance = new GenderApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var firstname = firstname_example;  // string | First name to recognize gender.
            var countrycode = countrycode_example;  // string | ISO 3166-1 alpha-2 country code e.g. 'US'. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information.

            try
            {
                // Recognize gender by first name (advanced)
                GenderExtendedGetResponse result = apiInstance.GetGenderExtended(license, guid, firstname, countrycode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GenderApi.GetGenderExtended: " + e.Message );
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
 **firstname** | **string**| First name to recognize gender. | 
 **countrycode** | **string**| ISO 3166-1 alpha-2 country code e.g. &#39;US&#39;. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information. | 

### Return type

[**GenderExtendedGetResponse**](GenderExtendedGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

