# Introduction 

This project includes models and APIs for communicating with the Voicify CMS APIs at https://cms.voicify.com

# Getting Started

You can install this package from NuGet:

```
Install-Package Voicify.Sdk.Cms
```

Then you can pull in the namespace:

```csharp
using Voicify.Sdk.Cms.Api
```

Each service has its own API class to use in order to make requests against it. These are also typed against `interfaces` so you can optionally inject them or mock them during testing.

## Authentication

Currently, you'll need to authenticate an API user against your Voicify organization to get an Access token to start making requests against the API.

To do this, you can create a new `AuthenticationApi` client and then send a request to authenticate your API account:

```csharp
var authClient = new AuthenticationApi("https://cms.voicify.com");

var tokenInfo = await authClient.AuthenticateAsync("your-organization-id", "your-organization-secret", "password", "your-api-user-name", "your-api-user-password");
var accessToken = tokenInfo.AccessToken;

// you can also refresh your token
var refreshedTokenInfo = await authClient.AuthenticateAsync("your-organization-id", "your-organization-secret", "refresh_token", "your-api-user-name", null, "your-refresh-token");
var newAccessToken = refreshedTokenInfo.AccessToken;

// these access tokens are used on subsequent requests to the API

```

## Making Requests

Once you have an access token, you can start to make requests against your organization and the apps within it. For example, we can use the previous `accessToken` variable to authenticate and create a new welcome message.

```csharp
var welcomeMessageClient = new WelcomeMessageApi(new Configuration
{
    BasePath = "https://cms.voicify.com",
    ApiKey = new Dictionary<string, string> 
    {
        { "Bearer", $"Bearer {accessToken}" }
    }
});
welcomeMessageClient.CreateFullContentItem(new WelcomeMessageModel(
    title: "New welcome message",
    applicationId: "an-app-id",
    applicationFeatureId: "an-app-feature-id",
    content: "Welcome to my app! I made this from the Voicify SDK!"
));
```

Voicify Partners and Customers can also check out the extended documentation and details at https://support.voicify.com

# Contributing

The Voicify core development team owns this repo and NuGet package, but all Voicify developers are welcome to contribute changes. Before contributing, please create an issue that you can track your PRs against and be sure there is not already a PR open for it.

# Build and Test

There are some steps to autogenerate the C# Clients and APIs from the swagger API models that Voicify outputs.

## Generate Api Clients from Swagger

First, make sure you get the latest version of `Voicify.Sdk.Core.Models` NuGet.

Then, get the latest APIs by generating from the latest models and https://cms.voicify.com:

Sample:

```
java -jar swagger-codegen-cli.jar generate -i http://cms.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -Dapis -DsupportingFiles -DmodelTests=false -o ../../src/Voicify.Sdk.Cms/Voicify.Sdk.Cms/Generated
```


## Generate Tests from Swagger

With the latest API classes, be sure to generate the new tests:

```
java -jar swagger-codegen-cli.jar generate -i http://cms.voicify.com/swagger/v1/swagger.json -l csharp -c ../csharp-options.json -DapiTests=true -o ../../src/Voicify.Sdk.Cms/Voicify.Sdk.Cms.Tests/Generated
```

Delete any duplicated stuff that is created in the test project

Then find and replace the expected models namespace everywhere.

Find: using Voicify.Sdk.Cms.Model;
Replace with: using Voicify.Sdk.Core.Models.Model;

Then do any other replacements or fixes required in order to fix the build

Also be wary of generated tests overriding any that are explicitly setup. You may need to pull the accepted tests that are enabled out of the `Generated` folder.

Also, the generator will generate extra .csproj and .sln files. Be sure to delete those before pushing changes.