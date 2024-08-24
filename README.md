# Rapid Api ve Api Consume İle Hotelier Projesi
Merhabalar, bu proje, ASP.NET Core kullanılarak çok katmanlı mimari yapısında geliştirilmiş bir API ve MVC uygulamasını içermektedir. Projemizde veri tabanı olarak MSSQL kullanılmış olup, backend kısmı tamamen API ile kodlanmıştır. Frontend tarafında ise, API yapısı MVC controller üzerinden entegre edilerek veriler tüketilmiştir. Bu sayede, verilerin dinamik bir şekilde yönetilmesi ve kullanıcı arayüzüne aktarılması sağlanmıştır. Ayrıca, çok katmanlı mimari sayesinde projede hem sürdürülebilirlik hem de esneklik artırılmıştır.


### Projede kullanılan teknolojiler ve özellikler

📌 Asp.Net Core Api

📌 Asp.Net Identity

📌 MSSQL

📌 X.PagedList ile Pagination İşlemleri

📌 Swagger

📌 Postman

📌 Api Consume

📌 Rapid Api

📌 Json Web Token

📌 Login

📌 Register

📌 AspNet Core 8.0

📌 Fluent Validation

📌 N Tier Architecture

📌 DTO Layer

📌 Mvc

📌 Deploy

📌 Entity Framework Core

📌 Repository Design Pattern

📌 MailKit ile Mail Gönderme İşlemleri

📌 Rezervasyon İşlemleri

📌 Rezervasyon İşlemlerinde isime göre filtreleme

📌 Tüm CRUD İşlemleri


### Projemde Kullandığım Paketler

![image](https://github.com/user-attachments/assets/4b515470-2361-4196-b74d-ff2bf0607254)


## Admin Dashboard Alanı

![admin dashboard](https://github.com/user-attachments/assets/9cda6d14-275d-4888-a683-9113300000d0)

Bu site içerisinde istatistikler yer almakta olup, dashboardda personel sayısı, rezervasyon sayısı, müşteri sayısı ve oda sayısı gibi bilgilere ulaşılabilmektedir. Ayrıca, son 4 personel, müşteriler ve sosyal medya verileri de dashboardda görüntülenmektedir. En alt kısımda bulunan sosyal medya alanının verileri ise Rapid API üzerinden çekilmektedir. Bu sayede, kullanıcılar site üzerinde güncel ve dinamik bilgilere kolaylıkla erişebilmektedir.

-----------------------------------------------------------------------------------------------------------------

## Admin Rezervasyon Alanı
![admin tüm rezervasyonlar](https://github.com/user-attachments/assets/cc26fd7e-aa18-4421-b017-7c9be1acf2d4)
![admin kişi adına göre rezervasyon bulma](https://github.com/user-attachments/assets/c2b82495-6c0f-4c97-868a-55992fc3d6b8)
![admin onaylı rezervasyonlar](https://github.com/user-attachments/assets/debf486a-29b9-4bfd-97db-a731431a0517)
![admin bekletilen rezervasyonlar](https://github.com/user-attachments/assets/1f066a49-8800-42bd-a752-13207ab898a1)
![admin iptal edilen rezervasyonlar](https://github.com/user-attachments/assets/bd0bb585-4fea-4d01-859a-f6956de14785)
![admin rezervasyon detayı](https://github.com/user-attachments/assets/4e364aa2-d0ae-47a7-84f4-97655f7c575e)
![rezervasyon güncelleme](https://github.com/user-attachments/assets/a40faf45-b6d4-4d14-8fee-331a7d83d877)


📌 Bu bölümde rezervasyonlar listelenir ve her bir rezervasyon için güncelleme, iptal etme, onaylama ve bekletme, detay görüntüleme veya tamamen silme işlemleri yapılabilir. 

📌 Misafir adına göre filtreleme seçeneği bulunur. 

📌 Eğer bir rezervasyon onaylanmışsa, onaylama butonu pasifleşir ve diğer işlemler (iptal, bekletme) gerçekleştirilene kadar bu buton pasif kalır. 

📌 Onaylı, iptal edilen ve bekletilen rezervasyonlar için ayrı sayfalara gidilebilir. Hangi butona tıklanmışsa, o buton pasif hale gelir ve rezervasyon durumu değişene kadar aktif olmaz.


-----------------------------------------------------------------------------------------------------------------
## Admin Dosya Ve Resim Dosyası Yükleme

![resim dosyası yükleme](https://github.com/user-attachments/assets/8c15bc9d-d453-45af-bed6-44b55a7c3096)


![dosya yükleme](https://github.com/user-attachments/assets/c9028c0b-1607-4fc3-a091-c20a659d6b09)

-----------------------------------------------------------------------------------------------------------------

## Admin MailKit ile Mail Gönderme İşlemi

![gerçek mail gönderme işlemi](https://github.com/user-attachments/assets/dd962fb4-7019-41e9-95d2-dce29b643835)

![gmail hesabıma gelen mail](https://github.com/user-attachments/assets/5ce0a210-a06b-4dff-a77b-da22941a334d)

📌 Admin sayfasından Admin, kullanıcılara, personelere veya rezervasyon yaptıran kişilere mail gönderebilir. Bu işlem sonucunda gmail hesabına gerçek bi mail gönderilmektedir. .Net Core Mailkit kullanılmıştır.


-----------------------------------------------------------------------------------------------------------------


## Admin Personel Listesi

![admin personeller](https://github.com/user-attachments/assets/eb946c51-03fb-405f-ba9c-780375bfc997)

📌 Bu alanda Hotelier çalışanları görüntülenmektedir


-----------------------------------------------------------------------------------------------------------------

## Admin Referanslar

![admin referanslar](https://github.com/user-attachments/assets/60210b8c-01f1-41d4-9282-12051025f2eb)

📌 Bu alanda Hotelier'i deneyimlemiş ve referans mesajı yazmış tüm eski müşteriler görüntülenmektedir. Referans bilgileri hotelier sayfasında sergilenmektedir.


-----------------------------------------------------------------------------------------------------------------

## Admin Oda Listesi

![admin odalar](https://github.com/user-attachments/assets/e254ab79-b8a3-4f25-bf24-11407e36b5c0)

![admin oda ekleme](https://github.com/user-attachments/assets/72f5466f-21d9-4804-8524-ec6b8c5a788b)

📌 Bu alanda Hotelier sayfasında yer alan tüm oda bilgileri görüntülenmektedir. Admin odaları buradan yönetir.


-----------------------------------------------------------------------------------------------------------------

## Admin İletişim Ve Mesajlar Listesi

![admin gelen mesajlar](https://github.com/user-attachments/assets/1257eed3-c7ba-42b1-ae13-3302f86c49a1)

![admin gönderilen mesajlar](https://github.com/user-attachments/assets/e56cf42d-0ecf-439a-a2e7-6d79a7cb275d)

![admin gelen mesaj detayı](https://github.com/user-attachments/assets/cf6753c7-5824-49ae-b1cd-3eda4eb8c8e1)

![yeni mesaj oluşturma sayfası](https://github.com/user-attachments/assets/7e93056b-2695-489f-befa-517aa7d5c20a)

![yeni mesaj oluşturma ve gönderme](https://github.com/user-attachments/assets/c2273b11-b0fa-4d78-978b-238a4380f30a)

![gönderilen mesaj detayı arya için](https://github.com/user-attachments/assets/8eeb0e97-fd6a-484e-b981-37390b5060f7)


📌 Bu alanda Hotelier sayfasında yer alan gelen ve gönderilen tüm mesajlar görüntülenmektedir

📌 Admin mesaj gönderebilir, yada Hotelier sayfasındaki iletişim panelinden gönderilen tüm mesajlar Admin Paneline gelen mesajlar bölümüne düşer.

📌 Burada X.PagedList ile pagination işlemi yapılmıştır.

📌 Yandaki side bar alanından kaç adet gelen ve gönderilen mesaj olduğu bilgisine de ulaşabiliriz. 


-----------------------------------------------------------------------------------------------------------------

## Sisteme Register Panelinden Kayıt yapmış Kullanıcılar

![sisteme kaydolmuş kullanıcılar](https://github.com/user-attachments/assets/fff3373c-051f-4857-a666-928b98093e27)

📌 Identity ile sisteme kaydolmuş kullanıların listesi.
📌 Bu Kullanıcılar Identity ile Register Panelinden Kayıt yapmış Kullanıcılardır. Login panelinden giriş yapmaktadırlar.
📌 Admin Panelinde Admin, Personel, Ziyaretçi gibi rollere atanabilirler.


-----------------------------------------------------------------------------------------------------------------


## Sisteme Register Panelinden Kayıt yapmış Kullanıcılar için Rol Atama İşlemi

![roller](https://github.com/user-attachments/assets/24fe77b5-13ce-4572-9170-12c4d0edb020)


![rol atama](https://github.com/user-attachments/assets/f807196a-2344-4608-ba47-d94f826bf969)


![kullanıcıya rol atanıyor](https://github.com/user-attachments/assets/2524d562-3fb0-429e-bfbe-a64dddd8e06e)

![Ekran görüntüsü 2024-08-24 041702](https://github.com/user-attachments/assets/8fc2e174-242b-47c4-a7d0-df8b7b164d5c)


📌 Bu Kullanıcılar Identity ile Register Panelinden Kayıt yapmış Kullanıcılar olup Admin Panelinde Admin, Personel, Ziyaretçi gibi rollere atanabilirler.


-----------------------------------------------------------------------------------------------------------------

## Otel Lokasyonları

![otel lokasyonları](https://github.com/user-attachments/assets/15be3a19-a43a-41c5-966a-bb8d0316c70d)


-----------------------------------------------------------------------------------------------------------------

## Admin Hizmetlerimiz Listesi

![admin hizmetler](https://github.com/user-attachments/assets/06bc0397-de22-4797-8eab-31bd4ac8f6af)

-----------------------------------------------------------------------------------------------------------------
## Admin Setting Panelinden Kullanıcı Profil Güncelleme Ekranı

![Profil Bilgileri ve Şifre Güncelleme](https://github.com/user-attachments/assets/673b6dd2-07a3-43d2-8cc4-569a19f56d00)

📌 Burada sisteme giriş yapmış kullanıcı / admin bilgilerini ve giriş şifresini değiştirebilir.

-----------------------------------------------------------------------------------------------------------------

## Register ve Login sayfaları

![image](https://github.com/user-attachments/assets/d2df6adf-e7c7-4e94-96be-69f10badfc09)

![image](https://github.com/user-attachments/assets/23272a82-f7a0-4797-99b3-0078fe1b0e2f)

-----------------------------------------------------------------------------------------------------------------
## Error sayfaları

![image](https://github.com/user-attachments/assets/19337e16-a901-4164-ba18-131ad8a6b585)
📌 Burada Url'e hatalı bir istek girdiğimizde veya erişimi olmayan biri erişim sağlamaya çalıştığında bu ayfayla karşılaşır ve Hotelier anasayfasına yönlendirilir.

-----------------------------------------------------------------------------------------------------------------
## Fluent Validation

![image](https://github.com/user-attachments/assets/62399064-e1c0-4275-ace6-95a025f7dfcd)
📌 Burada Validasyon İşlemi uygulanmıştır. Fluent Validation Kullanılmıştır.


-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------

# Hotelier Sayfası

![hotelier giriş](https://github.com/user-attachments/assets/cc9ea73f-be91-435d-a752-077d48a2d4f3)

![hakkımızda dinamik çekilen veriler](https://github.com/user-attachments/assets/1be093c4-d881-407e-95ab-37dbb2b3bb6f)

📌 Burada Hakkımızda Bölümünde Sisteme Kaydı yapılan oda, personel ve müşteri sayıları dinemaik olarak çekilir. Entitiye özgü metotlarla About ile oda, personel ve müşteri tabloları arasında ilişki kurulmuştur.

![son eklenen 3 oda](https://github.com/user-attachments/assets/5a079e1b-5c59-46cd-acdd-fa3824198cda)

![otel video](https://github.com/user-attachments/assets/6e523521-c473-4cb6-b0aa-81195a387f45)

![hizmetlerimiz2](https://github.com/user-attachments/assets/8d2999b6-fb1c-4aa1-a279-f078872573b0)

![referasnlar](https://github.com/user-attachments/assets/0cfedae5-4c6c-45ed-99a6-3e12d7d3c256)

![ekip arkadaşları](https://github.com/user-attachments/assets/b3fda841-5500-4e8f-ab57-87e5cb3abb13)

![footer](https://github.com/user-attachments/assets/32a070e1-12d5-4483-98a7-be298a2c787d)

-----------------------------------------------------------------------------------------------------------------
![rezervasyon sayfası](https://github.com/user-attachments/assets/c5715f78-d201-4882-9b98-61dd05077e2f)

![biri rezervasyon yapıyo](https://github.com/user-attachments/assets/3a36e531-295d-4cfa-b2e8-069467d7345f)

![pınar tunanın rezervasyonu düştü, onay bekliyo admin karar vercek](https://github.com/user-attachments/assets/560d86ca-f411-4d85-a3e0-0826691ad935)

📌 Rezervasyonlar Hotelier sayfası rezervasyon panelinden yapılmaktadır. Rezervasyon yapan ziyaretçinin rezervasyonu Admin paneli rezervasyonlar bölümüne düşer. Admin rezervasyonu onaylayana kadar "Onay Bekliyor" durumunda gözükür.

-----------------------------------------------------------------------------------------------------------------


![iletişim sayfası](https://github.com/user-attachments/assets/c04060b0-46c0-481d-829a-a1592e918432)

![iletişim sayfası mesaj kategorisi seçme](https://github.com/user-attachments/assets/34852589-a833-4950-9bd6-19b15eb56a70)

![melikenin mesajından sonra gelen mesjlar görünüm](https://github.com/user-attachments/assets/591f4453-f026-45c3-848b-b7778d0eeafd)

![melikenin mesajı geldi](https://github.com/user-attachments/assets/3312cffe-f789-4dc6-91b4-8a0ba5a0d912)

📌 Burası Hotelier'ın İletişim Panelidir. 

📌 Buradan Ziyaretçiler Admine Mesaj gönderebilir

📌 Görsellerde Melike adli ziyaretçi mesaj göndermektedir. Mesaj kategorisi bölümünden Kategori seçebilir ve mesaj konusunu kategoriye göre belirleyebilir. Yada yazacağı mesaja göre Kategori seçer diyelim. Burada da ilişli tablo kullanılmıştır

📌 Son olarak Melike adlı kişinin mesajı Admin Panelinde Gelen mesajlar bölümüne düşmüştür.


-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------


## Projem Ek Olarak Hotelierden Bağımsız Rapid Api Ve JWT içermektedir. Ek olarak SQL tarafında Tetikleyici Oluşturma yöntemiyle de Hakkımızda Bölümündeki Count Değerleri Dinamik olarak çekilmiştir


![Tetikleyiciler oluşturuldu ](https://github.com/user-attachments/assets/c76bb7b5-3086-4f46-987e-14e4ccbd64a2)

📌 Tetikleyici oluşturma (oda , personel ve müşteri sayılarını dinemik verilerini çektik.)

-----------------------------------------------------------------------------------------------------------------

![jwt admin token oluştur](https://github.com/user-attachments/assets/94bd61df-f4be-4c82-b020-89a02e633bb1)
📌 JWT Admin Token Oluşturma

![jwt başarılı postman 1](https://github.com/user-attachments/assets/71f04eb6-cadc-47a5-8b55-d26a003e4391)

 ![jwt başarılı1](https://github.com/user-attachments/assets/43b0ae47-fc36-4152-942e-a1432825569a)

![jwt admin token başarılı giriş yaptı](https://github.com/user-attachments/assets/4c4cca2e-776c-4912-830e-82b54f9bc293)
📌 JWT Admin Token Başarılı Giriş Yaptı


-----------------------------------------------------------------------------------------------------------------

![booking görsel1](https://github.com/user-attachments/assets/c18180be-ccf6-4d68-8391-ab5ea896dbb4)

📌 Rapid Api ile Booking


![searchlocation by id](https://github.com/user-attachments/assets/fa1fca07-66cd-41e6-8ce3-c3f100fef80f)

📌 Rapid Api ile Lokasyona göre İd bulma

![istanbul idsine göre ötelleri getirme, öncesinde şehir adı yazarak idyi bulmuştuk](https://github.com/user-attachments/assets/74de6b66-b781-4874-bdd9-8f59bac599eb)

📌 Rapid Api ile Lokasyona (İstanbul) göre Id bulduk ve sonrasında İstanbul Id sine göre Otelleri Getirdik

-----------------------------------------------------------------------------------------------------------------

![exchange görsel1](https://github.com/user-attachments/assets/97fd0fb7-e6db-4359-a077-9aa891b187b2)

📌 Rapid Api ile Exchange Verileri

-----------------------------------------------------------------------------------------------------------------

![imdb görsel1](https://github.com/user-attachments/assets/353f46b4-e3fa-4cc8-8620-4dc2505373b6)

📌 Rapid Api ile IMDB Verileri



-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------

## Birazda API Tarafına Göz Atalım..

![apiler1](https://github.com/user-attachments/assets/053744a1-20df-4f34-8d46-7097a42318d3)

![apiler2](https://github.com/user-attachments/assets/728ccc65-9e99-4b5b-9da3-b9f47193a2c6)

![apiler3](https://github.com/user-attachments/assets/9d72dce6-c2d1-462a-9203-6febca74d636)

![apiler4](https://github.com/user-attachments/assets/7c0cbc04-4da6-4387-9aad-dce1312daf30)

![apiler5](https://github.com/user-attachments/assets/fe6cfae1-4af9-4bdf-aa4b-716582c85dd7)

![apiler6](https://github.com/user-attachments/assets/2ae76823-c6bd-448c-bc8b-dbf354657b57)

![gelen mesajlar](https://github.com/user-attachments/assets/cd820060-1860-490a-be9d-7f703414f07c)

![iptal edilen rezervasyonları listeliyo](https://github.com/user-attachments/assets/e2223bdc-e844-4ea9-a8ba-8d60ea0572c0)

📌 Görüldüğü gibi API tarafında tüm Apilerimiz hazırdır. Bu apiler WebUI tarafında tüketilemektedir.
📌 Katmanlar arası referanslarla Api Controllerlar aracılığıyla güçlü Api istekleri barındırmaktadır.


-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------


# Teşekkür...

Bu proje bana çok şey kattı ve ASP.NET CORE teknolojilerinde gelişmeme öncü olan projelerimden biridir. Geliştirmeye açık bir proje olup amacım şuydu; bir otel sitesi yöneticisi olsaydım hangi özellikleri barındırması gerektiği ve bu siteyi hem admin panelinde hemde ziyaretçilerin göreceği panelde nasıl bir görünüme sahip olmasını isterdim diye düşünerek yola çıktım.
Adminin yetkileri ve ziyaretçi panelini yönetmesi, ziyaretçilerin adminle dinamik haldeki iletişimi, Adminin Personeller ve ziyaretçilerle Mail üzerinden iletişim kurabilmesi ve rezervasyonların detaylı yönetilebilirliği en önemli bulduğum özellikleridir projemin.
İncelediğiniz için teşekkürler. Geri dönüşleriniz için Bana Linkedin Hesabımdan Ulaşabilirsiniz : https://www.linkedin.com/in/esincaglakiral/
