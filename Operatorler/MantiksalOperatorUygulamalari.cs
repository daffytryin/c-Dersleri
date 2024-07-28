/*

MANTIKSAL OPERATÖR UYGULAMALARI

1- Yaşı 18den büyük ya da veli izni var ise bir işte çaalışabilir
durumunu kontrol etme
*/
// var yas = 18;
// bool veli_izni = false;

// bool yas_kontrol = (yas >= 18);
// bool veli_kontrol = (veli_izni);

// var sonuc = (yas_kontrol || veli_kontrol) ? "çalışabilir": "çalışamaz";

// Console.WriteLine(sonuc);


/*2-Ders notu 50 - 100 arasındaysa geçti değilse kaldı bilgisi yazdır*/


// int not = 50;
// bool kosul1 = (not>=50);
// bool kosul2 = (not<=100);

// var sonuc = (kosul1 && kosul2) ? "geçti":"kaldı";
// Console.WriteLine(sonuc);

/*3- Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi
alabilme durumunu yazdır*/

// int ortalama = 50;
// int zayif = 0;

// var sonuc = (ortalama >=70) ? ((zayif ==0) ?"teşekkür alabilir":"zayıfınızın olmaması gerekir" ):
// "notunuz en az 70 olmalı";
// Console.WriteLine(sonuc);

/*4- İşe girmek için en az önlisans ya da lisans mezunu olma durumunu
kontrol et, sigara kullanmama koşulu ekle*/

// string egitim = "lisans";
// bool sigara_icme = false;

// var sonuc = (egitim =="lisans" || egitim == "önlisans") && (!sigara_icme) ? "geçerli":"geçersiz";
// Console.WriteLine(sonuc);


/*5- Uygulamaya giriş kontrolünü username ya da parola için yap*/

// string email = "info@mail.com";
// string password = "12345";
// string username = "dafi";

// var sonuc = ((email == "info@mail.co" || username == "daf") && password == "12345") ? "giriş yapıldı": "giriş yapılmadı";
// Console.WriteLine(sonuc);