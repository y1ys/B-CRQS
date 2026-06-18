
namespace WindowsFormsApp5
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.detectTimeBox = new System.Windows.Forms.TextBox();
            this.lineBox = new System.Windows.Forms.TextBox();
            this.productLotNumBox = new System.Windows.Forms.TextBox();
            this.classesBox = new System.Windows.Forms.TextBox();
            this.shiftBox = new System.Windows.Forms.TextBox();
            this.sapBox = new System.Windows.Forms.TextBox();
            this.defectReworkDescriptionBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.reworkCountBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ngCountBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reworkResultComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(294, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "班次：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(543, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "白/夜：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(45, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "线号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(294, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "产品批号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(543, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "SAP号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(45, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "产品名称：";
            // 
            // productNameBox
            // 
            this.productNameBox.BackColor = System.Drawing.Color.White;
            this.productNameBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productNameBox.Location = new System.Drawing.Point(141, 129);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.ReadOnly = true;
            this.productNameBox.Size = new System.Drawing.Size(417, 29);
            this.productNameBox.TabIndex = 3;
            this.productNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productNameBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // detectTimeBox
            // 
            this.detectTimeBox.BackColor = System.Drawing.Color.White;
            this.detectTimeBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detectTimeBox.Location = new System.Drawing.Point(109, 38);
            this.detectTimeBox.Name = "detectTimeBox";
            this.detectTimeBox.ReadOnly = true;
            this.detectTimeBox.Size = new System.Drawing.Size(121, 29);
            this.detectTimeBox.TabIndex = 3;
            this.detectTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lineBox
            // 
            this.lineBox.BackColor = System.Drawing.Color.White;
            this.lineBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineBox.Location = new System.Drawing.Point(110, 82);
            this.lineBox.Name = "lineBox";
            this.lineBox.ReadOnly = true;
            this.lineBox.Size = new System.Drawing.Size(121, 29);
            this.lineBox.TabIndex = 3;
            this.lineBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productLotNumBox
            // 
            this.productLotNumBox.BackColor = System.Drawing.Color.White;
            this.productLotNumBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productLotNumBox.Location = new System.Drawing.Point(390, 82);
            this.productLotNumBox.Name = "productLotNumBox";
            this.productLotNumBox.ReadOnly = true;
            this.productLotNumBox.Size = new System.Drawing.Size(121, 29);
            this.productLotNumBox.TabIndex = 3;
            this.productLotNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classesBox
            // 
            this.classesBox.BackColor = System.Drawing.Color.White;
            this.classesBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classesBox.Location = new System.Drawing.Point(390, 38);
            this.classesBox.Name = "classesBox";
            this.classesBox.ReadOnly = true;
            this.classesBox.Size = new System.Drawing.Size(121, 29);
            this.classesBox.TabIndex = 3;
            this.classesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shiftBox
            // 
            this.shiftBox.BackColor = System.Drawing.Color.White;
            this.shiftBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shiftBox.Location = new System.Drawing.Point(614, 32);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.ReadOnly = true;
            this.shiftBox.Size = new System.Drawing.Size(121, 29);
            this.shiftBox.TabIndex = 3;
            this.shiftBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sapBox
            // 
            this.sapBox.BackColor = System.Drawing.Color.White;
            this.sapBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sapBox.Location = new System.Drawing.Point(615, 81);
            this.sapBox.Name = "sapBox";
            this.sapBox.ReadOnly = true;
            this.sapBox.Size = new System.Drawing.Size(121, 29);
            this.sapBox.TabIndex = 3;
            this.sapBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // defectReworkDescriptionBox
            // 
            this.defectReworkDescriptionBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.defectReworkDescriptionBox.Location = new System.Drawing.Point(49, 215);
            this.defectReworkDescriptionBox.Multiline = true;
            this.defectReworkDescriptionBox.Name = "defectReworkDescriptionBox";
            this.defectReworkDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.defectReworkDescriptionBox.Size = new System.Drawing.Size(524, 241);
            this.defectReworkDescriptionBox.TabIndex = 3;
            this.defectReworkDescriptionBox.TextChanged += new System.EventHandler(this.defectReworkDescriptionBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(579, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "返工量：";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // reworkCountBox
            // 
            this.reworkCountBox.BackColor = System.Drawing.Color.White;
            this.reworkCountBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reworkCountBox.Location = new System.Drawing.Point(667, 235);
            this.reworkCountBox.Name = "reworkCountBox";
            this.reworkCountBox.Size = new System.Drawing.Size(85, 29);
            this.reworkCountBox.TabIndex = 3;
            this.reworkCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(579, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "不合格数：";
            // 
            // ngCountBox
            // 
            this.ngCountBox.BackColor = System.Drawing.Color.White;
            this.ngCountBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ngCountBox.Location = new System.Drawing.Point(667, 292);
            this.ngCountBox.Name = "ngCountBox";
            this.ngCountBox.Size = new System.Drawing.Size(85, 29);
            this.ngCountBox.TabIndex = 3;
            this.ngCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ngCountBox.TextChanged += new System.EventHandler(this.ngCountBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(579, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "返工结果：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(45, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "返工及缺陷描述：";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(626, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reworkResultComboBox
            // 
            this.reworkResultComboBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reworkResultComboBox.FormattingEnabled = true;
            this.reworkResultComboBox.Items.AddRange(new object[] {
            "返工合格",
            "报废",
            "让步接收"});
            this.reworkResultComboBox.Location = new System.Drawing.Point(667, 351);
            this.reworkResultComboBox.Name = "reworkResultComboBox";
            this.reworkResultComboBox.Size = new System.Drawing.Size(121, 29);
            this.reworkResultComboBox.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(762, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "袋";
            this.label12.Click += new System.EventHandler(this.label8_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(762, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "袋";
            this.label13.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.reworkResultComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sapBox);
            this.Controls.Add(this.ngCountBox);
            this.Controls.Add(this.reworkCountBox);
            this.Controls.Add(this.shiftBox);
            this.Controls.Add(this.classesBox);
            this.Controls.Add(this.productLotNumBox);
            this.Controls.Add(this.defectReworkDescriptionBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lineBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.detectTimeBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "返工记录表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox productNameBox;
        public System.Windows.Forms.TextBox detectTimeBox;
        public System.Windows.Forms.TextBox lineBox;
        public System.Windows.Forms.TextBox productLotNumBox;
        public System.Windows.Forms.TextBox classesBox;
        public System.Windows.Forms.TextBox shiftBox;
        public System.Windows.Forms.TextBox sapBox;
        public System.Windows.Forms.TextBox defectReworkDescriptionBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox reworkCountBox;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox ngCountBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox reworkResultComboBox;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
    }
}