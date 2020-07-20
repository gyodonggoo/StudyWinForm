using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using BookRentalShop.SubItems;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            UserID.Text = $"Login : {Commens.USERID}";
        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            var result = MetroMessageBox.Show(this, "종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MnuCoMng_Click(object sender, EventArgs e)
        {
            DevMngForm form = new DevMngForm();
            ShowFormControl(form, "구분코드 관리");
        }

        private void BooksMange_Click(object sender, EventArgs e)
        {
            BooksMngForm form = new BooksMngForm();
            ShowFormControl(form, "도서 관리");
        }
        private void UserMng_Click(object sender, EventArgs e)
        {
            UserMngForm form = new UserMngForm();
            ShowFormControl(form, "사용자 관리");
        }
        private void ShowFormControl(Form form, string text)
        {
            form.MdiParent = this;
            form.Text = text;
            form.Dock = DockStyle.Fill;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void RentalMng_Click(object sender, EventArgs e)
        {
            RentalMngForm form = new RentalMngForm();
            ShowFormControl(form, "대여 관리");
        }

        private void PeopleMng_Click(object sender, EventArgs e)
        {

        }
    }
}
