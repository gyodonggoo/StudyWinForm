using Google.Protobuf.WellKnownTypes;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;

namespace BookRentalShop.SubItems
{
    public partial class DevMngForm : MetroForm
    {
        readonly string strTBLname = "divtbl";
        BaseMode myMode = BaseMode.NONE;//기본상태
        public DevMngForm()
        {
            InitializeComponent();
        }

        private void DevMngForm_Load(object sender, EventArgs e)
        {
            UpdateData();
            GrbDevTbl.ReadOnly = true;
        }
        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commens.CONNSTR))
            {
                //쿼리
                string strQuery = $"SELECT Division, Names FROM {strTBLname}";
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

                GrbDevTbl.DataSource = ds;
                GrbDevTbl.DataMember = strTBLname;
            }
            SetColumHeaders();
        }
        private void SetColumHeaders()
        {
            DataGridViewColumn column;

            column = GrbDevTbl.Columns[0];
            column.Width = 100;
            column.HeaderText = "구분코드";

            column = GrbDevTbl.Columns[1];
            column.Width = 150;
            column.HeaderText = "이름";
        }
        private void SaveData()
        {
            if (string.IsNullOrEmpty(Divistion.Text) || string.IsNullOrEmpty(Names.Text))
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
                        cmd.CommandText = "UPDATE divtbl " +
                                      "   SET Names = @Names " +
                                      " WHERE Division = @Division";
                    }
                    else if (myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO divtbl (Division, Names) " +
                                          "VALUES (@Division, @Names)";
                    }
                    else if (myMode == BaseMode.DELETE)
                    {
                        cmd.CommandText = "DELETE FROM divtbl " +
                                      "WHERE Division = @Division";
                    }
                    //쿼리문  파라미터 대입 실행
                    if(myMode == BaseMode.UPDATE || myMode == BaseMode.INSERT)
                    {
                        //파라미터 생성
                        MySqlParameter paraNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45);
                        MySqlParameter paraDivision = new MySqlParameter("@Division", MySqlDbType.VarChar, 45);
                        //파라미너 값 set
                        paraNames.Value = Names.Text;
                        paraDivision.Value = Divistion.Text;
                        //쿼리문 파라미터 set
                        cmd.Parameters.Add(paraNames);
                        cmd.Parameters.Add(paraDivision);
                    }
                    else if(myMode == BaseMode.DELETE)
                    {
                        //파라미터 생성
                        MySqlParameter paraDivision = new MySqlParameter("@Division", MySqlDbType.VarChar);
                        //파라미너 값 set
                        paraDivision.Value = Divistion.Text;
                        //쿼리문 파라미터 set
                        cmd.Parameters.Add(paraDivision);
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
                    else if(myMode == BaseMode.DELETE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 삭제 되었습니다.", "삭제");
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
                DataGridViewRow data = GrbDevTbl.Rows[e.RowIndex];
                Divistion.Text = data.Cells[0].Value.ToString();
                Names.Text = data.Cells[1].Value.ToString();

                Divistion.ReadOnly = true;
                myMode = BaseMode.UPDATE;//수정 모드 변경
                Names.Focus();
            }
        }
        private void InitControls()
        {
            Divistion.Text = Names.Text = string.Empty;
            Divistion.Focus();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            Divistion.Text = Names.Text = string.Empty;
            Divistion.ReadOnly = false;
            myMode = BaseMode.INSERT;
            Divistion.Focus();
        }
        private void BtmDelete_Click(object sender, EventArgs e)
        {
            if(myMode != BaseMode.UPDATE)
            {
                MetroMessageBox.Show(this, "삭제할 데이터를 선택하세요", "알림");
                return;
            }
            else if(myMode == BaseMode.UPDATE)
            {
                myMode = BaseMode.DELETE;
                SaveData();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
