// Veri tipleri

/*
VALUE TYPES
1. Tam sayı: byte, short, integer, long
2. Ondalık sayı: float, double, decimal, char, boolean, struct

REFERENCE TYPES
String, Class, Array, Interface

*/

// int sayi = 100;

// float oran = 1.18f;

// double oran2 = 1.18;

// decimal oran3 = 1.18m;

// char cinsiyet = 'K';

// char cinsiyet2 = 'E';

// string urunAdi = "Samsung S23";

// bool satisDurumu = false;


/*
BELLEK
x=32 --> belli bir adreste Stack içinde tanımlanır
x=y --> farklı bir adreste Stack içinde tanımlanır
*/


/*
VERİ TİPİ DÖNÜŞÜMLERİ

    implicit casting --> bilinçsiz tür dönüşümü
    explicit casting --> bilinçli tür dönüşümü

*/

// int a = 10;
// byte b = (Convert.ToByte(a)); //veri kaybı var, bu nedenle tür dönüşüm gerekli
// long c = a; //veri kaybı yok, dönüşüm gereksiz

// long d = 20;
// int e = (int)d; //veri kaybı göz önüne alınır ve dönüşüm yapılır, aksi halde error alınır

// double f = 20.5;
// float g = (float)f; //veri kaybı var ancak tür dönüşümü yapıldığından error vermez

// double h = 10.5;
// int i = (int)h; //çıktı 10 olur

// int x = 10;
// string z = x.ToString(); 

// Console.Write("1. sayı: ");
// var sayi1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2. sayı: ");
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// var toplam = sayi1 + sayi2; /*string olarak toplanır 10 ve 20 girilirse 1020 çıktısı verir*/

// Console.Write(toplam);

/*
NULLABLE TYPES
*/

// int a = 10;
// string isim = null;

// Console.WriteLine(isim);
// Console.WriteLine(a); //value typelarda mutlaka değer ataması gerekli

// int? maas = null; //nullable type olarak tanımlandı
// bool? isActive = null;

// Console.WriteLine(maas);
// Console.WriteLine(maas.HasValue);
// Console.WriteLine(maas.GetValueOrDefault()); //int türünde null typeın default değeri 0'dır.
// Console.WriteLine(isActive.GetValueOrDefault());
