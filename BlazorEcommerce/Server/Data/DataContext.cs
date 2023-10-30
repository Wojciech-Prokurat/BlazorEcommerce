namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product()
                    {
                        Id = 1,
                        Title = "C# 10 i .NET 6 dla programistów aplikacji wieloplatformowych",
                        Description = "wórz aplikacje, witryny WWW oraz serwisy sieciowe za pomocą ASP.NET Core 6, Blazor i EF Core 6 w Visual Studio 2022 i Visual Studio Code. Wydanie VI",
                        ImageUrl = "https://static01.helion.com.pl/global/okladki/326x466/c10ne6.png",
                        Price = 79.50m,
                        CategoryId = 1
                    },
                    new Product()
                    {
                        Id = 2,
                        Title = "C# 8.0 w pigułce",
                        Description = "C# jest od początku rozwijany w konsekwentny, przemyślany sposób, a każda nowa funkcjonalność idealnie integruje się z resztą języka. W efekcie łączy on nowoczesność i bezpieczeństwo. Wersja 8.0 jest kolejną poważną aktualizacją tego języka. Zapewnia wysokopoziomowe abstrakcje, między innymi wyrażenia, zapytania i kontynuacje asynchroniczne, ale także udostępnia niskopoziomowe mechanizmy pozwalające osiągnąć maksymalną wydajność aplikacji dzięki wykorzystaniu takich konstrukcji jak własne typy wartościowe programisty czy opcjonalne wskaźniki. Ceną, jaką programista płaci za ten rozwój, jest konieczność ciągłej nauki.",
                        ImageUrl = "https://static01.helion.com.pl/global/okladki/145x218/c8wpig.png",
                        Price = 74.99m,
                        CategoryId = 1
                    },
                    new Product()
                    {
                        Id = 3,
                        Title = "Wzorce projektowe w .NET.",
                        Description = "Wzorce projektowe są bardzo przydatnym narzędziem w przyborniku programisty. Pozwalają na szybkie opracowanie złożonych zagadnień, ale można je również potraktować jako wstęp do ciekawego i inspirującego dochodzenia, jak rozwiązać konkretny problem na wiele różnych sposobów, na różnych poziomach zaawansowania technicznego i z zastosowaniem różnego rodzaju kompromisów. Takie próby jednak często prowadzą do nadinżynierii lub powstawania zbyt skomplikowanych struktur i mechanizmów. Chociaż bywa to zabawne i pomaga w doskonaleniu umiejętności programistycznych, nie jest pożądanym sposobem tworzenia systemów produkcyjnych.",
                        ImageUrl = "https://static01.helion.com.pl/global/okladki/326x466/wzprne.png",
                        Price = 37.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        CategoryId = 2,
                        Price = 4.99m,
                        Title = "The Matrix",
                        Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                    },
                    new Product
                    {
                        Id = 5,
                        CategoryId = 2,
                        Price = 3.99m,
                        Title = "Back to the Future",
                        Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                    },
                    new Product
                    {
                        Id = 6,
                        CategoryId = 2,
                        Price = 2.99m,
                        Title = "Toy Story",
                        Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",

                    },
                    new Product
                    {
                        Id = 7,
                        CategoryId = 3,
                        Title = "Half-Life 2",
                        Price = 49.99m,
                        Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

                    },
                    new Product
                    {
                        Id = 8,
                        CategoryId = 3,
                        Title = "Diablo II",
                        Price = 9.99m,
                        Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                    },
                    new Product
                    {
                        Id = 9,
                        CategoryId = 3,
                        Price = 14.99m,
                        Title = "Day of the Tentacle",
                        Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                    },
                    new Product
                    {
                        Id = 10,
                        CategoryId = 3,
                        Price = 159.99m,
                        Title = "Xbox",
                        Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                    },
                    new Product
                    {
                        Id = 11,
                        CategoryId = 3,
                        Price = 79.99m,
                        Title = "Super Nintendo Entertainment System",
                        Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    }
                    );
        }

    }
}