using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GR10
{//@karakusnavy
    public partial class Form1 : Form
    {
        public Form1()//@karakusnavy
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            TransparencyKey = BackColor;
            Opacity = 1;
            var f = new HelperForm { Opacity = 0.7, ShowInTaskbar = false, FormBorderStyle = FormBorderStyle.None };
            f.Show();
            Visible = false;
            Owner = f;
            Visible = true;
            Move += (o, a) => f.Bounds = Bounds;
            Resize += (o, a) => f.Bounds = Bounds;
            f.Bounds = Bounds;           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try{
                string url = textBox1.Text;
                if (url.Substring(0, 5) != "https")
                MessageBox.Show("Wrong Url ! (https://)");
                else
                download(url);
            }
            catch (Exception)
            { 
            MessageBox.Show("Wrong Url ! (https://)");
            }
//@karakusnavy
        }
        void download(string url)
        {//@karakusnavy
            WebClient client = new WebClient();
            client.DownloadFile(url, @"index.html");
            MessageBox.Show("Download Succesfull!");
            System.Diagnostics.Process.Start(Application.StartupPath);            
        }
    }
}
