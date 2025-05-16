🌡️ Arduino Nano | BMP180 & DHT11 Sensörleri ile Sıcaklık, Nem ve Basınç Takip Sistemi
Bu proje, Arduino Nano kullanarak BMP180 (basınç & sıcaklık) ve DHT11 (nem & sıcaklık) sensörlerinden alınan verileri C# Windows Forms (Visual Studio) uygulamasıyla bilgisayarda canlı olarak görselleştiren bir sistemdir. Veriler hem gauge göstergeler hem de grafikler ile ekrana yansıtılır.

📦 Kullanılan Malzemeler
Bileşen	Açıklama
Arduino Nano	Mikrodenetleyici kartı
BMP180 Sensörü	Basınç ve sıcaklık ölçer
DHT11 Sensörü	Nem ve sıcaklık ölçer
10kΩ Direnç	DHT11 için pull-up direnci
Breadboard & Jumper Kabloları	Bağlantılar için

🖥️ Visual Studio Uygulaması
C# Windows Forms ile arayüz geliştirildi.

System.IO.Ports kütüphanesi ile Arduino’dan veri alındı.

Veriler gauge göstergeler ve canlı grafik olarak gösterildi.

Kullanılan Kütüphaneler:
csharp
Kopyala
Düzenle
using System;
using System.IO.Ports;
using System.Windows.Forms;
🔌 Devre Bağlantıları
DHT11 Bağlantısı:
Arduino Nano	DHT11
D2	Data
5V	VCC
GND	GND

Not: DHT11 Data ile 5V arasına 10kΩ pull-up direnci bağlı olmalıdır.

BMP180 Bağlantısı:
Arduino Nano	BMP180
3.3V	VIN
GND	GND
A4	SDA
A5	SCL

Not: BMP180 sensörünü 3.3V'a bağlamalısın. 5V bağlantısı cihaza zarar verebilir.

🚀 Projenin Çalışma Prensibi
Arduino Nano, BMP180 ve DHT11 sensörlerinden veri toplar.

Bu verileri seri port üzerinden bilgisayara yollar.

C# Windows Forms uygulaması seri porttan gelen verileri okur.

Sıcaklık, nem ve basınç değerleri arayüzde gauge göstergeler ve grafiklerle gösterilir.

🛠️ Kurulum & Çalıştırma
Arduino Tarafı:
Arduino IDE ile ilgili .ino dosyasını yükle.

Arduino Nano'yu bilgisayara bağla.

Visual Studio Tarafı:
Visual Studio ile projeyi aç.

Doğru COM Portu seçtiğinden emin ol.

Uygulamayı başlat.

📈 Uygulama Alanları
Hava durumu istasyonları

İç ortam hava kalitesi izleme

Sensör verilerinin görsel sunumu

📄 Lisans
Bu proje MIT Lisansı ile paylaşılmıştır.

⭐ Katkıda Bulunmak İstersen:
Bu repoyu fork'la,

Geliştirmeler yap,

Pull request gönder,

⭐ beğenip desteğini göster!
