using System;
using MetroFramework.Forms;
using MetroFramework.Components;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace AnonFile_Uploader
{    

    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string url = Helper.ApiKey();
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }

            using (var webClient = new WebClient())
            {
                var response = webClient.UploadFile(url, filePath);
                string stg = System.Text.Encoding.UTF8.GetString(response);
                richTextBox1.Text = stg;
            }                

        }
    }
}
