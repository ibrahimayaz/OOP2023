namespace Odev;

public class Ogrenci
{
    public int No { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public List<Ders> alinanDersler;
    public List<Bolum> bolumler;

}