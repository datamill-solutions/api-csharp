# DataMill.Api.ConvertApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConvertCapitalFirst**](ConvertApi.md#convertcapitalfirst) | **POST** /convert/capitalfirst | Convert any string to capitalize words
[**ConvertLowerCase**](ConvertApi.md#convertlowercase) | **POST** /convert/lowercase | Convert any string to lower case
[**ConvertUpperCase**](ConvertApi.md#convertuppercase) | **POST** /convert/uppercase | Convert any string to upper case
[**ConvertWrap**](ConvertApi.md#convertwrap) | **POST** /convert/wrap | Wrap text
[**GetPhoneticCode**](ConvertApi.md#getphoneticcode) | **POST** /phonetic/code/get | Calculate phonetic codes of a given text


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

            var apiInstance = new ConvertApi();
            var text = text_example;  // string | Free-form text to be converted.

            try
            {
                // Convert any string to capitalize words
                ConvertCapitalFirstResponse result = apiInstance.ConvertCapitalFirst(text);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertApi.ConvertCapitalFirst: " + e.Message );
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

            var apiInstance = new ConvertApi();
            var text = text_example;  // string | Free-form text to be converted.

            try
            {
                // Convert any string to lower case
                ConvertLowerCaseResponse result = apiInstance.ConvertLowerCase(text);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertApi.ConvertLowerCase: " + e.Message );
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

            var apiInstance = new ConvertApi();
            var text = text_example;  // string | Free-form text to be converted.

            try
            {
                // Convert any string to upper case
                ConvertUpperCaseResponse result = apiInstance.ConvertUpperCase(text);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertApi.ConvertUpperCase: " + e.Message );
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

            var apiInstance = new ConvertApi();
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
                Debug.Print("Exception when calling ConvertApi.ConvertWrap: " + e.Message );
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

            var apiInstance = new ConvertApi();
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
                Debug.Print("Exception when calling ConvertApi.GetPhoneticCode: " + e.Message );
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

