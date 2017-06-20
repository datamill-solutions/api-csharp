# DataMill.Api.DataMillApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckBIC**](DataMillApi.md#checkbic) | **POST** /bic/check | Check BIC for spelling
[**CheckEmailDomain**](DataMillApi.md#checkemaildomain) | **POST** /email/domain/check | Check email syntax and mail server domain
[**CheckEmailMailbox**](DataMillApi.md#checkemailmailbox) | **POST** /email/extended/check | Check email syntax, mail server domain and mailbox itself
[**CheckEmailSyntax**](DataMillApi.md#checkemailsyntax) | **POST** /email/syntax/check | Check email syntax
[**CheckIBAN**](DataMillApi.md#checkiban) | **POST** /iban/check | Check IBAN for spelling
[**CheckMobilePhone**](DataMillApi.md#checkmobilephone) | **POST** /phone/mobile/check | Verify mobile phone number
[**CheckUrl**](DataMillApi.md#checkurl) | **POST** /url/check | Information about web resources
[**CheckVAT**](DataMillApi.md#checkvat) | **POST** /vat/check | Check vat number for correctness
[**ConvertCapitalFirst**](DataMillApi.md#convertcapitalfirst) | **POST** /convert/capitalfirst | Convert any string to capitalize words
[**ConvertLowerCase**](DataMillApi.md#convertlowercase) | **POST** /convert/lowercase | Convert any string to lower case
[**ConvertUpperCase**](DataMillApi.md#convertuppercase) | **POST** /convert/uppercase | Convert any string to upper case
[**ConvertWrap**](DataMillApi.md#convertwrap) | **POST** /convert/wrap | Wrap text
[**ExtractHouseNumber**](DataMillApi.md#extracthousenumber) | **POST** /address/housenumber/extract | Try to extract house number from street information
[**FormatPhoneNumber**](DataMillApi.md#formatphonenumber) | **POST** /phone/format | Parse, format and validate phone numbers
[**GetDUNSRating**](DataMillApi.md#getdunsrating) | **POST** /business-data/duns/rating | Get marketing information by DUNS number
[**GetFirstNames**](DataMillApi.md#getfirstnames) | **POST** /firstname/get | Recognize and extract first names
[**GetGender**](DataMillApi.md#getgender) | **POST** /gender/get | Recognize gender by first name
[**GetGenderExtended**](DataMillApi.md#getgenderextended) | **POST** /gender/extended/get | Recognize gender by first name (advanced)
[**GetPhoneCountryCode**](DataMillApi.md#getphonecountrycode) | **POST** /phone/countrycode/get | International and national dial prefix
[**GetPhoneticCode**](DataMillApi.md#getphoneticcode) | **POST** /phonetic/code/get | Calculate phonetic codes of a given text
[**GetSocialMediaActivities**](DataMillApi.md#getsocialmediaactivities) | **POST** /social-media/activities/get | Retrieve social media data by email address
[**LocateAddress**](DataMillApi.md#locateaddress) | **POST** /address/locate | Reverse address lookup
[**ResolveDUNS**](DataMillApi.md#resolveduns) | **POST** /business-data/duns/resolve | Resolve company information by DUNS number
[**ResolveVAT**](DataMillApi.md#resolvevat) | **POST** /vat/resolve | Try to resolve VAT number to company information
[**SearchAddress**](DataMillApi.md#searchaddress) | **POST** /address/search | Lookup physical postal address
[**SearchAddressMultiple**](DataMillApi.md#searchaddressmultiple) | **POST** /address/search/multiple | Address lookup with multiple possible results
[**SearchDUNS**](DataMillApi.md#searchduns) | **POST** /business-data/duns/search | Find DUNS number and company information by name
[**SearchUndeliverableContact**](DataMillApi.md#searchundeliverablecontact) | **POST** /business-data/undeliverable-contacts/search | Find moved and deceased contacts
[**SearchVAT**](DataMillApi.md#searchvat) | **POST** /vat/search | Find VAT number and company information by name


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

            var apiInstance = new DataMillApi();
            var bic = bic_example;  // string | BIC to be checked

            try
            {
                // Check BIC for spelling
                BicCheckResponse result = apiInstance.CheckBIC(bic);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.CheckBIC: " + e.Message );
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

<a name="checkemaildomain"></a>
# **CheckEmailDomain**
> EmailDomainCheckResponse CheckEmailDomain (string email)

Check email syntax and mail server domain

Checks the spelling of an email address to detect typos and spelling errors. In addition if the email address has a valid syntax its mail server is determined and checked for existence. The mail server itself will be compared with a list of disposable providers to detect addresses with a short lifetime. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class CheckEmailDomainExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var email = email_example;  // string | The email address to be checked

            try
            {
                // Check email syntax and mail server domain
                EmailDomainCheckResponse result = apiInstance.CheckEmailDomain(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.CheckEmailDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The email address to be checked | 

### Return type

[**EmailDomainCheckResponse**](EmailDomainCheckResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkemailmailbox"></a>
# **CheckEmailMailbox**
> EmailExtendedCheckResponse CheckEmailMailbox (string email)

Check email syntax, mail server domain and mailbox itself

Checks the spelling of an email address to detect typos and spelling errors. If the email address has a valid syntax its mail server is determined and checked for existence. The mail server itself will be compared with a list of disposable providers to detect addresses with a short lifetime. Additionally the mail server will be checked if an email for the given mailbox can be received. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class CheckEmailMailboxExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var email = email_example;  // string | The email address to be checked

            try
            {
                // Check email syntax, mail server domain and mailbox itself
                EmailExtendedCheckResponse result = apiInstance.CheckEmailMailbox(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.CheckEmailMailbox: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The email address to be checked | 

### Return type

[**EmailExtendedCheckResponse**](EmailExtendedCheckResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkemailsyntax"></a>
# **CheckEmailSyntax**
> EmailSyntaxCheckResponse CheckEmailSyntax (string email)

Check email syntax

Checks the spelling of an email address to detect typos and spelling errors. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class CheckEmailSyntaxExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var email = email_example;  // string | The email address to be checked

            try
            {
                // Check email syntax
                EmailSyntaxCheckResponse result = apiInstance.CheckEmailSyntax(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.CheckEmailSyntax: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The email address to be checked | 

### Return type

[**EmailSyntaxCheckResponse**](EmailSyntaxCheckResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkiban"></a>
# **CheckIBAN**
> IbanCheckResponse CheckIBAN (string iban)

Check IBAN for spelling

Checks the spelling, country code and checksum of an IBAN (International Bank Account Number). The IBAN is an internationally agreed system of identifying bank accounts across national borders. The function does not verify if the IBAN really exists, instead the format is checked for validity only. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class CheckIBANExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var iban = iban_example;  // string | IBAN to be checked.

            try
            {
                // Check IBAN for spelling
                IbanCheckResponse result = apiInstance.CheckIBAN(iban);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.CheckIBAN: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iban** | **string**| IBAN to be checked. | 

### Return type

[**IbanCheckResponse**](IbanCheckResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkmobilephone"></a>
# **CheckMobilePhone**
> PhoneMobileCheckResponse CheckMobilePhone (string phonenumber, string countrycode)

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
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var phonenumber = phonenumber_example;  // string | Mobile phone number to be verified.
            var countrycode = countrycode_example;  // string | ISO 3166-1 alpha-2 country code e.g. 'US'. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information.

            try
            {
                // Verify mobile phone number
                PhoneMobileCheckResponse result = apiInstance.CheckMobilePhone(phonenumber, countrycode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.CheckMobilePhone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phonenumber** | **string**| Mobile phone number to be verified. | 
 **countrycode** | **string**| ISO 3166-1 alpha-2 country code e.g. &#39;US&#39;. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information. | 

### Return type

[**PhoneMobileCheckResponse**](PhoneMobileCheckResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkurl"></a>
# **CheckUrl**
> UrlCheckResponse CheckUrl (string url, string maxRedirects = null)

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
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var url = url_example;  // string | The url to be checked (e.g. any website)
            var maxRedirects = maxRedirects_example;  // string | The maximum amount of redirects until the lookup for the root resource will be stopped (default **10**) (optional)  (default to 10)

            try
            {
                // Information about web resources
                UrlCheckResponse result = apiInstance.CheckUrl(url, maxRedirects);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.CheckUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | **string**| The url to be checked (e.g. any website) | 
 **maxRedirects** | **string**| The maximum amount of redirects until the lookup for the root resource will be stopped (default **10**) | [optional] [default to 10]

### Return type

[**UrlCheckResponse**](UrlCheckResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkvat"></a>
# **CheckVAT**
> VatCheckResponse CheckVAT (string vatnumber)

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
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var vatnumber = vatnumber_example;  // string | The VAT number of a company within the European Union

            try
            {
                // Check vat number for correctness
                VatCheckResponse result = apiInstance.CheckVAT(vatnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.CheckVAT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vatnumber** | **string**| The VAT number of a company within the European Union | 

### Return type

[**VatCheckResponse**](VatCheckResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertcapitalfirst"></a>
# **ConvertCapitalFirst**
> ConvertCapitalFirstResponse ConvertCapitalFirst (string text)

Convert any string to capitalize words

Changes any word of a given text so that the first letter is capitalized and all the others turned into lower case. Special proper names, like \"DiCaprio\" are detected and ignored. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class ConvertCapitalFirstExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var text = text_example;  // string | Free-form text to be converted.

            try
            {
                // Convert any string to capitalize words
                ConvertCapitalFirstResponse result = apiInstance.ConvertCapitalFirst(text);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.ConvertCapitalFirst: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Free-form text to be converted. | 

### Return type

[**ConvertCapitalFirstResponse**](ConvertCapitalFirstResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertlowercase"></a>
# **ConvertLowerCase**
> ConvertLowerCaseResponse ConvertLowerCase (string text)

Convert any string to lower case

Converts all letters of any word in a given string in the respective lowercase. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class ConvertLowerCaseExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var text = text_example;  // string | Free-form text to be converted.

            try
            {
                // Convert any string to lower case
                ConvertLowerCaseResponse result = apiInstance.ConvertLowerCase(text);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.ConvertLowerCase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Free-form text to be converted. | 

### Return type

[**ConvertLowerCaseResponse**](ConvertLowerCaseResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertuppercase"></a>
# **ConvertUpperCase**
> ConvertUpperCaseResponse ConvertUpperCase (string text)

Convert any string to upper case

Converts all letters of any word in a given string in the respective capital. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class ConvertUpperCaseExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var text = text_example;  // string | Free-form text to be converted.

            try
            {
                // Convert any string to upper case
                ConvertUpperCaseResponse result = apiInstance.ConvertUpperCase(text);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.ConvertUpperCase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Free-form text to be converted. | 

### Return type

[**ConvertUpperCaseResponse**](ConvertUpperCaseResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertwrap"></a>
# **ConvertWrap**
> ConvertWrapResponse ConvertWrap (string text, int? limit, string mode = null, string linebreak = null)

Wrap text

Breaks a text into multiple newlines. Each line will be separated by a \\r (CR, ASCII 13) and \\n (LF, ASCII 10) character. The number of characters a line break will be inserted after can be justified. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class ConvertWrapExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var text = text_example;  // string | Fre-form text to be wrapped.
            var limit = 56;  // int? | The number of characters a linefeed will be inserted after (maximum character length per line).
            var mode = mode_example;  // string | The mode how the linefeed will be inserted. Either before (default) the current word, after the current word or exactly after the character. Possible values are **before** to break before last word, **after** to break after last word, **exact** to break at limit.  (optional) 
            var linebreak = linebreak_example;  // string | Defines which line separator should be used. Possible values are **full** for *\\r\\n*, **single** for *\\n*, **html** for *&lt;br&gt;*  (optional) 

            try
            {
                // Wrap text
                ConvertWrapResponse result = apiInstance.ConvertWrap(text, limit, mode, linebreak);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.ConvertWrap: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| Fre-form text to be wrapped. | 
 **limit** | **int?**| The number of characters a linefeed will be inserted after (maximum character length per line). | 
 **mode** | **string**| The mode how the linefeed will be inserted. Either before (default) the current word, after the current word or exactly after the character. Possible values are **before** to break before last word, **after** to break after last word, **exact** to break at limit.  | [optional] 
 **linebreak** | **string**| Defines which line separator should be used. Possible values are **full** for *\\r\\n*, **single** for *\\n*, **html** for *&amp;lt;br&amp;gt;*  | [optional] 

### Return type

[**ConvertWrapResponse**](ConvertWrapResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extracthousenumber"></a>
# **ExtractHouseNumber**
> AddressHouseNumberExtractResponse ExtractHouseNumber (string street = null, string housenumber = null)

Try to extract house number from street information

Find and extract the house number based on partial address information. The result is an extracted street name, house number and additional house number information (e.g. Apartment, Floor, Room). It is necessary to provide street and housenumber, either in street field or separated in street and house number field. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class ExtractHouseNumberExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var street = street_example;  // string | Free-form text containing the street name and optional the house number including additional house number information. The key is required if housenumber is empty or unset. (optional) 
            var housenumber = housenumber_example;  // string | Free-form text containing the house number including additional house number information and optional the street name. The key is required if street is empty or unset. (optional) 

            try
            {
                // Try to extract house number from street information
                AddressHouseNumberExtractResponse result = apiInstance.ExtractHouseNumber(street, housenumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.ExtractHouseNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **street** | **string**| Free-form text containing the street name and optional the house number including additional house number information. The key is required if housenumber is empty or unset. | [optional] 
 **housenumber** | **string**| Free-form text containing the house number including additional house number information and optional the street name. The key is required if street is empty or unset. | [optional] 

### Return type

[**AddressHouseNumberExtractResponse**](AddressHouseNumberExtractResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="formatphonenumber"></a>
# **FormatPhoneNumber**
> PhoneFormatResponse FormatPhoneNumber (string phonenumber, string countrycode, string format = null, string directDialingDelimiter = null, string allowedDelimiters = null)

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
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var phonenumber = phonenumber_example;  // string | Phone number to be formatted and validated
            var countrycode = countrycode_example;  // string | ISO 3166-1 alpha-2 country code e.g. 'US'. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information.
            var format = format_example;  // string | The custom format of the returning phone number if valid. The format is a combination of the following placeholders:  * **{countrycode}**: The international dial prefix for the country without leading zero or the \\\"+\\\" sign  * **{nationalcode}**: The regional dial prefix  * **{phonenumber}**: The phone number including the extension and without the international and regional prefix  * **{national_prefix}**: The national dial prefix including the leading zero  * **{international_prefix}**: The international dial prefix including leading zeros.  If no custom format is specified the following combination is used: **+{countrycode} {nationalcode} {phonenumber}** (canonical format)  (optional) 
            var directDialingDelimiter = directDialingDelimiter_example;  // string | Optional define a special character (e.g. -) as delimiter between the phone number and the extension. (optional) 
            var allowedDelimiters = allowedDelimiters_example;  // string | Optional collection of characters inside the specified phone number which are allowed for delimiter. The collection must be provided as **JSON** formatted string. (optional) 

            try
            {
                // Parse, format and validate phone numbers
                PhoneFormatResponse result = apiInstance.FormatPhoneNumber(phonenumber, countrycode, format, directDialingDelimiter, allowedDelimiters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.FormatPhoneNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phonenumber** | **string**| Phone number to be formatted and validated | 
 **countrycode** | **string**| ISO 3166-1 alpha-2 country code e.g. &#39;US&#39;. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information. | 
 **format** | **string**| The custom format of the returning phone number if valid. The format is a combination of the following placeholders:  * **{countrycode}**: The international dial prefix for the country without leading zero or the \\\&quot;+\\\&quot; sign  * **{nationalcode}**: The regional dial prefix  * **{phonenumber}**: The phone number including the extension and without the international and regional prefix  * **{national_prefix}**: The national dial prefix including the leading zero  * **{international_prefix}**: The international dial prefix including leading zeros.  If no custom format is specified the following combination is used: **+{countrycode} {nationalcode} {phonenumber}** (canonical format)  | [optional] 
 **directDialingDelimiter** | **string**| Optional define a special character (e.g. -) as delimiter between the phone number and the extension. | [optional] 
 **allowedDelimiters** | **string**| Optional collection of characters inside the specified phone number which are allowed for delimiter. The collection must be provided as **JSON** formatted string. | [optional] 

### Return type

[**PhoneFormatResponse**](PhoneFormatResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdunsrating"></a>
# **GetDUNSRating**
> BusinessDataDunsRatingResponse GetDUNSRating (string dunsNumber, string reasonCode)

Get marketing information by DUNS number

Get marketing information about a company (credit rating, PAYDEX score, demographic information, ...) based on the company's D-U-N-S number. In order to get the marketing information each request requires a reason. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class GetDUNSRatingExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var dunsNumber = dunsNumber_example;  // string | The D-U-N-S number you are looking for detailed information
            var reasonCode = reasonCode_example;  // string | Unique code describing the reason why you like to get detailed information about the specified company. Possible codes are:  * **1**: Credit decisions  * **2**: Credit check (intended business connection)  * **3**: Credit check (ongoing business connection)  * **4**: Debt collections  * **5**: Commercial credit insurance  * **6**: Insurance contract  * **7**: Leasing agreement  * **8**: Rental agreement 

            try
            {
                // Get marketing information by DUNS number
                BusinessDataDunsRatingResponse result = apiInstance.GetDUNSRating(dunsNumber, reasonCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.GetDUNSRating: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dunsNumber** | **string**| The D-U-N-S number you are looking for detailed information | 
 **reasonCode** | **string**| Unique code describing the reason why you like to get detailed information about the specified company. Possible codes are:  * **1**: Credit decisions  * **2**: Credit check (intended business connection)  * **3**: Credit check (ongoing business connection)  * **4**: Debt collections  * **5**: Commercial credit insurance  * **6**: Insurance contract  * **7**: Leasing agreement  * **8**: Rental agreement  | 

### Return type

[**BusinessDataDunsRatingResponse**](BusinessDataDunsRatingResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

            var apiInstance = new DataMillApi();
            var name = name_example;  // string | Full name to detect all first names and extract them

            try
            {
                // Recognize and extract first names
                FirstNameGetResponse result = apiInstance.GetFirstNames(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.GetFirstNames: " + e.Message );
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

<a name="getgender"></a>
# **GetGender**
> GenderGetResponse GetGender (string firstname)

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
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var firstname = firstname_example;  // string | First name to recognize gender.

            try
            {
                // Recognize gender by first name
                GenderGetResponse result = apiInstance.GetGender(firstname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.GetGender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstname** | **string**| First name to recognize gender. | 

### Return type

[**GenderGetResponse**](GenderGetResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgenderextended"></a>
# **GetGenderExtended**
> GenderExtendedGetResponse GetGenderExtended (string firstname, string countrycode)

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
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var firstname = firstname_example;  // string | First name to recognize gender.
            var countrycode = countrycode_example;  // string | ISO 3166-1 alpha-2 country code e.g. 'US'. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information.

            try
            {
                // Recognize gender by first name (advanced)
                GenderExtendedGetResponse result = apiInstance.GetGenderExtended(firstname, countrycode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.GetGenderExtended: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstname** | **string**| First name to recognize gender. | 
 **countrycode** | **string**| ISO 3166-1 alpha-2 country code e.g. &#39;US&#39;. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information. | 

### Return type

[**GenderExtendedGetResponse**](GenderExtendedGetResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getphonecountrycode"></a>
# **GetPhoneCountryCode**
> PhoneCountryCodeGetResponse GetPhoneCountryCode (string countrycode)

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
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var countrycode = countrycode_example;  // string | ISO 3166-1 alpha-2 country code e.g. 'US'. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information.

            try
            {
                // International and national dial prefix
                PhoneCountryCodeGetResponse result = apiInstance.GetPhoneCountryCode(countrycode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.GetPhoneCountryCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countrycode** | **string**| ISO 3166-1 alpha-2 country code e.g. &#39;US&#39;. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information. | 

### Return type

[**PhoneCountryCodeGetResponse**](PhoneCountryCodeGetResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getphoneticcode"></a>
# **GetPhoneticCode**
> PhoneticCodeGetResponse GetPhoneticCode (string text, int? phoneticAlgorithm = null)

Calculate phonetic codes of a given text

Get the phonetic code of a given text. Currently three phonetic algorithms are available:  * **Soundex** (algorithm code 1)  * **Colcogne Phonetic** (algorithm code 2)  * **Metaphon** (algorithm code 3) 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class GetPhoneticCodeExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var text = text_example;  // string | The text which should be converted. Each word will be converted separatly and generate a single entry in the result. 
            var phoneticAlgorithm = 56;  // int? | The phonetic algorithm which should be applied. If no algorithm code will be provided **Soundex** will be used. Codes:  * 1 = Soundex  * 2 = Colcogne Phonetic  * 3 = Metaphon  (optional) 

            try
            {
                // Calculate phonetic codes of a given text
                PhoneticCodeGetResponse result = apiInstance.GetPhoneticCode(text, phoneticAlgorithm);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.GetPhoneticCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| The text which should be converted. Each word will be converted separatly and generate a single entry in the result.  | 
 **phoneticAlgorithm** | **int?**| The phonetic algorithm which should be applied. If no algorithm code will be provided **Soundex** will be used. Codes:  * 1 &#x3D; Soundex  * 2 &#x3D; Colcogne Phonetic  * 3 &#x3D; Metaphon  | [optional] 

### Return type

[**PhoneticCodeGetResponse**](PhoneticCodeGetResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsocialmediaactivities"></a>
# **GetSocialMediaActivities**
> SocialMediaActivitiesGetResponse GetSocialMediaActivities (string email)

Retrieve social media data by email address

Get the number of followers and account information of multiple social media platforms from individual email addresses. If the social media information for a specific email address aren't fetched yet the request will be queued and the data will be available within the next 12 hours. Please consider that the response of a social media platform may be empty because of restricted access (privacy setting of the person being checked). The following social media platforms are currently checked:  * **LinkedIn**  * **XING**  * **Facebook**  * **Twitter**  * **Pinterest**  * **Instagram**  * **Youtube**  * **Google Plus**  * **Klout** 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class GetSocialMediaActivitiesExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var email = email_example;  // string | The person's email address being checked on mentioned social media plattforms

            try
            {
                // Retrieve social media data by email address
                SocialMediaActivitiesGetResponse result = apiInstance.GetSocialMediaActivities(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.GetSocialMediaActivities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The person&#39;s email address being checked on mentioned social media plattforms | 

### Return type

[**SocialMediaActivitiesGetResponse**](SocialMediaActivitiesGetResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locateaddress"></a>
# **LocateAddress**
> AddressSearchResponse LocateAddress (string latitude, string longitude, string locale = null)

Reverse address lookup

Resolve an address corresponding to a given geo-coordinate. The result is a single record which matches the given latitude and longitude. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class LocateAddressExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var latitude = latitude_example;  // string | Latitude of the address (use a dot as decimal point)
            var longitude = longitude_example;  // string | Longitude of the address (use a dot as decimal point)
            var locale = locale_example;  // string | The preferred language of address elements in the result. The locale must be provided according to RFC 4647 standard (language code). (optional) 

            try
            {
                // Reverse address lookup
                AddressSearchResponse result = apiInstance.LocateAddress(latitude, longitude, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.LocateAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **latitude** | **string**| Latitude of the address (use a dot as decimal point) | 
 **longitude** | **string**| Longitude of the address (use a dot as decimal point) | 
 **locale** | **string**| The preferred language of address elements in the result. The locale must be provided according to RFC 4647 standard (language code). | [optional] 

### Return type

[**AddressSearchResponse**](AddressSearchResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolveduns"></a>
# **ResolveDUNS**
> BusinessDataDunsResolveResponse ResolveDUNS (string dunsNumber, string reasonCode)

Resolve company information by DUNS number

Resolves company information (official name, postal address, annual turnover, number of employees, ...) based on  the company's D-U-N-S number. In order to get the company information each request requires a reason. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class ResolveDUNSExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var dunsNumber = dunsNumber_example;  // string | The D-U-N-S number you are looking for detailed information
            var reasonCode = reasonCode_example;  // string | Unique code describing the reason why you like to get detailed information about the specified company. Possible codes are:  * **1**: Credit decisions  * **2**: Credit check (intended business connection)  * **3**: Credit check (ongoing business connection)  * **4**: Debt collections  * **5**: Commercial credit insurance  * **6**: Insurance contract  * **7**: Leasing agreement  * **8**: Rental agreement 

            try
            {
                // Resolve company information by DUNS number
                BusinessDataDunsResolveResponse result = apiInstance.ResolveDUNS(dunsNumber, reasonCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.ResolveDUNS: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dunsNumber** | **string**| The D-U-N-S number you are looking for detailed information | 
 **reasonCode** | **string**| Unique code describing the reason why you like to get detailed information about the specified company. Possible codes are:  * **1**: Credit decisions  * **2**: Credit check (intended business connection)  * **3**: Credit check (ongoing business connection)  * **4**: Debt collections  * **5**: Commercial credit insurance  * **6**: Insurance contract  * **7**: Leasing agreement  * **8**: Rental agreement  | 

### Return type

[**BusinessDataDunsResolveResponse**](BusinessDataDunsResolveResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolvevat"></a>
# **ResolveVAT**
> VatResolveResponse ResolveVAT (string vatnumber, string locale = null)

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
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var vatnumber = vatnumber_example;  // string | The VAT number of a company within the European Union
            var locale = locale_example;  // string | The preferred language of address elements in the result. The locale must be provided according to RFC 4647 standard (language code). (optional) 

            try
            {
                // Try to resolve VAT number to company information
                VatResolveResponse result = apiInstance.ResolveVAT(vatnumber, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.ResolveVAT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vatnumber** | **string**| The VAT number of a company within the European Union | 
 **locale** | **string**| The preferred language of address elements in the result. The locale must be provided according to RFC 4647 standard (language code). | [optional] 

### Return type

[**VatResolveResponse**](VatResolveResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchaddress"></a>
# **SearchAddress**
> AddressSearchResponse SearchAddress (string address = null, string country = null, string state = null, string county = null, string city = null, string zip = null, string district = null, string street = null, string housenumber = null, string locale = null)

Lookup physical postal address

Find geo-location based on unstructured (single-line entry, un-qualified) or based on structured (qualified) address information. The result is a single record which matches the given geo-location. The response depends on the data quality of the request. If the request contains too many typos the response keys may be empty.  The unstructured query determines each address part by its own and afterwards finds the closest geo-location. It should only be used if you do not know which address information fits in which query parameter. The structured query provides an additional logic for specific countries to improve the result of the determined geo-location. Please consider that if you do not provide a country name/code the result may end in a different country because the same city + street combination may exist in multiple countries. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class SearchAddressExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var address = address_example;  // string | Unstructured query parameter. Free-form text containing address elements (e.g. city, postal code, street, house number). Each element is separated using a whitespace. The order of the elements does not matter. You can specify the 'address' parameter by itself or you can specify it with other parameters to narrow your search.  (optional) 
            var country = country_example;  // string | Specify the country using the country code (ISO 3166-1 alpha-3) or the country name. (optional) 
            var state = state_example;  // string | First subdivision level below the country. Specify the state using full or abbreviated notation. (optional) 
            var county = county_example;  // string | Second subdivision level below the country. Depending on the admin hierarchy in a country this level might not be applicable. (optional) 
            var city = city_example;  // string | The city name. (optional) 
            var zip = zip_example;  // string | Postal code defined by the government of the country. (optional) 
            var district = district_example;  // string | Subdivision level below the city. Depending on the admin hierarchy in a country this level might not be applicable. (optional) 
            var street = street_example;  // string | The street name. (optional) 
            var housenumber = housenumber_example;  // string | The house number or building name. (optional) 
            var locale = locale_example;  // string | The preferred language of address elements in the result. The locale must be provided according to RFC 4647 standard (language code). (optional) 

            try
            {
                // Lookup physical postal address
                AddressSearchResponse result = apiInstance.SearchAddress(address, country, state, county, city, zip, district, street, housenumber, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.SearchAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Unstructured query parameter. Free-form text containing address elements (e.g. city, postal code, street, house number). Each element is separated using a whitespace. The order of the elements does not matter. You can specify the &#39;address&#39; parameter by itself or you can specify it with other parameters to narrow your search.  | [optional] 
 **country** | **string**| Specify the country using the country code (ISO 3166-1 alpha-3) or the country name. | [optional] 
 **state** | **string**| First subdivision level below the country. Specify the state using full or abbreviated notation. | [optional] 
 **county** | **string**| Second subdivision level below the country. Depending on the admin hierarchy in a country this level might not be applicable. | [optional] 
 **city** | **string**| The city name. | [optional] 
 **zip** | **string**| Postal code defined by the government of the country. | [optional] 
 **district** | **string**| Subdivision level below the city. Depending on the admin hierarchy in a country this level might not be applicable. | [optional] 
 **street** | **string**| The street name. | [optional] 
 **housenumber** | **string**| The house number or building name. | [optional] 
 **locale** | **string**| The preferred language of address elements in the result. The locale must be provided according to RFC 4647 standard (language code). | [optional] 

### Return type

[**AddressSearchResponse**](AddressSearchResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchaddressmultiple"></a>
# **SearchAddressMultiple**
> AddressSearchMultipleResponse SearchAddressMultiple (string address, string locale = null)

Address lookup with multiple possible results

Find multiple geo-locations based on unstructured (single-line entry, un-qualified) address information. The result is a set of records which matches the given geo-location. The response depends on the data quality of the request. If the request contains too many typo errors the response keys may be empty. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class SearchAddressMultipleExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var address = address_example;  // string | Free-form text containing address elements (e.g. city, postal code, street, house number). Each element is separated using a whitespace. The order of the elements does not matter.
            var locale = locale_example;  // string | The preferred language of address elements in the result. The locale must be provided according to RFC 4647 standard (language code). (optional) 

            try
            {
                // Address lookup with multiple possible results
                AddressSearchMultipleResponse result = apiInstance.SearchAddressMultiple(address, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.SearchAddressMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Free-form text containing address elements (e.g. city, postal code, street, house number). Each element is separated using a whitespace. The order of the elements does not matter. | 
 **locale** | **string**| The preferred language of address elements in the result. The locale must be provided according to RFC 4647 standard (language code). | [optional] 

### Return type

[**AddressSearchMultipleResponse**](AddressSearchMultipleResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchduns"></a>
# **SearchDUNS**
> BusinessDataDunsSearchResponse SearchDUNS (string countryCode, string companyName = null, string dunsNumber = null, string state = null, string city = null, string zip = null, string street = null)

Find DUNS number and company information by name

Finds the D-U-N-S number and additional company information by the company's name. Optionally a filter for the headquarters location can be added to get a more accurate response. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class SearchDUNSExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var countryCode = countryCode_example;  // string | ISO 3166-1 alpha-2 country code e.g. 'US'. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information.
            var companyName = companyName_example;  // string | The company name you are looking for or relevant parts of it (may be empty if the duns_number is set) (optional) 
            var dunsNumber = dunsNumber_example;  // string | The D-U-N-S number you are looking for detailed information (may be empty if the company_name and country_code are set) (optional) 
            var state = state_example;  // string | Filter to get only companies which matches the specified state (required for United States) (optional) 
            var city = city_example;  // string | Filter to get only companies which matches the specified city (optional) 
            var zip = zip_example;  // string | Filter to get only companies which matches the specified postal code (optional) 
            var street = street_example;  // string | Filter to get only companies which matches the specified street (optional) 

            try
            {
                // Find DUNS number and company information by name
                BusinessDataDunsSearchResponse result = apiInstance.SearchDUNS(countryCode, companyName, dunsNumber, state, city, zip, street);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.SearchDUNS: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCode** | **string**| ISO 3166-1 alpha-2 country code e.g. &#39;US&#39;. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information. | 
 **companyName** | **string**| The company name you are looking for or relevant parts of it (may be empty if the duns_number is set) | [optional] 
 **dunsNumber** | **string**| The D-U-N-S number you are looking for detailed information (may be empty if the company_name and country_code are set) | [optional] 
 **state** | **string**| Filter to get only companies which matches the specified state (required for United States) | [optional] 
 **city** | **string**| Filter to get only companies which matches the specified city | [optional] 
 **zip** | **string**| Filter to get only companies which matches the specified postal code | [optional] 
 **street** | **string**| Filter to get only companies which matches the specified street | [optional] 

### Return type

[**BusinessDataDunsSearchResponse**](BusinessDataDunsSearchResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchundeliverablecontact"></a>
# **SearchUndeliverableContact**
> BusinessDataUndeliverableContactsResponse SearchUndeliverableContact (string firstName, string lastName, string countryCode, string zip, string street, string reason)

Find moved and deceased contacts

Checks if the postal address of a person identified by its full name is invalid (moved to a new address or deceased). This function does NOT verify/check if a known postal address is still valid, instead it only checks if the person is moved to another address or is deceased and therefore a mail will result in an undeliverable state. 

### Example
```csharp
using System;
using System.Diagnostics;
using DataMill.Api;
using DataMill.Client;
using DataMill.Model;

namespace Example
{
    public class SearchUndeliverableContactExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var firstName = firstName_example;  // string | The person's first name
            var lastName = lastName_example;  // string | The person's last name
            var countryCode = countryCode_example;  // string | ISO 3166-1 alpha-2 country code e.g. 'US'. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information.
            var zip = zip_example;  // string | Last known postal code the person lives in
            var street = street_example;  // string | Last known street name the person lives in
            var reason = reason_example;  // string | Free-form text written in english why you submit the query.

            try
            {
                // Find moved and deceased contacts
                BusinessDataUndeliverableContactsResponse result = apiInstance.SearchUndeliverableContact(firstName, lastName, countryCode, zip, street, reason);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.SearchUndeliverableContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstName** | **string**| The person&#39;s first name | 
 **lastName** | **string**| The person&#39;s last name | 
 **countryCode** | **string**| ISO 3166-1 alpha-2 country code e.g. &#39;US&#39;. Please see https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2 for further information. | 
 **zip** | **string**| Last known postal code the person lives in | 
 **street** | **string**| Last known street name the person lives in | 
 **reason** | **string**| Free-form text written in english why you submit the query. | 

### Return type

[**BusinessDataUndeliverableContactsResponse**](BusinessDataUndeliverableContactsResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchvat"></a>
# **SearchVAT**
> VatSearchResponse SearchVAT (string company, string city = null, string countryCode = null, string limit = null, string minScore = null)

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
            
            // Configure HTTP basic authorization: APISecurity
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DataMillApi();
            var company = company_example;  // string | The name of an company. You may enter the fully qualified name or only partial information.
            var city = city_example;  // string | The city where the company's headquarters is located. (optional) 
            var countryCode = countryCode_example;  // string | ISO 3166-1 alpha-2 country code to specify in which country to look for. Possible countries are: **AT, BE, CZ, DK, FI, GB, GR, HU, IT, LU, MT, SI**  (optional) 
            var limit = limit_example;  // string | The maximum amount of results returned if multiple companies are found. Default value is **10**.  (optional)  (default to 10)
            var minScore = minScore_example;  // string | Threshold to set the minimum score rate of results being returned. Default: **0.8**  (optional)  (default to 0.8)

            try
            {
                // Find VAT number and company information by name
                VatSearchResponse result = apiInstance.SearchVAT(company, city, countryCode, limit, minScore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataMillApi.SearchVAT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **string**| The name of an company. You may enter the fully qualified name or only partial information. | 
 **city** | **string**| The city where the company&#39;s headquarters is located. | [optional] 
 **countryCode** | **string**| ISO 3166-1 alpha-2 country code to specify in which country to look for. Possible countries are: **AT, BE, CZ, DK, FI, GB, GR, HU, IT, LU, MT, SI**  | [optional] 
 **limit** | **string**| The maximum amount of results returned if multiple companies are found. Default value is **10**.  | [optional] [default to 10]
 **minScore** | **string**| Threshold to set the minimum score rate of results being returned. Default: **0.8**  | [optional] [default to 0.8]

### Return type

[**VatSearchResponse**](VatSearchResponse.md)

### Authorization

[APISecurity](../README.md#APISecurity)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

