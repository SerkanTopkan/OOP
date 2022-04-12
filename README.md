# OOP (NESNE YÖNELİMLİ PROGRAMLAMA ÖRNEKLERİ)

## INHERİTANCE (KALITIM/MİRAS ALMA)
**Inheritance (Miras alma, Kalıtım)**, bir nesnenin özelliklerinin farklı nesneler tarafından da kullanılabilmesine olanak sağlayan OOP prensibidir. Yazılan bir base sınıf bir başka sınıf tarafından miras alınabilir. Bu işlem yapıldığı zaman temel alınan sınıfın tüm özellikleri yeni sınıfa aktarılır.

## ENCAPSULATİON (KAPSÜLLEME/SARMALLAMA)
**Kapsülleme (Encapsulation)** bir sınıfın içerisinde bulunan metodların ve değişkenlerin korumasıdır. İçerisinde bulunan metod ve değişkenlere dışarıdan yani diğer sınıflardan ne seviyede  erişilebileceğini kapsülleme ile sağlayabiliriz.

Bu erişim belirleyiciler (access modifiers);

**Public**: Her yerden erişilebilir.

**Private**: Sadece tanımlandığı sınıf içerisinden erişilebilir.

**Internal**: Sadece bulunduğu projede erişilebilir.

**Protected**: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

**Protected Internal**: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir. Ayrıca tanımlamanın aynı proje içerisinde olma şartı yoktur. Protected’dan farkı budur.

**Not: Eğer erişim belirleyici belirtilmemişse, sınıflar internal’dır.**

## ABSTRACTİON (SOYUTLAMA)
Öncelikle soyutlamanın Türkçe olarak ne ifade ettiğini kavrayalım; **soyutlama** bir metayı meydana getiren karmaşık oluşumları göz ardı ederek, o metanın işe yarayabilecek en öz haline inebilmektir. Diğer anlamda, temel özellikleri özetleyerek temel olmayan ayrıntıları dışarıda bırakmaktır.

Bu bağlamda soyutlama: nesnenin program için ihtiyaç duyulan özelliklerin arka plan ayrıntıları içermeksizin ifade ediliş biçimidir.

Örneğin; Console.WriteLine(“Merhaba Dünya”); ile ekrana bir şeyler yazdırırız arka planda neler döndüğünü bilmeden. İşte bu abstraction prensibidir. Daha derli toplu bir ifadeyle objelerin ayrıntılarıyla uğraşmak yerine yalnızca girdi ve çıktılarına odaklanarak tasarımı daha iyi oluşturmayı ve anlamayı sağlamaktır.

Bu soyutlamayı başlı başına ayrı konular olan Interface(arayüz) ve Abstract sınıflar ile sağlayabiliriz. 

## POLYMORPHİSM (ÇOK BİÇİMCİLİK)
**Çok biçimlilik** en basit tanımıyla; bir nesnenin birden fazla nesle gibi davranma şeklidir. Bir sınıf başka bir sınıftan türetildiğinde tüm özelliklerini miras alır. Türemiş sınıf içinde türetilen sınıftan gelen bazı özellikleri değiştirmek isteyebiliriz (ve yapabiliriz de). Sınıfın miras aldığı özelliklerin değiştirilebilmesine -ve nesne üzerinden çağrılabilmesine çok biçimlilik denir.

**2 tür polimorphism (çok biçimlilik) vardır;**

Compile Time Polymorphism (Derleme Zamanı Çok Biçimlilik)

Runtime Polymorphism (Çalışma Zamanı Çok Biçimlilik)
