# BlazorBeerCss
A repo to create a Blazor component library based on https://github.com/beercss

## Prerequisities
| BlazorBeerCss | .NET | Support |
| :--- | :---: | :---: |
| 6.0.x | [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0) | :heavy_check_mark: |
| 6.1.x | [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0) & [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) | :heavy_check_mark: |

### Quick Installation Guide
Add the following to `_Imports.razor`
```razor
@using BlazorBeerCssLibrary
```
Change the article tag to below in the `MainLayout.razor` or `App.razor`
```razor
<main class="responsive">
  @Body
 </main>
```
Add the following to `index.html` (client-side) or `_Host.cshtml` (server-side) in the `head`
```razor
<link href="_content/BlazorBeerCssLibrary/css/beercss/beer.min.css" rel="stylesheet">
<script type="module" src="_content/BlazorBeerCssLibrary/css/beercss/beer.min.js"></script>
<script type="module" src="_content/BlazorBeerCssLibrary/css/beercss/material-dynamic-colors.min.js"></script>
```
Add the following to `index.html` or `_Host.cshtml` in the `body`
```razor
<script src="_content/MudBlazor/MudBlazor.min.js"></script>
```
Add the following to the relevant sections of `Program.cs` if you need to use the BeerToast service
```c#
using BlazorBeerCssLibrary.BeerToast;
```
```c#
builder.Services.AddSingleton<BeerToastService>();
```
