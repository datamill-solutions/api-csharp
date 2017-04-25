# DataMill.Api.PhoneNumberApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckMobilePhone**](PhoneNumberApi.md#checkmobilephone) | **POST** /phone/mobile/check | Verify mobile phone number
[**FormatPhoneNumber**](PhoneNumberApi.md#formatphonenumber) | **POST** /phone/format | Parse, format and validate phone numbers
[**GetPhoneCountryCode**](PhoneNumberApi.md#getphonecountrycode) | **POST** /phone/countrycode/get | International and national dial prefix


<a name="checkmobilephone"></a>
# **CheckMobilePhone**
> PhoneMobileCheckResponse CheckMobilePhone (string license, string guid, string phonenumber, string countrycode)

Verify mobile phone number

Real time validation of mobile numbers without triggering a call of send a text message.

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class CheckMobilePhoneExample
    {
        public void main()
        {
            
            var apiInstance = new PhoneNumberApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var phonenumber = phonenumber_example;  // string | Mobile phone number to be verified.
            var countrycode = countrycode_example;  // string | ISO 3166-1 alpha-2 country code e.g. 'US'. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information.

            try
            {
                // Verify mobile phone number
                PhoneMobileCheckResponse result = apiInstance.CheckMobilePhone(license, guid, phonenumber, countrycode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneNumberApi.CheckMobilePhone: " + e.Message );
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
 **phonenumber** | **string**| Mobile phone number to be verified. | 
 **countrycode** | **string**| ISO 3166-1 alpha-2 country code e.g. &#39;US&#39;. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information. | 

### Return type

[**PhoneMobileCheckResponse**](PhoneMobileCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="formatphonenumber"></a>
# **FormatPhoneNumber**
> PhoneFormatResponse FormatPhoneNumber (string license, string guid, string phonenumber, string countrycode, string format = null, string directDialingDelimiter = null, string allowedDelimiters = null)

Parse, format and validate phone numbers

Validates a given phone number and converts it to the canonical form. In addition the type of the phone number is determined (e.g. \"fixed line\", \"mobile\", ...). The number is not checked for existence. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class FormatPhoneNumberExample
    {
        public void main()
        {
            
            var apiInstance = new PhoneNumberApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var phonenumber = phonenumber_example;  // string | Phone number to be formatted and validated
            var countrycode = countrycode_example;  // string | ISO 3166-1 alpha-2 country code e.g. 'US'. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information.
            var format = format_example;  // string | The custom format of the returning phone number if valid. The format is a combination of the following placeholders:  * **{countrycode}**: The international dial prefix for the country without leading zero or the \\\"+\\\" sign  * **{nationalcode}**: The regional dial prefix  * **{phonenumber}**: The phone number including the extension and without the international and regional prefix  * **{national_prefix}**: The national dial prefix including the leading zero  * **{international_prefix}**: The international dial prefix including leading zeros.  If no custom format is specified the following combination is used: **+{countrycode} {nationalcode} {phonenumber}** (canonical format)  (optional) 
            var directDialingDelimiter = directDialingDelimiter_example;  // string | Optional define a special character (e.g. -) as delimiter between the phone number and the extension. (optional) 
            var allowedDelimiters = allowedDelimiters_example;  // string | Optional collection of characters inside the specified phone number which are allowed for delimiter. The collection must be provided as **JSON** formatted string. (optional) 

            try
            {
                // Parse, format and validate phone numbers
                PhoneFormatResponse result = apiInstance.FormatPhoneNumber(license, guid, phonenumber, countrycode, format, directDialingDelimiter, allowedDelimiters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneNumberApi.FormatPhoneNumber: " + e.Message );
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
 **phonenumber** | **string**| Phone number to be formatted and validated | 
 **countrycode** | **string**| ISO 3166-1 alpha-2 country code e.g. &#39;US&#39;. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information. | 
 **format** | **string**| The custom format of the returning phone number if valid. The format is a combination of the following placeholders:  * **{countrycode}**: The international dial prefix for the country without leading zero or the \\\&quot;+\\\&quot; sign  * **{nationalcode}**: The regional dial prefix  * **{phonenumber}**: The phone number including the extension and without the international and regional prefix  * **{national_prefix}**: The national dial prefix including the leading zero  * **{international_prefix}**: The international dial prefix including leading zeros.  If no custom format is specified the following combination is used: **+{countrycode} {nationalcode} {phonenumber}** (canonical format)  | [optional] 
 **directDialingDelimiter** | **string**| Optional define a special character (e.g. -) as delimiter between the phone number and the extension. | [optional] 
 **allowedDelimiters** | **string**| Optional collection of characters inside the specified phone number which are allowed for delimiter. The collection must be provided as **JSON** formatted string. | [optional] 

### Return type

[**PhoneFormatResponse**](PhoneFormatResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getphonecountrycode"></a>
# **GetPhoneCountryCode**
> PhoneCountryCodeGetResponse GetPhoneCountryCode (string license, string guid, string countrycode)

International and national dial prefix

Resolves the national and international dial prefix for a country specified by the given ISO country code.

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class GetPhoneCountryCodeExample
    {
        public void main()
        {
            
            var apiInstance = new PhoneNumberApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var countrycode = countrycode_example;  // string | ISO 3166-1 alpha-2 country code e.g. 'US'. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information.

            try
            {
                // International and national dial prefix
                PhoneCountryCodeGetResponse result = apiInstance.GetPhoneCountryCode(license, guid, countrycode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneNumberApi.GetPhoneCountryCode: " + e.Message );
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
 **countrycode** | **string**| ISO 3166-1 alpha-2 country code e.g. &#39;US&#39;. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information. | 

### Return type

[**PhoneCountryCodeGetResponse**](PhoneCountryCodeGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

