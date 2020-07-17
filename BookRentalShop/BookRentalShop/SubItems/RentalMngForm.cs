using K4os.Compression.LZ4.Internal;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BookRentalShop.SubItems
{
    public partial class RentalMngForm : MetroForm
    {
        readonly string strTBLname = "membertbl";
        BaseMode myMode = BaseMode.NONE;//기본상태
        public RentalMngForm()
        {
            InitializeComponent();
        }

        private void DevMngForm_Load(object sender, EventArgs e)
        {
            //콤보박스 초기화
            UpdateComboMember();
            UpdateComboBook();
            //초기값 세팅
            //UpdateData();
            InitControls();
            GrdRentalTbl.ReadOnly = true;
        }

        private void UpdateComboMember()
        {
            //콤보박스 세팅, 선택 초기화
            using (MySqlConnection conn = new MySqlConnection(Commens.CONNSTR))
            {
                //쿼리
                string strQuery = "SELECT Idx, Names FROM membertbl";
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

                Member.DataSource = new BindingSource(temps, null);
                Member.DisplayMember = "Key";
                Member.ValueMember = "Value";
            }
        }

        private void UpdateComboBook()
        {
            //콤보박스 세팅, 선택 초기화
            using (MySqlConnection conn = new MySqlConnection(Commens.CONNSTR))
            {
                //쿼리
                string strQuery = "SELECT b.Idx, b.Names, " +
                                  "(SELECT Names FROM divtbl WHERE Division = b.Division) AS Division " +
                                  "FROM bookstbl AS b";
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

                Book.DataSource = new BindingSource(temps, null);
                Book.DisplayMember = "Key";
                Book.ValueMember = "Value";
            }
        }

        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commens.CONNSTR))
            {
                //쿼리
                string strQuery = $"SELECT * From {strTBLname}";
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

                GrdRentalTbl.DataSource = ds;
                GrdRentalTbl.DataMember = strTBLname;
            }
            SetColumHeaders();
        }

        private void SetColumHeaders()
        {
            DataGridViewColumn column;

            column = GrdRentalTbl.Columns[0];
            column.Width = 150;
            column.HeaderText = "번호";

            column = GrdRentalTbl.Columns[1];
            column.Width = 150;
            column.HeaderText = "이름";

            column = GrdRentalTbl.Columns[2];
            column.Width = 150;
            column.HeaderText = "등급";

            column = GrdRentalTbl.Columns[3];
            column.Width = 150;
            column.HeaderText = "주소";

            column = GrdRentalTbl.Columns[4];
            column.Width = 150;
            column.HeaderText = "전화번호";

            column = GrdRentalTbl.Columns[5];
            column.Width = 150;
            column.HeaderText = "이메일";
        }
        private void SaveData()
        {
            //빈값 비교
            //if (string.IsNullOrEmpty(Names.Text)
            //    || Book.SelectedIndex < 1
            //    || string.IsNullOrEmpty(Addr.Text)
            //    || string.IsNullOrEmpty(Mobile.Text)
            //    || string.IsNullOrEmpty(Email.Text))
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
                        cmd.CommandText = $"UPDATE {strTBLname} " +
                                          "SET " +
                                          "     Names = @Names, " +
                                          "     Levels = @Levels, " +
                                          "     Addr = @Addr, " +
                                          "     Mobile = @Mobile, " +
                                          "     Email = @Email " +
                                          "WHERE Idx = @Idx";
                    }
                    else if (myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = $"INSERT INTO {strTBLname} " +
                                          "(" +
                                          "     Names, " +
                                          "     Levels, " +
                                          "     Addr, " +
                                          "     Mobile, " +
                                          "     Email" +
                                          ") " +
                                          "VALUES " +
                                          "(" +
                                          "     @Names, " +
                                          "     @Levels, " +
                                          "     @Addr, " +
                                          "     @Mobile, " +
                                          "     @Email" +
                                          ")";
                    }

                    //쿼리문  파라미터 대입 실행
                    //파라미터 생성
                    MySqlParameter paraNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45);
                    MySqlParameter paraLevels = new MySqlParameter("@Levels", MySqlDbType.VarChar, 1);
                    MySqlParameter paraAddr = new MySqlParameter("@Addr", MySqlDbType.VarChar, 100);
                    MySqlParameter paraMobile = new MySqlParameter("@Mobile", MySqlDbType.VarChar, 13);
                    MySqlParameter paraEmail = new MySqlParameter("@Email", MySqlDbType.VarChar, 50);
                    //파라미너 값 set
                    //paraNames.Value = Names.Text;
                    //paraLevels.Value = Book.Text;
                    //paraAddr.Value = Addr.Text;
                    //paraMobile.Value = Mobile.Text;
                    //paraEmail.Value = Email.Text;
                    //쿼리문 파라미터 set
                    cmd.Parameters.Add(paraNames);
                    cmd.Parameters.Add(paraLevels);
                    cmd.Parameters.Add(paraAddr);
                    cmd.Parameters.Add(paraMobile);
                    cmd.Parameters.Add(paraEmail);
                    if (myMode == BaseMode.UPDATE)
                    {
                        MySqlParameter paraIdx = new MySqlParameter("@Idx", MySqlDbType.Int32);
                        paraIdx.Value = IDX.Text;
                        cmd.Parameters.Add(paraIdx);
                    }

                    //결과 값 몇개 실행 되었는가
                    var result = cmd.ExecuteNonQuery();

                    //결과 값에 따른 메시지 박스 출력
                    if (myMode == BaseMode.INSERT)
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
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdRentalTbl.Rows[e.RowIndex];
                //ID
                //IDX.Text = data.Cells[0].Value.ToString();
                ////Names
                //Names.Text = data.Cells[1].Value.ToString();
                ////Levels
                //Book.Text = data.Cells[2].Value.ToString();
                ////Addr
                //Addr.Text = data.Cells[3].Value.ToString();
                ////Mobile
                //Mobile.Text = data.Cells[4].Value.ToString();
                ////Email
                //Email.Text = data.Cells[5].Value.ToString();

                //IDX.ReadOnly = true;
                //myMode = BaseMode.UPDATE;//수정 모드 변경
                //Names.Focus();
            }
        }
        private void InitControls()
        {
            //설정값 초기화
            //IDX.Text = Names.Text = Email.Text = Mobile.Text = Addr.Text = string.Empty;
            //Book.SelectedIndex = 0;
            IDX.ReadOnly = true;
            IDX.Focus();

            myMode = BaseMode.NONE;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            InitControls();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            InitControls();
            myMode = BaseMode.INSERT;
            //Names.Focus();
        }
    }
}
