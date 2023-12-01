namespace BokOgFilmInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hallo, Hva heter du?  ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hei, {name}!");
            Console.WriteLine("Hva heter filmen?");
            string movie = Console.ReadLine();
            
            Console.WriteLine("Når kom filmen ut?");
            int releaseYear = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Skriv en kort beskrivelse av filmen:");
            string description = Console.ReadLine();
            
            Console.WriteLine("Hvem ressigerte filmen?");
            string director = Console.ReadLine();
            
            Console.WriteLine("Hvilke skuespillere var med?");
            string actors = Console.ReadLine();

            Movie movie2 = new Movie(movie, releaseYear, description, director, actors);


            Console.Clear();
            Console.WriteLine($"Filmen heter {movie2.Name}");
            Console.WriteLine($"Filmen kom ut i {movie2.ReleaseYear}");
            Console.WriteLine($"Beskrivelse av filmen: {movie2.Description}");
            Console.WriteLine($"Regissøren av filmen er: {movie2.Director}");
            Console.WriteLine($"De mest populære skuespillere som var med er: {movie2.Actors}");

            var newMovie = Console.ReadLine();
            if(newMovie == "1")
            {
                newMovie1();
            }
            else
            {
                return;
            }
            //else if (newMovie = "2")
            //{w
            //    newMovie2();
            //}
            //else if ( newMovie = "3")
            //{
            //    newMovie3();
            //}
        }

        public void newMovie1()
        {
            Console.WriteLine("Hva heter filmen?");
            string movie = Console.ReadLine();

            Console.WriteLine("Når kom filmen ut?");
            int releaseYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv en kort beskrivelse av filmen:");
            string description = Console.ReadLine();

            Console.WriteLine("Hvem ressigerte filmen?");
            string director = Console.ReadLine();

            Console.WriteLine("Hvilke skuespillere var med?");
            string actors = Console.ReadLine();

            Movie movie2 = new Movie(movie, releaseYear, description, director, actors);

            Console.Clear();
            Console.WriteLine($"Filmen heter {movie2.Name}");
            Console.WriteLine($"Filmen kom ut i {movie2.ReleaseYear}");
            Console.WriteLine($"Beskrivelse av filmen: {movie2.Description}");
            Console.WriteLine($"Regissøren av filmen er: {movie2.Director}");
            Console.WriteLine($"De mest populære skuespillere som var med er: {movie2.Actors}");
            List<Movie> MovieList = new List<Movie>();
            MovieList.Add(new Movie(movie, releaseYear, description, director, actors));
            Movie firstName = MovieList[0];
            foreach (Movie movieVar in MovieList)
            {
                Console.WriteLine(movieVar);
            }
        }
    }
}

//Bok/Film info
// Lag en applikasjon der man kan skrive inn forskjellige detaljer, og etter man har skrevet
// inn alt få printet tilbake det som ble skrevet inn som et “produkt”, enten en film eller en bok, dere velger.
// Man skal bli spurt av konsollen om Tittel, så år det kom ut, litt beskrivelse av hva filmen eller
// boken handler om, forfatter/regissør, hvilke skuespillere som var med.
// Når alle spørsmål er besvart skal man kunne få se boken eller filmen man skrev inn som et produkt,
// med alle egenskaper listet opp.

// BONUS:
// Legg til mulighet for å skrive inn flere bøker eller filmer, her trenger man å ta i bruk lister, neste ukes pensum