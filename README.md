# 📄 CvMakerApp - CV Oluşturucu Uygulaması

Modern ve kullanıcı dostu bir CV (Özgeçmiş) oluşturma ve yönetim uygulaması. ASP.NET Core 8.0 ile geliştirilmiş bu uygulama, kişisel bilgilerinizi, deneyimlerinizi, eğitim geçmişinizi ve becerilerinizi kolayca yönetmenizi sağlar.

## 🚀 Özellikler

### 📊 Yönetim Paneli
- **Kişisel Bilgiler**: Ad, soyad, açıklama, web sitesi, telefon, e-posta ve profil fotoğrafı yönetimi
- **İş Deneyimi**: Şirket adı, pozisyon, başlangıç/bitiş tarihleri ve açıklama bilgileri
- **Eğitim Geçmişi**: Okul adı, bölüm, eğitim türü ve tarih bilgileri
- **Dil Becerileri**: Dil adı ve seviye bilgileri
- **Üyelikler**: Organizasyon, pozisyon ve tarih bilgileri
- **Teknoloji Stack**: Kullanılan teknolojiler ve açıklamalar
- **Gönüllü Çalışmalar**: Şirket adı ve pozisyon bilgileri
- **Referanslar**: İsim, pozisyon ve şirket bilgileri
- **Açıklamalar**: Genel açıklama metinleri

### 🎨 CV Görüntüleme
- Modern ve profesyonel CV tasarımı
- Responsive (mobil uyumlu) tasarım
- Yazdırma dostu format
- Temiz ve okunabilir düzen

### 🛠️ Teknik Özellikler
- **Framework**: ASP.NET Core 8.0
- **Veritabanı**: SQL Server (Entity Framework Core)
- **UI Template**: PurpleAdmin
- **Mimari**: MVC (Model-View-Controller)
- **ORM**: Entity Framework Core 8.0

## 📋 Gereksinimler

### Sistem Gereksinimleri
- .NET 8.0 SDK
- SQL Server (LocalDB veya tam sürüm)
- Visual Studio 2022 veya Visual Studio Code
- IIS Express (geliştirme için)

### Paket Bağımlılıkları
```xml
<PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.20" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.20" />
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.20" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.20" />
<PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="8.0.7" />
```

## 🔧 Kurulum

### 1. Projeyi Klonlayın
```bash
git clone https://github.com/kullaniciadi/CvMakerApp.git
cd CvMakerApp
```

### 2. Veritabanı Bağlantısını Yapılandırın
`CvMakerApp/Entity/Context/Context.cs` dosyasında bulunan bağlantı dizesini kendi SQL Server ayarlarınıza göre düzenleyin:

```csharp
optionsBuilder.UseSqlServer("Server=localhost; initial catalog=CVMakerDB ; integrated Security=true; TrustServerCertificate=True");
```

### 3. Veritabanı Migration'larını Uygulayın
```bash
cd CvMakerApp
dotnet ef database update
```

### 4. Uygulamayı Çalıştırın
```bash
dotnet run
```

Uygulama varsayılan olarak `https://localhost:5001` adresinde çalışacaktır.

## 📱 Kullanım

### Yönetim Paneli
1. Uygulamayı başlattıktan sonra ana sayfaya gidin
2. Yönetim paneli üzerinden CV bölümlerinizi düzenleyin:
   - **Kişisel Bilgiler**: Temel bilgilerinizi güncelleyin
   - **Deneyim**: İş deneyimlerinizi ekleyin/düzenleyin
   - **Eğitim**: Eğitim geçmişinizi yönetin
   - **Diller**: Dil becerilerinizi belirtin
   - **Beceriler**: Teknoloji stack'inizi ekleyin
   - **Üyelikler**: Profesyonel üyeliklerinizi listeleyin
   - **Gönüllü Çalışmalar**: Sosyal sorumluluk projelerinizi ekleyin
   - **Referanslar**: İş referanslarınızı yönetin

### CV Görüntüleme
- `/Cv` sayfasından CV'nizin son halini görüntüleyebilirsiniz
- CV'nizi yazdırabilir veya PDF olarak kaydedebilirsiniz

## 🏗️ Proje Yapısı

```
CvMakerApp/
├── Controllers/
│   ├── AdminController.cs      # Yönetim paneli layout bileşenleri
│   ├── CvController.cs         # CV görüntüleme işlemleri
│   ├── DefaultController.cs    # Ana CRUD işlemleri
│   └── HomeController.cs       # Ana sayfa kontrolcüsü
├── Entity/
│   ├── Context/
│   │   └── Context.cs          # Veritabanı bağlamı
│   └── Entities/               # Veri modelleri
│       ├── Title.cs            # Kişisel bilgiler
│       ├── Experience.cs       # İş deneyimi
│       ├── Education.cs        # Eğitim bilgileri
│       ├── Language.cs         # Dil becerileri
│       ├── Membership.cs       # Üyelikler
│       ├── Stack.cs           # Teknoloji stack
│       ├── Voluntary.cs       # Gönüllü çalışmalar
│       ├── Testimonial.cs     # Referanslar
│       └── Description.cs     # Açıklamalar
├── Views/
│   ├── Admin/                 # Yönetim paneli görünümleri
│   ├── Cv/                    # CV görüntüleme sayfaları
│   ├── Default/               # CRUD işlem sayfaları
│   └── Shared/                # Paylaşılan layout dosyaları
├── wwwroot/                   # Statik dosyalar (CSS, JS, resimler)
└── Migrations/                # Veritabanı migration dosyaları
```

## 🎯 Ana Özellikler Detayı

### Veri Yönetimi
- **CRUD İşlemleri**: Tüm CV bölümleri için tam CRUD (Create, Read, Update, Delete) desteği
- **Veri Doğrulama**: Model bazlı veri doğrulama
- **İlişkisel Veri**: Normalize edilmiş veritabanı yapısı

### Kullanıcı Arayüzü
- **Responsive Tasarım**: Tüm cihazlarda uyumlu çalışır
- **Modern UI**: PurpleAdmin template ile profesyonel görünüm
- **Kolay Navigasyon**: Sezgisel menü yapısı
- **Form Validasyonu**: Gerçek zamanlı form doğrulama

### Performans
- **Entity Framework**: Optimize edilmiş veritabanı sorguları
- **Lazy Loading**: İhtiyaç duyulan verinin yüklenmesi
- **Caching**: Statik içerik önbellekleme

## 📸 Ekran Görüntüleri

*Bu bölüme 11 adet ekran görüntüsü eklenecektir:*

1. **Ana Sayfa** - Uygulamanın giriş ekranı
2. **Yönetim Paneli Dashboard** - Ana yönetim ekranı
3. **Kişisel Bilgiler Düzenleme** - Profil bilgileri formu
4. **İş Deneyimi Listesi** - Deneyim yönetim sayfası
5. **Deneyim Ekleme Formu** - Yeni deneyim ekleme ekranı
6. **Eğitim Geçmişi Yönetimi** - Eğitim bilgileri sayfası
7. **Dil Becerileri** - Dil yönetim ekranı
8. **Teknoloji Stack** - Beceriler yönetim sayfası
9. **CV Önizleme** - Tamamlanmış CV görünümü
10. **Mobil Görünüm** - Responsive tasarım örneği
11. **Yazdırma Görünümü** - Print-friendly CV formatı

## 🤝 Katkıda Bulunma

1. Bu repository'yi fork edin
2. Yeni bir feature branch oluşturun (`git checkout -b feature/yeni-ozellik`)
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/yeni-ozellik`)
5. Pull Request oluşturun

## 🐛 Hata Bildirimi

Bir hata bulduysanız veya öneriniz varsa, lütfen [Issues](https://github.com/kullaniciadi/CvMakerApp/issues) sayfasından bildiriniz.

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakınız.

## 👨‍💻 Geliştirici

**[Geliştirici Adı]**
- GitHub: [@kullaniciadi](https://github.com/kullaniciadi)
- LinkedIn: [linkedin.com/in/profil](https://linkedin.com/in/profil)
- E-posta: email@example.com

## 🙏 Teşekkürler

- [PurpleAdmin](https://www.bootstrapdash.com/product/purple-admin-template/) - UI Template
- [Microsoft](https://docs.microsoft.com/en-us/aspnet/core/) - ASP.NET Core Framework
- [Entity Framework](https://docs.microsoft.com/en-us/ef/) - ORM Framework

---

⭐ Bu projeyi beğendiyseniz, lütfen yıld��z vererek destekleyiniz!
