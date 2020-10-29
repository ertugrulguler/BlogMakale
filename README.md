# BlogMakale
Proje ufak çapta crud işlemleri yapabileceğimiz makale konulu bir .Net Core Wep Api projesidir.
Projenin veritabanı .Net Core Entity Framewok code first tekniği ile MSSQL de oluşturulmuştur.
Projeye fake data ile proje başlatılırken developer sürümünde otomatik veri basılmaktadır.
Projede katmanlı mimari kullanılmıştır.
Projede veri mapleme işlemi için AutoMapper kullanılmıştır.
Projeye loglama işlemi dahil edilecektir.
Projeye daha sonra MVC ile bir önyüz eklenecektir.


### Makale Listesi Çekme
https://localhost:44309/api/articles/getarticles adresine istek atılarak makale listesi çekilebilir.(localhost herkesin bilgisayarına göre değişir)

### Tek Bir Makale Çekme
https://localhost:44309/api/articles/GetArticle/{id} adresine id ile istek atılarak makale listesi çekilebilir.(localhost herkesin bilgisayarına göre değişir)

### Makale Ekleme
https://localhost:44309/api/articles/AddArticle adresine istek atılarak yeni bir makale eklenebilir.(localhost herkesin bilgisayarına göre değişir)

### Makale Silme
https://localhost:44309/api/articles/DeleteArticle/{id} adresine makalenizin idsini belirterek istek atarsanız makaleyi silebilirsiniz.(localhost herkesin bilgisayarına göre değişir)

### MakaleGüncelleme
https://localhost:44309/api/articles/UpdateArticle adresine istek atılarak makale güncellenebilir.(localhost herkesin bilgisayarına göre değişir)

# Atılan istek ve sonuçların resimleri paylaşılmıştır.
# Projeye ait script dosyası paylaşılmıştır

### Projede kullanılan tasarım desenleri nelerdir?
Öncelikle kullanılan her bir tasarım deseni hem kodun daha anlaşılır olmasını hem de daha iyi yönetilebilir olmasını sağlar.

#### Projede respository pattern kullanılmıştır.
Repository pattern daha çok business katmanında kullanılmıştır. Bu sayede veri erişimi için kullanılan ORM'e göre her seferinde uzun uzun sorgu yazılmaz. Sorgu bir defa 
metoda tanımlanır, o metot nerede çağrılırsa aynı sorgu çalışır. 

#### Projede Singleton design pattern kullanılmıştır.
Projenin veri initiaze kısmında kullanılmıştır. Bu sayade proje her seferinde bir yeniden veri üretimi sağlamaz, eğer veri yok ise veri üretilir ve gereksiz iş yükünden kurtulur.

#### Projede Dependency Injection pattern kullanılmıştır.
Projenin hemen her yerinde kullanılmıştır. Dependency injection SOLİD prensiplerinin sonuncusunun kullanım şeklidir. Bu sayede projede bir sınıfın başka bir sınıfa bağımlılığı olmaz,
yani bir sınıf için başka bir sınıfın newlenmesine gerek kalmaz. Gerekli bağımlılığı siz dışardan verirsiniz.

#### Projede Factory design pattern kullanılmıştır.
Projenin en çok business katmannında kullanılmıştır. Bir class doğrudan tanımlanmak yerine bir interfacede tanımlanıp ordan implement edilir. Daha sonra bu sınıfa benzer metotları,
değişkenleri vs olan bir sınıf da üretilecek olursa yine aynı interfaceden türetilir. Farklı olan metot vs sınıfın kendi içerisinde zaten tanımlanabilir. Yani kısacası benzer özelliklere 
sahip classların catısı interface ya da abstract bir class ile oluşturulur ortak metotlar vs burada tanımlanır ve yeni eklenecek özellikler olduğu zaman yönetilebilirlik kolaylaşır.

# Kullanılan Teknolojiler

### EntityFramework 
Projede ORM için EntityFramework Core kullanılmıştır. Daha önce çalıştığım bir şirkette 4 ay civarında kullandım.
### AutoMapper
Projede veri mapleme işlemi için AutoMapper kullandım. Yine aynı iş yerinde aynı süreçte kullandım.
### Nlog
Projede Nlog dahil edildi ancak implementasyonu henüz sağlanamadı. Yine aynı iş yerinde kullandım ve şuanda çalıştığım iş yerinde de 3 aydır kullanıyorum.
### NinJect 
Standart .net de dependency injection için kullandım ancak .net core bu işlemi yaptığı için bu projede kullanamadım.
### RestSharp 
Daha önce çalıştığım şirkette 4 ay civarında kullandım. Bu projenin ön yüz eklemesi tamamlandığında MVC tarafına eklenecektir.

# Daha geniş vaktim olsaydı eklemek istediklerim
Yukarıda da belirttiğim üzere projeye bir ön yüz için ufak da olsa bir MVC projesi eklemek isterdim.


