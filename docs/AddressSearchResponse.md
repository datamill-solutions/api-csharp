# IO.Swagger.Model.AddressSearchResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountryIso2** | **string** | ISO 3166-1 alpha-2 country code | 
**CountryIso3** | **string** | ISO 3166-1 alpha-3 country code | 
**Country** | **string** | Country name together with the language information | 
**State** | **string** | State name/code together with the language information | 
**StateName** | **string** | State name together with the language information | 
**StateCode** | **string** | ISO 3166-2 state code (if available) | 
**County** | **string** | County name together with the language information (if available) | 
**District** | **string** | District name together with the language information (if available) | 
**Zip** | **string** | Postal code | 
**City** | **string** | City name together with the language information | 
**Street** | **string** | Street name together with the language information | 
**Housenumber** | **string** | House number or building name together with the language information (if available) | 
**AdditionalData** | **string** | Additional house number information (e.g. floor, apartment, top) | 
**Relevance** | **string** | Indicates the relevance of the result found. The higher the score the more relevant the alternative. The score is a normalized value between 0 and 100. Every typo or mismatch between the request and response data (e.g. incorrect data, abbreviation, ..) will reduce the relevance.  | 
**Latitude** | **string** | Latitude to place a marker indicating the given location on a map (uses a dot as decimal point) | 
**Longitude** | **string** | Longitude to place a marker indicating the given location on a map (uses a dot as decimal point) | 
**NavigationLatitude** | **string** | Latitude of a potential route waypoint (uses a dot as decimal point) | 
**NavigationLongitude** | **string** | Longitude of a potential route waypoint (uses a dot as decimal point) | 
**Matchlevel** | **string** | The most detailed address field that matches the geo-coding query. **housenumber**: the whole geo-location including the house number / building name was found. **street**: the whole geo-location excluding the house number / building name was found. Please consider if you do not provide a house number or building name in the request the most detailed address field possible will always be the street. **general**: our service could only resolve a few address parts above the street level (e.g. only country or country + city, ...).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

