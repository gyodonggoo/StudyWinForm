using MetroFramework.Forms;
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
    public partial class SearItemFrom : MetroForm//Form
    {
        public SearItemFrom()
        {
            InitializeComponent();
        }

        private void SearItemFrom_Load(object sender, EventArgs e)
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
            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1");//Open API 기본 url
            str.Append("?serviceKey=UB9SZcaYa9xzJQK8qL5DsjCMYYk%2B2qa20%2FuN1g1dVYmTHqk5fe862uloHnBeo%2BV85dezYbZqKhjLgIKKaS3QDw%3D%3D");//일반 인증키
            str.Append($"&secnNm={TxtSearchItem.Text}");//종목명 검색어
            str.Append("&pageNo=1");//페이지 수
            str.Append("&numOfRows=200");//읽어올 데이터수
            str.Append("&martTpcd=11");//주식시장 종류 : 11 은 유가증건 시장

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            DgvSearchItem.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    DgvSearchItem.Rows.Add(
                        item["isin"].InnerText,
                        item["issuDt"] == null ? string.Empty : item["issuDt"].InnerText,
                        item["korSecnNm"].InnerText,
                        item["secnKacdNm"].InnerText,
                        item["shotnIsin"].InnerText);
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
    }
}
