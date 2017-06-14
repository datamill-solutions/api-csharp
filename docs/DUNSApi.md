# DataMill.Api.DUNSApi

All URIs are relative to *https://api-beta.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDUNSRating**](DUNSApi.md#getdunsrating) | **POST** /business-data/duns/rating | Get marketing information by DUNS number
[**ResolveDUNS**](DUNSApi.md#resolveduns) | **POST** /business-data/duns/resolve | Resolve company information by DUNS number
[**SearchDUNS**](DUNSApi.md#searchduns) | **POST** /business-data/duns/search | Find DUNS number and company information by name


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

            var apiInstance = new DUNSApi();
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
                Debug.Print("Exception when calling DUNSApi.GetDUNSRating: " + e.Message );
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

            var apiInstance = new DUNSApi();
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
                Debug.Print("Exception when calling DUNSApi.ResolveDUNS: " + e.Message );
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

            var apiInstance = new DUNSApi();
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
                Debug.Print("Exception when calling DUNSApi.SearchDUNS: " + e.Message );
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

