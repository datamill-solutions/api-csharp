# DataMill.Api.SocialMediaApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSocialMediaActivities**](SocialMediaApi.md#getsocialmediaactivities) | **POST** /social-media/activities/get | Retrieve social media data by email address


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

            var apiInstance = new SocialMediaApi();
            var email = email_example;  // string | The person's email address being checked on mentioned social media plattforms

            try
            {
                // Retrieve social media data by email address
                SocialMediaActivitiesGetResponse result = apiInstance.GetSocialMediaActivities(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialMediaApi.GetSocialMediaActivities: " + e.Message );
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

