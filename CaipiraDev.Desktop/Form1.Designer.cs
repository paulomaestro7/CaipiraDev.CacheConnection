
namespace CaipiraDev.Desktop
{
    partial class Fmr_View
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_ConnectRedis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_ConnectRedis
            // 
            this.Btn_ConnectRedis.Location = new System.Drawing.Point(2, 4);
            this.Btn_ConnectRedis.Name = "Btn_ConnectRedis";
            this.Btn_ConnectRedis.Size = new System.Drawing.Size(305, 23);
            this.Btn_ConnectRedis.TabIndex = 0;
            this.Btn_ConnectRedis.Text = "+ Connect Redis Server";
            this.Btn_ConnectRedis.UseVisualStyleBackColor = true;
            this.Btn_ConnectRedis.Click += new System.EventHandler(this.Btn_ConnectRedis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Fmr_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ConnectRedis);
            this.Name = "Fmr_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cache Redis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ConnectRedis;
        private System.Windows.Forms.Label label1;
    }
}

