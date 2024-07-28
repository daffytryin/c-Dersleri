/*

IF-ELSE UYGULAMALARI

*/

/*1- Kullanıcıya saunulan bir menü içerisinden seçilecek olan 4 işlem
tipine göre hesaplama yapın*/

// Console.Write("İki sayı giriniz: ");
// var sayi1 = Convert.ToInt32(Console.ReadLine());
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Bir işlem tipi seçiniz: 1 - (+), 2- (-), 3- (*), 4 - (/):    ");

// var secim = Convert.ToInt32(Console.ReadLine());
// double sonuc = 0;
// if(secim == 1) {
//     sonuc = sayi1+sayi2;
// } else if (secim == 2) {
//     sonuc = sayi1-sayi2;
// }else if (secim == 3) {
//     sonuc = sayi1*sayi2;
// }else if (secim == 4) {
//     sonuc = sayi1/sayi2;
// } else {
//     Console.WriteLine("Yanlış giriş yaptınız.");
// }
// Console.WriteLine($"Sonuç: {sonuc}");

/*2- Bir öğrencinin 2 yazılı 1 sözlü notunu alıp hesaplanan ortalamaya
göre not ağırlığına karşılık gelen not bilgisini yazın

0   -   24  ->  0
25  -   44  ->  1
45  -   54  ->  2
55  -   69  ->  3
70  -   84  ->  4
85  -   100 ->  5

*/
// int not=-1;
// bool ok = true;
// Console.WriteLine("1. yazılı: ");
// int not1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("2. yazılı: ");
// int not2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("3. yazılı: ");
// int not3 = Convert.ToInt32(Console.ReadLine());

// var ortalama = (not1+not2+not3)/3;

// if(ortalama >=0 && ortalama <25) {
//     not = 0 ;
// } else if (ortalama >= 25 && ortalama < 45) {
//     not = 1;
// }else if (ortalama >= 45 && ortalama < 55) {
//     not = 2;
// }else if (ortalama >= 55 && ortalama < 70) {
//     not = 3;
// }else if (ortalama >= 70 && ortalama < 55) {
//     not = 4;
// }else if (ortalama >= 85 && ortalama < 100) {
//     not = 5;
// } else {
//     ok = false;
//     Console.WriteLine("Yanlış not girdiniz.");
// }

// if(ok) {
// Console.WriteLine($"Not ortalamanız: {ortalama} ve Notunuz: {not}");
// }
/*3- Girilen 2 sayıdan en büyüğünü bulun*/

// Console.WriteLine("1. sayı: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("2. sayı: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("3. sayı: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int enbuyuk = 0;

// if(a>b && a>c) {
//     enbuyuk = a;
// } else if(b>a && b>c) {
//     enbuyuk = b;
// } else if(c>a && c>b) {
//     enbuyuk = c;
// }
// Console.WriteLine($"En büyük sayı: {enbuyuk}");

