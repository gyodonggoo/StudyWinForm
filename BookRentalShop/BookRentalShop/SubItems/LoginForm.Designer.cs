namespace BookRentalShop.SubItems
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ID = new MetroFramework.Controls.MetroTextBox();
            this.PassWord = new MetroFramework.Controls.MetroTextBox();
            this.BtnOK = new MetroFramework.Controls.MetroButton();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(21, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(21, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "PassWord :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ID
            // 
            // 
            // 
            // 
            this.ID.CustomButton.Image = null;
            this.ID.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.ID.CustomButton.Name = "";
            this.ID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ID.CustomButton.TabIndex = 1;
            this.ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ID.CustomButton.UseSelectable = true;
            this.ID.CustomButton.Visible = false;
            this.ID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ID.Lines = new string[0];
            this.ID.Location = new System.Drawing.Point(105, 61);
            this.ID.MaxLength = 12;
            this.ID.Name = "ID";
            this.ID.PasswordChar = '\0';
            this.ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ID.SelectedText = "";
            this.ID.SelectionLength = 0;
            this.ID.SelectionStart = 0;
            this.ID.ShortcutsEnabled = true;
            this.ID.Size = new System.Drawing.Size(194, 30);
            this.ID.TabIndex = 0;
            this.ID.UseSelectable = true;
            this.ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // PassWord
            // 
            // 
            // 
            // 
            this.PassWord.CustomButton.Image = null;
            this.PassWord.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.PassWord.CustomButton.Name = "";
            this.PassWord.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassWord.CustomButton.TabIndex = 1;
            this.PassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassWord.CustomButton.UseSelectable = true;
            this.PassWord.CustomButton.Visible = false;
            this.PassWord.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PassWord.Lines = new string[0];
            this.PassWord.Location = new System.Drawing.Point(105, 109);
            this.PassWord.MaxLength = 32767;
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '●';
            this.PassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassWord.SelectedText = "";
            this.PassWord.SelectionLength = 0;
            this.PassWord.SelectionStart = 0;
            this.PassWord.ShortcutsEnabled = true;
            this.PassWord.Size = new System.Drawing.Size(194, 30);
            this.PassWord.TabIndex = 1;
            this.PassWord.UseSelectable = true;
            this.PassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassWord_KeyPress);
            // 
            // BtnOK
            // 
            this.BtnOK.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnOK.Location = new System.Drawing.Point(67, 154);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(76, 39);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseSelectable = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnCancel.Location = new System.Drawing.Point(193, 154);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(76, 39);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 209);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox ID;
        private MetroFramework.Controls.MetroTextBox PassWord;
        private MetroFramework.Controls.MetroButton BtnOK;
        private MetroFramework.Controls.MetroButton BtnCancel;
    }
}