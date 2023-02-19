using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Storage.Blobs;

namespace LearningPlatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void GetBlobServiceClientSAS(ref BlobServiceClient blobServiceClient,
            string accountName, string sasToken)
        {
            string blobUri = "https://kasana.blob.core.windows.net/learningplatform?sp=racwdl&st=2023-02-18T23:01:34Z&se=2023-04-29T07:01:34Z&spr=https&sv=2021-06-08&sr=c&sig=TjF0tIhjvADn9abJ1VHKEFEZGjUjcID3F4Ej9keiops%3D";

            blobServiceClient = new BlobServiceClient
                (new Uri($"{blobUri}?{"sp = racwdl & st = 2023 - 02 - 18T23:01:34Z&se=2023-04-29T07:01:34Z&spr=https&sv=2021-06-08&sr=c&sig=TjF0tIhjvADn9abJ1VHKEFEZGjUjcID3F4Ej9keiops%3D}"), null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ""
        }
    }
}
