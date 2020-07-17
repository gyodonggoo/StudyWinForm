using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
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
using System.Xml;

namespace MyStockSystem.SubItems
{
    public partial class GalmetgilForm : MetroForm//Form
    {
        public GalmetgilForm()
        {
            InitializeComponent();
        }

        private void GalmetgilForm_Load(object sender, EventArgs e)
        {
            DgvSearchItem.Font = new Font(@"NanumGothic", 10, FontStyle.Regular);
        }

        private void MtlSearchWeb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm main = new MainForm();
            main.Location = this.Location;
            main.ShowDialog();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://apis.data.go.kr/6260000/BusanGalmaetGilService/getGalmaetGilInfo");
            str.Append("?serviceKey=UB9SZcaYa9xzJQK8qL5DsjCMYYk%2B2qa20%2FuN1g1dVYmTHqk5fe862uloHnBeo%2BV85dezYbZqKhjLgIKKaS3QDw%3D%3D");
            str.Append("&pageNo=1");
            str.Append("&numOfRows=200");
            str.Append("&resultType=json");

            string json = wc.DownloadString(str.ToString());
            JObject obj = JObject.Parse(json);
            JArray items = JArray.Parse(obj.SelectToken("getGalmaetGilInfo.item").ToString());
            DgvSearchItem.Rows.Clear();

            try
            {
                foreach (var item in items)
                {
                    //kosNm, kosType, kosTxt, img, txt1, title, txt2
                    DgvSearchItem.Rows.Add(
                        $"{item.SelectToken("kosNm")}",
                        $"{item.SelectToken("kosType")}",
                        $"{item.SelectToken("kosTxt")}",
                        $"{item.SelectToken("img")}",
                        $"{item.SelectToken("txt1")}",
                        $"{item.SelectToken("title")}",
                        $"{item.SelectToken("txt2")}"
                        );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DgvSearchItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                metroButton1_Click(sender, new EventArgs());
            }
        }

        private void DgvSearchItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selvalue = DgvSearchItem.Rows[e.RowIndex].Cells[3].Value.ToString();
            //MessageBox.Show(selvalue);

            DownloadForm form = new DownloadForm();
            form.ParentUrl = selvalue;
            form.ShowDialog();

        }
    }
}
