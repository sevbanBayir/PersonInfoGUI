public class Person
{
    public string SicilNo { get; set; }
    public string AdSoyad { get; set; }
    public string Cinsiyet { get; set; }
    public int Yas { get; set; }

    // Default constructor
    public Person()
    {
        SicilNo = "";
        AdSoyad = "";
        Cinsiyet = "";
        Yas = 0;
    }

    // Parameterized constructor
    public Person(string sicilNo, string adSoyad, string cinsiyet, int yas)
    {
        SicilNo = sicilNo;
        AdSoyad = adSoyad;
        Cinsiyet = cinsiyet;
        Yas = yas;
    }

    // Copy constructor
    public Person(Person person)
    {
        SicilNo = person.SicilNo;
        AdSoyad = person.AdSoyad;
        Cinsiyet = person.Cinsiyet;
        Yas = person.Yas;
    }

    public string PersInfo()
    {
        return $"Sicil No: {SicilNo}\nAd Soyad: {AdSoyad}";
    }
} 