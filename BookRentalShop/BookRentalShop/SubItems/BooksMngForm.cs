using Google.Protobuf.WellKnownTypes;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;

namespace BookRentalShop.SubItems
{
    public partial class BooksMngForm : MetroForm
    {
        readonly string strTBLname = "bookstbl";
        BaseMode myMode = BaseMode.NONE;//기본상태
        public BooksMngForm()
        {
            InitializeComponent();
        }

        private void DevMngForm_Load(object sender, EventArgs e)
        {
            UpdateCombDivision();
            UpdateData();
            InitControls();
            GrdBooksTbl.ReadOnly = true;
        }

        private void UpdateCombDivision()
        {
            using (MySqlConnection conn = new MySqlConnection(Commens.CONNSTR))
            {
                //쿼리
                string strQuery = "SELECT Division, Names From divtbl";
                conn.Open();
                //커맨드 생성
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temps = new Dictionary<string, string>();
                temps.Add("선택", "");
                while (reader.Read())
                {
                    temps.Add(reader[1].ToString(), reader[0].ToString());
                }

                Divistion.DataSource = new BindingSource(temps, null);
                Divistion.DisplayMember = "Key";
                Divistion.ValueMember = "Value";
                //Divistion.SelectedIndex = -1;
            }
        }

        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commens.CONNSTR))
            {
                //쿼리
                string strQuery = $"SELECT b.Idx, " +
                                   "         b.Author, " +
                                   "         b.Division," +
                                   "         d.Names As DivisionName, " +
                                   "         b.Names, " +
                                   "         b.ReleaseDate, " +
                                   "         b.ISBN, " +
                                   "         b.Price " +
                                   "     FROM bookstbl AS b " +
                                   "     INNER JOIN divtbl AS d " +
                                   "     ON b.Division = d.Division " +
                                   "     ORDER BY b.Idx ASC";
                conn.Open();
                //커맨드 생성
                MySqlCommand cmd = new MySqlCommand();
                //커멘드에 db 연결
                cmd.Connection = conn;
                //쿼리 연동
                cmd.CommandText = strQuery;

                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, strTBLname);

                GrdBooksTbl.DataSource = ds;
                GrdBooksTbl.DataMember = strTBLname;
            }
            SetColumHeaders();
        }
        private void SetColumHeaders()
        {
            DataGridViewColumn column;

            column = GrdBooksTbl.Columns[0];
            column.Width = 53;
            column.HeaderText = "번호";

            column = GrdBooksTbl.Columns[1];
            column.Width = 170;
            column.HeaderText = "저자명";

            column = GrdBooksTbl.Columns[2];
            column.Visible = false;

            column = GrdBooksTbl.Columns[3];
            column.Width = 90;
            column.HeaderText = "장르";

            column = GrdBooksTbl.Columns[4];
            column.Width = 200;
            column.HeaderText = "이름";

            column = GrdBooksTbl.Columns[5];
            column.Width = 120;
            column.HeaderText = "출간일";

            column = GrdBooksTbl.Columns[6];
            column.Width = 120;
            column.HeaderText = "ISBN";

            column = GrdBooksTbl.Columns[7];
            column.Width = 90;
            column.HeaderText = "가격";
        }
        private void SaveData()
        {   
            //빈값 비교
            if (string.IsNullOrEmpty(Author.Text)
                || Divistion.SelectedIndex<1
                || string.IsNullOrEmpty(Names.Text) 
                || string.IsNullOrEmpty(Isbn.Text))
            {
                MetroMessageBox.Show(this, "빈값은 넣을 수 없습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (myMode == BaseMode.NONE)
            {
                MetroMessageBox.Show(this, "신규 등록시 신규버튼을 눌러주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commens.CONNSTR))
                {
                    //conn.Open 후 마지막에 항상 conn.Cloase 써야함
                    //using 문 쓰면 using 문끝날때 자동으로 실행함
                    conn.Open();
                    //sql 커맨드  생성
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    //쿼리문
                    if (myMode == BaseMode.UPDATE)
                    {
                        cmd.CommandText = "UPDATE bookstbl "+
                                             "SET " +
                                                 "Author = @Author, " +
                                                  "Division = @Division, " +
                                                  "Names = @Names, " +
                                                  "ReleaseDate = @ReleaseDate, " +
                                                  "ISBN = @ISBN, " +
                                                  "Price = @Price " +
                                          "WHERE Idx = @Idx";
                    }
                    else if (myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO bookstbl " +
                                                "(" +
                                                "   Author, "+
                                                "   Division, " +
                                                "   Names, " +
                                                "   ReleaseDate, " +
                                                "   ISBN, " +
                                                "   Price" +
                                                ") " +
                                           "VALUES " +
                                                "(" +
                                                "   @Author, " +
                                                "   @Division, " +
                                                "   @Names, " +
                                                "   @ReleaseDate, " +
                                                "   @ISBN, " +
                                                "   @Price" +
                                                ")";
                    }

                    //쿼리문  파라미터 대입 실행
                    //파라미터 생성
                    MySqlParameter paraAuthor = new MySqlParameter("@Author", MySqlDbType.VarChar, 45);
                    MySqlParameter paraDivision = new MySqlParameter("@Division", MySqlDbType.VarChar, 4);
                    MySqlParameter paraNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 100);
                    MySqlParameter paraReleaseDate = new MySqlParameter("@ReleaseDate", MySqlDbType.Date);
                    MySqlParameter paraISBN = new MySqlParameter("@ISBN", MySqlDbType.VarChar, 13);
                    MySqlParameter paraPrice = new MySqlParameter("@Price", MySqlDbType.Decimal);
                    //파라미너 값 set
                    paraAuthor.Value = Author.Text;
                    paraDivision.Value = Divistion.SelectedValue;
                    paraNames.Value = Names.Text;
                    paraReleaseDate.Value = DateRelease.Value;
                    paraISBN.Value = Isbn.Text;
                    paraPrice.Value = Price.Text;
                    //쿼리문 파라미터 set
                    cmd.Parameters.Add(paraAuthor);
                    cmd.Parameters.Add(paraDivision);
                    cmd.Parameters.Add(paraNames);
                    cmd.Parameters.Add(paraReleaseDate);
                    cmd.Parameters.Add(paraISBN);
                    cmd.Parameters.Add(paraPrice);
                    if(myMode == BaseMode.UPDATE)
                    {
                        MySqlParameter paraIdx = new MySqlParameter("@Idx", MySqlDbType.Int32);
                        paraIdx.Value = IDX.Text;
                        cmd.Parameters.Add(paraIdx);
                    }

                    //결과 값 몇개 실행 되었는가
                    var result = cmd.ExecuteNonQuery();

                    //결과 값에 따른 메시지 박스 출력
                    if(myMode == BaseMode.INSERT)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 신규 입력 되었습니다.", "신규입력");
                    }
                    else if (myMode == BaseMode.UPDATE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 수정 되었습니다.", "수정");
                    }

                    //결과 출력후 텍스트 박스 초기화
                    InitControls();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"에러 발생 {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateData();
            }
        }
        private void GrbDevTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //셀선택시 셀 내용 클릭시만 반응
            if(e.RowIndex > -1)
            {
                //클릭시 입력 컨트롤에 데이터 할당
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex];
                IDX.Text = data.Cells[0].Value.ToString();
                Author.Text = data.Cells[1].Value.ToString();

                //장르 콤보박스 cells[2]
                //글자로 인덱스  찾기
                //Divistion.SelectedIndex = Divistion.FindString(data.Cells[3].Value.ToString());
                //코드 값을 그대로 할당
                Divistion.SelectedValue = data.Cells[2].Value.ToString();

                //이름
                Names.Text = data.Cells[4].Value.ToString();
                
                //출간일 날짜 피커 cells[5]
                DateRelease.CustomFormat = "yyyy-MM-dd";
                DateRelease.Format = DateTimePickerFormat.Custom;
                DateRelease.Value = (DateTime)data.Cells[5].Value;

                //Isbn
                Isbn.Text = data.Cells[6].Value.ToString();

                //price
                Price.Text = data.Cells[7].Value.ToString();

                

                //출간일 날자 피커



                IDX.ReadOnly = true;
                myMode = BaseMode.UPDATE;//수정 모드 변경
                Author.Focus();
            }
        }
        private void InitControls()
        {
            IDX.Text = Author.Text = string.Empty;
            Isbn.Text = Names.Text = Price.Text = string.Empty;
            Divistion.SelectedIndex = 0;
            IDX.ReadOnly = true;
            IDX.Focus();

            DateRelease.CustomFormat = "yyyy-MM-dd";
            DateRelease.Format = DateTimePickerFormat.Custom;
            DateRelease.Value = DateTime.Now;

            myMode = BaseMode.INSERT;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            InitControls();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            InitControls();

            IDX.Focus();
        }
    }
}
