using System;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShop.SubItems
{
    public partial class LoginForm : MetroForm
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void LoginProcess()
        {
            //빈값 비교
            if(string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(PassWord.Text))
            {
                MetroMessageBox.Show(this,"아이디, 패스워드를 입력 하세요!", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ID.Focus();
                return;
            }
            //실제 DB 처리
            string resultID = string.Empty;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commens.CONNSTR))
                {
                    conn.Open();
                    //Mysql에 날려줄 커맨드 생성
                    MySqlCommand cmd = new MySqlCommand();
                    //커멘드에 db 연결
                    cmd.Connection = conn;
                    //아이디 비번 값 일치하는 아이디값 받기
                    cmd.CommandText = "SELECT userid FROM usertbl " +
                                      "WHERE userid = @userid " +
                                      "AND password = @password";
                    //파라미터 set
                    MySqlParameter parameterID = new MySqlParameter("@userid", MySqlDbType.VarChar,12);
                    parameterID.Value = ID.Text;
                    MySqlParameter parameterPassword = new MySqlParameter("@password", MySqlDbType.VarChar);
                    var md5Hash = MD5.Create();
                    var cryptoPassword = Commens.GetMd5Hash(md5Hash, PassWord.Text.Trim());
                    parameterPassword.Value = cryptoPassword;
                    //파라미터 add
                    cmd.Parameters.Add(parameterID);
                    cmd.Parameters.Add(parameterPassword);

                    //리더 생성
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //sql 결과값 읽기
                    reader.Read();

                    //결과값 없을시
                    if (!reader.HasRows)
                    {
                        MetroMessageBox.Show(this, "아이디, 패스워드를 정확히 입력하세요", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ID.Text = PassWord.Text = string.Empty;
                        ID.Focus();
                        return;
                    }
                    //결과값 있을시
                    else
                    {
                        //결과값 set
                        resultID = reader["userid"] != null ? reader["userid"].ToString() : string.Empty;
                        Commens.USERID = resultID;
                        MetroMessageBox.Show(this, $"{resultID} 로그인 성공");
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"DB접속 에러 : {ex.Message}", "로그인 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(resultID))
            {
                MetroMessageBox.Show(this, "아이디, 패스워드를 정확히 입력하세요", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID.Text = PassWord.Text = string.Empty;
                ID.Focus();
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                PassWord.Focus();
            }
        }

        private void PassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //LoginProcess();
                BtnOK_Click(sender, new EventArgs());
            }
        }

    }
}
