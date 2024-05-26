using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PearlBookstore.API.Migrations
{
    /// <inheritdoc />
    public partial class ItemsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Storages_StorageID",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Items_StorageID",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "StorageID",
                table: "Items",
                newName: "Counter");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Items",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Wisława", "Szymborska" },
                    { 2, "Adam", "Mickiewicz" },
                    { 3, "Henryk", "Sienkiewicz" },
                    { 4, "Bolesław", "Prus" },
                    { 5, "Juliusz", "Słowacki" },
                    { 6, "Eliza", "Orzeszkowa" },
                    { 7, "Maria", "Konopnicka" },
                    { 8, "Stefan", "Żeromski" },
                    { 9, "Władysław", "Reymont" },
                    { 10, "Stanisław", "Lem" },
                    { 11, "Czesław", "Miłosz" },
                    { 12, "Zbigniew", "Herbert" },
                    { 13, "Bruno", "Schulz" },
                    { 14, "Józef", "Mackiewicz" },
                    { 15, "Olga", "Tokarczuk" },
                    { 16, "Ryszard", "Kapuściński" },
                    { 17, "Sławomir", "Mrożek" },
                    { 18, "Jerzy", "Pilch" },
                    { 19, "Andrzej", "Sapkowski" },
                    { 20, "Dorota", "Masłowska" },
                    { 21, "Joanna", "Bator" },
                    { 22, "Magdalena", "Tulli" },
                    { 23, "Tadeusz", "Różewicz" },
                    { 24, "Janusz", "Głowacki" },
                    { 25, "Hanna", "Krall" },
                    { 26, "Ewa", "Kurkowska" },
                    { 27, "Krzysztof", "Kieślowski" },
                    { 28, "Ewa", "Lipska" },
                    { 29, "Zofia", "Nałkowska" },
                    { 30, "Agnieszka", "Osiecka" },
                    { 31, "George", "Orwell" },
                    { 32, "Jane", "Austen" },
                    { 33, "Mark", "Twain" },
                    { 34, "Charles", "Dickens" },
                    { 35, "Ernest", "Hemingway" },
                    { 36, "F. Scott", "Fitzgerald" },
                    { 37, "J.K.", "Rowling" },
                    { 38, "J.R.R.", "Tolkien" },
                    { 39, "Agatha", "Christie" },
                    { 40, "Leo", "Tolstoy" },
                    { 41, "Fyodor", "Dostoevsky" },
                    { 42, "Gabriel", "García Márquez" },
                    { 43, "Homer", "" },
                    { 44, "William", "Shakespeare" },
                    { 45, "Victor", "Hugo" },
                    { 46, "Marcel", "Proust" },
                    { 47, "Franz", "Kafka" },
                    { 48, "Herman", "Melville" },
                    { 49, "James", "Joyce" },
                    { 50, "Virginia", "Woolf" },
                    { 51, "Arthur", "Conan Doyle" },
                    { 52, "Jack", "London" },
                    { 53, "Edgar Allan", "Poe" },
                    { 54, "H.G.", "Wells" },
                    { 55, "Mary", "Shelley" },
                    { 56, "Margaret", "Atwood" },
                    { 57, "Kazuo", "Ishiguro" },
                    { 58, "Haruki", "Murakami" },
                    { 59, "Chinua", "Achebe" },
                    { 60, "Isabel", "Allende" },
                    { 61, "Salman", "Rushdie" },
                    { 62, "Toni", "Morrison" },
                    { 63, "Alice", "Munro" },
                    { 64, "V.S.", "Naipaul" },
                    { 65, "Orhan", "Pamuk" },
                    { 66, "Milan", "Kundera" },
                    { 67, "Umberto", "Eco" },
                    { 68, "Elena", "Ferrante" },
                    { 69, "John", "Steinbeck" },
                    { 70, "Harper", "Lee" },
                    { 71, "Kurt", "Vonnegut" },
                    { 72, "Ray", "Bradbury" },
                    { 73, "Aldous", "Huxley" },
                    { 74, "George", "R.R. Martin" },
                    { 75, "Isaac", "Asimov" },
                    { 76, "Philip", "K. Dick" },
                    { 77, "Arthur", "C. Clarke" },
                    { 78, "Neil", "Gaiman" },
                    { 79, "Stephen", "King" },
                    { 80, "Erich", "Maria Remarque" },
                    { 81, "Hermann", "Hesse" },
                    { 82, "Khaled", "Hosseini" },
                    { 83, "J.D.", "Salinger" },
                    { 84, "Joseph", "Conrad" },
                    { 85, "John", "Grisham" },
                    { 86, "Dan", "Brown" },
                    { 87, "Douglas", "Adams" },
                    { 88, "Michael", "Crichton" },
                    { 89, "Roald", "Dahl" },
                    { 90, "Anne", "Rice" },
                    { 91, "Paulo", "Coelho" },
                    { 92, "John", "Irving" },
                    { 93, "Sylvia", "Plath" },
                    { 94, "Emily", "Bronte" },
                    { 95, "Charlotte", "Bronte" },
                    { 96, "Emily", "Dickinson" },
                    { 97, "Oscar", "Wilde" },
                    { 98, "Charles", "Bukowski" },
                    { 99, "Robert", "Frost" },
                    { 100, "Markus", "Zusak" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Horror" },
                    { 2, "Fantastyka" },
                    { 3, "Science Fiction" },
                    { 4, "Kryminał" },
                    { 5, "Thriller" },
                    { 6, "Romans" },
                    { 7, "Powieść historyczna" },
                    { 8, "Literatura faktu" },
                    { 9, "Biografia" },
                    { 10, "Poradnik" },
                    { 11, "Literatura młodzieżowa" },
                    { 12, "Literatura dziecięca" },
                    { 13, "Komiks" },
                    { 14, "Klasyka" },
                    { 15, "Przygodowa" },
                    { 16, "Poezja" },
                    { 17, "Powieść dystopijna" },
                    { 18, "Esej" },
                    { 19, "Drama" },
                    { 20, "Mity i legendy" },
                    { 21, "Fikcja" },
                    { 22, "Tragedia" },
                    { 23, "Polska literatura" },
                    { 24, "Samobójstwo" },
                    { 25, "Historia" },
                    { 26, "Literatura" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Twarda oprawa" },
                    { 2, "Miękka oprawa" },
                    { 3, "Ebook" },
                    { 4, "Audiobook" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AuthorId", "Counter", "Description", "Price", "Title", "YearPublication" },
                values: new object[,]
                {
                    { 1, 1, 37, "Książka autorstwa: Wisława Szymborska o tytule: How to Start Writing wydana w roku: 2021", 16.3m, "How to Start Writing", 2021 },
                    { 2, 1, 35, "Książka autorstwa: Wisława Szymborska o tytule: Map wydana w roku: 2015", 31.41m, "Map", 2015 },
                    { 3, 1, 30, "Książka autorstwa: Wisława Szymborska o tytule: Map wydana w roku: 2015", 40.15m, "Map", 2015 },
                    { 4, 2, 38, "Książka autorstwa: Adam Mickiewicz o tytule: Migrant birds wydana w roku: 2012", 10.0m, "Migrant birds", 2012 },
                    { 5, 2, 39, "Książka autorstwa: Adam Mickiewicz o tytule: Listy Adama Mickiewicza wydana w roku: 2006", 29.17m, "Listy Adama Mickiewicza", 2006 },
                    { 6, 2, 28, "Książka autorstwa: Adam Mickiewicz o tytule: Venok iz vasilʹkov i ruty-- wydana w roku: 2003", 25.77m, "Venok iz vasilʹkov i ruty--", 2003 },
                    { 7, 4, 33, "Książka autorstwa: Bolesław Prus o tytule: The doll wydana w roku: 2011", 22.73m, "The doll", 2011 },
                    { 8, 4, 44, "Książka autorstwa: Bolesław Prus o tytule: Literackie notatki o kompozycji wydana w roku: 2010", 46.85m, "Literackie notatki o kompozycji", 2010 },
                    { 9, 4, 48, "Książka autorstwa: Bolesław Prus o tytule: \"Obrazy wszystkiego\" wydana w roku: 2006", 34.46m, "\"Obrazy wszystkiego\"", 2006 },
                    { 10, 5, 50, "Książka autorstwa: Juliusz Słowacki o tytule: Kolęda wydana w roku: 2011", 34.92m, "Kolęda", 2011 },
                    { 11, 5, 45, "Książka autorstwa: Juliusz Słowacki o tytule: Poland's angry romantic wydana w roku: 2009", 47.72m, "Poland's angry romantic", 2009 },
                    { 12, 5, 44, "Książka autorstwa: Juliusz Słowacki o tytule: Juliusz Słowacki wydana w roku: 2002", 37.69m, "Juliusz Słowacki", 2002 },
                    { 13, 6, 39, "Książka autorstwa: Eliza Orzeszkowa o tytule: Wóz Żagornanta wydana w roku: 2012", 12.10m, "Wóz Żagornanta", 2012 },
                    { 14, 6, 35, "Książka autorstwa: Eliza Orzeszkowa o tytule: Mirtala wydana w roku: 2011", 40.49m, "Mirtala", 2011 },
                    { 15, 6, 19, "Książka autorstwa: Eliza Orzeszkowa o tytule: Publicystyka społeczna wydana w roku: 2005", 33.1m, "Publicystyka społeczna", 2005 },
                    { 16, 7, 38, "Książka autorstwa: Maria Konopnicka o tytule: Wiersze wydana w roku: 2010", 10.4m, "Wiersze", 2010 },
                    { 17, 7, 31, "Książka autorstwa: Maria Konopnicka o tytule: Hu, hu, ha! Zima zła wydana w roku: 2010", 31.89m, "Hu, hu, ha! Zima zła", 2010 },
                    { 18, 7, 41, "Książka autorstwa: Maria Konopnicka o tytule: Listy do synów i córek wydana w roku: 2010", 38.52m, "Listy do synów i córek", 2010 },
                    { 19, 8, 47, "Książka autorstwa: Stefan Żeromski o tytule: Żeromski wydana w roku: 2013", 42.98m, "Żeromski", 2013 },
                    { 20, 8, 46, "Książka autorstwa: Stefan Żeromski o tytule: Stefan Żeromski i jego rodzina wydana w roku: 2013", 31.88m, "Stefan Żeromski i jego rodzina", 2013 },
                    { 21, 8, 35, "Książka autorstwa: Stefan Żeromski o tytule: Stefan Żeromski mało znany wydana w roku: 2012", 14.56m, "Stefan Żeromski mało znany", 2012 },
                    { 22, 9, 23, "Książka autorstwa: Władysław Reymont o tytule: Dziennik nieciągły wydana w roku: 2009", 46.61m, "Dziennik nieciągły", 2009 },
                    { 23, 9, 17, "Książka autorstwa: Władysław Reymont o tytule: Korespondencja 1890-1925 wydana w roku: 2002", 48.54m, "Korespondencja 1890-1925", 2002 },
                    { 24, 9, 21, "Książka autorstwa: Władysław Reymont o tytule: Władysław St. Reymont pod znakiem \"panteizmu druku\" wydana w roku: 2000", 20.82m, "Władysław St. Reymont pod znakiem \"panteizmu druku\"", 2000 },
                    { 25, 10, 48, "Książka autorstwa: Stanisław Lem o tytule: Truth and Other Stories wydana w roku: 2021", 16.83m, "Truth and Other Stories", 2021 },
                    { 26, 10, 30, "Książka autorstwa: Stanisław Lem o tytule: The Seventh Voyage wydana w roku: 2019", 22.37m, "The Seventh Voyage", 2019 },
                    { 27, 10, 41, "Książka autorstwa: Stanisław Lem o tytule: The Three Electroknights wydana w roku: 2018", 48.94m, "The Three Electroknights", 2018 },
                    { 28, 11, 35, "Książka autorstwa: Czesław Miłosz o tytule: Mountains of Parnassus wydana w roku: 2017", 12.59m, "Mountains of Parnassus", 2017 },
                    { 29, 11, 26, "Książka autorstwa: Czesław Miłosz o tytule: The mountains of Parnassus = wydana w roku: 2017", 47.90m, "The mountains of Parnassus =", 2017 },
                    { 30, 11, 27, "Książka autorstwa: Czesław Miłosz o tytule: Przekłady poetyckie wszystkie wydana w roku: 2015", 45.24m, "Przekłady poetyckie wszystkie", 2015 },
                    { 31, 12, 42, "Książka autorstwa: Zbigniew Herbert o tytule: \"Moj bliźni, moj bracie\" wydana w roku: 2016", 28.58m, "\"Moj bliźni, moj bracie\"", 2016 },
                    { 32, 12, 22, "Książka autorstwa: Zbigniew Herbert o tytule: Berlinde De Bruyckere wydana w roku: 2015", 24.23m, "Berlinde De Bruyckere", 2015 },
                    { 33, 12, 25, "Książka autorstwa: Zbigniew Herbert o tytule: Notes herbertowski wydana w roku: 2014", 19.64m, "Notes herbertowski", 2014 },
                    { 34, 13, 28, "Książka autorstwa: Bruno Schulz o tytule: Undula wydana w roku: 2020", 42.53m, "Undula", 2020 },
                    { 35, 13, 25, "Książka autorstwa: Bruno Schulz o tytule: Becoming Citizens in a Changing World wydana w roku: 2018", 17.23m, "Becoming Citizens in a Changing World", 2018 },
                    { 36, 13, 15, "Książka autorstwa: Bruno Schulz o tytule: Collected stories wydana w roku: 2018", 37.2m, "Collected stories", 2018 },
                    { 37, 14, 15, "Książka autorstwa: Józef Mackiewicz o tytule: Triumph of Provocation wydana w roku: 2009", 42.31m, "Triumph of Provocation", 2009 },
                    { 38, 14, 16, "Książka autorstwa: Józef Mackiewicz o tytule: The triumph of provocation wydana w roku: 2009", 31.98m, "The triumph of provocation", 2009 },
                    { 39, 14, 25, "Książka autorstwa: Józef Mackiewicz o tytule: Katyń--zbrodnia bez sądu i kary wydana w roku: 1997", 23.15m, "Katyń--zbrodnia bez sądu i kary", 1997 },
                    { 40, 15, 17, "Książka autorstwa: Olga Tokarczuk o tytule: Mr. Distinctive wydana w roku: 2024", 18.25m, "Mr. Distinctive", 2024 },
                    { 41, 15, 15, "Książka autorstwa: Olga Tokarczuk o tytule: Opowiadania bizarne wydana w roku: 2018", 31.2m, "Opowiadania bizarne", 2018 },
                    { 42, 15, 32, "Książka autorstwa: Olga Tokarczuk o tytule: NieObcy wydana w roku: 2015", 25.6m, "NieObcy", 2015 },
                    { 43, 16, 21, "Książka autorstwa: Ryszard Kapuściński o tytule: An Advertisement for Toothpaste wydana w roku: 2018", 35.65m, "An Advertisement for Toothpaste", 2018 },
                    { 44, 16, 20, "Książka autorstwa: Ryszard Kapuściński o tytule: Nobody Leaves wydana w roku: 2017", 35.82m, "Nobody Leaves", 2017 },
                    { 45, 16, 38, "Książka autorstwa: Ryszard Kapuściński o tytule: Imperium wydana w roku: 2016", 43.49m, "Imperium", 2016 },
                    { 46, 17, 24, "Książka autorstwa: Sławomir Mrożek o tytule: Scenopis od wieczności wydana w roku: 2014", 10.70m, "Scenopis od wieczności", 2014 },
                    { 47, 17, 32, "Książka autorstwa: Sławomir Mrożek o tytule: Listy, 1959-1994 wydana w roku: 2013", 38.60m, "Listy, 1959-1994", 2013 },
                    { 48, 17, 20, "Książka autorstwa: Sławomir Mrożek o tytule: Mrożek w obrazach wydana w roku: 2013", 21.94m, "Mrożek w obrazach", 2013 },
                    { 49, 18, 42, "Książka autorstwa: Jerzy Pilch o tytule: Zawsze nie ma nigdy wydana w roku: 2016", 15.12m, "Zawsze nie ma nigdy", 2016 },
                    { 50, 18, 34, "Książka autorstwa: Jerzy Pilch o tytule: Dziennik wydana w roku: 2012", 26.24m, "Dziennik", 2012 },
                    { 51, 18, 38, "Książka autorstwa: Jerzy Pilch o tytule: My first suicide wydana w roku: 2012", 19.82m, "My first suicide", 2012 },
                    { 52, 19, 18, "Książka autorstwa: Andrzej Sapkowski o tytule: Edge of the World wydana w roku: 2024", 18.43m, "Edge of the World", 2024 },
                    { 53, 19, 16, "Książka autorstwa: Andrzej Sapkowski o tytule: The Last Wish wydana w roku: 2022", 42.19m, "The Last Wish", 2022 },
                    { 54, 19, 22, "Książka autorstwa: Andrzej Sapkowski o tytule: Tower of Fools wydana w roku: 2021", 25.82m, "Tower of Fools", 2021 },
                    { 55, 20, 39, "Książka autorstwa: Dorota Masłowska o tytule: Dorota Maslowska wydana w roku: 2023", 40.49m, "Dorota Maslowska", 2023 },
                    { 56, 20, 39, "Książka autorstwa: Dorota Masłowska o tytule: Jak przejac kontrole nad swiatem, nie wychodzac z domu wydana w roku: 2017", 25.18m, "Jak przejac kontrole nad swiatem, nie wychodzac z domu", 2017 },
                    { 57, 20, 16, "Książka autorstwa: Dorota Masłowska o tytule: White and Red wydana w roku: 2015", 18.29m, "White and Red", 2015 },
                    { 58, 21, 23, "Książka autorstwa: Joanna Bator o tytule: NieObcy wydana w roku: 2015", 42.53m, "NieObcy", 2015 },
                    { 59, 21, 40, "Książka autorstwa: Joanna Bator o tytule: Wyspa łza wydana w roku: 2015", 17.31m, "Wyspa łza", 2015 },
                    { 60, 21, 31, "Książka autorstwa: Joanna Bator o tytule: Rekin z parku Yoyogi wydana w roku: 2014", 20.28m, "Rekin z parku Yoyogi", 2014 },
                    { 61, 22, 13, "Książka autorstwa: Magdalena Tulli o tytule: In red wydana w roku: 2011", 17.81m, "In red", 2011 },
                    { 62, 22, 10, "Książka autorstwa: Magdalena Tulli o tytule: Flaw wydana w roku: 2007", 17.78m, "Flaw", 2007 },
                    { 63, 22, 23, "Książka autorstwa: Magdalena Tulli o tytule: Moving parts wydana w roku: 2005", 42.51m, "Moving parts", 2005 },
                    { 64, 23, 39, "Książka autorstwa: Tadeusz Różewicz o tytule: Wiersze i poematy z \"Twórczości\" (1946-2005) wydana w roku: 2017", 41.97m, "Wiersze i poematy z \"Twórczości\" (1946-2005)", 2017 },
                    { 65, 23, 12, "Książka autorstwa: Tadeusz Różewicz o tytule: Survivors and Other Poems wydana w roku: 2016", 16.28m, "Survivors and Other Poems", 2016 },
                    { 66, 23, 35, "Książka autorstwa: Tadeusz Różewicz o tytule: Sobbing Superpower wydana w roku: 2013", 13.34m, "Sobbing Superpower", 2013 },
                    { 67, 24, 37, "Książka autorstwa: Janusz Głowacki o tytule: Made in Poland wydana w roku: 2017", 45.88m, "Made in Poland", 2017 },
                    { 68, 24, 35, "Książka autorstwa: Janusz Głowacki o tytule: Fortynbras sie upił wydana w roku: 2014", 14.81m, "Fortynbras sie upił", 2014 },
                    { 69, 24, 24, "Książka autorstwa: Janusz Głowacki o tytule: Przyszłem, czyli, Jak pisałem scenariusz o Lechu Wałęsie dla Andrzeja Wajdy wydana w roku: 2013", 24.24m, "Przyszłem, czyli, Jak pisałem scenariusz o Lechu Wałęsie dla Andrzeja Wajdy", 2013 },
                    { 70, 25, 34, "Książka autorstwa: Hanna Krall o tytule: NieObcy wydana w roku: 2015", 40.42m, "NieObcy", 2015 },
                    { 71, 25, 14, "Książka autorstwa: Hanna Krall o tytule: Chasing the king of hearts wydana w roku: 2013", 22.78m, "Chasing the king of hearts", 2013 },
                    { 72, 25, 28, "Książka autorstwa: Hanna Krall o tytule: Chasing The King Of Hearts wydana w roku: 2013", 17.85m, "Chasing The King Of Hearts", 2013 },
                    { 73, 27, 28, "Książka autorstwa: Krzysztof Kieślowski o tytule: Przypadek wydana w roku: 2015", 14.13m, "Przypadek", 2015 },
                    { 74, 27, 46, "Książka autorstwa: Krzysztof Kieślowski o tytule: Trois couleurs, bleu wydana w roku: 2011", 39.63m, "Trois couleurs, bleu", 2011 },
                    { 75, 27, 10, "Książka autorstwa: Krzysztof Kieślowski o tytule: Blue, white, red wydana w roku: 2011", 29.41m, "Blue, white, red", 2011 },
                    { 76, 28, 37, "Książka autorstwa: Ewa Lipska o tytule: Dear Ms. Schubert wydana w roku: 2020", 21.39m, "Dear Ms. Schubert", 2020 },
                    { 77, 28, 29, "Książka autorstwa: Ewa Lipska o tytule: Sara Lipska wydana w roku: 2012", 17.32m, "Sara Lipska", 2012 },
                    { 78, 28, 44, "Książka autorstwa: Ewa Lipska o tytule: Poems wydana w roku: 2009", 36.56m, "Poems", 2009 },
                    { 79, 29, 35, "Książka autorstwa: Zofia Nałkowska o tytule: Boundary wydana w roku: 2016", 28.50m, "Boundary", 2016 },
                    { 80, 29, 39, "Książka autorstwa: Zofia Nałkowska o tytule: Choucas wydana w roku: 2014", 37.53m, "Choucas", 2014 },
                    { 81, 29, 15, "Książka autorstwa: Zofia Nałkowska o tytule: Romance of Teresa Hennert wydana w roku: 2014", 25.51m, "Romance of Teresa Hennert", 2014 },
                    { 82, 30, 15, "Książka autorstwa: Agnieszka Osiecka o tytule: Neponset wydana w roku: 2016", 45.21m, "Neponset", 2016 },
                    { 83, 30, 49, "Książka autorstwa: Agnieszka Osiecka o tytule: Na pocza̜tku był negatyw wydana w roku: 2014", 44.66m, "Na pocza̜tku był negatyw", 2014 },
                    { 84, 30, 40, "Książka autorstwa: Agnieszka Osiecka o tytule: Filmidła wydana w roku: 2013", 31.60m, "Filmidła", 2013 },
                    { 85, 31, 50, "Książka autorstwa: George Orwell o tytule: Hanging wydana w roku: 2023", 40.75m, "Hanging", 2023 },
                    { 86, 31, 21, "Książka autorstwa: George Orwell o tytule: Animal Farm by George Orwell wydana w roku: 2022", 34.75m, "Animal Farm by George Orwell", 2022 },
                    { 87, 31, 34, "Książka autorstwa: George Orwell o tytule: Nineteen Eighty-Four wydana w roku: 2022", 42.19m, "Nineteen Eighty-Four", 2022 },
                    { 88, 32, 23, "Książka autorstwa: Jane Austen o tytule: Prejudice and Pride wydana w roku: 2024", 19.51m, "Prejudice and Pride", 2024 },
                    { 89, 32, 25, "Książka autorstwa: Jane Austen o tytule: Mismatched wydana w roku: 2024", 27.51m, "Mismatched", 2024 },
                    { 90, 32, 15, "Książka autorstwa: Jane Austen o tytule: Pride and Prejudice (Copper Lodge Library) wydana w roku: 2024", 16.4m, "Pride and Prejudice (Copper Lodge Library)", 2024 },
                    { 91, 33, 25, "Książka autorstwa: Mark Twain o tytule: Abenteuer und Fahrten des Huckleberry Finn wydana w roku: 2024", 18.91m, "Abenteuer und Fahrten des Huckleberry Finn", 2024 },
                    { 92, 33, 47, "Książka autorstwa: Mark Twain o tytule: Pudd'nhead Wilson wydana w roku: 2024", 10.84m, "Pudd'nhead Wilson", 2024 },
                    { 93, 33, 18, "Książka autorstwa: Mark Twain o tytule: Pudd'nhead Wilson wydana w roku: 2024", 24.25m, "Pudd'nhead Wilson", 2024 },
                    { 94, 34, 40, "Książka autorstwa: Charles Dickens o tytule: Oliver Twist wydana w roku: 2024", 35.32m, "Oliver Twist", 2024 },
                    { 95, 34, 16, "Książka autorstwa: Charles Dickens o tytule: Tiempos difíciles wydana w roku: 2024", 31.86m, "Tiempos difíciles", 2024 },
                    { 96, 34, 26, "Książka autorstwa: Charles Dickens o tytule: Christmas Carol (Time Trilogy) wydana w roku: 2023", 36.6m, "Christmas Carol (Time Trilogy)", 2023 },
                    { 97, 35, 38, "Książka autorstwa: Ernest Hemingway o tytule: Men Without Women wydana w roku: 2023", 49.70m, "Men Without Women", 2023 },
                    { 98, 35, 16, "Książka autorstwa: Ernest Hemingway o tytule: Sun Also Rises : (Pierian Classics) wydana w roku: 2022", 15.94m, "Sun Also Rises : (Pierian Classics)", 2022 },
                    { 99, 35, 39, "Książka autorstwa: Ernest Hemingway o tytule: Men Without Women - Unabridged wydana w roku: 2022", 28.91m, "Men Without Women - Unabridged", 2022 },
                    { 100, 36, 42, "Książka autorstwa: F. Scott Fitzgerald o tytule: Great Gatsby (Firenze Annotated Edition) wydana w roku: 2023", 38.48m, "Great Gatsby (Firenze Annotated Edition)", 2023 },
                    { 101, 36, 33, "Książka autorstwa: F. Scott Fitzgerald o tytule: The Great Gatsby (Classics Made Easy) wydana w roku: 2023", 48.89m, "The Great Gatsby (Classics Made Easy)", 2023 },
                    { 102, 36, 50, "Książka autorstwa: F. Scott Fitzgerald o tytule: Great Gatsby, This Side of Paradise, & Other Major Works wydana w roku: 2023", 21.14m, "Great Gatsby, This Side of Paradise, & Other Major Works", 2023 },
                    { 103, 37, 44, "Książka autorstwa: J.K. Rowling o tytule: Harry Potter Wizarding Almanac wydana w roku: 2023", 30.37m, "Harry Potter Wizarding Almanac", 2023 },
                    { 104, 37, 50, "Książka autorstwa: J.K. Rowling o tytule: Harry Potter Paperback Full Book Set Volumes 1-7 wydana w roku: 2023", 19.57m, "Harry Potter Paperback Full Book Set Volumes 1-7", 2023 },
                    { 105, 37, 16, "Książka autorstwa: J.K. Rowling o tytule: Ink Black Heart wydana w roku: 2022", 12.97m, "Ink Black Heart", 2022 },
                    { 106, 38, 50, "Książka autorstwa: J.R.R. Tolkien o tytule: Parma Eldalamberon 17 wydana w roku: 2021", 10.28m, "Parma Eldalamberon 17", 2021 },
                    { 107, 38, 20, "Książka autorstwa: J.R.R. Tolkien o tytule: Quenya Phonology wydana w roku: 2021", 17.69m, "Quenya Phonology", 2021 },
                    { 108, 38, 28, "Książka autorstwa: J.R.R. Tolkien o tytule: The Nature of Middle-Earth wydana w roku: 2021", 10.12m, "The Nature of Middle-Earth", 2021 },
                    { 109, 39, 17, "Książka autorstwa: Agatha Christie o tytule: Man in the Brown Suit wydana w roku: 2024", 29.54m, "Man in the Brown Suit", 2024 },
                    { 110, 39, 16, "Książka autorstwa: Agatha Christie o tytule: Poirot's Early Cases wydana w roku: 2024", 14.40m, "Poirot's Early Cases", 2024 },
                    { 111, 39, 46, "Książka autorstwa: Agatha Christie o tytule: Agatha Christie's Diamonds and Death wydana w roku: 2024", 47.1m, "Agatha Christie's Diamonds and Death", 2024 },
                    { 112, 40, 35, "Książka autorstwa: Leo Tolstoy o tytule: Tolstoy Bilingual wydana w roku: 2024", 32.98m, "Tolstoy Bilingual", 2024 },
                    { 113, 40, 24, "Książka autorstwa: Leo Tolstoy o tytule: Kingdom of God Is Within You (Warbler Classics Annotated Edition) wydana w roku: 2024", 11.95m, "Kingdom of God Is Within You (Warbler Classics Annotated Edition)", 2024 },
                    { 114, 40, 16, "Książka autorstwa: Leo Tolstoy o tytule: Tolstoy Illustrated wydana w roku: 2023", 44.82m, "Tolstoy Illustrated", 2023 },
                    { 115, 41, 33, "Książka autorstwa: Fyodor Dostoevsky o tytule: White Nights (Warbler Classics Annotated Edition) wydana w roku: 2024", 26.83m, "White Nights (Warbler Classics Annotated Edition)", 2024 },
                    { 116, 41, 18, "Książka autorstwa: Fyodor Dostoevsky o tytule: Notes from the Underground (Heathen Edition) wydana w roku: 2023", 42.91m, "Notes from the Underground (Heathen Edition)", 2023 },
                    { 117, 41, 11, "Książka autorstwa: Fyodor Dostoevsky o tytule: Classic Christmas Stories wydana w roku: 2022", 30.38m, "Classic Christmas Stories", 2022 },
                    { 118, 42, 42, "Książka autorstwa: Gabriel García Márquez o tytule: Until August wydana w roku: 2024", 44.87m, "Until August", 2024 },
                    { 119, 42, 41, "Książka autorstwa: Gabriel García Márquez o tytule: 40 Short Stories -- Sixth Edition wydana w roku: 2021", 42.23m, "40 Short Stories -- Sixth Edition", 2021 },
                    { 120, 42, 44, "Książka autorstwa: Gabriel García Márquez o tytule: Scandal of the Century wydana w roku: 2020", 33.82m, "Scandal of the Century", 2020 },
                    { 121, 43, 49, "Książka autorstwa: Homer o tytule: Book of Revelation wydana w roku: 2024", 11.47m, "Book of Revelation", 2024 },
                    { 122, 43, 25, "Książka autorstwa: Homer o tytule: Prayer and Providence wydana w roku: 2024", 21.79m, "Prayer and Providence", 2024 },
                    { 123, 43, 50, "Książka autorstwa: Homer o tytule: Commentary on the Minor Prophets wydana w roku: 2024", 48.24m, "Commentary on the Minor Prophets", 2024 },
                    { 124, 44, 25, "Książka autorstwa: William Shakespeare o tytule: Sonnets wydana w roku: 2025", 25.50m, "Sonnets", 2025 },
                    { 125, 44, 48, "Książka autorstwa: William Shakespeare o tytule: St. Ives wydana w roku: 2025", 41.42m, "St. Ives", 2025 },
                    { 126, 44, 26, "Książka autorstwa: William Shakespeare o tytule: William Shakespeare's Measure for Measure - Unabridged wydana w roku: 2024", 20.68m, "William Shakespeare's Measure for Measure - Unabridged", 2024 },
                    { 127, 45, 29, "Książka autorstwa: Victor Hugo o tytule: Penguin Readers Level 4 wydana w roku: 2024", 27.91m, "Penguin Readers Level 4", 2024 },
                    { 128, 45, 46, "Książka autorstwa: Victor Hugo o tytule: Les Misérables wydana w roku: 2024", 22.11m, "Les Misérables", 2024 },
                    { 129, 45, 27, "Książka autorstwa: Victor Hugo o tytule: Miserables wydana w roku: 2023", 47.19m, "Miserables", 2023 },
                    { 130, 46, 41, "Książka autorstwa: Marcel Proust o tytule: Swanns Way wydana w roku: 2023", 48.94m, "Swanns Way", 2023 },
                    { 131, 46, 30, "Książka autorstwa: Marcel Proust o tytule: Swann in Love wydana w roku: 2023", 32.21m, "Swann in Love", 2023 },
                    { 132, 46, 19, "Książka autorstwa: Marcel Proust o tytule: Lettres à Horace Finaly wydana w roku: 2022", 16.66m, "Lettres à Horace Finaly", 2022 },
                    { 133, 47, 38, "Książka autorstwa: Franz Kafka o tytule: Metamorphosis and the Trial wydana w roku: 2024", 27.93m, "Metamorphosis and the Trial", 2024 },
                    { 134, 47, 18, "Książka autorstwa: Franz Kafka o tytule: Selected Stories wydana w roku: 2024", 31.50m, "Selected Stories", 2024 },
                    { 135, 47, 39, "Książka autorstwa: Franz Kafka o tytule: Franz Kafka's the Metamorphosis - Unabridged wydana w roku: 2024", 11.23m, "Franz Kafka's the Metamorphosis - Unabridged", 2024 },
                    { 136, 49, 31, "Książka autorstwa: James Joyce o tytule: Collected Epiphanies of James Joyce wydana w roku: 2024", 23.14m, "Collected Epiphanies of James Joyce", 2024 },
                    { 137, 49, 10, "Książka autorstwa: James Joyce o tytule: A Fistful of Pain wydana w roku: 2023", 14.76m, "A Fistful of Pain", 2023 },
                    { 138, 49, 31, "Książka autorstwa: James Joyce o tytule: James Joyce's the Dead - Unabridged wydana w roku: 2022", 12.58m, "James Joyce's the Dead - Unabridged", 2022 },
                    { 139, 50, 30, "Książka autorstwa: Virginia Woolf o tytule: Mrs. Dalloway (Heathen Edition) wydana w roku: 2024", 47.9m, "Mrs. Dalloway (Heathen Edition)", 2024 },
                    { 140, 50, 13, "Książka autorstwa: Virginia Woolf o tytule: In the Orchard : And Evening over Sussex wydana w roku: 2024", 40.60m, "In the Orchard : And Evening over Sussex", 2024 },
                    { 141, 50, 13, "Książka autorstwa: Virginia Woolf o tytule: Room of One's Own - Unabridged wydana w roku: 2024", 17.90m, "Room of One's Own - Unabridged", 2024 },
                    { 142, 51, 21, "Książka autorstwa: Arthur Conan Doyle o tytule: Return of Sherlock Holmes wydana w roku: 2024", 38.31m, "Return of Sherlock Holmes", 2024 },
                    { 143, 51, 17, "Książka autorstwa: Arthur Conan Doyle o tytule: Best of Sherlock Holmes - Volume II wydana w roku: 2024", 31.20m, "Best of Sherlock Holmes - Volume II", 2024 },
                    { 144, 51, 46, "Książka autorstwa: Arthur Conan Doyle o tytule: Adventures of Sherlock Holmes wydana w roku: 2024", 41.30m, "Adventures of Sherlock Holmes", 2024 },
                    { 145, 52, 20, "Książka autorstwa: Jack London o tytule: White Fang wydana w roku: 2024", 18.81m, "White Fang", 2024 },
                    { 146, 52, 32, "Książka autorstwa: Jack London o tytule: Jack London Collection - Call of the Wild and White Fang - Unabridged wydana w roku: 2023", 12.91m, "Jack London Collection - Call of the Wild and White Fang - Unabridged", 2023 },
                    { 147, 52, 27, "Książka autorstwa: Jack London o tytule: White Fang - Unabridged wydana w roku: 2023", 44.38m, "White Fang - Unabridged", 2023 },
                    { 148, 53, 24, "Książka autorstwa: Edgar Allan Poe o tytule: Tales of the Grotesque and Arabesque wydana w roku: 2024", 27.54m, "Tales of the Grotesque and Arabesque", 2024 },
                    { 149, 53, 28, "Książka autorstwa: Edgar Allan Poe o tytule: Spirited Engagement wydana w roku: 2023", 25.30m, "Spirited Engagement", 2023 },
                    { 150, 53, 11, "Książka autorstwa: Edgar Allan Poe o tytule: The Raven and Other Poems wydana w roku: 2023", 35.83m, "The Raven and Other Poems", 2023 },
                    { 151, 54, 31, "Książka autorstwa: H.G. Wells o tytule: Argonauts of the Air wydana w roku: 2023", 29.92m, "Argonauts of the Air", 2023 },
                    { 152, 54, 14, "Książka autorstwa: H.G. Wells o tytule: Chronic Argonauts & the Time Machine wydana w roku: 2023", 26.25m, "Chronic Argonauts & the Time Machine", 2023 },
                    { 153, 54, 34, "Książka autorstwa: H.G. Wells o tytule: Time Machine (Wells Trilogy) wydana w roku: 2023", 19.13m, "Time Machine (Wells Trilogy)", 2023 },
                    { 154, 55, 33, "Książka autorstwa: Mary Shelley o tytule: Mary Shelley's the Last Man wydana w roku: 2024", 20.39m, "Mary Shelley's the Last Man", 2024 },
                    { 155, 55, 36, "Książka autorstwa: Mary Shelley o tytule: Frankenstein or the Modern Prometheus - Unabridged wydana w roku: 2023", 32.67m, "Frankenstein or the Modern Prometheus - Unabridged", 2023 },
                    { 156, 55, 33, "Książka autorstwa: Mary Shelley o tytule: Santastein wydana w roku: 2023", 27.23m, "Santastein", 2023 },
                    { 157, 56, 32, "Książka autorstwa: Margaret Atwood o tytule: Paper Boat : New and Selected Poems wydana w roku: 2024", 23.12m, "Paper Boat : New and Selected Poems", 2024 },
                    { 158, 56, 19, "Książka autorstwa: Margaret Atwood o tytule: Handmaid's Tale wydana w roku: 2024", 46.23m, "Handmaid's Tale", 2024 },
                    { 159, 56, 17, "Książka autorstwa: Margaret Atwood o tytule: Furies wydana w roku: 2023", 12.42m, "Furies", 2023 },
                    { 160, 57, 25, "Książka autorstwa: Kazuo Ishiguro o tytule: Summer We Crossed Europe in the Rain wydana w roku: 2024", 39.73m, "Summer We Crossed Europe in the Rain", 2024 },
                    { 161, 57, 18, "Książka autorstwa: Kazuo Ishiguro o tytule: Buried Giant wydana w roku: 2022", 12.76m, "Buried Giant", 2022 },
                    { 162, 57, 38, "Książka autorstwa: Kazuo Ishiguro o tytule: Pale View of Hills wydana w roku: 2019", 33.47m, "Pale View of Hills", 2019 },
                    { 163, 58, 12, "Książka autorstwa: Haruki Murakami o tytule: End of the World and Hard-Boiled Wonderland wydana w roku: 2024", 11.4m, "End of the World and Hard-Boiled Wonderland", 2024 },
                    { 164, 58, 50, "Książka autorstwa: Haruki Murakami o tytule: Novelist As a Vocation wydana w roku: 2022", 23.84m, "Novelist As a Vocation", 2022 },
                    { 165, 58, 48, "Książka autorstwa: Haruki Murakami o tytule: Chip Kidd wydana w roku: 2021", 16.58m, "Chip Kidd", 2021 },
                    { 166, 59, 42, "Książka autorstwa: Chinua Achebe o tytule: Backpack Literature -- Sixth edition wydana w roku: 2020", 26.77m, "Backpack Literature -- Sixth edition", 2020 },
                    { 167, 59, 50, "Książka autorstwa: Chinua Achebe o tytule: Literature and the Writing Process -- eleventh edition wydana w roku: 2018", 17.88m, "Literature and the Writing Process -- eleventh edition", 2018 },
                    { 168, 59, 39, "Książka autorstwa: Chinua Achebe o tytule: Africa's Tarnished Name wydana w roku: 2018", 47.28m, "Africa's Tarnished Name", 2018 },
                    { 169, 60, 44, "Książka autorstwa: Isabel Allende o tytule: El viento conoce mi nombre wydana w roku: 2023", 31.91m, "El viento conoce mi nombre", 2023 },
                    { 170, 60, 43, "Książka autorstwa: Isabel Allende o tytule: Violeta wydana w roku: 2022", 25.24m, "Violeta", 2022 },
                    { 171, 60, 23, "Książka autorstwa: Isabel Allende o tytule: Mujeres del alma mía wydana w roku: 2020", 15.31m, "Mujeres del alma mía", 2020 },
                    { 172, 61, 28, "Książka autorstwa: Salman Rushdie o tytule: Victory City wydana w roku: 2024", 33.92m, "Victory City", 2024 },
                    { 173, 61, 38, "Książka autorstwa: Salman Rushdie o tytule: Very Indian Christmas wydana w roku: 2024", 45.30m, "Very Indian Christmas", 2024 },
                    { 174, 61, 24, "Książka autorstwa: Salman Rushdie o tytule: Knife wydana w roku: 2024", 12.9m, "Knife", 2024 },
                    { 175, 62, 28, "Książka autorstwa: Toni Morrison o tytule: Desdemona wydana w roku: 2024", 21.87m, "Desdemona", 2024 },
                    { 176, 62, 13, "Książka autorstwa: Toni Morrison o tytule: Toni Morrison Treasury wydana w roku: 2023", 49.41m, "Toni Morrison Treasury", 2023 },
                    { 177, 62, 38, "Książka autorstwa: Toni Morrison o tytule: Recitatif wydana w roku: 2022", 25.4m, "Recitatif", 2022 },
                    { 178, 63, 36, "Książka autorstwa: Alice Munro o tytule: Selected Stories Volume Two : 1995-2009 wydana w roku: 2021", 18.1m, "Selected Stories Volume Two : 1995-2009", 2021 },
                    { 179, 63, 30, "Książka autorstwa: Alice Munro o tytule: Julieta wydana w roku: 2016", 41.1m, "Julieta", 2016 },
                    { 180, 63, 24, "Książka autorstwa: Alice Munro o tytule: A Wilderness Station wydana w roku: 2015", 41.84m, "A Wilderness Station", 2015 },
                    { 181, 64, 47, "Książka autorstwa: V.S. Naipaul o tytule: House for Mr Biswas wydana w roku: 2024", 24.73m, "House for Mr Biswas", 2024 },
                    { 182, 64, 41, "Książka autorstwa: V.S. Naipaul o tytule: India wydana w roku: 2017", 30.97m, "India", 2017 },
                    { 183, 64, 39, "Książka autorstwa: V.S. Naipaul o tytule: House For Mr Biswas wydana w roku: 2016", 27.16m, "House For Mr Biswas", 2016 },
                    { 184, 65, 27, "Książka autorstwa: Orhan Pamuk o tytule: Nights of Plague * Exp * wydana w roku: 2022", 21.33m, "Nights of Plague * Exp *", 2022 },
                    { 185, 65, 47, "Książka autorstwa: Orhan Pamuk o tytule: Chip Kidd wydana w roku: 2021", 24.96m, "Chip Kidd", 2021 },
                    { 186, 65, 45, "Książka autorstwa: Orhan Pamuk o tytule: Veba Geceleri wydana w roku: 2021", 47.44m, "Veba Geceleri", 2021 },
                    { 187, 66, 35, "Książka autorstwa: Milan Kundera o tytule: Let the Old Dead Make Room for the New Dead wydana w roku: 2019", 43.3m, "Let the Old Dead Make Room for the New Dead", 2019 },
                    { 188, 66, 25, "Książka autorstwa: Milan Kundera o tytule: K̲h̲andah aur farāmoshī kī kitāb wydana w roku: 2018", 11.98m, "K̲h̲andah aur farāmoshī kī kitāb", 2018 },
                    { 189, 66, 15, "Książka autorstwa: Milan Kundera o tytule: Festival of Insignificance wydana w roku: 2015", 23.93m, "Festival of Insignificance", 2015 },
                    { 190, 67, 14, "Książka autorstwa: Umberto Eco o tytule: Sicilian Avengers wydana w roku: 2024", 47.18m, "Sicilian Avengers", 2024 },
                    { 191, 67, 33, "Książka autorstwa: Umberto Eco o tytule: Poetry of Translation wydana w roku: 2022", 41.49m, "Poetry of Translation", 2022 },
                    { 192, 67, 45, "Książka autorstwa: Umberto Eco o tytule: Filosofi in libertà wydana w roku: 2022", 28.68m, "Filosofi in libertà", 2022 },
                    { 193, 68, 33, "Książka autorstwa: Elena Ferrante o tytule: My Brilliant Friend wydana w roku: 2023", 39.53m, "My Brilliant Friend", 2023 },
                    { 194, 68, 29, "Książka autorstwa: Elena Ferrante o tytule: In the Margins wydana w roku: 2021", 32.58m, "In the Margins", 2021 },
                    { 195, 68, 49, "Książka autorstwa: Elena Ferrante o tytule: La vita bugiarda degli adulti wydana w roku: 2019", 21.67m, "La vita bugiarda degli adulti", 2019 },
                    { 196, 69, 36, "Książka autorstwa: John Steinbeck o tytule: Zhe Sdang Gi Rgun 'brum wydana w roku: 2022", 19.38m, "Zhe Sdang Gi Rgun 'brum", 2022 },
                    { 197, 69, 50, "Książka autorstwa: John Steinbeck o tytule: Witchfinder Omnibus Volume 1 wydana w roku: 2019", 40.45m, "Witchfinder Omnibus Volume 1", 2019 },
                    { 198, 69, 46, "Książka autorstwa: John Steinbeck o tytule: Classic Stories of World War II wydana w roku: 2018", 14.22m, "Classic Stories of World War II", 2018 },
                    { 199, 70, 40, "Książka autorstwa: Harper Lee o tytule: Trailer Park Opportunities wydana w roku: 2023", 28.50m, "Trailer Park Opportunities", 2023 },
                    { 200, 70, 43, "Książka autorstwa: Harper Lee o tytule: On Lee's to Kill a Mockingbird : (CliffsNotes, 2nd Edition) wydana w roku: 2022", 45.96m, "On Lee's to Kill a Mockingbird : (CliffsNotes, 2nd Edition)", 2022 },
                    { 201, 70, 44, "Książka autorstwa: Harper Lee o tytule: Creative Writing wydana w roku: 2020", 28.10m, "Creative Writing", 2020 },
                    { 202, 71, 12, "Książka autorstwa: Kurt Vonnegut o tytule: Slaughterhouse-Five wydana w roku: 2023", 43.92m, "Slaughterhouse-Five", 2023 },
                    { 203, 71, 16, "Książka autorstwa: Kurt Vonnegut o tytule: Palm Sunday wydana w roku: 2021", 49.70m, "Palm Sunday", 2021 },
                    { 204, 71, 14, "Książka autorstwa: Kurt Vonnegut o tytule: Slaughterhouse 5 wydana w roku: 2020", 42.74m, "Slaughterhouse 5", 2020 },
                    { 205, 72, 42, "Książka autorstwa: Ray Bradbury o tytule: Adventures #7 wydana w roku: 2023", 13.16m, "Adventures #7", 2023 },
                    { 206, 72, 32, "Książka autorstwa: Ray Bradbury o tytule: The Shape of Things wydana w roku: 2023", 49.44m, "The Shape of Things", 2023 },
                    { 207, 72, 20, "Książka autorstwa: Ray Bradbury o tytule: Home to Stay! wydana w roku: 2022", 29.87m, "Home to Stay!", 2022 },
                    { 208, 73, 34, "Książka autorstwa: Aldous Huxley o tytule: Brave New World wydana w roku: 2024", 15.22m, "Brave New World", 2024 },
                    { 209, 73, 35, "Książka autorstwa: Aldous Huxley o tytule: Art of Seeing wydana w roku: 2023", 24.74m, "Art of Seeing", 2023 },
                    { 210, 73, 41, "Książka autorstwa: Aldous Huxley o tytule: Brave New World wydana w roku: 2022", 11.3m, "Brave New World", 2022 },
                    { 211, 74, 16, "Książka autorstwa: George R.R. Martin o tytule: George R. R. Martin Presents Wild Cards : Sleeper Straddle wydana w roku: 2024", 24.7m, "George R. R. Martin Presents Wild Cards : Sleeper Straddle", 2024 },
                    { 212, 74, 36, "Książka autorstwa: George R.R. Martin o tytule: Puerto Estelar. Novela Gráfica / Starport (Graphic Novel) wydana w roku: 2021", 32.99m, "Puerto Estelar. Novela Gráfica / Starport (Graphic Novel)", 2021 },
                    { 213, 74, 20, "Książka autorstwa: George R.R. Martin o tytule: Fire and Blood wydana w roku: 2021", 22.89m, "Fire and Blood", 2021 },
                    { 214, 75, 50, "Książka autorstwa: Isaac Asimov o tytule: Adventures #11 wydana w roku: 2023", 32.85m, "Adventures #11", 2023 },
                    { 215, 75, 42, "Książka autorstwa: Isaac Asimov o tytule: Foundation Complete Series Set, 7 Books. Foundation, Second Foundation, Foundation and Empire, Foundation's Edge, Prelude to Foundation, Foundation and Earth, Forward the Foundation wydana w roku: 2021", 34.42m, "Foundation Complete Series Set, 7 Books. Foundation, Second Foundation, Foundation and Empire, Foundation's Edge, Prelude to Foundation, Foundation and Earth, Forward the Foundation", 2021 },
                    { 216, 75, 24, "Książka autorstwa: Isaac Asimov o tytule: One Hundred wydana w roku: 2020", 49.25m, "One Hundred", 2020 },
                    { 217, 76, 17, "Książka autorstwa: Philip K. Dick o tytule: Variable Man and Other Stories wydana w roku: 2023", 41.40m, "Variable Man and Other Stories", 2023 },
                    { 218, 76, 24, "Książka autorstwa: Philip K. Dick o tytule: Short Stories wydana w roku: 2023", 41.77m, "Short Stories", 2023 },
                    { 219, 76, 41, "Książka autorstwa: Philip K. Dick o tytule: Radio Free Albemuth wydana w roku: 2023", 13.77m, "Radio Free Albemuth", 2023 },
                    { 220, 77, 47, "Książka autorstwa: Arthur C. Clarke o tytule: Arthur C. Clarke's Venus Prime 1-Breaking Strain wydana w roku: 2021", 41.81m, "Arthur C. Clarke's Venus Prime 1-Breaking Strain", 2021 },
                    { 221, 77, 18, "Książka autorstwa: Arthur C. Clarke o tytule: Arthur C. Clarke's Venus Prime 4-The Medusa Encounter wydana w roku: 2021", 31.94m, "Arthur C. Clarke's Venus Prime 4-The Medusa Encounter", 2021 },
                    { 222, 77, 14, "Książka autorstwa: Arthur C. Clarke o tytule: Arthur C. Clarke's Venus Prime 2-Maelstrom wydana w roku: 2021", 19.37m, "Arthur C. Clarke's Venus Prime 2-Maelstrom", 2021 },
                    { 223, 78, 17, "Książka autorstwa: Neil Gaiman o tytule: Unti Gaiman Novel #7 wydana w roku: 2024", 26.54m, "Unti Gaiman Novel #7", 2024 },
                    { 224, 78, 10, "Książka autorstwa: Neil Gaiman o tytule: NO REMORSE wydana w roku: 2024", 16.49m, "NO REMORSE", 2024 },
                    { 225, 78, 11, "Książka autorstwa: Neil Gaiman o tytule: Bioluminescent wydana w roku: 2023", 26.66m, "Bioluminescent", 2023 },
                    { 226, 79, 18, "Książka autorstwa: Stephen King o tytule: Every Flower Has Its Place wydana w roku: 2024", 27.92m, "Every Flower Has Its Place", 2024 },
                    { 227, 79, 46, "Książka autorstwa: Stephen King o tytule: Billy Summers wydana w roku: 2023", 43.16m, "Billy Summers", 2023 },
                    { 228, 79, 19, "Książka autorstwa: Stephen King o tytule: Cycle of the Werewolf wydana w roku: 2023", 34.11m, "Cycle of the Werewolf", 2023 },
                    { 229, 80, 44, "Książka autorstwa: Erich Maria Remarque o tytule: All Quiet on the Western Front - Unabridged wydana w roku: 2024", 34.31m, "All Quiet on the Western Front - Unabridged", 2024 },
                    { 230, 80, 27, "Książka autorstwa: Erich Maria Remarque o tytule: Im Westen Nichts Neues wydana w roku: 2024", 25.63m, "Im Westen Nichts Neues", 2024 },
                    { 231, 80, 42, "Książka autorstwa: Erich Maria Remarque o tytule: Schatten im Paradies (New York Intermezzo) wydana w roku: 2018", 19.43m, "Schatten im Paradies (New York Intermezzo)", 2018 },
                    { 232, 81, 45, "Książka autorstwa: Hermann Hesse o tytule: Demian wydana w roku: 2024", 45.47m, "Demian", 2024 },
                    { 233, 81, 20, "Książka autorstwa: Hermann Hesse o tytule: »Umgaukelt Von Westlichen und Östlichen Ködern« wydana w roku: 2023", 19.83m, "»Umgaukelt Von Westlichen und Östlichen Ködern«", 2023 },
                    { 234, 81, 24, "Książka autorstwa: Hermann Hesse o tytule: »&Gt; Große Zeiten&Lt; Hinterlassen Große Schutthaufen« wydana w roku: 2023", 21.7m, "»&Gt; Große Zeiten&Lt; Hinterlassen Große Schutthaufen«", 2023 },
                    { 235, 82, 22, "Książka autorstwa: Khaled Hosseini o tytule: Sea Prayer wydana w roku: 2018", 18.41m, "Sea Prayer", 2018 },
                    { 236, 82, 28, "Książka autorstwa: Khaled Hosseini o tytule: The Battle within wydana w roku: 2018", 18.3m, "The Battle within", 2018 },
                    { 237, 82, 38, "Książka autorstwa: Khaled Hosseini o tytule: Kŭrigo san i ullyŏtta wydana w roku: 2013", 16.11m, "Kŭrigo san i ullyŏtta", 2013 },
                    { 238, 83, 47, "Książka autorstwa: J.D. Salinger o tytule: For Esme wydana w roku: 2018", 18.50m, "For Esme", 2018 },
                    { 239, 83, 35, "Książka autorstwa: J.D. Salinger o tytule: Raise High the Roof Beam, Carpenters and Seymour wydana w roku: 2018", 28.93m, "Raise High the Roof Beam, Carpenters and Seymour", 2018 },
                    { 240, 83, 47, "Książka autorstwa: J.D. Salinger o tytule: Raise High the Roof Beam, Carpenters; Seymour - an Introduction wydana w roku: 2018", 34.33m, "Raise High the Roof Beam, Carpenters; Seymour - an Introduction", 2018 },
                    { 241, 84, 27, "Książka autorstwa: Joseph Conrad o tytule: Heart of Darkness and the Secret Agent wydana w roku: 2024", 19.6m, "Heart of Darkness and the Secret Agent", 2024 },
                    { 242, 84, 48, "Książka autorstwa: Joseph Conrad o tytule: First Love & Spring Torrents (Warbler Classics Annotated Edition) wydana w roku: 2024", 43.41m, "First Love & Spring Torrents (Warbler Classics Annotated Edition)", 2024 },
                    { 243, 84, 18, "Książka autorstwa: Joseph Conrad o tytule: Horror wydana w roku: 2023", 16.1m, "Horror", 2023 },
                    { 244, 85, 37, "Książka autorstwa: John Grisham o tytule: Camino Ghosts wydana w roku: 2024", 10.79m, "Camino Ghosts", 2024 },
                    { 245, 85, 30, "Książka autorstwa: John Grisham o tytule: The #1 Lawyer wydana w roku: 2024", 38.59m, "The #1 Lawyer", 2024 },
                    { 246, 85, 40, "Książka autorstwa: John Grisham o tytule: Boys from Biloxi wydana w roku: 2023", 42.61m, "Boys from Biloxi", 2023 },
                    { 247, 86, 48, "Książka autorstwa: Dan Brown o tytule: Gigi wydana w roku: 2024", 28.31m, "Gigi", 2024 },
                    { 248, 86, 35, "Książka autorstwa: Dan Brown o tytule: Gigi wydana w roku: 2023", 31.89m, "Gigi", 2023 },
                    { 249, 86, 37, "Książka autorstwa: Dan Brown o tytule: Trout wydana w roku: 2023", 39.90m, "Trout", 2023 },
                    { 250, 87, 50, "Książka autorstwa: Douglas Adams o tytule: Dark Tides of Mars wydana w roku: 2023", 17.20m, "Dark Tides of Mars", 2023 },
                    { 251, 87, 37, "Książka autorstwa: Douglas Adams o tytule: Dark Tides of Mars Collector's Edition wydana w roku: 2023", 41.45m, "Dark Tides of Mars Collector's Edition", 2023 },
                    { 252, 87, 14, "Książka autorstwa: Douglas Adams o tytule: Routledge Handbook of Sport History wydana w roku: 2021", 17.32m, "Routledge Handbook of Sport History", 2021 },
                    { 253, 88, 35, "Książka autorstwa: Michael Crichton o tytule: Andromeda Evolution wydana w roku: 2019", 18.16m, "Andromeda Evolution", 2019 },
                    { 254, 88, 19, "Książka autorstwa: Michael Crichton o tytule: Dragon Teeth wydana w roku: 2017", 45.30m, "Dragon Teeth", 2017 },
                    { 255, 88, 31, "Książka autorstwa: Michael Crichton o tytule: DRAGON TEETH wydana w roku: 2017", 21.34m, "DRAGON TEETH", 2017 },
                    { 256, 89, 16, "Książka autorstwa: Roald Dahl o tytule: Fantastic Mr Fox wydana w roku: 2024", 29.17m, "Fantastic Mr Fox", 2024 },
                    { 257, 89, 46, "Książka autorstwa: Roald Dahl o tytule: Giraffe and the Pelly and Me wydana w roku: 2024", 42.76m, "Giraffe and the Pelly and Me", 2024 },
                    { 258, 89, 43, "Książka autorstwa: Roald Dahl o tytule: Magic Finger wydana w roku: 2024", 49.22m, "Magic Finger", 2024 },
                    { 259, 90, 21, "Książka autorstwa: Anne Rice o tytule: Belinda/Exit to Eden wydana w roku: 2019", 39.15m, "Belinda/Exit to Eden", 2019 },
                    { 260, 90, 10, "Książka autorstwa: Anne Rice o tytule: Helping Injured Animals wydana w roku: 2019", 41.24m, "Helping Injured Animals", 2019 },
                    { 261, 90, 28, "Książka autorstwa: Anne Rice o tytule: Blood Communion wydana w roku: 2018", 25.89m, "Blood Communion", 2018 },
                    { 262, 91, 16, "Książka autorstwa: Paulo Coelho o tytule: Manual of The Warrior of Light wydana w roku: 2021", 24.70m, "Manual of The Warrior of Light", 2021 },
                    { 263, 91, 42, "Książka autorstwa: Paulo Coelho o tytule: Te Ruanuku [The Alchemist] wydana w roku: 2020", 30.62m, "Te Ruanuku [The Alchemist]", 2020 },
                    { 264, 91, 17, "Książka autorstwa: Paulo Coelho o tytule: Arquero wydana w roku: 2020", 41.37m, "Arquero", 2020 },
                    { 265, 92, 48, "Książka autorstwa: John Irving o tytule: The Last Chairlift wydana w roku: 2023", 43.22m, "The Last Chairlift", 2023 },
                    { 266, 92, 21, "Książka autorstwa: John Irving o tytule: Thirteenth Floor wydana w roku: 2023", 40.55m, "Thirteenth Floor", 2023 },
                    { 267, 92, 48, "Książka autorstwa: John Irving o tytule: Tu Invitación wydana w roku: 2022", 40.62m, "Tu Invitación", 2022 },
                    { 268, 93, 17, "Książka autorstwa: Sylvia Plath o tytule: Mary Ventura y el noveno reino / Mary Ventura and the Ninth Kingdom wydana w roku: 2020", 27.3m, "Mary Ventura y el noveno reino / Mary Ventura and the Ninth Kingdom", 2020 },
                    { 269, 93, 22, "Książka autorstwa: Sylvia Plath o tytule: Mary Ventura and the Ninth Kingdom wydana w roku: 2019", 20.99m, "Mary Ventura and the Ninth Kingdom", 2019 },
                    { 270, 93, 48, "Książka autorstwa: Sylvia Plath o tytule: Letters of Sylvia Plath Volume II wydana w roku: 2018", 45.21m, "Letters of Sylvia Plath Volume II", 2018 },
                    { 271, 94, 46, "Książka autorstwa: Emily Bronte o tytule: Wuthering Heights - Unabridged wydana w roku: 2024", 49.50m, "Wuthering Heights - Unabridged", 2024 },
                    { 272, 94, 24, "Książka autorstwa: Emily Bronte o tytule: Brontë Sisters Collection - Jane Eyre - Wuthering Heights - the Tenant of Wildfell Hall - Unabridged wydana w roku: 2023", 15.28m, "Brontë Sisters Collection - Jane Eyre - Wuthering Heights - the Tenant of Wildfell Hall - Unabridged", 2023 },
                    { 273, 94, 40, "Książka autorstwa: Emily Bronte o tytule: Vanity Fair wydana w roku: 2020", 32.78m, "Vanity Fair", 2020 },
                    { 274, 95, 20, "Książka autorstwa: Charlotte Bronte o tytule: Jane Eyre - Unabridged wydana w roku: 2024", 22.67m, "Jane Eyre - Unabridged", 2024 },
                    { 275, 95, 33, "Książka autorstwa: Charlotte Bronte o tytule: Biographical Notes on the Pseudonymous Bells - Unabridged wydana w roku: 2024", 48.7m, "Biographical Notes on the Pseudonymous Bells - Unabridged", 2024 },
                    { 276, 95, 22, "Książka autorstwa: Charlotte Bronte o tytule: Classic Romance Collection - Volume I - Jane Eyre - Lady Chatterley's Lover - o Pioneers! - Unabridged wydana w roku: 2024", 16.83m, "Classic Romance Collection - Volume I - Jane Eyre - Lady Chatterley's Lover - o Pioneers! - Unabridged", 2024 },
                    { 277, 96, 26, "Książka autorstwa: Emily Dickinson o tytule: Petite Poems Hope Is the Thing with Feathers wydana w roku: 2024", 45.85m, "Petite Poems Hope Is the Thing with Feathers", 2024 },
                    { 278, 96, 29, "Książka autorstwa: Emily Dickinson o tytule: Letters of Emily Dickinson wydana w roku: 2024", 19.56m, "Letters of Emily Dickinson", 2024 },
                    { 279, 96, 19, "Książka autorstwa: Emily Dickinson o tytule: Enchantment wydana w roku: 2024", 42.14m, "Enchantment", 2024 },
                    { 280, 97, 30, "Książka autorstwa: Oscar Wilde o tytule: Lord Arthur Savile's Crime and Other Stories wydana w roku: 2023", 10.33m, "Lord Arthur Savile's Crime and Other Stories", 2023 },
                    { 281, 97, 46, "Książka autorstwa: Oscar Wilde o tytule: De Profundis wydana w roku: 2023", 27.9m, "De Profundis", 2023 },
                    { 282, 97, 18, "Książka autorstwa: Oscar Wilde o tytule: Picture of Dorian Gray wydana w roku: 2023", 27.97m, "Picture of Dorian Gray", 2023 },
                    { 283, 98, 27, "Książka autorstwa: Charles Bukowski o tytule: Prying wydana w roku: 2022", 33.98m, "Prying", 2022 },
                    { 284, 98, 34, "Książka autorstwa: Charles Bukowski o tytule: On Drinking wydana w roku: 2019", 20.81m, "On Drinking", 2019 },
                    { 285, 98, 23, "Książka autorstwa: Charles Bukowski o tytule: Storm for the Living and the Dead wydana w roku: 2019", 38.77m, "Storm for the Living and the Dead", 2019 },
                    { 286, 99, 36, "Książka autorstwa: Robert Frost o tytule: History of Central and Northern Europe wydana w roku: 2025", 15.35m, "History of Central and Northern Europe", 2025 },
                    { 287, 99, 29, "Książka autorstwa: Robert Frost o tytule: Polish Portrait of Bonnie Prince Charlie wydana w roku: 2023", 31.80m, "Polish Portrait of Bonnie Prince Charlie", 2023 },
                    { 288, 99, 29, "Książka autorstwa: Robert Frost o tytule: Multicultural Commonwealth wydana w roku: 2023", 31.90m, "Multicultural Commonwealth", 2023 },
                    { 289, 100, 48, "Książka autorstwa: Markus Zusak o tytule: Bratʹi︠a︡ Volf wydana w roku: 2015", 43.81m, "Bratʹi︠a︡ Volf", 2015 },
                    { 290, 100, 14, "Książka autorstwa: Markus Zusak o tytule: Złodziejka książek wydana w roku: 2014", 30.36m, "Złodziejka książek", 2014 },
                    { 291, 100, 28, "Książka autorstwa: Markus Zusak o tytule: Underdogs wydana w roku: 2011", 35.16m, "Underdogs", 2011 }
                });

            migrationBuilder.InsertData(
                table: "ItemsGenres",
                columns: new[] { "Id", "GenreId", "ItemId" },
                values: new object[,]
                {
                    { 1, 10, 1 },
                    { 2, 24, 2 },
                    { 3, 6, 3 },
                    { 4, 3, 4 },
                    { 5, 1, 5 },
                    { 6, 10, 6 },
                    { 7, 25, 7 },
                    { 8, 22, 8 },
                    { 9, 16, 9 },
                    { 10, 7, 10 },
                    { 11, 10, 11 },
                    { 12, 2, 12 },
                    { 13, 10, 13 },
                    { 14, 4, 14 },
                    { 15, 25, 15 },
                    { 16, 12, 16 },
                    { 17, 7, 17 },
                    { 18, 15, 18 },
                    { 19, 8, 19 },
                    { 20, 7, 20 },
                    { 21, 17, 21 },
                    { 22, 19, 22 },
                    { 23, 9, 23 },
                    { 24, 26, 24 },
                    { 25, 14, 25 },
                    { 26, 24, 26 },
                    { 27, 7, 27 },
                    { 28, 5, 28 },
                    { 29, 3, 29 },
                    { 30, 23, 30 },
                    { 31, 26, 31 },
                    { 32, 15, 32 },
                    { 33, 18, 33 },
                    { 34, 24, 34 },
                    { 35, 2, 35 },
                    { 36, 1, 36 },
                    { 37, 4, 37 },
                    { 38, 20, 38 },
                    { 39, 24, 39 },
                    { 40, 14, 40 },
                    { 41, 14, 41 },
                    { 42, 15, 42 },
                    { 43, 22, 43 },
                    { 44, 26, 44 },
                    { 45, 13, 45 },
                    { 46, 14, 46 },
                    { 47, 2, 47 },
                    { 48, 23, 48 },
                    { 49, 21, 49 },
                    { 50, 25, 50 },
                    { 51, 5, 51 },
                    { 52, 3, 52 },
                    { 53, 8, 53 },
                    { 54, 24, 54 },
                    { 55, 9, 55 },
                    { 56, 25, 56 },
                    { 57, 13, 57 },
                    { 58, 9, 58 },
                    { 59, 8, 59 },
                    { 60, 22, 60 },
                    { 61, 16, 61 },
                    { 62, 11, 62 },
                    { 63, 25, 63 },
                    { 64, 11, 64 },
                    { 65, 8, 65 },
                    { 66, 22, 66 },
                    { 67, 11, 67 },
                    { 68, 18, 68 },
                    { 69, 24, 69 },
                    { 70, 20, 70 },
                    { 71, 14, 71 },
                    { 72, 10, 72 },
                    { 73, 1, 73 },
                    { 74, 9, 74 },
                    { 75, 4, 75 },
                    { 76, 1, 76 },
                    { 77, 8, 77 },
                    { 78, 22, 78 },
                    { 79, 23, 79 },
                    { 80, 19, 80 },
                    { 81, 26, 81 },
                    { 82, 3, 82 },
                    { 83, 18, 83 },
                    { 84, 25, 84 },
                    { 85, 21, 85 },
                    { 86, 2, 86 },
                    { 87, 24, 87 },
                    { 88, 2, 88 },
                    { 89, 4, 89 },
                    { 90, 4, 90 },
                    { 91, 15, 91 },
                    { 92, 3, 92 },
                    { 93, 7, 93 },
                    { 94, 15, 94 },
                    { 95, 25, 95 },
                    { 96, 26, 96 },
                    { 97, 20, 97 },
                    { 98, 9, 98 },
                    { 99, 6, 99 },
                    { 100, 24, 100 },
                    { 101, 16, 101 },
                    { 102, 7, 102 },
                    { 103, 24, 103 },
                    { 104, 12, 104 },
                    { 105, 8, 105 },
                    { 106, 15, 106 },
                    { 107, 15, 107 },
                    { 108, 14, 108 },
                    { 109, 26, 109 },
                    { 110, 19, 110 },
                    { 111, 23, 111 },
                    { 112, 7, 112 },
                    { 113, 5, 113 },
                    { 114, 6, 114 },
                    { 115, 2, 115 },
                    { 116, 5, 116 },
                    { 117, 25, 117 },
                    { 118, 5, 118 },
                    { 119, 8, 119 },
                    { 120, 14, 120 },
                    { 121, 10, 121 },
                    { 122, 8, 122 },
                    { 123, 26, 123 },
                    { 124, 16, 124 },
                    { 125, 22, 125 },
                    { 126, 16, 126 },
                    { 127, 24, 127 },
                    { 128, 11, 128 },
                    { 129, 5, 129 },
                    { 130, 19, 130 },
                    { 131, 26, 131 },
                    { 132, 15, 132 },
                    { 133, 15, 133 },
                    { 134, 15, 134 },
                    { 135, 22, 135 },
                    { 136, 2, 136 },
                    { 137, 16, 137 },
                    { 138, 13, 138 },
                    { 139, 17, 139 },
                    { 140, 14, 140 },
                    { 141, 2, 141 },
                    { 142, 15, 142 },
                    { 143, 2, 143 },
                    { 144, 22, 144 },
                    { 145, 13, 145 },
                    { 146, 10, 146 },
                    { 147, 4, 147 },
                    { 148, 8, 148 },
                    { 149, 17, 149 },
                    { 150, 15, 150 },
                    { 151, 12, 151 },
                    { 152, 2, 152 },
                    { 153, 14, 153 },
                    { 154, 17, 154 },
                    { 155, 18, 155 },
                    { 156, 24, 156 },
                    { 157, 25, 157 },
                    { 158, 9, 158 },
                    { 159, 16, 159 },
                    { 160, 12, 160 },
                    { 161, 15, 161 },
                    { 162, 4, 162 },
                    { 163, 18, 163 },
                    { 164, 23, 164 },
                    { 165, 3, 165 },
                    { 166, 12, 166 },
                    { 167, 13, 167 },
                    { 168, 6, 168 },
                    { 169, 18, 169 },
                    { 170, 10, 170 },
                    { 171, 17, 171 },
                    { 172, 15, 172 },
                    { 173, 17, 173 },
                    { 174, 4, 174 },
                    { 175, 5, 175 },
                    { 176, 16, 176 },
                    { 177, 3, 177 },
                    { 178, 25, 178 },
                    { 179, 8, 179 },
                    { 180, 9, 180 },
                    { 181, 18, 181 },
                    { 182, 18, 182 },
                    { 183, 19, 183 },
                    { 184, 9, 184 },
                    { 185, 20, 185 },
                    { 186, 26, 186 },
                    { 187, 17, 187 },
                    { 188, 21, 188 },
                    { 189, 20, 189 },
                    { 190, 24, 190 },
                    { 191, 13, 191 },
                    { 192, 10, 192 },
                    { 193, 19, 193 },
                    { 194, 8, 194 },
                    { 195, 4, 195 },
                    { 196, 4, 196 },
                    { 197, 20, 197 },
                    { 198, 17, 198 },
                    { 199, 5, 199 },
                    { 200, 18, 200 },
                    { 201, 19, 201 },
                    { 202, 5, 202 },
                    { 203, 20, 203 },
                    { 204, 2, 204 },
                    { 205, 19, 205 },
                    { 206, 20, 206 },
                    { 207, 1, 207 },
                    { 208, 14, 208 },
                    { 209, 3, 209 },
                    { 210, 22, 210 },
                    { 211, 19, 211 },
                    { 212, 9, 212 },
                    { 213, 10, 213 },
                    { 214, 18, 214 },
                    { 215, 10, 215 },
                    { 216, 12, 216 },
                    { 217, 20, 217 },
                    { 218, 25, 218 },
                    { 219, 24, 219 },
                    { 220, 3, 220 },
                    { 221, 10, 221 },
                    { 222, 16, 222 },
                    { 223, 6, 223 },
                    { 224, 19, 224 },
                    { 225, 16, 225 },
                    { 226, 13, 226 },
                    { 227, 26, 227 },
                    { 228, 9, 228 },
                    { 229, 3, 229 },
                    { 230, 14, 230 },
                    { 231, 26, 231 },
                    { 232, 7, 232 },
                    { 233, 12, 233 },
                    { 234, 20, 234 },
                    { 235, 1, 235 },
                    { 236, 5, 236 },
                    { 237, 14, 237 },
                    { 238, 18, 238 },
                    { 239, 26, 239 },
                    { 240, 26, 240 },
                    { 241, 13, 241 },
                    { 242, 20, 242 },
                    { 243, 13, 243 },
                    { 244, 21, 244 },
                    { 245, 14, 245 },
                    { 246, 5, 246 },
                    { 247, 12, 247 },
                    { 248, 20, 248 },
                    { 249, 25, 249 },
                    { 250, 4, 250 },
                    { 251, 7, 251 },
                    { 252, 16, 252 },
                    { 253, 4, 253 },
                    { 254, 4, 254 },
                    { 255, 12, 255 },
                    { 256, 20, 256 },
                    { 257, 23, 257 },
                    { 258, 2, 258 },
                    { 259, 13, 259 },
                    { 260, 4, 260 },
                    { 261, 7, 261 },
                    { 262, 23, 262 },
                    { 263, 7, 263 },
                    { 264, 11, 264 },
                    { 265, 23, 265 },
                    { 266, 23, 266 },
                    { 267, 21, 267 },
                    { 268, 6, 268 },
                    { 269, 15, 269 },
                    { 270, 7, 270 },
                    { 271, 11, 271 },
                    { 272, 4, 272 },
                    { 273, 17, 273 },
                    { 274, 25, 274 },
                    { 275, 8, 275 },
                    { 276, 2, 276 },
                    { 277, 1, 277 },
                    { 278, 2, 278 },
                    { 279, 3, 279 },
                    { 280, 17, 280 },
                    { 281, 14, 281 },
                    { 282, 15, 282 },
                    { 283, 17, 283 },
                    { 284, 12, 284 },
                    { 285, 5, 285 },
                    { 286, 5, 286 },
                    { 287, 25, 287 },
                    { 288, 16, 288 },
                    { 289, 26, 289 },
                    { 290, 4, 290 },
                    { 291, 18, 291 }
                });

            migrationBuilder.InsertData(
                table: "ItemsTypes",
                columns: new[] { "Id", "ItemId", "TypeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 2, 2 },
                    { 4, 2, 3 },
                    { 5, 2, 4 },
                    { 6, 3, 1 },
                    { 7, 3, 2 },
                    { 8, 4, 1 },
                    { 9, 5, 1 },
                    { 10, 5, 2 },
                    { 11, 5, 3 },
                    { 12, 5, 4 },
                    { 13, 6, 1 },
                    { 14, 7, 1 },
                    { 15, 7, 2 },
                    { 16, 7, 3 },
                    { 17, 8, 1 },
                    { 18, 8, 2 },
                    { 19, 9, 1 },
                    { 20, 10, 1 },
                    { 21, 11, 1 },
                    { 22, 11, 2 },
                    { 23, 11, 3 },
                    { 24, 11, 4 },
                    { 25, 12, 1 },
                    { 26, 12, 2 },
                    { 27, 13, 1 },
                    { 28, 13, 2 },
                    { 29, 14, 1 },
                    { 30, 14, 2 },
                    { 31, 14, 3 },
                    { 32, 14, 4 },
                    { 33, 15, 1 },
                    { 34, 15, 2 },
                    { 35, 16, 1 },
                    { 36, 16, 2 },
                    { 37, 16, 3 },
                    { 38, 17, 1 },
                    { 39, 17, 2 },
                    { 40, 17, 3 },
                    { 41, 18, 1 },
                    { 42, 18, 2 },
                    { 43, 18, 3 },
                    { 44, 18, 4 },
                    { 45, 19, 1 },
                    { 46, 20, 1 },
                    { 47, 21, 1 },
                    { 48, 22, 1 },
                    { 49, 22, 2 },
                    { 50, 23, 1 },
                    { 51, 23, 2 },
                    { 52, 24, 1 },
                    { 53, 24, 2 },
                    { 54, 24, 3 },
                    { 55, 25, 1 },
                    { 56, 25, 2 },
                    { 57, 25, 3 },
                    { 58, 25, 4 },
                    { 59, 26, 1 },
                    { 60, 27, 1 },
                    { 61, 27, 2 },
                    { 62, 27, 3 },
                    { 63, 28, 1 },
                    { 64, 28, 2 },
                    { 65, 28, 3 },
                    { 66, 28, 4 },
                    { 67, 29, 1 },
                    { 68, 30, 1 },
                    { 69, 31, 1 },
                    { 70, 31, 2 },
                    { 71, 32, 1 },
                    { 72, 32, 2 },
                    { 73, 32, 3 },
                    { 74, 33, 1 },
                    { 75, 33, 2 },
                    { 76, 34, 1 },
                    { 77, 34, 2 },
                    { 78, 34, 3 },
                    { 79, 35, 1 },
                    { 80, 35, 2 },
                    { 81, 35, 3 },
                    { 82, 35, 4 },
                    { 83, 36, 1 },
                    { 84, 36, 2 },
                    { 85, 36, 3 },
                    { 86, 37, 1 },
                    { 87, 37, 2 },
                    { 88, 37, 3 },
                    { 89, 38, 1 },
                    { 90, 39, 1 },
                    { 91, 39, 2 },
                    { 92, 39, 3 },
                    { 93, 40, 1 },
                    { 94, 40, 2 },
                    { 95, 41, 1 },
                    { 96, 42, 1 },
                    { 97, 43, 1 },
                    { 98, 44, 1 },
                    { 99, 44, 2 },
                    { 100, 45, 1 },
                    { 101, 45, 2 },
                    { 102, 46, 1 },
                    { 103, 46, 2 },
                    { 104, 47, 1 },
                    { 105, 47, 2 },
                    { 106, 48, 1 },
                    { 107, 48, 2 },
                    { 108, 48, 3 },
                    { 109, 48, 4 },
                    { 110, 49, 1 },
                    { 111, 49, 2 },
                    { 112, 50, 1 },
                    { 113, 50, 2 },
                    { 114, 50, 3 },
                    { 115, 50, 4 },
                    { 116, 51, 1 },
                    { 117, 52, 1 },
                    { 118, 53, 1 },
                    { 119, 53, 2 },
                    { 120, 53, 3 },
                    { 121, 53, 4 },
                    { 122, 54, 1 },
                    { 123, 54, 2 },
                    { 124, 54, 3 },
                    { 125, 54, 4 },
                    { 126, 55, 1 },
                    { 127, 56, 1 },
                    { 128, 57, 1 },
                    { 129, 57, 2 },
                    { 130, 58, 1 },
                    { 131, 58, 2 },
                    { 132, 58, 3 },
                    { 133, 58, 4 },
                    { 134, 59, 1 },
                    { 135, 60, 1 },
                    { 136, 61, 1 },
                    { 137, 62, 1 },
                    { 138, 62, 2 },
                    { 139, 62, 3 },
                    { 140, 63, 1 },
                    { 141, 63, 2 },
                    { 142, 63, 3 },
                    { 143, 64, 1 },
                    { 144, 64, 2 },
                    { 145, 64, 3 },
                    { 146, 64, 4 },
                    { 147, 65, 1 },
                    { 148, 66, 1 },
                    { 149, 66, 2 },
                    { 150, 67, 1 },
                    { 151, 67, 2 },
                    { 152, 68, 1 },
                    { 153, 68, 2 },
                    { 154, 68, 3 },
                    { 155, 68, 4 },
                    { 156, 69, 1 },
                    { 157, 69, 2 },
                    { 158, 70, 1 },
                    { 159, 70, 2 },
                    { 160, 71, 1 },
                    { 161, 72, 1 },
                    { 162, 72, 2 },
                    { 163, 73, 1 },
                    { 164, 73, 2 },
                    { 165, 73, 3 },
                    { 166, 73, 4 },
                    { 167, 74, 1 },
                    { 168, 74, 2 },
                    { 169, 75, 1 },
                    { 170, 75, 2 },
                    { 171, 75, 3 },
                    { 172, 76, 1 },
                    { 173, 76, 2 },
                    { 174, 76, 3 },
                    { 175, 77, 1 },
                    { 176, 78, 1 },
                    { 177, 78, 2 },
                    { 178, 79, 1 },
                    { 179, 80, 1 },
                    { 180, 80, 2 },
                    { 181, 81, 1 },
                    { 182, 81, 2 },
                    { 183, 81, 3 },
                    { 184, 81, 4 },
                    { 185, 82, 1 },
                    { 186, 82, 2 },
                    { 187, 83, 1 },
                    { 188, 83, 2 },
                    { 189, 83, 3 },
                    { 190, 84, 1 },
                    { 191, 84, 2 },
                    { 192, 84, 3 },
                    { 193, 85, 1 },
                    { 194, 85, 2 },
                    { 195, 85, 3 },
                    { 196, 86, 1 },
                    { 197, 86, 2 },
                    { 198, 86, 3 },
                    { 199, 87, 1 },
                    { 200, 87, 2 },
                    { 201, 88, 1 },
                    { 202, 88, 2 },
                    { 203, 88, 3 },
                    { 204, 88, 4 },
                    { 205, 89, 1 },
                    { 206, 90, 1 },
                    { 207, 90, 2 },
                    { 208, 90, 3 },
                    { 209, 91, 1 },
                    { 210, 91, 2 },
                    { 211, 92, 1 },
                    { 212, 93, 1 },
                    { 213, 94, 1 },
                    { 214, 94, 2 },
                    { 215, 94, 3 },
                    { 216, 94, 4 },
                    { 217, 95, 1 },
                    { 218, 96, 1 },
                    { 219, 96, 2 },
                    { 220, 96, 3 },
                    { 221, 96, 4 },
                    { 222, 97, 1 },
                    { 223, 98, 1 },
                    { 224, 98, 2 },
                    { 225, 98, 3 },
                    { 226, 98, 4 },
                    { 227, 99, 1 },
                    { 228, 99, 2 },
                    { 229, 99, 3 },
                    { 230, 100, 1 },
                    { 231, 100, 2 },
                    { 232, 100, 3 },
                    { 233, 101, 1 },
                    { 234, 102, 1 },
                    { 235, 102, 2 },
                    { 236, 102, 3 },
                    { 237, 103, 1 },
                    { 238, 103, 2 },
                    { 239, 103, 3 },
                    { 240, 103, 4 },
                    { 241, 104, 1 },
                    { 242, 105, 1 },
                    { 243, 105, 2 },
                    { 244, 105, 3 },
                    { 245, 105, 4 },
                    { 246, 106, 1 },
                    { 247, 106, 2 },
                    { 248, 106, 3 },
                    { 249, 106, 4 },
                    { 250, 107, 1 },
                    { 251, 107, 2 },
                    { 252, 107, 3 },
                    { 253, 108, 1 },
                    { 254, 109, 1 },
                    { 255, 109, 2 },
                    { 256, 109, 3 },
                    { 257, 109, 4 },
                    { 258, 110, 1 },
                    { 259, 110, 2 },
                    { 260, 110, 3 },
                    { 261, 110, 4 },
                    { 262, 111, 1 },
                    { 263, 111, 2 },
                    { 264, 111, 3 },
                    { 265, 111, 4 },
                    { 266, 112, 1 },
                    { 267, 113, 1 },
                    { 268, 114, 1 },
                    { 269, 114, 2 },
                    { 270, 115, 1 },
                    { 271, 115, 2 },
                    { 272, 115, 3 },
                    { 273, 116, 1 },
                    { 274, 116, 2 },
                    { 275, 116, 3 },
                    { 276, 116, 4 },
                    { 277, 117, 1 },
                    { 278, 117, 2 },
                    { 279, 117, 3 },
                    { 280, 118, 1 },
                    { 281, 118, 2 },
                    { 282, 119, 1 },
                    { 283, 120, 1 },
                    { 284, 120, 2 },
                    { 285, 120, 3 },
                    { 286, 121, 1 },
                    { 287, 122, 1 },
                    { 288, 123, 1 },
                    { 289, 123, 2 },
                    { 290, 124, 1 },
                    { 291, 124, 2 },
                    { 292, 124, 3 },
                    { 293, 124, 4 },
                    { 294, 125, 1 },
                    { 295, 126, 1 },
                    { 296, 126, 2 },
                    { 297, 126, 3 },
                    { 298, 126, 4 },
                    { 299, 127, 1 },
                    { 300, 127, 2 },
                    { 301, 128, 1 },
                    { 302, 128, 2 },
                    { 303, 128, 3 },
                    { 304, 129, 1 },
                    { 305, 129, 2 },
                    { 306, 130, 1 },
                    { 307, 130, 2 },
                    { 308, 130, 3 },
                    { 309, 130, 4 },
                    { 310, 131, 1 },
                    { 311, 132, 1 },
                    { 312, 132, 2 },
                    { 313, 132, 3 },
                    { 314, 132, 4 },
                    { 315, 133, 1 },
                    { 316, 133, 2 },
                    { 317, 133, 3 },
                    { 318, 134, 1 },
                    { 319, 134, 2 },
                    { 320, 134, 3 },
                    { 321, 135, 1 },
                    { 322, 135, 2 },
                    { 323, 135, 3 },
                    { 324, 136, 1 },
                    { 325, 137, 1 },
                    { 326, 137, 2 },
                    { 327, 137, 3 },
                    { 328, 138, 1 },
                    { 329, 138, 2 },
                    { 330, 139, 1 },
                    { 331, 139, 2 },
                    { 332, 140, 1 },
                    { 333, 140, 2 },
                    { 334, 140, 3 },
                    { 335, 140, 4 },
                    { 336, 141, 1 },
                    { 337, 141, 2 },
                    { 338, 141, 3 },
                    { 339, 141, 4 },
                    { 340, 142, 1 },
                    { 341, 142, 2 },
                    { 342, 143, 1 },
                    { 343, 143, 2 },
                    { 344, 144, 1 },
                    { 345, 144, 2 },
                    { 346, 144, 3 },
                    { 347, 144, 4 },
                    { 348, 145, 1 },
                    { 349, 145, 2 },
                    { 350, 146, 1 },
                    { 351, 146, 2 },
                    { 352, 147, 1 },
                    { 353, 147, 2 },
                    { 354, 147, 3 },
                    { 355, 147, 4 },
                    { 356, 148, 1 },
                    { 357, 148, 2 },
                    { 358, 148, 3 },
                    { 359, 148, 4 },
                    { 360, 149, 1 },
                    { 361, 150, 1 },
                    { 362, 150, 2 },
                    { 363, 151, 1 },
                    { 364, 151, 2 },
                    { 365, 151, 3 },
                    { 366, 151, 4 },
                    { 367, 152, 1 },
                    { 368, 152, 2 },
                    { 369, 152, 3 },
                    { 370, 153, 1 },
                    { 371, 153, 2 },
                    { 372, 153, 3 },
                    { 373, 153, 4 },
                    { 374, 154, 1 },
                    { 375, 155, 1 },
                    { 376, 155, 2 },
                    { 377, 156, 1 },
                    { 378, 156, 2 },
                    { 379, 156, 3 },
                    { 380, 156, 4 },
                    { 381, 157, 1 },
                    { 382, 157, 2 },
                    { 383, 158, 1 },
                    { 384, 159, 1 },
                    { 385, 159, 2 },
                    { 386, 160, 1 },
                    { 387, 160, 2 },
                    { 388, 161, 1 },
                    { 389, 161, 2 },
                    { 390, 161, 3 },
                    { 391, 161, 4 },
                    { 392, 162, 1 },
                    { 393, 162, 2 },
                    { 394, 162, 3 },
                    { 395, 162, 4 },
                    { 396, 163, 1 },
                    { 397, 163, 2 },
                    { 398, 164, 1 },
                    { 399, 164, 2 },
                    { 400, 164, 3 },
                    { 401, 165, 1 },
                    { 402, 165, 2 },
                    { 403, 165, 3 },
                    { 404, 166, 1 },
                    { 405, 166, 2 },
                    { 406, 167, 1 },
                    { 407, 167, 2 },
                    { 408, 167, 3 },
                    { 409, 168, 1 },
                    { 410, 168, 2 },
                    { 411, 168, 3 },
                    { 412, 169, 1 },
                    { 413, 169, 2 },
                    { 414, 170, 1 },
                    { 415, 170, 2 },
                    { 416, 171, 1 },
                    { 417, 171, 2 },
                    { 418, 172, 1 },
                    { 419, 172, 2 },
                    { 420, 172, 3 },
                    { 421, 172, 4 },
                    { 422, 173, 1 },
                    { 423, 173, 2 },
                    { 424, 173, 3 },
                    { 425, 174, 1 },
                    { 426, 174, 2 },
                    { 427, 175, 1 },
                    { 428, 175, 2 },
                    { 429, 176, 1 },
                    { 430, 176, 2 },
                    { 431, 177, 1 },
                    { 432, 177, 2 },
                    { 433, 177, 3 },
                    { 434, 177, 4 },
                    { 435, 178, 1 },
                    { 436, 179, 1 },
                    { 437, 179, 2 },
                    { 438, 180, 1 },
                    { 439, 180, 2 },
                    { 440, 180, 3 },
                    { 441, 181, 1 },
                    { 442, 182, 1 },
                    { 443, 182, 2 },
                    { 444, 183, 1 },
                    { 445, 183, 2 },
                    { 446, 184, 1 },
                    { 447, 184, 2 },
                    { 448, 184, 3 },
                    { 449, 184, 4 },
                    { 450, 185, 1 },
                    { 451, 185, 2 },
                    { 452, 185, 3 },
                    { 453, 185, 4 },
                    { 454, 186, 1 },
                    { 455, 186, 2 },
                    { 456, 187, 1 },
                    { 457, 188, 1 },
                    { 458, 188, 2 },
                    { 459, 188, 3 },
                    { 460, 189, 1 },
                    { 461, 189, 2 },
                    { 462, 189, 3 },
                    { 463, 190, 1 },
                    { 464, 190, 2 },
                    { 465, 190, 3 },
                    { 466, 190, 4 },
                    { 467, 191, 1 },
                    { 468, 191, 2 },
                    { 469, 191, 3 },
                    { 470, 192, 1 },
                    { 471, 192, 2 },
                    { 472, 192, 3 },
                    { 473, 193, 1 },
                    { 474, 193, 2 },
                    { 475, 194, 1 },
                    { 476, 194, 2 },
                    { 477, 194, 3 },
                    { 478, 195, 1 },
                    { 479, 195, 2 },
                    { 480, 196, 1 },
                    { 481, 196, 2 },
                    { 482, 196, 3 },
                    { 483, 196, 4 },
                    { 484, 197, 1 },
                    { 485, 197, 2 },
                    { 486, 197, 3 },
                    { 487, 198, 1 },
                    { 488, 199, 1 },
                    { 489, 199, 2 },
                    { 490, 200, 1 },
                    { 491, 201, 1 },
                    { 492, 201, 2 },
                    { 493, 202, 1 },
                    { 494, 202, 2 },
                    { 495, 202, 3 },
                    { 496, 203, 1 },
                    { 497, 203, 2 },
                    { 498, 204, 1 },
                    { 499, 204, 2 },
                    { 500, 205, 1 },
                    { 501, 206, 1 },
                    { 502, 206, 2 },
                    { 503, 207, 1 },
                    { 504, 208, 1 },
                    { 505, 208, 2 },
                    { 506, 208, 3 },
                    { 507, 209, 1 },
                    { 508, 209, 2 },
                    { 509, 210, 1 },
                    { 510, 210, 2 },
                    { 511, 210, 3 },
                    { 512, 211, 1 },
                    { 513, 211, 2 },
                    { 514, 211, 3 },
                    { 515, 211, 4 },
                    { 516, 212, 1 },
                    { 517, 212, 2 },
                    { 518, 212, 3 },
                    { 519, 212, 4 },
                    { 520, 213, 1 },
                    { 521, 213, 2 },
                    { 522, 213, 3 },
                    { 523, 214, 1 },
                    { 524, 214, 2 },
                    { 525, 214, 3 },
                    { 526, 215, 1 },
                    { 527, 215, 2 },
                    { 528, 216, 1 },
                    { 529, 217, 1 },
                    { 530, 217, 2 },
                    { 531, 217, 3 },
                    { 532, 217, 4 },
                    { 533, 218, 1 },
                    { 534, 218, 2 },
                    { 535, 218, 3 },
                    { 536, 218, 4 },
                    { 537, 219, 1 },
                    { 538, 219, 2 },
                    { 539, 219, 3 },
                    { 540, 220, 1 },
                    { 541, 220, 2 },
                    { 542, 220, 3 },
                    { 543, 220, 4 },
                    { 544, 221, 1 },
                    { 545, 221, 2 },
                    { 546, 221, 3 },
                    { 547, 221, 4 },
                    { 548, 222, 1 },
                    { 549, 222, 2 },
                    { 550, 223, 1 },
                    { 551, 223, 2 },
                    { 552, 223, 3 },
                    { 553, 224, 1 },
                    { 554, 224, 2 },
                    { 555, 225, 1 },
                    { 556, 226, 1 },
                    { 557, 226, 2 },
                    { 558, 227, 1 },
                    { 559, 227, 2 },
                    { 560, 227, 3 },
                    { 561, 228, 1 },
                    { 562, 228, 2 },
                    { 563, 229, 1 },
                    { 564, 229, 2 },
                    { 565, 229, 3 },
                    { 566, 230, 1 },
                    { 567, 230, 2 },
                    { 568, 230, 3 },
                    { 569, 230, 4 },
                    { 570, 231, 1 },
                    { 571, 231, 2 },
                    { 572, 232, 1 },
                    { 573, 232, 2 },
                    { 574, 233, 1 },
                    { 575, 234, 1 },
                    { 576, 234, 2 },
                    { 577, 234, 3 },
                    { 578, 235, 1 },
                    { 579, 235, 2 },
                    { 580, 236, 1 },
                    { 581, 236, 2 },
                    { 582, 236, 3 },
                    { 583, 237, 1 },
                    { 584, 237, 2 },
                    { 585, 237, 3 },
                    { 586, 238, 1 },
                    { 587, 238, 2 },
                    { 588, 239, 1 },
                    { 589, 240, 1 },
                    { 590, 241, 1 },
                    { 591, 241, 2 },
                    { 592, 242, 1 },
                    { 593, 242, 2 },
                    { 594, 242, 3 },
                    { 595, 242, 4 },
                    { 596, 243, 1 },
                    { 597, 244, 1 },
                    { 598, 244, 2 },
                    { 599, 244, 3 },
                    { 600, 245, 1 },
                    { 601, 246, 1 },
                    { 602, 247, 1 },
                    { 603, 248, 1 },
                    { 604, 249, 1 },
                    { 605, 249, 2 },
                    { 606, 250, 1 },
                    { 607, 250, 2 },
                    { 608, 251, 1 },
                    { 609, 251, 2 },
                    { 610, 251, 3 },
                    { 611, 251, 4 },
                    { 612, 252, 1 },
                    { 613, 252, 2 },
                    { 614, 253, 1 },
                    { 615, 253, 2 },
                    { 616, 254, 1 },
                    { 617, 254, 2 },
                    { 618, 255, 1 },
                    { 619, 255, 2 },
                    { 620, 255, 3 },
                    { 621, 255, 4 },
                    { 622, 256, 1 },
                    { 623, 257, 1 },
                    { 624, 257, 2 },
                    { 625, 257, 3 },
                    { 626, 258, 1 },
                    { 627, 259, 1 },
                    { 628, 259, 2 },
                    { 629, 259, 3 },
                    { 630, 260, 1 },
                    { 631, 260, 2 },
                    { 632, 261, 1 },
                    { 633, 262, 1 },
                    { 634, 262, 2 },
                    { 635, 262, 3 },
                    { 636, 262, 4 },
                    { 637, 263, 1 },
                    { 638, 263, 2 },
                    { 639, 263, 3 },
                    { 640, 263, 4 },
                    { 641, 264, 1 },
                    { 642, 265, 1 },
                    { 643, 265, 2 },
                    { 644, 265, 3 },
                    { 645, 265, 4 },
                    { 646, 266, 1 },
                    { 647, 266, 2 },
                    { 648, 266, 3 },
                    { 649, 267, 1 },
                    { 650, 268, 1 },
                    { 651, 268, 2 },
                    { 652, 269, 1 },
                    { 653, 269, 2 },
                    { 654, 269, 3 },
                    { 655, 270, 1 },
                    { 656, 270, 2 },
                    { 657, 270, 3 },
                    { 658, 271, 1 },
                    { 659, 271, 2 },
                    { 660, 271, 3 },
                    { 661, 272, 1 },
                    { 662, 273, 1 },
                    { 663, 273, 2 },
                    { 664, 274, 1 },
                    { 665, 274, 2 },
                    { 666, 274, 3 },
                    { 667, 274, 4 },
                    { 668, 275, 1 },
                    { 669, 275, 2 },
                    { 670, 275, 3 },
                    { 671, 275, 4 },
                    { 672, 276, 1 },
                    { 673, 276, 2 },
                    { 674, 277, 1 },
                    { 675, 278, 1 },
                    { 676, 278, 2 },
                    { 677, 278, 3 },
                    { 678, 278, 4 },
                    { 679, 279, 1 },
                    { 680, 279, 2 },
                    { 681, 279, 3 },
                    { 682, 279, 4 },
                    { 683, 280, 1 },
                    { 684, 281, 1 },
                    { 685, 281, 2 },
                    { 686, 281, 3 },
                    { 687, 281, 4 },
                    { 688, 282, 1 },
                    { 689, 283, 1 },
                    { 690, 283, 2 },
                    { 691, 284, 1 },
                    { 692, 285, 1 },
                    { 693, 285, 2 },
                    { 694, 286, 1 },
                    { 695, 286, 2 },
                    { 696, 287, 1 },
                    { 697, 287, 2 },
                    { 698, 288, 1 },
                    { 699, 289, 1 },
                    { 700, 290, 1 },
                    { 701, 290, 2 },
                    { 702, 290, 3 },
                    { 703, 290, 4 },
                    { 704, 291, 1 },
                    { 705, 291, 2 },
                    { 706, 291, 3 },
                    { 707, 291, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ItemsGenres",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.RenameColumn(
                name: "Counter",
                table: "Items",
                newName: "StorageID");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Items",
                type: "double",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Items_StorageID",
                table: "Items",
                column: "StorageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Storages_StorageID",
                table: "Items",
                column: "StorageID",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
