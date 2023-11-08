namespace Odev;
public class Ders
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public int Kredi { get; set; }
    public int Akts { get; set; }

    public List<Ogrenci> dersiAlanOgrenciler;
}