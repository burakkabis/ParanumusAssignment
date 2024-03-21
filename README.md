
<p id="description">Merhaba 👋 Bu proje Çok Katmanlı Mimari temel alınarak geliştirilmiştir. Projede SOLID yazılım prensipleri benimsenmiştir.Veritabanı için SQL Server Veritabanı kullanılmaktadır. Ayrıca projenin Front-End tarafı ve diğer uygulamalarla iletişim kurabilmesi için servis katmanında bir Web API kodlanmıştır. Projenin back-end kısmında C# kullanıldı. Geliştirme çok katmanlı mimari esas alınarak yapıldı. Katmanların ne işe yaradığı hakkında bilgi vermek istiyorum;</p>

### 1-Entities Katmanı:

<p id="description">Program genelinde kullanılacak nesnelerin sınıflarının tanımlandığı yerdir. Bu katmandaki sınıfların her biri veritabanındaki bir tabloya karşılık gelir bunlara ek olarak farklı tablolardan gelen verilerin birleştirildiği DTO (Veri Aktarım Nesnesi) sınıflarını da içerir.</p>

 ### 2-Data Access Katmanı:

<p id="description">Veritabanı bağlantılarının ve işlemlerinin yapıldığı katmandır. Veritabanı bağlantısı için gerekli konfigürasyon burada yapılır. Ayrıca veri çıkarma ekleme silme güncelleme gibi işlemler de bu katmanda kodlanır.</p>

### 3-Business Katmanı: 

<p id="description">İş kurallarının tanımlandığı ve kontrol edildiği katmandır. Programa bir komut geldiğinde hangi işlemleri yapması gerektiği ve hangi kurallar dizisinden geçmesi gerektiği burada tanımlanır.</p>

### 4-Core Katmani: 

<p id="description">Tüm katmanlarda ortak olarak kullanılacak yapıların cross cutting concerns(loglamacachingsecurityvalidation... yapilari) aspects extensions ve utilities(araclarin) kodlandığı bölümdür.</p>

### 5-Servis Katmanı (Web API): 

<p id="description">Front-End kısmının ve diğer platformların programla iletişim kurmasını ve işlem yapmasını sağlayan servislerin yazıldığı kısımdır.</p>
Projenin;
Business/DependencyResolvers/Autofac/AutofacBusinessModule classinda bulunan
builder.RegisterType<InMemoryProductDal>().As<IProductDal>().SingleInstance(); kod parcasi suan projenin InMemory formatta calistigini gosterir.
InMemoryProductDal yerine EfProductDal yazarsam veri erisimim tamamen EntityFramework'e gececek.Sadece bunu yaparak sistemde hicbir katman bozulmadan ve surdurulebilir bir kodlama yapmis oluruz.

## Backend Gereksinimleri:

Autofac:7.0.0<br>Autofac.Extensions.DependencyInjection:7.0.0<br>Autofac.Extras.DynamicProxy :7.0.0<br>Microsoft.AspNetCore.Authentication.JwtBearer:6.0.0<br>Microsoft.AspNetCore.Http:2.2.2<br>Microsoft.AspNetCore.Http.Abstractions: 2.2.0<br>Microsoft.EntityFrameworkCore:7.0.0<br>Microsoft.EntityFrameworkCore.SqlServer:7.0.0<br>Microsoft.Extensions.Configuration.Binder:7.0.0<br>Swashbuckle.AspNetCore:6.2.3



## PROJENIN TESTI:
Sistemi ister Postman ister Run edildiginde web ekranina gelen swagger uzerinden test edebilirsiniz.

https://localhost:7235/api/products/getall


