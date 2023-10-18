class Kitap
{
    private string KitapAdi { get; set; }
    private string YazarAdi { get; set; }
    private int BasimSayisi { get; set; }
    public string YazarBilgisiniGetir()
    {
        return YazarAdi;
    }
    public string KitapAdiniGetir()
    {
        return KitapAdi;
    }
}