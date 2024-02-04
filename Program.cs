
System.Console.WriteLine(Gunler.Cuma);
System.Console.WriteLine((int)Gunler.Pazar);

int sıcaklık = 22;
if (sıcaklık<= (int)HavaDurumu.Normal)
{
    System.Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
}
else if (sıcaklık>=(int)HavaDurumu.Sıcak)
{
    System.Console.WriteLine(" Dışarıya çıkmak için çok sıcak bir gün");
}
else if (sıcaklık> (int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.ÇokSıcak)
{
    System.Console.WriteLine("Hadi dışarı çıkalım.");
}

enum Gunler
{
    Pazartesi=1,
    Salı,
    Çarşamba,
    Perşembe=45,
    Cuma,
    Cumartesi,
    Pazar,
}
enum HavaDurumu
{
 Soguk = 5,
 Normal = 20,
 Sıcak= 30,
 ÇokSıcak = 49   
}