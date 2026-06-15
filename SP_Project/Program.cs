Film film1 = new Film("Inception", "Science Fiction", 148);
Film film2 = new Film("The Shawshank Redemption", "Drama", 142);
Film film3 = new Film("Spirited Away", "Animatie", 125);

film1.Tooninfo();
film2.Tooninfo();
film3.Tooninfo();

class Film
{
    public string Titel;
    public string Genre;
    public int Duurtijd;

   
    public Film(string titel, string genre, int duurtijd)
    {
        Titel = titel;
        Genre = genre;
        Duurtijd = duurtijd;
    }

    
    public void Tooninfo()
    {
        Console.WriteLine("=== Filmgegevens ===");
        Console.WriteLine($"Titel: {Titel}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Duurtijd: {Duurtijd} minuten");
        Console.WriteLine();
    }
}
