using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WEATHERSTATION
{
    public partial class PROJECT : Form
    {

        private SerialPort serialPort;

        public PROJECT()
        {
            InitializeComponent();

            // SerialPort ayarları
            serialPort = new SerialPort("COM3", 9600); // COM3'ü Arduino'nun bağlı olduğu porta göre değiştir
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port açılırken hata: " + ex.Message, "Seri Port Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine(); // Veriyi oku
            string[] values = data.Split('/'); // Veriyi '/' ile ayır (nem/sıcaklık/basınç)

            if (values.Length == 3)
            {
                // Verileri int'e çevir (DHT11 ve BMP085 için integer değerler)
                int humidity = int.Parse(values[0]);
                int temperature = int.Parse(values[1]);
                int pressure = int.Parse(values[2]);

                // Gauge'leri, chart'ı ve text kutularını güncelle (UI thread'inde güncelleme için Invoke kullan)
                this.Invoke((MethodInvoker)delegate
                {
                    aGauge1.Value = temperature; // Sıcaklık gauge
                    aGauge2.Value = humidity;    // Nem gauge
                    aGauge3.Value = pressure;    // Basınç gauge

                    // Chart1'i güncelle
                    chart1.Series["Temperature"].Points.AddY(temperature); // Sıcaklık serisi
                    chart1.Series["Humidity"].Points.AddY(humidity);       // Nem serisi
                    chart1.Series["Pressure"].Points.AddY(pressure);       // Basınç serisi

                    // Grafiği son 10 nokta ile sınırla
                    if (chart1.Series["Temperature"].Points.Count > 10)
                    {
                        chart1.Series["Temperature"].Points.RemoveAt(0);
                        chart1.Series["Humidity"].Points.RemoveAt(0);
                        chart1.Series["Pressure"].Points.RemoveAt(0);
                    }

                    // Text kutularını güncelle
                    label1.Text = $"Temperature: {temperature} °C"; // Sıcaklık
                    label2.Text = $"Humidity: {humidity} %";              // Nem
                    label3.Text = $"Pressure: {pressure} hPa";         // Basınç
                });
            }
        }

        private void PROJECT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
