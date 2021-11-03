using HtmlAgilityPack;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace GUI
{


    public partial class Form1 : Form
    {

        int limit = 30;
        public void Web_scraping()
        {
            var html = @"http://192.168.43.254/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var item = htmlDoc.DocumentNode.SelectSingleNode("/html/body/pre/h1");
            this.label2.Text = "Wilgotność: " + item.InnerText + "%RH";
            var item2 = htmlDoc.DocumentNode.SelectSingleNode("/html/body/pre/h2");
            this.label1.Text = "Temperatura: " + item2.InnerText + "°C";
            // \/ Zamiana inner.text na int z wykorzystaniem wyrażeń regularnych.
            // \/ Nadanie wartości na progress bar
            Regex re2 = new Regex(@"[0-9]{2}");
            Match m1 = re2.Match(item2.InnerText);
            string lev1 = m1.Value;
            int temp = int.Parse(lev1);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 50;
            progressBar1.Value = temp;
            Regex re = new Regex(@"[0-9]{2}");
            Match m = re.Match(item.InnerText);
            string lel = m.Value;
            int hum = int.Parse(lel);
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            progressBar2.Value = hum;
            if (temp > limit)
            {
                this.label3.Text = "Zbyt wysoka temperatura";
            }
            else
            {
                this.label3.Text = "Gotowy do wyładowania";
            }
            if (temp > limit)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
        }
        public Form1()
        {
            InitializeComponent();
            Web_scraping();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Web_scraping();
        }
    }
}
