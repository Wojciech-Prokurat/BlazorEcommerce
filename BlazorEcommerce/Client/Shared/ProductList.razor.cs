using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Shared
{
    public partial class ProductList
    {
        private static List<Product> Products = new List<Product>()
         {
             new Product()
             {
                 Id = 1,
                 Title= "C# 10 i .NET 6 dla programistów aplikacji wieloplatformowych",
                 Description= "wórz aplikacje, witryny WWW oraz serwisy sieciowe za pomocą ASP.NET Core 6, Blazor i EF Core 6 w Visual Studio 2022 i Visual Studio Code. Wydanie VI",
                 ImageUrl = "https://static01.helion.com.pl/global/okladki/326x466/c10ne6.png",
                 Price = 79.50m
             },
             new Product()
             {
                 Id = 2,
                 Title= "C# 8.0 w pigułce",
                 Description= "C# jest od początku rozwijany w konsekwentny, przemyślany sposób, a każda nowa funkcjonalność idealnie integruje się z resztą języka. W efekcie łączy on nowoczesność i bezpieczeństwo. Wersja 8.0 jest kolejną poważną aktualizacją tego języka. Zapewnia wysokopoziomowe abstrakcje, między innymi wyrażenia, zapytania i kontynuacje asynchroniczne, ale także udostępnia niskopoziomowe mechanizmy pozwalające osiągnąć maksymalną wydajność aplikacji dzięki wykorzystaniu takich konstrukcji jak własne typy wartościowe programisty czy opcjonalne wskaźniki. Ceną, jaką programista płaci za ten rozwój, jest konieczność ciągłej nauki.",
                 ImageUrl = "https://static01.helion.com.pl/global/okladki/145x218/c8wpig.png",
                 Price = 74.99m
             },
             new Product()
             {
                 Id = 3,
                 Title= "Wzorce projektowe w .NET.",
                 Description= "Wzorce projektowe są bardzo przydatnym narzędziem w przyborniku programisty. Pozwalają na szybkie opracowanie złożonych zagadnień, ale można je również potraktować jako wstęp do ciekawego i inspirującego dochodzenia, jak rozwiązać konkretny problem na wiele różnych sposobów, na różnych poziomach zaawansowania technicznego i z zastosowaniem różnego rodzaju kompromisów. Takie próby jednak często prowadzą do nadinżynierii lub powstawania zbyt skomplikowanych struktur i mechanizmów. Chociaż bywa to zabawne i pomaga w doskonaleniu umiejętności programistycznych, nie jest pożądanym sposobem tworzenia systemów produkcyjnych.",
                 ImageUrl = "https://static01.helion.com.pl/global/okladki/326x466/wzprne.png",
                 Price = 37.99m
             }
         };
    }
}
