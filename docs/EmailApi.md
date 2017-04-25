# DataMill.Api.EmailApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckEmailDomain**](EmailApi.md#checkemaildomain) | **POST** /email/domain/check | Check email syntax and mail server domain
[**CheckEmailMailbox**](EmailApi.md#checkemailmailbox) | **POST** /email/extended/check | Check email syntax, mail server domain and mailbox itself
[**CheckEmailSyntax**](EmailApi.md#checkemailsyntax) | **POST** /email/syntax/check | Check email syntax


<a name="checkemaildomain"></a>
# **CheckEmailDomain**
> EmailDomainCheckResponse CheckEmailDomain (string license, string guid, string email)

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
            
            var apiInstance = new EmailApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var email = email_example;  // string | The email address to be checked

            try
            {
                // Check email syntax and mail server domain
                EmailDomainCheckResponse result = apiInstance.CheckEmailDomain(license, guid, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.CheckEmailDomain: " + e.Message );
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
 **email** | **string**| The email address to be checked | 

### Return type

[**EmailDomainCheckResponse**](EmailDomainCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkemailmailbox"></a>
# **CheckEmailMailbox**
> EmailExtendedCheckResponse CheckEmailMailbox (string license, string guid, string email)

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
            
            var apiInstance = new EmailApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var email = email_example;  // string | The email address to be checked

            try
            {
                // Check email syntax, mail server domain and mailbox itself
                EmailExtendedCheckResponse result = apiInstance.CheckEmailMailbox(license, guid, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.CheckEmailMailbox: " + e.Message );
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
 **email** | **string**| The email address to be checked | 

### Return type

[**EmailExtendedCheckResponse**](EmailExtendedCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkemailsyntax"></a>
# **CheckEmailSyntax**
> EmailSyntaxCheckResponse CheckEmailSyntax (string license, string guid, string email)

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
            
            var apiInstance = new EmailApi();
            var license = license_example;  // string | The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var guid = guid_example;  // string | The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. 
            var email = email_example;  // string | The email address to be checked

            try
            {
                // Check email syntax
                EmailSyntaxCheckResponse result = apiInstance.CheckEmailSyntax(license, guid, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.CheckEmailSyntax: " + e.Message );
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
 **email** | **string**| The email address to be checked | 

### Return type

[**EmailSyntaxCheckResponse**](EmailSyntaxCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

