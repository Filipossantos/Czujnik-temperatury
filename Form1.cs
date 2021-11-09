using HtmlAgilityPack;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
namespace GUI
{

    public partial class Form1 : Form
    {

        int limit = 30;
        string adres = "http://192.168.43.254/";
        int temp, hum;
        string folderName = @"c:\Users\domis_000\Desktop\pomiar.txt";
        string folderName2 = @"c:\Users\domis_000\Desktop\pomiar.csv";
        public void Web_scraping()
        {
            try
            {
                var html = @adres;
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(html);
                var item = htmlDoc.DocumentNode.SelectSingleNode("/html/body/pre/h1");
                var item2 = htmlDoc.DocumentNode.SelectSingleNode("/html/body/pre/h2");
                this.label2.Text = "Wilgotność: " + item.InnerText + "%RH";
                this.label1.Text = "Temperatura: " + item2.InnerText + "°C";
                Regex re2 = new Regex(@"[0-9]{2}");
                Regex re = new Regex(@"[0-9]{2}");
                Match m1 = re2.Match(item2.InnerText);
                Match m = re.Match(item.InnerText);
                string lev1 = m1.Value;
                string lev2 = m.Value;
                temp = int.Parse(lev1);
                hum = int.Parse(lev2);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd odczytu!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
             
        }
        public void tlo_kolor()
        {
            if (temp > limit)
            {
                this.label3.Text = "Zbyt wysoka temperatura";
            }
            else
            {
                this.label3.Text = "Piec gotowy do wyładowania";
            }
            if (temp > limit)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
        }
        public void pasek()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 50;
            progressBar1.Value = temp;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            progressBar2.Value = hum;
        }
        public Form1()
        {
            InitializeComponent();
            Web_scraping();
            pasek();
            tlo_kolor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zapisano.Visible = true;
            string path = System.IO.Path.Combine(folderName);
            var Dzisiaj = DateTime.Now;
            string Dzisiejsza_data = Dzisiaj.Year + "-" + Dzisiaj.Month + "-" + Dzisiaj.Day;
            string Godzina = Dzisiaj.Hour + ":" + Dzisiaj.Minute;
            if (!System.IO.File.Exists(path))
            {
                
                new System.IO.FileStream("pomiar.txt", FileMode.Append);
                using (StreamWriter sw = File.CreateText(folderName))
                {
                    sw.WriteLine("Data;Godzina;Temperatura;Wilgotnosc");
                    sw.WriteLine(Dzisiejsza_data+";"+Godzina+ ";"+temp + ";" + hum);
                }
            }
            else
            {

                using (StreamWriter fo = File.AppendText(folderName))
                {
                    fo.WriteLine(Dzisiejsza_data + ";" + Godzina + ";" + temp + ";" + hum);
                }    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wyeksportowano.Visible = true;
            string path2 = System.IO.Path.Combine(folderName);
            System.IO.FileInfo fi = new System.IO.FileInfo(path2);
            if (fi.Exists)
            {
                File.Copy(folderName, folderName2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja za pomocą czujnika (Dht11) mierzy temperaturę oraz poziom" +
                " wilgotności, następnie wysyła dane na serwer przy użyciu modułu ESP8266." +
                " Wykorzystywane IDE: Visual Studio, Arduino.  Języki programowania: c# / c++.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Web_scraping();
            pasek();
        }
    }
}
