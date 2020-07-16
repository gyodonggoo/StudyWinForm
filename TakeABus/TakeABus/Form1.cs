using MetroFramework.Forms;
using System;
using System.Net;
using System.Text;
using System.Xml;
using System.Threading;

namespace TakeABus
{
    public partial class MainFrom : MetroForm
    {
        string text;
        
        public string GoFirstStop = "177820102";
        public string GoSecondStop = "177240201";
        public string BackFirstStop = "180480301";
        public string BackSecondStop = "177240301";

        public XmlNodeList items1, items2, items3, items4;

        public MainFrom()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(new ThreadStart(GetGoFirst));
            Thread thread2 = new Thread(new ThreadStart(GetGoSecond));
            Thread thread3 = new Thread(new ThreadStart(GetBackFirst));
            Thread thread4 = new Thread(new ThreadStart(GetBackSecond));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
        }
        public void GetGoFirst()
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://61.43.246.153/openapi-data/service/busanBIMS2/stopArr");
            str.Append("?ServiceKey=UB9SZcaYa9xzJQK8qL5DsjCMYYk%2B2qa20%2FuN1g1dVYmTHqk5fe862uloHnBeo%2BV85dezYbZqKhjLgIKKaS3QDw%3D%3D");
            str.Append($"&bstopid={GoFirstStop}");

            string xml = wc.DownloadString(str.ToString());

            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            items1 = doc.GetElementsByTagName("item");

            Thread thread = new Thread(new ThreadStart(SetFirstGo));
            thread.Start();
        }
        public void GetGoSecond()
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://61.43.246.153/openapi-data/service/busanBIMS2/stopArr");
            str.Append("?ServiceKey=UB9SZcaYa9xzJQK8qL5DsjCMYYk%2B2qa20%2FuN1g1dVYmTHqk5fe862uloHnBeo%2BV85dezYbZqKhjLgIKKaS3QDw%3D%3D");
            str.Append($"&bstopid={GoSecondStop}");

            string xml = wc.DownloadString(str.ToString());

            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            items2 = doc.GetElementsByTagName("item");

            Thread thread = new Thread(new ThreadStart(SetSecondGo));
            thread.Start();
        }
        public void GetBackFirst()
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://61.43.246.153/openapi-data/service/busanBIMS2/stopArr");
            str.Append("?ServiceKey=UB9SZcaYa9xzJQK8qL5DsjCMYYk%2B2qa20%2FuN1g1dVYmTHqk5fe862uloHnBeo%2BV85dezYbZqKhjLgIKKaS3QDw%3D%3D");
            str.Append($"&bstopid={BackFirstStop}");

            string xml = wc.DownloadString(str.ToString());

            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            items3 = doc.GetElementsByTagName("item");

            Thread thread = new Thread(new ThreadStart(SetFirstBack));
            thread.Start();
        }
        public void GetBackSecond()
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://61.43.246.153/openapi-data/service/busanBIMS2/stopArr");
            str.Append("?ServiceKey=UB9SZcaYa9xzJQK8qL5DsjCMYYk%2B2qa20%2FuN1g1dVYmTHqk5fe862uloHnBeo%2BV85dezYbZqKhjLgIKKaS3QDw%3D%3D");
            str.Append($"&bstopid={BackSecondStop}");

            string xml = wc.DownloadString(str.ToString());

            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            items4 = doc.GetElementsByTagName("item");

            Thread thread = new Thread(new ThreadStart(SetSecondBack));
            thread.Start();
        }
        public void SetFirstGo()
        {
            foreach (XmlNode item in items1)
            {
                String sample = item["lineNo"].InnerText;

                if (sample.Equals("103"))
                {
                    text += ($"{item["lineNo"].InnerText}번 버스\r\n");
                    text += ($"다음 버스     : {item["station1"].InnerText}정거장 전, {item["min1"].InnerText}분 남음\r\n");
                    text += ($"다다음 버스 : {item["station2"].InnerText}정거장 전, {item["min2"].InnerText}분 남음");
                    GoFirstBus1.Text = text;
                }
                else if (sample.Equals("96"))
                {
                    text += ($"{item["lineNo"].InnerText}번 버스\r\n");
                    text += ($"다음 버스     : {item["station1"].InnerText}정거장 전, {item["min1"].InnerText}분 남음\r\n");
                    text += ($"다다음 버스 : {item["station2"].InnerText}정거장 전, {item["min2"].InnerText}분 남음");
                    GoFirstBus2.Text = text;
                }
                text = string.Empty;
            }
        }
        public void SetSecondGo()
        {
            foreach (XmlNode item in items2)
            {
                String sample = item["lineNo"].InnerText;

                if (sample.Equals("1011"))
                {
                    text += ($"{item["lineNo"].InnerText}번 버스\r\n");
                    text += ($"다음 버스     : {item["station1"].InnerText}정거장 전, {item["min1"].InnerText}분 남음\r\n");
                    text += ($"다다음 버스 : {item["station2"].InnerText}정거장 전, {item["min2"].InnerText}분 남음");
                    GoSecondBus1.Text = text;
                }
                text = string.Empty;
            }
        }
        public void SetFirstBack()
        {
            foreach (XmlNode item in items3)
            {
                String sample = item["lineNo"].InnerText;

                if (sample.Equals("1011"))
                {
                    text += ($"{item["lineNo"].InnerText}번 버스\r\n");
                    text += ($"다음 버스     : {item["station1"].InnerText}정거장 전, {item["min1"].InnerText}분 남음\r\n");
                    text += ($"다다음 버스 : {item["station2"].InnerText}정거장 전, {item["min2"].InnerText}분 남음");
                    BackFirstBus1.Text = text;
                }
                text = string.Empty;
            }
        }
        public void SetSecondBack()
        {
            foreach (XmlNode item in items4)
            {
                String sample = item["lineNo"].InnerText;

                if (sample.Equals("103"))
                {
                    text += ($"{item["lineNo"].InnerText}번 버스\r\n");
                    text += ($"다음 버스     : {item["station1"].InnerText}정거장 전, {item["min1"].InnerText}분 남음\r\n");
                    text += ($"다다음 버스 : {item["station2"].InnerText}정거장 전, {item["min2"].InnerText}분 남음");
                    BackSecondBus1.Text = text;
                }
                else if (sample.Equals("96"))
                {
                    text += ($"{item["lineNo"].InnerText}번 버스\r\n");
                    text += ($"다음 버스     : {item["station1"].InnerText}정거장 전, {item["min1"].InnerText}분 남음\r\n");
                    text += ($"다다음 버스 : {item["station2"].InnerText}정거장 전, {item["min2"].InnerText}분 남음");
                    BackSecondBus2.Text = text;
                }
                text = string.Empty;
            }
        }
    }
}
