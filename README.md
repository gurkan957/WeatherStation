
# 🌡️ Arduino Nano ile BMP180 & DHT11 Sensörlerinden Sıcaklık, Nem ve Basınç Ölçümü

## Proje Açıklaması

Bu projede, Arduino Nano kullanılarak BMP180 (basınç ve sıcaklık sensörü) ve DHT11 (nem ve sıcaklık sensörü) ile ölçülen veriler, Visual Studio'da geliştirilen C# Windows Forms uygulaması ile bilgisayar ortamında görselleştirilmektedir. Ölçülen veriler, hem gauge göstergelerle hem de grafikler ile gerçek zamanlı olarak gösterilir.

## Kullanılan Malzemeler

| Bileşen           | Açıklama                        |
|-------------------|---------------------------------|
| Arduino Nano      | Mikrodenetleyici kartı          |
| BMP180 Sensörü    | Basınç ve sıcaklık ölçümü       |
| DHT11 Sensörü     | Nem ve sıcaklık ölçümü          |
| 10kΩ Direnç       | DHT11 için pull-up direnci      |
| Breadboard        | Devre kurulumu için             |
| Jumper Kabloları  | Bağlantı kabloları              |

## Visual Studio Uygulaması

Bu projede Visual Studio ile C# Windows Forms arayüzü oluşturulmuştur. Seri port üzerinden gelen veriler, uygulamada gauge göstergeler ve grafiklerle görselleştirilmektedir.

### Kullanılan Kütüphaneler
```csharp
using System;
using System.IO.Ports;
using System.Windows.Forms;
```

## Arduino Nano Bağlantıları

### DHT11 Bağlantıları
| Arduino Nano Pin | DHT11 Pin  |
|------------------|------------|
| D2               | Data       |
| 5V               | VCC        |
| GND              | GND        |

> Not: DHT11 sensörünün Data pinine **10kΩ pull-up direnci** bağlanmalıdır.

### BMP180 Bağlantıları
| Arduino Nano Pin | BMP180 Pin |
|------------------|------------|
| 3.3V             | VIN        |
| GND              | GND        |
| A4               | SDA        |
| A5               | SCL        |

> Not: BMP180 sensörü 3.3V ile çalışmalıdır. 5V'a bağlanması önerilmez.

## Projenin Çalışma Mantığı

1. Arduino Nano, BMP180 ve DHT11 sensörlerinden sıcaklık, nem ve basınç verilerini toplar.
2. Toplanan veriler seri port üzerinden bilgisayara aktarılır.
3. Visual Studio'da geliştirilen C# arayüz bu verileri okur.
4. Veriler gauge göstergeler ile görsel olarak gösterilirken aynı zamanda grafik üzerinde de anlık olarak çizdirilir.

## Projenin Kullanım Alanları

- Basit hava durumu istasyonları
- İç ortam hava kalitesi ölçümü
- Sensör verilerinin görselleştirilmesi ve takibi

## Nasıl Kullanılır?

### Arduino Tarafı
1. Arduino IDE ile projedeki .ino dosyasını yükleyin.
2. Arduino Nano'yu bilgisayara bağlayın.

### Visual Studio Tarafı
1. Projeyi Visual Studio ile açın.
2. Seri port ayarlarını doğru şekilde yapılandırın.
3. Uygulamayı başlatın ve gelen verileri görüntüleyin.
