# BlazorBeerCSS WIP
A repo to create a Blazor component library based on [BeerCSS](https://github.com/beercss/beercss)
A demo can be seen here: [Demo](https://kristianfriis.github.io/BlazorBeerCss/)

## Prerequisities
| BlazorBeerCss | .NET | Support |
| :--- | :---: | :---: |
| 6.0.x | [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0) | :heavy_check_mark: |
| 6.1.x | [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0) & [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) | :heavy_check_mark: |

### Quick Installation Guide
Install Package
```
dotnet add package BlazorBeerCss
```
Add the following to `_Imports.razor`
```razor
@using BlazorBeerCss
```
Change the article tag to below in the `MainLayout.razor` or `App.razor`
```razor
<BeerMain Responsive="BeerResponsive.Responsive">
  @Body
 </BeerMain>
```
Add the following to `index.html` (client-side) or `_Host.cshtml` (server-side) in the `head`
```razor
<link href="_content/BlazorBeerCss/css/beercss/beer.min.css" rel="stylesheet">
<script type="module" src="_content/BlazorBeerCss/css/beercss/beer.min.js"></script>
<script type="module" src="_content/BlazorBeerCss/css/beercss/material-dynamic-colors.min.js"></script>
```
Add the following to the relevant sections of `Program.cs` if you need to use the BeerToast service
```c#
using BlazorBeerCss.BeerToast;
```
```c#
builder.Services.AddSingleton<BeerToastService>();
```
### Optional
Remove unused css in wwwwroot/css and remove the scaffolded css from MainLayout.razor.css and NavMenu.razor.css 