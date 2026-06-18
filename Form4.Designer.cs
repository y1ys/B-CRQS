
namespace WindowsFormsApp5
{
    partial class Form4
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelpwdtip = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxpwd = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelpwd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("宋体", 14F);
            this.buttonLogin.Location = new System.Drawing.Point(201, 264);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(128, 54);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelpwdtip);
            this.groupBox1.Controls.Add(this.textBoxname);
            this.groupBox1.Controls.Add(this.textBoxpwd);
            this.groupBox1.Controls.Add(this.labelname);
            this.groupBox1.Controls.Add(this.labelpwd);
            this.groupBox1.Location = new System.Drawing.Point(99, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 148);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录：";
            // 
            // labelpwdtip
            // 
            this.labelpwdtip.AutoSize = true;
            this.labelpwdtip.Location = new System.Drawing.Point(260, 102);
            this.labelpwdtip.Name = "labelpwdtip";
            this.labelpwdtip.Size = new System.Drawing.Size(0, 12);
            this.labelpwdtip.TabIndex = 2;
            // 
            // textBoxname
            // 
            this.textBoxname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxname.Font = new System.Drawing.Font("宋体", 14F);
            this.textBoxname.Location = new System.Drawing.Point(112, 35);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(142, 29);
            this.textBoxname.TabIndex = 1;
            // 
            // textBoxpwd
            // 
            this.textBoxpwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxpwd.Font = new System.Drawing.Font("宋体", 14F);
            this.textBoxpwd.Location = new System.Drawing.Point(112, 92);
            this.textBoxpwd.Name = "textBoxpwd";
            this.textBoxpwd.Size = new System.Drawing.Size(142, 29);
            this.textBoxpwd.TabIndex = 1;
            this.textBoxpwd.UseSystemPasswordChar = true;
            // 
            // labelname
            // 
            this.labelname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("宋体", 14F);
            this.labelname.Location = new System.Drawing.Point(21, 38);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(85, 19);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "用户名：";
            // 
            // labelpwd
            // 
            this.labelpwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelpwd.AutoSize = true;
            this.labelpwd.Font = new System.Drawing.Font("宋体", 14F);
            this.labelpwd.Location = new System.Drawing.Point(21, 95);
            this.labelpwd.Name = "labelpwd";
            this.labelpwd.Size = new System.Drawing.Size(66, 19);
            this.labelpwd.TabIndex = 0;
            this.labelpwd.Text = "密码：";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 364);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelpwdtip;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxpwd;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelpwd;
    }
}