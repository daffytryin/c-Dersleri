/*

REFERANS TİPLER

x değişkeni tanımlandığında belleğin stack adresinde yer alır.
Referans tiplerin bellekte tutulması çalışma şekilleri gibi
bundan daha farklıdır. 

bir dizi oluşturulduğunda bu dizinin stackte adres bilgisi 
tanımlanır, array ise belleğin heap bölümünde tutulur.

x=t gibi bir eşitlik söz konusu olduğunda stackte aynı adres farklı
adreslerde tanımlanır, ancak heapte bu array bilgisi aynı yerde tutulur.
t veya x'te yapılan değişiklikler aynı value üzerinde değişikliğe neden olur.


*/

int x = 10;
int y = x;

Console.WriteLine(x); //10
Console.WriteLine(y); //10

x = 20;

Console.WriteLine(x); //20
Console.WriteLine(y); //10

//farklı adreslerde tutulan veriler
Console.WriteLine();

int[] a = {10,20};
int[] b = a;

Console.WriteLine(a[0]); //10
Console.WriteLine(b[0]); //10

a[0] = 20;

Console.WriteLine(a[0]); //20
Console.WriteLine(b[0]); //20

//aynı adreste tutulan veriler