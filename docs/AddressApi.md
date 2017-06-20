# DataMill.Api.AddressApi

All URIs are relative to *https://api.methis.at*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExtractHouseNumber**](AddressApi.md#extracthousenumber) | **POST** /address/housenumber/extract | Try to extract house number from street information
[**LocateAddress**](AddressApi.md#locateaddress) | **POST** /address/locate | Reverse address lookup
[**SearchAddress**](AddressApi.md#searchaddress) | **POST** /address/search | Lookup physical postal address
[**SearchAddressMultiple**](AddressApi.md#searchaddressmultiple) | **POST** /address/search/multiple | Address lookup with multiple possible results


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

            var apiInstance = new AddressApi();
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
                Debug.Print("Exception when calling AddressApi.ExtractHouseNumber: " + e.Message );
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

            var apiInstance = new AddressApi();
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
                Debug.Print("Exception when calling AddressApi.LocateAddress: " + e.Message );
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

            var apiInstance = new AddressApi();
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
                Debug.Print("Exception when calling AddressApi.SearchAddress: " + e.Message );
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

            var apiInstance = new AddressApi();
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
                Debug.Print("Exception when calling AddressApi.SearchAddressMultiple: " + e.Message );
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

