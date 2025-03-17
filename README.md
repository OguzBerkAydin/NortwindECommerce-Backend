# Northwind Backend

Bu proje, kurumsal mimariye sahip katmanlı bir .NET Core web uygulamasıdır. Proje, SOLID prensiplerine uygun olarak geliştirilmiş ve modern yazılım geliştirme tekniklerini içermektedir.

## Kullanılan Teknolojiler

- **.NET Core**: Çapraz platform destekli, açık kaynak kodlu bir framework
- **Entity Framework Core**: Nesne ilişkisel eşleme (ORM) frameworkü
- **Autofac**: Bağımlılık enjeksiyonu (DI) için kullanılan IoC container
- **FluentValidation**: Doğrulama kuralları için kullanılan kütüphane
- **JWT (JSON Web Token)**: Kimlik doğrulama ve yetkilendirme için kullanılan token tabanlı güvenlik sistemi
- **ASP.NET Core Web API**: RESTful servis geliştirmek için kullanılan web framework

## Proje Yapısı

Proje, katmanlı mimari ile aşağıdaki katmanlardan oluşmaktadır:

### Core Katmanı

Projenin temel bileşenlerini içeren, diğer katmanlar tarafından kullanılan ortak kod tabanını barındırır:

- **Aspect**: AOP (Aspect Oriented Programming) kullanımı için gerekli yapıları içerir
- **CrossCuttingConcerns**: Validation, caching gibi kesişen ilgi alanlarını içerir
- **DataAccess**: Veri erişim katmanı için temel yapıları içerir
- **Entities**: Temel entity sınıflarını içerir
- **Extensions**: Genişletme metotlarını içerir
- **Utilities**: Yardımcı sınıfları ve metotları içerir
  - **Business**: İş kuralları yardımcıları
  - **Interceptors**: AOP için interceptor sınıfları
  - **IoC**: Inversion of Control container yapıları
  - **Results**: Standart dönüş tipleri
  - **Security**: Güvenlik ile ilgili yardımcılar

### Entities Katmanı

Veritabanı tablolarına karşılık gelen entity sınıflarını içerir:

- **Concrete**: Somut entity sınıfları
- **DTOs**: Veri transfer objeleri

### DataAccess Katmanı

Veritabanı işlemlerini gerçekleştiren katman:

- **Abstract**: Veri erişim arayüzleri
- **Concrete**: Somut veri erişim sınıfları
  - **EntityFramework**: EF Core implementasyonları
  - **InMemory**: Hafıza içi veri erişim sınıfları

### Business Katmanı

İş kurallarının ve iş akışlarının yönetildiği katman:

- **Abstract**: İş servisi arayüzleri
- **Concrete**: Somut iş servisi sınıfları
- **BusinessAspects**: İş katmanına özgü aspect'ler
- **ValidationRules**: Doğrulama kuralları

### WebAPI Katmanı

Dış dünya ile iletişimi sağlayan API katmanı:

- **Controllers**: HTTP isteklerini karşılayan controller sınıfları

### ConsoleUI Katmanı

Konsol uygulaması ile test etmek için kullanılan katman.

## Mimari Özellikler

- **SOLID Prensipleri**: Yazılım geliştirmede SOLID prensiplerine uygun yapı
- **AOP (Aspect Oriented Programming)**: Kesişen ilgi alanlarının (validation, caching, logging gibi) yönetimi
- **IoC (Inversion of Control)**: Bağımlılık enjeksiyonu ile gevşek bağlı yapı
- **Repository Pattern**: Veri erişim katmanında kullanılan tasarım deseni
- **JWT Authentication**: Token tabanlı kimlik doğrulama sistemi
- **Caching**: Performans iyileştirmesi için önbellek mekanizması
- **Validation**: Girdilerin doğrulanması için FluentValidation kullanımı
- **Global Exception Handling**: Uygulama genelinde hata yönetimi

## Kurulum

1. Projeyi klonlayın
2. Gerekli bağımlılıkları yükleyin:
   ```bash
   dotnet restore
   ```
3. `context` sınıfındaki veritabanı bağlantı ayarlarını yapılandırın
4. Veritabanını oluşturun: `dotnet ef database update`
5. Projeyi çalıştırın: `dotnet run --project WebAPI`

## Lisans

Bu proje açık kaynak kodlu olup, eğitim amaçlı hazırlanmıştır.
