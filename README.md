
Klasör yapısı:

Core Klasörü=> Domain ve Application Katmanı
Infrastructure Klasörü=> Infrastructure ve Persistence Katmanı
Presentation Klasörü=>API, MVC vb.





Dıştan içe:
*Presentation/Persistence/Infrastructure => Repository- Service Interface(Application) =>Domain
*Core:Application+Domain

Referanslar: Her katman kendinden bir önceki katmanı referans eder.
1.Application=>Domain'i referan eder.
2a.Infrastructure=>Application'u referans eder.
2b.Persistence=>Application'u referans eder.
2c.Presentation=>Application'u referans eder.

Presentation, Infrastructure, Persistence  yatay ilişkiye sahip direkt olarak birbirlerini referan edemez.

    ONION ARCHITECTURE:
-Domain(Domain Entities/Core) Katmanı;
 *Merkezi Katman
 ***************Entities, Value Object, Enumeration, Entitiy Exceptions**********
 
 
 -Repository & Service Interfaces(Core) Katmanı;
  *Domain ile Business katmanı arasında soyutlama işlemi yapan katman
  *Tüm interfceler burada
  *Domain katmanını referans eder
  *Bu katmanın amacı; veri erişiminde loose coupling(gevşek bağlı) yaklaşım sergilemektir.
    *APPLICATİON CLASS LIBARY YAPISINDA OLUŞTURULUR.
  **********Interfaces,Dtos, ViewModel, Mapping, Validations, CQRS Pattern*******
  
  
  -Persistence Katmanı;
  *Veritabanı işlemlerini yürüten katman
  *Application katmanındaki repository interfacelerinin concrete nesneleri bu katmandadır.
  ***********Repository Concrete Classes,DbContext, Migrations, Configurations, Seeding(başlangıç dataları)********
  
  
  -Infrastructure Katmanı;
  *Persistence katmanıyla bütünleşebilen katmandır. Çünkü her ikisi de business katmanıdır.
  *Veri tabanı işlemleri dışındaki işleri,servisleri yürüttüğümüz katmandır.
  *Örn: email-service service, Payment,Notification,hazır servislerden veri çekmek için bu katman kullanılır.
  
  
  -Presentation Katmanı;
  Kullanıcının uygulamayla(client) iletişime geçtiği katmandır.
  *************Web Api, Web App, MVC, Php vb.*********************
  
  
  
IOC Container kullanma sebebimiz;
Presentation-Persistence-Infrastructure katmanı yatay ilişkiye sahip. Yani birbirlerini doğrudan refere edemiyorlar.
-ICar servisimizi düşünelim. ICar => Repository&Service Interfaces katmanında bulunur.
-Car servisimiz ise veritabanıyla alakalı olduğunu varsayarak Persistence katmanında.
-Presentation katmanında da API projem var diyelim. Ben car servisinin metotlarını dış dünyaya sunmak istiyorum fakat persistence katmanını refere edemiyorum.
-O zaman dependency injection ile ICar servisini alırım ve CarService'in tüm metotlarına ulaşabilirim.



