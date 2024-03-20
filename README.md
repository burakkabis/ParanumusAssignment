Herkese merhaba 👋 
Bu proje Çok Katmanlı Mimari temel alınarak geliştirilmiştir. Projede SOLID yazılım prensipleri benimsenmiştir.Veritabanı için SQL Server Veritabanı kullanılmaktadır.
Ayrıca projenin Front-End tarafı ve diğer uygulamalarla iletişim kurabilmesi için servis katmanında bir Web API kodlanmıştır.

Projenin back-end kısmında C# kullanıldı. Geliştirme çok katmanlı mimari esas alınarak yapıldı. Katmanların ne işe yaradığı hakkında bilgi vermek istiyorum;
1-Entities Katmanı: Program genelinde kullanılacak nesnelerin sınıflarının tanımlandığı yerdir. Bu katmandaki sınıfların her biri veritabanındaki bir tabloya karşılık gelir, bunlara ek olarak farklı tablolardan gelen verilerin birleştirildiği DTO (Veri Aktarım Nesnesi) sınıflarını da içerir.
2-Data Access Katmanı: Veritabanı bağlantılarının ve işlemlerinin yapıldığı katmandır. Veritabanı bağlantısı için gerekli konfigürasyon burada yapılır. Ayrıca veri çıkarma, ekleme, silme, güncelleme gibi işlemler de bu katmanda kodlanır.
3-Business Katmanı: İş kurallarının tanımlandığı ve kontrol edildiği katmandır. Programa bir komut geldiğinde hangi işlemleri yapması gerektiği ve hangi kurallar dizisinden geçmesi gerektiği burada tanımlanır.
4-Core Katmani: Tüm katmanlarda ortak olarak kullanılacak yapıların, cross cutting concerns(loglama,caching,security,validation... yapilari), aspects, extensions ve utilities(araclarin) kodlandığı bölümdür.
5-Servis Katmanı (Web API): Front-End kısmının ve diğer platformların programla iletişim kurmasını ve işlem yapmasını sağlayan servislerin yazıldığı kısımdır.

Projenin;
Business/DependencyResolvers/Autofac/AutofacBusinessModule classinda bulunan
builder.RegisterType<InMemoryProductDal>().As<IProductDal>().SingleInstance(); kod parcasi suan projenin InMemory formatta calistigini gosterir.
InMemoryProductDal yerine EfProductDal yazarsam veri erisimim tamamen EntityFramework'e gececek.Sadece bunu yaparak sistemde hicbir katman bozulmadan ve surdurulebilir bir kodlama yapmis oluruz.

Backend Gereksinimleri:
Autofac:7.0.0
Autofac.Extensions.DependencyInjection:7.0.0
Autofac.Extras.DynamicProxy :7.0.0
Microsoft.AspNetCore.Authentication.JwtBearer:6.0.0
Microsoft.AspNetCore.Http:2.2.2
Microsoft.AspNetCore.Http.Abstractions: 2.2.0
Microsoft.EntityFrameworkCore:7.0.0
Microsoft.EntityFrameworkCore.SqlServer:7.0.0
Microsoft.Extensions.Configuration.Binder:7.0.0
Swashbuckle.AspNetCore:6.2.3


PROJENIN TESTI:Sistemi ister Postman ister Run edildiginde web ekranina gelen swagger uzerinden test edebilirsiniz.

https://localhost:7235/api/products/getall
