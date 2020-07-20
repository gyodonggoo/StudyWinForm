using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
            UpdateData();
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
                string strQuery = "SELECT r.idx AS '대여번호', "+
                                  "       m.Names AS '대여회원', "+
                                  "       b.Names AS '대여책제목', " +
                                  "       b.ISBN, " +
                                  "       r.rentalDate AS '대여일', " +
                                  "       r.returnDate AS '반납일', " +
                                  "       r.memberIdx, " +
                                  "       r.bookIdx " +
                                  "FROM rentaltbl AS r " +
                                  "INNER JOIN membertbl AS m " +
                                  "     ON r.memberIdx = m.Idx " +
                                  "INNER JOIN bookstbl AS b " +
                                  "     ON r.bookIdx = b.Idx";
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
            column.Width = 50;
            column.HeaderText = "번호";

            column = GrdRentalTbl.Columns[1];
            column.Width = 110;
            column.HeaderText = "회원";

            column = GrdRentalTbl.Columns[2];
            column.Width = 150;
            column.HeaderText = "책";

            column = GrdRentalTbl.Columns[3];
            column.Width = 100;
            column.HeaderText = "ISBN";

            column = GrdRentalTbl.Columns[4];
            column.Width = 120;
            column.HeaderText = "전화번호";

            column = GrdRentalTbl.Columns[5];
            column.Width = 100;

            column = GrdRentalTbl.Columns[6];//memberidx
            column.Visible = false;
            column = GrdRentalTbl.Columns[7];//bookidx
            column.Visible = false;
        }
        private void SaveData()
        {
            //빈값 비교
            //if (string.IsNullOrEmpty(IDX.Text)
            //    || Book.SelectedIndex < 1
            //    || string.IsNullOrEmpty(Addr.Text)
            //    || string.IsNullOrEmpty(Mobile.Text)
            //    || string.IsNullOrEmpty(Email.Text))
            //{
            //    MetroMessageBox.Show(this, "빈값은 넣을 수 없습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

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
                        cmd.CommandText = "UPDATE rentaltbl "+
                                          "SET "+
                                          "     memberIdx = @memberIdx, " +
                                          "     bookIdx = @bookIdx, " +
                                          "     rentalDate = @rentalDate, " +
                                          "     returnDate = @returnDate " +
                                          "WHERE " +
                                          "      Idx = @Idx";
                    }
                    else if (myMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO rentaltbl "+
                                          "(" +
                                          "     memberIdx, " +
                                          "     bookIdx, " +
                                          "     rentalDate, " +
                                          "     returnDate " +
                                          ") " +
                                          "VALUES " +
                                          "(" +
                                          "     @memberIdx, " +
                                          "     @bookIdx, " +
                                          "     @rentalDate, " +
                                          "     @returnDate) ";
                    }

                    //쿼리문  파라미터 대입 실행
                    //파라미터 생성
                    MySqlParameter paramemberIdx = new MySqlParameter("@memberIdx", MySqlDbType.Int32);
                    MySqlParameter parabookIdx = new MySqlParameter("@bookIdx", MySqlDbType.Int32);
                    MySqlParameter pararentalDate = new MySqlParameter("@rentalDate", MySqlDbType.Date);
                    MySqlParameter parareturnDate = new MySqlParameter("@returnDate", MySqlDbType.Date);
                    //파라미너 값 set
                    paramemberIdx.Value = Member.SelectedValue;
                    parabookIdx.Value = Book.SelectedValue;
                    pararentalDate.Value = RentalDate.Value;
                    if (myMode == BaseMode.INSERT)
                        parareturnDate.Value = null;
                    else
                        parareturnDate.Value = ReturnDate.Value;
                    //쿼리문 파라미터 set
                    cmd.Parameters.Add(paramemberIdx);
                    cmd.Parameters.Add(parabookIdx);
                    cmd.Parameters.Add(pararentalDate);
                    cmd.Parameters.Add(parareturnDate);
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
        private void InitControls()
        {
            //설정값 초기화
            IDX.Text = String.Empty;
            IDX.Focus();
            IDX.ReadOnly = true;

            Member.SelectedIndex = Book.SelectedIndex = 0;

            RentalDate.CustomFormat = "yyyy-MM-dd";
            RentalDate.Format = DateTimePickerFormat.Custom;
            RentalDate.Value = DateTime.Now;

            ReturnDate.CustomFormat = " ";
            ReturnDate.Format = DateTimePickerFormat.Custom;

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
        }

        private void GrdRentalTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //셀선택시 셀 내용 클릭시만 반응
            if (e.RowIndex > -1)
            {
               DataGridViewRow data = GrdRentalTbl.Rows[e.RowIndex];
                
                IDX.Text = data.Cells[0].Value.ToString();
                
                Member.SelectedValue = data.Cells[6].Value.ToString();
                
                Book.SelectedValue = data.Cells[7].Value.ToString();
                
                RentalDate.Value = DateTime.Parse(data.Cells[4].Value.ToString());
                
                if(!string.IsNullOrEmpty(data.Cells[5].Value.ToString()))
                {
                    ReturnDate.CustomFormat = "yyyy-MM-dd";
                    ReturnDate.Format = DateTimePickerFormat.Custom;
                    ReturnDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());
                }
                else
                {
                    ReturnDate.CustomFormat = "";
                    ReturnDate.Format = DateTimePickerFormat.Custom;
                        
                }



                myMode = BaseMode.UPDATE;//수정 모드 변경
            }
        }

        private void ReturnDate_VisibleChanged(object sender, EventArgs e)
        {
            ReturnDate.CustomFormat = "yyyy-MM-dd";
            ReturnDate.Format = DateTimePickerFormat.Custom;
        }

        private void Export_Click(object sender, EventArgs e)
        {
            //xlsx 일때
            IWorkbook workbook = new XSSFWorkbook();
            //xls 일때
            //IWorkbook workbook = new HSSFWorkbook();
            ISheet sheet1 = workbook.CreateSheet("Sheet1");
            sheet1.CreateRow(0).CreateCell(0).SetCellValue("Rental Book Data");
            int x = 1;

            DataSet ds = GrdRentalTbl.DataSource as DataSet;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                IRow row = sheet1.CreateRow(i);
                for (int j = 0; j < ds.Tables[0].Rows[0].ItemArray.Length; j++)
                {
                    if (j == 4 || j == 5)
                    {
                        var value = string.IsNullOrEmpty(ds.Tables[0].Rows[i].ItemArray[j].ToString()) ?
                            "" : ds.Tables[0].Rows[i].ItemArray[j].ToString().Substring(0, 10);
                        row.CreateCell(j).SetCellValue(value);
                    }
                    else if (j > 5)
                        break;
                    else
                    {
                        row.CreateCell(j).SetCellValue(ds.Tables[0].Rows[i].ItemArray[j].ToString());
                    }
                }
            }
            FileStream file = File.Create(Environment.CurrentDirectory + $@"\export.xlsx");
            workbook.Write(file);
            file.Close();

            MessageBox.Show("Export Done!!");
        }
    }
}
