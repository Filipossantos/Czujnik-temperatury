using HtmlAgilityPack;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace GUI
{
    public partial class Form1 : Form
    {
        int limit = 30;
        string adres = "http://192.168.43.254/";
        int temp, hum;
        string folderName = @"pomiar.txt";
        string folderName2 = @"pomiar.csv";
        int ID = 0;
        public void Web_scraping()
        {
            try
            {
                var html = @adres;
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(html);
                string sciezka = "/html/body/pre/";
                var item = htmlDoc.DocumentNode.SelectSingleNode(sciezka + "h1");
                var item2 = htmlDoc.DocumentNode.SelectSingleNode(sciezka + "h2");
                this.label2.Text = "Wilgotność: " + item.InnerText + "%RH";
                this.label1.Text = "Temperatura: " + item2.InnerText + "°C";
                string regex = "[0-9]{2}";
                Regex re2 = new Regex(regex);
                Regex re = new Regex(regex);
                Match m1 = re2.Match(item2.InnerText);
                Match m = re.Match(item.InnerText);
                string lev1 = m1.Value;
                string lev2 = m.Value;
                temp = int.Parse(lev1);
                hum = int.Parse(lev2);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd odczytu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.label3.Text = "Dobra temperatura";
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
            MySQL_ToDatagridview();
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
                    sw.WriteLine(Dzisiejsza_data + ";" + Godzina + ";" + temp + ";" + hum);
                }
            }
            else
            {

                using (StreamWriter fo = File.AppendText(folderName))
                {
                    fo.WriteLine(Dzisiejsza_data + ";" + Godzina + ";" + temp + ";" + hum);
                }
            }
       
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = pomiary; Integrated Security = True";
            SqlCommand nowa = new SqlCommand("INSERT INTO [Table](ID) SELECT (MAX(ID)+1) from [Table]", con);
            con.Open();
            nowa.ExecuteNonQuery();
            con.Close();
            SqlCommand cmd = new SqlCommand("update [Table] set Data=@data,Godzina=@godzina,Temperatura=@temperatura,Wilgotnosc=@wilgotnosc where ID=(SELECT max(id) FROM [TABLE])", con);
                con.Open();
                cmd.Parameters.AddWithValue("@data", Dzisiejsza_data);
                cmd.Parameters.AddWithValue("@godzina", Godzina);
                cmd.Parameters.AddWithValue("@temperatura", temp);
                cmd.Parameters.AddWithValue("@wilgotnosc", hum);
                cmd.ExecuteNonQuery();
                con.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wyeksportowano.Visible = true;
            string path2 = System.IO.Path.Combine(folderName);
            string path1 = System.IO.Path.Combine(folderName2);
            System.IO.FileInfo fi = new System.IO.FileInfo(path2);
            System.IO.FileInfo fi1 = new System.IO.FileInfo(path1);
            if (fi1.Exists)
            {
                MessageBox.Show("Plik już istnieje!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (fi.Exists)
                {
                    File.Copy(folderName, folderName2);
                }
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
            MySQL_ToDatagridview();
        }
        private void MySQL_ToDatagridview()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = pomiary; Integrated Security = True";
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "SELECT Data,Godzina,Temperatura,Wilgotnosc FROM [Table]";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridVie.DataSource = data;
            
        }

    }
}
