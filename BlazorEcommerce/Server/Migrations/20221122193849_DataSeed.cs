using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "wórz aplikacje, witryny WWW oraz serwisy sieciowe za pomocą ASP.NET Core 6, Blazor i EF Core 6 w Visual Studio 2022 i Visual Studio Code. Wydanie VI", "https://static01.helion.com.pl/global/okladki/326x466/c10ne6.png", 79.50m, "C# 10 i .NET 6 dla programistów aplikacji wieloplatformowych" },
                    { 2, "C# jest od początku rozwijany w konsekwentny, przemyślany sposób, a każda nowa funkcjonalność idealnie integruje się z resztą języka. W efekcie łączy on nowoczesność i bezpieczeństwo. Wersja 8.0 jest kolejną poważną aktualizacją tego języka. Zapewnia wysokopoziomowe abstrakcje, między innymi wyrażenia, zapytania i kontynuacje asynchroniczne, ale także udostępnia niskopoziomowe mechanizmy pozwalające osiągnąć maksymalną wydajność aplikacji dzięki wykorzystaniu takich konstrukcji jak własne typy wartościowe programisty czy opcjonalne wskaźniki. Ceną, jaką programista płaci za ten rozwój, jest konieczność ciągłej nauki.", "https://static01.helion.com.pl/global/okladki/145x218/c8wpig.png", 74.99m, "C# 8.0 w pigułce" },
                    { 3, "Wzorce projektowe są bardzo przydatnym narzędziem w przyborniku programisty. Pozwalają na szybkie opracowanie złożonych zagadnień, ale można je również potraktować jako wstęp do ciekawego i inspirującego dochodzenia, jak rozwiązać konkretny problem na wiele różnych sposobów, na różnych poziomach zaawansowania technicznego i z zastosowaniem różnego rodzaju kompromisów. Takie próby jednak często prowadzą do nadinżynierii lub powstawania zbyt skomplikowanych struktur i mechanizmów. Chociaż bywa to zabawne i pomaga w doskonaleniu umiejętności programistycznych, nie jest pożądanym sposobem tworzenia systemów produkcyjnych.", "https://static01.helion.com.pl/global/okladki/326x466/wzprne.png", 37.99m, "Wzorce projektowe w .NET." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
