# DataMill.Model.VatResolveResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Valid** | **string** | Flag if the VAT number is valid or not [0, 1] | 
**Countrycode** | **string** | ISO 3166-1 alpha-2 country code | 
**Vatnumber** | **string** | The verified VAT number without the country code as prefix | 
**Name** | **string** | The official company name if VAT number is valid | 
**Countryname** | **string** | Country name together with the language information | 
**State** | **string** | State name/code together with the language information | 
**County** | **string** | County name together with the language information (if available) | 
**City** | **string** | City name together with the language information | 
**Zip** | **string** | Postal code | 
**Street** | **string** | Street name together with the language information | 
**Housenumber** | **string** | House number together with the language information (if available) | 
**AdditionalData** | **string** | Additional house number information (e.g. floor, apartment, top) | 
**RawAddress** | **string** | The raw address of the company received before its split into its address parts | 
**CountrycodeIso3** | **string** | ISO 3166-1 alpha-3 country code | 
**Relevance** | **string** | Indicates the relevance of the result found. The higher the score the more relevant the alternative. The score is a normalized value between 0 and 100. Every typo or mismatch between the request and response data (e.g. incorrect data, abbreviation, ..) will reduce the relevance.  | 
**Latitude** | **string** | Latitude to place a marker indicating the given location on a map (uses a dot as decimal point) | 
**Longitude** | **string** | Longitude to place a marker indicating the given location on a map (uses a dot as decimal point) | 
**Matchlevel** | **string** | The most detailed address field that matches the geo-coding query: **housenumber**: the whole geo-location including the house number / building name was found. **street**: the whole geo-location excluding the house number / building name was found. Please consider if you do not provide a house number or building name in the request the most detailed address field possible will always be the street. **general**: our service could only resolve a few address parts above the street level (e.g. only country or country + city, ...).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

