public class Araba{
    /*
    Sınıf Adı, Özelikler, Metodlar ==>> PascalCase
    Sınıf Değişkenleri(fields) ve Metod Parametreleri==>> camelCase
    */
    public string Ad { get; set; }
    public string Model { get; set; }

    public void Ilerle(){
        Console.WriteLine($"{Ad} isimli araba İlerliyor...");
    }
    public void Dur(){
        Console.WriteLine("Araba Duruyor...");
    }
}