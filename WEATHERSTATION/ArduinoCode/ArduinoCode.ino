  #include <Wire.h>
  #include <Adafruit_BMP085.h>
  #include "DHT.h"
  #define DHTPIN 2 //DHT pin tanımlaması
  #define DHTTYPE DHT11 //DHT modeli tanımlaması
  Adafruit_BMP085 bmp;
  DHT dht(DHTPIN, DHTTYPE);
  void setup() {
    Serial.begin(9600);
    dht.begin();
    bmp.begin();
  }
  void loop() {
    int h = dht.readHumidity(); //Nem değerini oku
    int t = dht.readTemperature(); //Sıcaklık değerini oku
    long int p = bmp.readPressure() / 100; //Basınç değerini oku (Pa -> hPa birim dönüşümü için 100'e bölüyoruz)
    Serial.print(h); //Nem değerini seri porta gönder
    Serial.print("/");
    Serial.print(t); //Sıcaklık değerini seri porta gönder
    Serial.print("/");
    Serial.println(p); //Basınç değerini seri porta gönder
    delay(500); //500 milisaniye bekleme süresi
  }