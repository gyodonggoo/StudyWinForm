using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace MyStockSystem.SubItems
{
    public partial class DownloadForm : MetroForm
    {
        public string ParentUrl { get; set; }
        public string fileName;
        public string filePath;

        WebClient client;

        public DownloadForm()
        {
            InitializeComponent();
        }
        private void DownloadForm_Load(object sender, System.EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void DownloadForm_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(StartDounload));
            thread.Start();
        }

        

        private void StartDounload()
        {
            Uri uri = new Uri(ParentUrl);
             fileName = ParentUrl.Substring(ParentUrl.IndexOf('=')+1);
            client.DownloadFileAsync(uri, Environment.CurrentDirectory + $@"\{fileName}");

        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            pictureBox1.Load(Environment.CurrentDirectory + $@"\{fileName}");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Value = e.ProgressPercentage;

                if(e.BytesReceived == e.TotalBytesToReceive)//현재량이 전체량과 같을경우
                {
                    Client_DownloadFileCompleted(sender, null);
                }
            }));
        }

       
    }
}
