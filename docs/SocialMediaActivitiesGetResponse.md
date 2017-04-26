# DataMill.Model.SocialMediaActivitiesGetResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **long?** | Unique status code describing the response  * **1**: Social media activities found and present in the response,  * **-1**: No social media activities found for the requested email address (in this case all following response keys except the status_description are not present),  * **-2**: Your requested is queued and a response will be available within the next 12 hours (in this case all following response keys except the status_description are not present)  | 
**StatusDescription** | **string** | Short description of the status code | 
**Name** | **string** | First name and last name of the person | [optional] 
**Email** | **string** | The requested email address | [optional] 
**Gender** | **string** | The person&#39;s gender written in english and all lowercase. Either **female** or **male** | [optional] 
**Avatar** | **string** | Profile image (fully qualified url) of the social media profile with the most followers | [optional] 
**Bio** | **string** | Biography of the social media profile where the person has the most followers (unless it doesn&#39;t show a biography, then the social media profile with the second most followers is checked) | [optional] 
**MaxFollowers** | **long?** | The maximum number of followers found by any of the social media platforms | [optional] 
**SumFollowers** | **long?** | The total number of followers of all social media platforms | [optional] 
**Location** | [**SocialMediaActivitiesGetLocation**](SocialMediaActivitiesGetLocation.md) |  | [optional] 
**Education** | [**List&lt;SocialMediaActivitiesGetEducation&gt;**](SocialMediaActivitiesGetEducation.md) | Collection of all educations found. | [optional] 
**Employment** | [**List&lt;SocialMediaActivitiesGetEmployment&gt;**](SocialMediaActivitiesGetEmployment.md) | Collection of all companies the person worked for. | [optional] 
**Linkedin** | [**SocialMediaActivitiesGetLinkedIn**](SocialMediaActivitiesGetLinkedIn.md) |  | [optional] 
**Xing** | [**SocialMediaActivitiesGetXing**](SocialMediaActivitiesGetXing.md) |  | [optional] 
**Facebook** | [**SocialMediaActivitiesGetFacebook**](SocialMediaActivitiesGetFacebook.md) |  | [optional] 
**Twitter** | [**SocialMediaActivitiesGetTwitter**](SocialMediaActivitiesGetTwitter.md) |  | [optional] 
**Pinterest** | [**SocialMediaActivitiesGetPinterest**](SocialMediaActivitiesGetPinterest.md) |  | [optional] 
**Instagram** | [**SocialMediaActivitiesGetInstagram**](SocialMediaActivitiesGetInstagram.md) |  | [optional] 
**Youtube** | [**SocialMediaActivitiesGetYouTube**](SocialMediaActivitiesGetYouTube.md) |  | [optional] 
**Googleplus** | [**SocialMediaActivitiesGetGooglePlus**](SocialMediaActivitiesGetGooglePlus.md) |  | [optional] 
**Klout** | [**SocialMediaActivitiesGetKlout**](SocialMediaActivitiesGetKlout.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

