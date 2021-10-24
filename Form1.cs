using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
namespace GUI
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_load(object sendner, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)
        {
            var html = @"http://192.168.43.254/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var item = htmlDoc.DocumentNode.SelectSingleNode("/html/body/pre/h1");
            this.label2.Text ="Wilgotność: "+item.InnerHtml+"%RH";
            var item2 = htmlDoc.DocumentNode.SelectSingleNode("/html/body/pre/h2");
            this.label1.Text = "Temperatura: "+item2.InnerHtml+"°C";
        }
       
    }
}
