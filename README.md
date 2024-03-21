
<p id="description">Merhaba 👋
 Bu proje Çok Katmanlı Mimari temel alınarak geliştirilmiştir. Projede SOLID yazılım prensipleri benimsenmiştir.Veritabanı için SQL Server Veritabanı kullanılmaktadır. Ayrıca projenin Front-End tarafı ve diğer uygulamalarla iletişim kurabilmesi için servis katmanında bir Web API kodlanmıştır. Projenin back-end kısmında C# kullanıldı. Geliştirme çok katmanlı mimari esas alınarak yapıldı. Katmanların ne işe yaradığı hakkında bilgi vermek istiyorum;</p>

### 1-Entities Katmanı:

<p id="description">Program genelinde kullanılacak nesnelerin,sınıflarının tanımlandığı yerdir. Bu katmandaki sınıfların her biri veritabanındaki bir tabloya karşılık gelir bunlara ek olarak farklı tablolardan gelen verilerin birleştirildiği DTO (Veri Aktarım Nesnesi) sınıflarını da içerir.</p>

 ### 2-Data Access Katmanı:

<p id="description">Veritabanı bağlantılarının ve işlemlerinin yapıldığı katmandır. Veritabanı bağlantısı için gerekli konfigürasyon burada yapılır. Ayrıca veri çıkarma ekleme silme güncelleme gibi işlemler de bu katmanda kodlanır.</p>

### 3-Business Katmanı: 

<p id="description">İş kurallarının tanımlandığı ve kontrol edildiği katmandır. Programa bir komut geldiğinde hangi işlemleri yapması gerektiği ve hangi kurallar dizisinden geçmesi gerektiği burada tanımlanır.</p>

### 4-Core Katmani: 

<p id="description">Tüm katmanlarda ortak olarak kullanılacak yapıların cross cutting concerns(loglama,caching,security,validation... yapilari) aspects, extensions ve utilities(araclarin) kodlandığı bölümdür.</p>

### 5-Servis Katmanı (Web API): 

<p id="description">Front-End kısmının ve diğer platformların programla iletişim kurmasını ve işlem yapmasını sağlayan servislerin yazıldığı kısımdır.</p>

### Veri erişim nasıl değişir?
Business/DependencyResolvers/Autofac/AutofacBusinessModule classinda bulunan
builder.RegisterType(InMemoryProductDal)().As(IProductDal)().SingleInstance(); kod parcasi suan projenin InMemory formatta calistigini gosterir.
InMemoryProductDal yerine EfProductDal yazarsam veri erisimim tamamen EntityFramework'e gececek.Sadece bunu yaparak sistemde hicbir katman bozulmadan ve surdurulebilir bir kodlama yapmis oluruz.

## Backend Gereksinimleri:

Autofac:7.0.0<br>Autofac.Extensions.DependencyInjection:7.0.0<br>Autofac.Extras.DynamicProxy :7.0.0<br>Microsoft.AspNetCore.Authentication.JwtBearer:6.0.0<br>Microsoft.AspNetCore.Http:2.2.2<br>Microsoft.AspNetCore.Http.Abstractions: 2.2.0<br>Microsoft.EntityFrameworkCore:7.0.0<br>Microsoft.EntityFrameworkCore.SqlServer:7.0.0<br>Microsoft.Extensions.Configuration.Binder:7.0.0<br>Swashbuckle.AspNetCore:6.2.3


## Projede bulunmasi gerekenler
.Net 6.0 <br> Microsoft Sql Server Managment Studio 18 <br> Postman

## Kurulum Asamasi

!(![1](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/add2a45b-ae21-4880-ab67-e04f2ad7c8fd)
)

!(![2](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/39978f7e-ee24-47e5-a8e0-dd3f7ba87145)
)

!(![3](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/5d90addc-d349-438b-b333-3aa67c00fcbe)
)

!(![4](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/e94d5f4a-c3b6-4ec1-a208-3e9b6d98144d)
)

!(![5](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/a8a7029d-a562-42c6-bbe0-9daa70aa83db)
)

## Database
<p id="description">Projede veritabanı olarak SQL SERVER kullanıldı. Veritabanını oluşturmak için gerekli kodlari mail araciligiyla size atmis bulunmaktayim.Eger kendiniz veri tabanini olusturmak isterseniz asagidaki gorsellerdeki adimi takip etmeniz yeterli olacaktir.</p>

## <p id="description">1-Sql server uzerinde yeni bir veri tabani olusturun.</p>

!(![0](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/e2514027-aa69-401a-a901-126be94facc2)
)


!()![0-1](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/8409f926-ca14-4fd6-b796-ddc412ca7cf1)


## <p id="description">2-Veritabani olusturduktan sonra veri tabani tablolarini olusturunuz.</p>

<p id="description">Tablo verilerinin turleri ve isimleri burada girilir.</p>


!(![0-3(TabloOlustruma )](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/c077dc44-1b1f-4acb-91f5-ba14e21f2dcf)
)

<p id="description">Tabloya sag tiklayip Design i secerek tabloda olan verilerin isimlerini ve veri turunu girebilirsiniz.Ayni sekilde tabloya sag tiklayip Edit Top 200 Row secerseniz verileri ekleyebilirsiniz.</p>




## <p id="description">3-OperationClaims Tablosunun olusturulmasi.</p>

!(![OperationClaimdesign](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/737aaabc-387c-4fb1-9dca-06742f23bc77)
)

!(![operationclaimsedit](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/1394df01-59f6-4800-bca4-0c4b3074d984)
)


## <p id="description">4-Products Tablosunun olusturulmasi.</p>

!(![productDesign](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/5b2548c2-370e-42a5-948c-380b4cb5f938)
)

!(![productedit](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/7924aad4-fda8-4b80-ad6c-d54c31d88e8f)
)



## <p id="description">4-UserOperationClaims Tablosunun olusturulmasi.</p>

!(![3UserOperationClaimsDesign](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/be9d799e-22b3-403a-9ebf-69c93329b16c)
)

!(![3UserOperationClaimsEdit200](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/5a54c0b6-7364-44eb-a19a-6aed7271852f)
)



## <p id="description">4-Users Tablosunun olusturulmasi.</p>

!(![4UsersDesign](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/23204d1e-1904-4a84-89d8-4e21b06267d8)
)


!(![4UsersEdit200](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/f8d6738d-e18a-4957-b07a-1f7b282dbbea)
)


### <p id="description">Backend kisminda sql server adresinizin dogru oldugundan emin olun.Adresinizi kendi server adresiniz ile degistirin.</p>

!(![c#veritabani](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/b7f9151c-a97a-49d4-a591-c646785eeae5)
)


### <p id="description">Kendi olusturdugunuz veritabanini kullanmak istiyorsaniz kirmizi dikdortgendeki kisim EfProductDal olarak kalmali.Eger benim inMemory formatta olustrudugum verilere ulasmak isterseniz inMemoryProductDal yapmaniz yeterli.(Ustteki yorum satiri aktiflestirip efproductdal satirini yorum satiri yapip inmemory formata gecebilirsiniz.)</p>


!(![efproduct](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/9ccc56c3-3e4d-47ab-b845-1eb7a25528a4)
)







## PROJENIN TESTI:
<p id="description">Sistemi ister Postman ile ister Run edildiginde web ekranina gelen swagger uzerinden test edebilirsiniz.Ben postman ile test etmeyi tercih ettim.</p>

### <p id="description">Program calistiginda Portunuz benim portumdan farkli olabilir.Benim suanki portum:https://localhost:7235/ Eger sizinki farkliysa lutfen kendi portunuza gore degistirip istekleri oyle yapiniz. </p>




### Kullanici Register Islemi:

!(![REGISTER1](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/bd05201c-5a3d-44d9-9a4b-ea92c227e1c6)
)

!(![REGISTER2](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/38892931-7f4f-435e-96a8-9e851efe9f32)
)


<p id="description">Ayni kullanici sisteme tekrardan kayit oldugunda "Kullanici mevcut uyarisi.".</p>

!(![REGISTER3](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/5909d886-0897-4531-827c-e094c422450a)
)

### Login islemleri: 
<p id="description">Kullanici sisteme kayit olduktan sonra Login islemi yaoabilir.Geriye token ve token ezpiration degerleri doner.</p>

!(![LOGIN1](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/2a2879e4-a8c6-4f03-8f5b-b04d877057b3)
)

### Login yaparken sifre hatali girilirse:
<p id="description">Parola hatasi mesaji alir.</p>

!(![LOGIN2](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/7e5e4730-e1b5-4d4f-9bd6-ed3af057f569)
)


### GETALL Istegi:

!(![getall istegi](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/7f0f22de-cb06-4dd4-9fc9-d1577acea734)
)


### ADD Istegi(Yetkisiz):
<p id="description">Ekleme yapilirken yetki olmasi gerektigi icin,simdilik kullaniciya yetki vermedigimiz icin ekleme operasyonu yapilirken "Yetkiniz yok hatasi aliyor."</p>

!(![PRODUCTADD(YETKI YOK)](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/87e0c0c9-c040-4539-a616-b8a766a52386)
)

!(![PRODUCTADD(YETKI YOK)2](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/5ebd0c91-2a77-4651-84b8-af6696953252)
)

### ADD Istegi(Yetkili):
<p id="description">Yukarida Database kisminda bulunan Ahmet isimli 3 numarali Id'ye sahip olan kullanici OperationClaims tablosunda bulunan 4 numarali id olan "product.add" yetkisine sahiptir.Bunu UserOperationClaims tablosunda (3 numarali userId yani (Ahmet) 4 numarali OperationClaims(yani "product.add" )) yetkisine sahiptir)gorebiliriz.Eger ekleme islemi yaparken Ahmet kullanicisiyla bu islemi yapacak olursak bir problem olmaz.</p>


<p id="description">Oncelikle yetkili olan Ahmet kullanicisinin sisteme girisi yapiliyor.Tirnak icindeki token degeri kopyalanir."</p>

!(![PRODUCTADD(YETKI VAR1)](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/26579b08-86e8-4fd6-a0e4-801ee38cde50)
)


<p id="description">Products/add kisminda urun bilgileri Body/raw/json formatinda yazilir."</p>

!(![PRODUCTADD(YETKI VAR2)](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/eb4eae03-6f5f-42b8-b836-c2ddbd4cc57c)
)


<p id="description">Login islemi yapildiginda kopyalamis oldugumuz tokeni Headers/Authorization kismina tokenin basina Bearer ekleyip Send tusuna basariz.</p>

!(![PRODUCTADD(YETKI VAR3)](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/f2d541a2-e22a-4712-90a7-47d02635758f)
)


!(![PRODUCTADD(YETKI VAR4)](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/7fd4e32b-660c-4374-9e19-f1c0fe2e0338)
)


### DELETE Istegi(Yetkili):


<p id="description">Yetkilendirme mekanizmasi varken.Ahmet kullanicisi yine yetkili."</p>


!(![ProductDelete(yetkilendirme mekanizmasini yorum satiri yaptiktan sonra  urunun silinmesi ve geri donus degeri)](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/0ef66a86-4ace-4380-902a-28fe72fe7dc7)
)

<p id="description">Ahmet kullancisi yetkili degilken.</p>


!(![ProductDelete(yetki yok)1](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/dfed4fd7-052f-42b8-acc5-6ce54f6ad478)
)


!(![ProductDelete(yetki yok)2](https://github.com/burakkabis/ParanumusAssignment/assets/134310460/9747fe9b-0df0-4a39-8280-40ee896c305a)
)




