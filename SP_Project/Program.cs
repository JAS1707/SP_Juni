Film film1 = new Film("Inception", "Science Fiction", 148, 13);
Film film2 = new Film("The Shawshank Redemption", "Drama", 142, 16);
Film film3 = new Film("Spirited Away", "Animatie", 125, 6);

film1.Tooninfo();
film2.Tooninfo();
film3.Tooninfo();

class Film
{
    public string Titel;
    public string Genre;
    public int Duurtijd;
    public int Leeftijdsgrens;

   
    public Film(string titel, string genre, int duurtijd, int leeftijdsgrens)
    {
        Titel = titel;
        Genre = genre;
        Duurtijd = duurtijd;
        Leeftijdsgrens = leeftijdsgrens;
    }

    
    public void Tooninfo()
    {
        Console.WriteLine("=== Filmgegevens ===");
        Console.WriteLine($"De film heet '{Titel}'.");
        Console.WriteLine($"Dit is een {Genre}-film.");
        Console.WriteLine($"De film duurt {Duurtijd} minuten.");
        Console.WriteLine($"De leeftijdsgrens voor deze film is {Leeftijdsgrens} jaar.");
        Console.WriteLine();
    }
}
