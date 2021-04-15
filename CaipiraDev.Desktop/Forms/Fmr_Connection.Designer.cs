
namespace CaipiraDev.Desktop.Forms
{
    partial class Fmr_Connection
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
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.Txt_Port = new System.Windows.Forms.TextBox();
            this.Lbl_Port = new System.Windows.Forms.Label();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Chk_Password = new System.Windows.Forms.CheckBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Test = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(153, 48);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(580, 23);
            this.Txt_Name.TabIndex = 0;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(62, 51);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(42, 15);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "Name:";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(62, 91);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(52, 15);
            this.Lbl_Address.TabIndex = 3;
            this.Lbl_Address.Text = "Address:";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(153, 88);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(461, 23);
            this.Txt_Address.TabIndex = 2;
            // 
            // Txt_Port
            // 
            this.Txt_Port.Location = new System.Drawing.Point(626, 88);
            this.Txt_Port.Name = "Txt_Port";
            this.Txt_Port.Size = new System.Drawing.Size(107, 23);
            this.Txt_Port.TabIndex = 4;
            this.Txt_Port.Text = "6380";
            this.Txt_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Port_KeyPress);
            // 
            // Lbl_Port
            // 
            this.Lbl_Port.AutoSize = true;
            this.Lbl_Port.Location = new System.Drawing.Point(616, 92);
            this.Lbl_Port.Name = "Lbl_Port";
            this.Lbl_Port.Size = new System.Drawing.Size(10, 15);
            this.Lbl_Port.TabIndex = 5;
            this.Lbl_Port.Text = ":";
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Location = new System.Drawing.Point(62, 132);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(33, 15);
            this.Lbl_User.TabIndex = 7;
            this.Lbl_User.Text = "User:";
            // 
            // Txt_User
            // 
            this.Txt_User.Location = new System.Drawing.Point(153, 129);
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(580, 23);
            this.Txt_User.TabIndex = 6;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(62, 176);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(60, 15);
            this.Lbl_Password.TabIndex = 10;
            this.Lbl_Password.Text = "Password:";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(153, 173);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(461, 23);
            this.Txt_Password.TabIndex = 9;
            this.Txt_Password.UseSystemPasswordChar = true;
            // 
            // Chk_Password
            // 
            this.Chk_Password.AutoSize = true;
            this.Chk_Password.Location = new System.Drawing.Point(625, 175);
            this.Chk_Password.Name = "Chk_Password";
            this.Chk_Password.Size = new System.Drawing.Size(108, 19);
            this.Chk_Password.TabIndex = 11;
            this.Chk_Password.Text = "Show password";
            this.Chk_Password.UseVisualStyleBackColor = true;
            this.Chk_Password.CheckedChanged += new System.EventHandler(this.Chk_Password_CheckedChanged);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(658, 234);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 12;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(577, 234);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 13;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Test
            // 
            this.Btn_Test.Location = new System.Drawing.Point(62, 234);
            this.Btn_Test.Name = "Btn_Test";
            this.Btn_Test.Size = new System.Drawing.Size(134, 23);
            this.Btn_Test.TabIndex = 14;
            this.Btn_Test.Text = "Test Connection";
            this.Btn_Test.UseVisualStyleBackColor = true;
            this.Btn_Test.Click += new System.EventHandler(this.Btn_Test_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 279);
            this.panel1.TabIndex = 15;
            // 
            // Fmr_Connection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(833, 303);
            this.Controls.Add(this.Btn_Test);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Chk_Password);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Lbl_User);
            this.Controls.Add(this.Txt_User);
            this.Controls.Add(this.Lbl_Port);
            this.Controls.Add(this.Txt_Port);
            this.Controls.Add(this.Lbl_Address);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fmr_Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Settings";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.TextBox Txt_Port;
        private System.Windows.Forms.Label Lbl_Port;
        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.CheckBox Chk_Password;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Test;
        private System.Windows.Forms.Panel panel1;
    }
}