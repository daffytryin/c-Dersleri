/*

TERNARY OPERATÖRÜ

*/

int sayi = -10;

var sonuc = (sayi % 2 == 0) ? 
                (sayi>0) ? "sayi pozitif çift":"sayi negatif çift":
                (sayi>0) ? "sayi pozitif çift":"sayi negatif tek";

Console.WriteLine(sonuc);