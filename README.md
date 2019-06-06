# ![TornCity.Net](TornCity.Net/TornCity.png) TornCity.Net
A .Net wrapper for the [Torn City API](https://www.torn.com/api.html)

## Documentation
The [API documentation](https://www.torn.com/api.html#) can be found at https://www.torn.com/api.html#.  
An [API Key](https://www.torn.com/preferences.php#tab=api) is required to interact with the API.  

### Installation  
Release builds will be added to Nuget (eventually)

## Example 
### Visual Basic
```vb
'Create the TornClient from which API requests will be made
Dim TornClient = New TornClient("API_key_goes_here") 'An overload exists for passing the TornClientConfig

'Get the profile info associated with the API key above
Dim myProfile = Await TornClient.SendRequestAsync(Of User.Profile)

'Get the profile info for another player
Dim notMyProfile = Await TornClient.SendRequestAsync(Of User.Profile)(2255529)

'Apply selections to your query using the request endpoint selector (UserSelector, FactionSelector, etc..)
Dim myBasicInfo = Await TornClient.SendRequestAsync(New UserSelector(UserSelection.basic, UserSelection.icons))
Dim notMyBasicInfo = Await TornClient.SendRequestAsync(New UserSelector(UserSelection.basic, UserSelection.icons), 2255529)
```
### C#
```cs
// Create the TornClient from which API requests will be made
var TornClient = new TornClient("API_key_goes_here"); // An overload exists for passing the TornClientConfig

// Get the profile info associated with the API key above
var myProfile = await TornClient.SendRequestAsync<User.Profile>;

// Get the profile info for another player
var notMyProfile = await TornClient.SendRequestAsync<User.Profile>(2255529);

// Apply selections to your query using the request endpoint selector (UserSelector, FactionSelector, etc..)
var myBasicInfo = await TornClient.SendRequestAsync(new UserSelector(UserSelection.basic, UserSelection.icons)); 
var notMyBasicInfo = await TornClient.SendRequestAsync(New UserSelector(UserSelection.basic, UserSelection.icons), 2255529); 
```  

## Caching  
The [Torn API](https://www.torn.com/api.html#) caches the requests made and returns the cached results for any duplicate request made within 30 seconds. New data can only be retrieved for query once this 30 second period has expired. This transalates to two (2) requests per minute for a given query. However, regardless of if your request if fulfilled from cached data or with updated data, the try still counts to your total request limit per minute. So as to assist you with not *wasting* requests, a local cache is maintained, using the same expiration period as the API. If a duplicate request is made for a given query before the cached result has expired, a request will **not** be made to the API, but instead, the locally cached results will be returned. Once the cache expires, resending the request will fetch from the API.  

> Cache duration can be controlled using `TornClientConfig#CacheDurationSeconds`
