internal class Program
{
    private static void Main(string[] args)
    {

        /* //İLK AŞAMA SAATİN KAÇ 6 DAN ÖNCE YA DA SONRA OLDUĞUNU SORGULATIP SONRA İYİ GÜNLER YA DA İYİ GECELER DEDİRİYORUZ.
        
        int time = DateTime.Now.Hour;

        if(time <=18)
            Console.WriteLine("İYİ GÜNLER");
        else
            Console.WriteLine("İYİ GECELER");

        Console.ReadKey();
        */


        int time = DateTime.Now.Hour;

        if (time >= 6 && time <=11)
            Console.WriteLine("GÜNAYDIN");
        else if (time <=18)
            Console.WriteLine("İYİ GÜNLER");
        else
            Console.WriteLine("İYİ GECELER");

        
        //BU ALANDA İF ELSE İN FARKLI BİR ŞEKİLDE YAPIMINI GÖRÜYORUZ.
        string sonuc = time<= 18 ? "İyi Günler!" : "İyi Geceler!";
        
        sonuc = time >= 6 && time < 11 ? "Günaydın!" : time <= 18 ? "İyi Günler" : "İyi Geceler";
        Console.WriteLine(sonuc);
        Console.ReadKey();
    }
}