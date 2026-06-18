
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.balanceSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.lightSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label40 = new System.Windows.Forms.Label();
            this.lightUpDown = new System.Windows.Forms.NumericUpDown();
            this.callStatus = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lightStatus = new System.Windows.Forms.PictureBox();
            this.scanGunStatus = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.recordStatus = new System.Windows.Forms.PictureBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.button28 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button25 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button20 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button24 = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.time16_label = new System.Windows.Forms.Label();
            this.time15_label = new System.Windows.Forms.Label();
            this.time14_label = new System.Windows.Forms.Label();
            this.time13_label = new System.Windows.Forms.Label();
            this.time12_label = new System.Windows.Forms.Label();
            this.time11_label = new System.Windows.Forms.Label();
            this.time10_label = new System.Windows.Forms.Label();
            this.time9_label = new System.Windows.Forms.Label();
            this.time8_label = new System.Windows.Forms.Label();
            this.time7_label = new System.Windows.Forms.Label();
            this.time6_label = new System.Windows.Forms.Label();
            this.time5_label = new System.Windows.Forms.Label();
            this.time4_label = new System.Windows.Forms.Label();
            this.time3_label = new System.Windows.Forms.Label();
            this.time2_label = new System.Windows.Forms.Label();
            this.time1_label = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.taskStatus1 = new System.Windows.Forms.PictureBox();
            this.redCountBox = new System.Windows.Forms.TextBox();
            this.detectType2_Box = new System.Windows.Forms.TextBox();
            this.spotCheckCountBox = new System.Windows.Forms.TextBox();
            this.yellowCountBox = new System.Windows.Forms.TextBox();
            this.projectNameBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.line2_comboBox = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.inspector2_comboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.stdPrintCodeBox = new System.Windows.Forms.TextBox();
            this.sapCodeBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button26 = new System.Windows.Forms.Button();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.button32 = new System.Windows.Forms.Button();
            this.tubWeightBox = new System.Windows.Forms.TextBox();
            this.LabelWight6 = new System.Windows.Forms.Label();
            this.LabelWight5 = new System.Windows.Forms.Label();
            this.LabelWight4 = new System.Windows.Forms.Label();
            this.LabelWight3 = new System.Windows.Forms.Label();
            this.LabelWight2 = new System.Windows.Forms.Label();
            this.LabelWight1 = new System.Windows.Forms.Label();
            this.taskStatus2 = new System.Windows.Forms.PictureBox();
            this.endBtn = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.tubWeightBox6 = new System.Windows.Forms.TextBox();
            this.tubWeightBox5 = new System.Windows.Forms.TextBox();
            this.tubWeightBox4 = new System.Windows.Forms.TextBox();
            this.tubWeightBox3 = new System.Windows.Forms.TextBox();
            this.tubWeightBox2 = new System.Windows.Forms.TextBox();
            this.tubWeightBox1 = new System.Windows.Forms.TextBox();
            this.defect_comboBox = new System.Windows.Forms.ComboBox();
            this.line3_comboBox = new System.Windows.Forms.ComboBox();
            this.inspector3_comboBox = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.status3 = new System.Windows.Forms.PictureBox();
            this.status2 = new System.Windows.Forms.PictureBox();
            this.arrow3 = new System.Windows.Forms.PictureBox();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.status1 = new System.Windows.Forms.PictureBox();
            this.statusCountLabel = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelControlRoi1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button33 = new System.Windows.Forms.Button();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.outerSapBox = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.outerProductBatchBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.backlabelingprojectnum = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.labelingprojectnum = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.stdProductBatchBox = new System.Windows.Forms.TextBox();
            this.detectResultBox = new System.Windows.Forms.TextBox();
            this.hSmartWin11 = new HalconDotNet.HSmartWindowControl();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SureButton = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.detectType1_comboBox = new System.Windows.Forms.ComboBox();
            this.inspector1_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.line1_comboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label73 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.wightLable5 = new System.Windows.Forms.Label();
            this.wightLable4 = new System.Windows.Forms.Label();
            this.wightLable3 = new System.Windows.Forms.Label();
            this.wightLable2 = new System.Windows.Forms.Label();
            this.wightLable1 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.button31 = new System.Windows.Forms.Button();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.button30 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanGunStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordStatus)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatus1)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatus2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(1448, 5);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(277, 32);
            this.timeLabel.TabIndex = 48;
            this.timeLabel.Text = "2023-8-14 11:34:36";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(1576, 86);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(52, 27);
            this.label44.TabIndex = 48;
            this.label44.Text = "扫码";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(1674, 86);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(52, 27);
            this.label45.TabIndex = 48;
            this.label45.Text = "台秤";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // balanceSerialPort
            // 
            this.balanceSerialPort.PortName = "COM13";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(1411, 86);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(52, 27);
            this.label40.TabIndex = 48;
            this.label40.Text = "光源";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lightUpDown
            // 
            this.lightUpDown.Enabled = false;
            this.lightUpDown.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lightUpDown.Location = new System.Drawing.Point(1509, 82);
            this.lightUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.lightUpDown.Name = "lightUpDown";
            this.lightUpDown.Size = new System.Drawing.Size(64, 34);
            this.lightUpDown.TabIndex = 49;
            this.lightUpDown.ValueChanged += new System.EventHandler(this.lightUpDown_ValueChanged);
            // 
            // callStatus
            // 
            this.callStatus.BackColor = System.Drawing.Color.Transparent;
            this.callStatus.Image = ((System.Drawing.Image)(resources.GetObject("callStatus.Image")));
            this.callStatus.Location = new System.Drawing.Point(1729, 79);
            this.callStatus.Name = "callStatus";
            this.callStatus.Size = new System.Drawing.Size(40, 40);
            this.callStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.callStatus.TabIndex = 3;
            this.callStatus.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(659, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lightStatus
            // 
            this.lightStatus.BackColor = System.Drawing.Color.Transparent;
            this.lightStatus.Image = ((System.Drawing.Image)(resources.GetObject("lightStatus.Image")));
            this.lightStatus.Location = new System.Drawing.Point(1466, 79);
            this.lightStatus.Name = "lightStatus";
            this.lightStatus.Size = new System.Drawing.Size(40, 40);
            this.lightStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightStatus.TabIndex = 3;
            this.lightStatus.TabStop = false;
            this.lightStatus.Click += new System.EventHandler(this.lightStatus_Click);
            // 
            // scanGunStatus
            // 
            this.scanGunStatus.BackColor = System.Drawing.Color.Transparent;
            this.scanGunStatus.Image = ((System.Drawing.Image)(resources.GetObject("scanGunStatus.Image")));
            this.scanGunStatus.Location = new System.Drawing.Point(1631, 79);
            this.scanGunStatus.Name = "scanGunStatus";
            this.scanGunStatus.Size = new System.Drawing.Size(40, 40);
            this.scanGunStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scanGunStatus.TabIndex = 3;
            this.scanGunStatus.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("微软雅黑", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(770, 43);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(499, 40);
            this.label28.TabIndex = 48;
            this.label28.Text = "E-PQS Detection System Line B";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(1772, 86);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(52, 27);
            this.label43.TabIndex = 48;
            this.label43.Text = "录像";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordStatus
            // 
            this.recordStatus.BackColor = System.Drawing.Color.Transparent;
            this.recordStatus.Image = ((System.Drawing.Image)(resources.GetObject("recordStatus.Image")));
            this.recordStatus.Location = new System.Drawing.Point(1827, 79);
            this.recordStatus.Name = "recordStatus";
            this.recordStatus.Size = new System.Drawing.Size(40, 40);
            this.recordStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recordStatus.TabIndex = 3;
            this.recordStatus.TabStop = false;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label49.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label49.Location = new System.Drawing.Point(1633, 41);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(81, 27);
            this.label49.TabIndex = 50;
            this.label49.Text = "label49";
            this.label49.Visible = false;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label50.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label50.Location = new System.Drawing.Point(1726, 41);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(0, 27);
            this.label50.TabIndex = 50;
            this.label50.Visible = false;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label51.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label51.Location = new System.Drawing.Point(1813, 43);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(0, 27);
            this.label51.TabIndex = 50;
            this.label51.Visible = false;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox13);
            this.tabPage7.Controls.Add(this.button25);
            this.tabPage7.Controls.Add(this.groupBox12);
            this.tabPage7.Controls.Add(this.button20);
            this.tabPage7.Location = new System.Drawing.Point(4, 36);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1894, 861);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "数据查询";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.button28);
            this.groupBox13.Controls.Add(this.label36);
            this.groupBox13.Controls.Add(this.label37);
            this.groupBox13.Controls.Add(this.dateTimePicker3);
            this.groupBox13.Controls.Add(this.dateTimePicker4);
            this.groupBox13.Controls.Add(this.dataGridView5);
            this.groupBox13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox13.Location = new System.Drawing.Point(24, 424);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1749, 355);
            this.groupBox13.TabIndex = 46;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "缺陷及返工数据查询";
            // 
            // button28
            // 
            this.button28.AutoSize = true;
            this.button28.Location = new System.Drawing.Point(810, 28);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(98, 41);
            this.button28.TabIndex = 49;
            this.button28.Text = "搜索";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(54, 38);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(90, 21);
            this.label36.TabIndex = 48;
            this.label36.Text = "开始时间：";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(432, 38);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(90, 21);
            this.label37.TabIndex = 48;
            this.label37.Text = "结束时间：";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker3.Location = new System.Drawing.Point(566, 34);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker3.TabIndex = 46;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker4.Location = new System.Drawing.Point(188, 34);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker4.TabIndex = 47;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn35,
            this.Column27,
            this.Column28,
            this.Column29});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView5.Location = new System.Drawing.Point(26, 75);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowHeadersWidth = 5;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.Size = new System.Drawing.Size(1705, 261);
            this.dataGridView5.TabIndex = 45;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "id";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "detect_time";
            this.dataGridViewTextBoxColumn16.HeaderText = "返工时间";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "classes";
            this.dataGridViewTextBoxColumn17.HeaderText = "班次";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "shift";
            this.dataGridViewTextBoxColumn19.HeaderText = "班制";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "project_num";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn18.HeaderText = "项目号";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "product_batch";
            this.dataGridViewTextBoxColumn25.HeaderText = "项目批号";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "sap_code";
            this.dataGridViewTextBoxColumn26.HeaderText = "SAP号";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn24.HeaderText = "产品名称";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "defect_rework_description";
            this.dataGridViewTextBoxColumn35.HeaderText = "返工及缺陷描述";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // Column27
            // 
            this.Column27.DataPropertyName = "rework_count";
            this.Column27.HeaderText = "返工量";
            this.Column27.MinimumWidth = 8;
            this.Column27.Name = "Column27";
            // 
            // Column28
            // 
            this.Column28.DataPropertyName = "ng_count";
            this.Column28.HeaderText = "不合格数";
            this.Column28.MinimumWidth = 8;
            this.Column28.Name = "Column28";
            // 
            // Column29
            // 
            this.Column29.DataPropertyName = "rework_result";
            this.Column29.HeaderText = "返工结果";
            this.Column29.MinimumWidth = 8;
            this.Column29.Name = "Column29";
            // 
            // button25
            // 
            this.button25.AutoSize = true;
            this.button25.Location = new System.Drawing.Point(1754, 197);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(190, 49);
            this.button25.TabIndex = 8;
            this.button25.Text = "黄/红灯选择";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Visible = false;
            this.button25.Click += new System.EventHandler(this.button25_Click_2);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button1);
            this.groupBox12.Controls.Add(this.button19);
            this.groupBox12.Controls.Add(this.button21);
            this.groupBox12.Controls.Add(this.button18);
            this.groupBox12.Controls.Add(this.button16);
            this.groupBox12.Controls.Add(this.button15);
            this.groupBox12.Controls.Add(this.label35);
            this.groupBox12.Controls.Add(this.label34);
            this.groupBox12.Controls.Add(this.dateTimePicker2);
            this.groupBox12.Controls.Add(this.dateTimePicker1);
            this.groupBox12.Controls.Add(this.dataGridView4);
            this.groupBox12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox12.Location = new System.Drawing.Point(23, 18);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1750, 393);
            this.groupBox12.TabIndex = 46;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "抽检记录数据查询";
            this.groupBox12.Enter += new System.EventHandler(this.groupBox12_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1294, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 51;
            this.button1.Text = "校称历史";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.Location = new System.Drawing.Point(1133, 30);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(98, 41);
            this.button19.TabIndex = 50;
            this.button19.Text = "删除";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click_1);
            this.button19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button19_MouseDown);
            // 
            // button21
            // 
            this.button21.AutoSize = true;
            this.button21.Location = new System.Drawing.Point(1616, 30);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(120, 41);
            this.button21.TabIndex = 49;
            this.button21.Text = "照片查看";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button18
            // 
            this.button18.AutoSize = true;
            this.button18.Location = new System.Drawing.Point(1455, 30);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(120, 41);
            this.button18.TabIndex = 49;
            this.button18.Text = "录像查看";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.Location = new System.Drawing.Point(972, 29);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(98, 41);
            this.button16.TabIndex = 49;
            this.button16.Text = "导出";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.Location = new System.Drawing.Point(757, 29);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(98, 41);
            this.button15.TabIndex = 49;
            this.button15.Text = "搜索";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(54, 37);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(90, 21);
            this.label35.TabIndex = 48;
            this.label35.Text = "开始时间：";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(408, 37);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(90, 21);
            this.label34.TabIndex = 48;
            this.label34.Text = "结束时间：";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2.Location = new System.Drawing.Point(530, 33);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column30,
            this.dataGridViewTextBoxColumn10,
            this.Column15,
            this.Column46,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn12,
            this.Column5,
            this.Column4,
            this.Column8,
            this.Column14,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column6,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column16,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column31,
            this.Column32,
            this.Column33,
            this.Column34,
            this.Column35,
            this.Column36,
            this.Column37,
            this.Column38,
            this.Column39,
            this.Column40,
            this.Column41,
            this.Column42,
            this.Column43,
            this.Column44,
            this.Column45});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView4.Location = new System.Drawing.Point(28, 77);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 5;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(1688, 277);
            this.dataGridView4.TabIndex = 45;
            // 
            // Column30
            // 
            this.Column30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column30.DataPropertyName = "id";
            this.Column30.HeaderText = "序号";
            this.Column30.MinimumWidth = 8;
            this.Column30.Name = "Column30";
            this.Column30.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column30.Visible = false;
            this.Column30.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "detect_time";
            this.dataGridViewTextBoxColumn10.HeaderText = "抽检时间";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // Column15
            // 
            this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column15.DataPropertyName = "detect_type";
            this.Column15.HeaderText = "抽检类型";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.Width = 150;
            // 
            // Column46
            // 
            this.Column46.DataPropertyName = "factory";
            this.Column46.HeaderText = "工厂";
            this.Column46.MinimumWidth = 8;
            this.Column46.Name = "Column46";
            this.Column46.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "line";
            this.dataGridViewTextBoxColumn14.HeaderText = "线体名称";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "classes";
            this.dataGridViewTextBoxColumn11.HeaderText = "班次";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "shift";
            this.dataGridViewTextBoxColumn13.HeaderText = "班制";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "project_num";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn12.HeaderText = "项目号";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "product_batch";
            this.Column5.HeaderText = "产品批号";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "sap_code";
            this.Column4.HeaderText = "SAP号";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.DataPropertyName = "product_name";
            this.Column8.HeaderText = "产品名称";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column14.DataPropertyName = "detailed_information";
            this.Column14.HeaderText = "详细信息";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.Width = 150;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column11.DataPropertyName = "total_count";
            this.Column11.HeaderText = "总样本量";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column12.DataPropertyName = "red_light_count";
            this.Column12.HeaderText = "红灯量";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.Width = 150;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column13.DataPropertyName = "yellow_light_count";
            this.Column13.HeaderText = "黄灯量";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.Width = 150;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "tub_weight_1";
            this.Column6.HeaderText = "称重1";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column22
            // 
            this.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column22.DataPropertyName = "tub_weight_2";
            this.Column22.HeaderText = "称重2";
            this.Column22.MinimumWidth = 8;
            this.Column22.Name = "Column22";
            this.Column22.Width = 150;
            // 
            // Column23
            // 
            this.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column23.DataPropertyName = "tub_weight_3";
            this.Column23.HeaderText = "称重3";
            this.Column23.MinimumWidth = 8;
            this.Column23.Name = "Column23";
            this.Column23.Width = 150;
            // 
            // Column24
            // 
            this.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column24.DataPropertyName = "tub_weight_4";
            this.Column24.HeaderText = "称重4";
            this.Column24.MinimumWidth = 8;
            this.Column24.Name = "Column24";
            this.Column24.Width = 150;
            // 
            // Column25
            // 
            this.Column25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column25.DataPropertyName = "tub_weight_5";
            this.Column25.HeaderText = "称重5";
            this.Column25.MinimumWidth = 8;
            this.Column25.Name = "Column25";
            this.Column25.Width = 150;
            // 
            // Column26
            // 
            this.Column26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column26.DataPropertyName = "tub_weight_6";
            this.Column26.HeaderText = "称重6";
            this.Column26.MinimumWidth = 8;
            this.Column26.Name = "Column26";
            this.Column26.Width = 150;
            // 
            // Column17
            // 
            this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column17.DataPropertyName = "defect_rework_description";
            this.Column17.HeaderText = "缺陷返工描述";
            this.Column17.MinimumWidth = 8;
            this.Column17.Name = "Column17";
            this.Column17.Width = 150;
            // 
            // Column18
            // 
            this.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column18.DataPropertyName = "rework_count";
            this.Column18.HeaderText = "返工数量";
            this.Column18.MinimumWidth = 8;
            this.Column18.Name = "Column18";
            this.Column18.Width = 150;
            // 
            // Column19
            // 
            this.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column19.DataPropertyName = "ng_count";
            this.Column19.HeaderText = "不合格数量";
            this.Column19.MinimumWidth = 8;
            this.Column19.Name = "Column19";
            this.Column19.Width = 150;
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column20.DataPropertyName = "rework_result";
            this.Column20.HeaderText = "返工结果";
            this.Column20.MinimumWidth = 8;
            this.Column20.Name = "Column20";
            this.Column20.Width = 150;
            // 
            // Column21
            // 
            this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column21.DataPropertyName = "notes";
            this.Column21.HeaderText = "备注";
            this.Column21.MinimumWidth = 8;
            this.Column21.Name = "Column21";
            this.Column21.Width = 150;
            // 
            // Column16
            // 
            this.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column16.DataPropertyName = "inspector";
            this.Column16.HeaderText = "抽检人";
            this.Column16.MinimumWidth = 8;
            this.Column16.Name = "Column16";
            this.Column16.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "order_id";
            this.Column1.HeaderText = "产品ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "std_product_batch";
            this.Column2.HeaderText = "标准批号";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "std_sap_code";
            this.Column3.HeaderText = "标准SAP号";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "min_weight";
            this.Column7.HeaderText = "重量下限";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "std_outer_box";
            this.Column9.HeaderText = "标准外箱";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "outer_box";
            this.Column10.HeaderText = "外箱";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // Column31
            // 
            this.Column31.DataPropertyName = "std_bag_bottle_project_number";
            this.Column31.HeaderText = "标准袋/膜/瓶项目号";
            this.Column31.MinimumWidth = 8;
            this.Column31.Name = "Column31";
            this.Column31.Width = 150;
            // 
            // Column32
            // 
            this.Column32.DataPropertyName = "bag_bottle_project_number";
            this.Column32.HeaderText = "袋/膜/瓶项目号";
            this.Column32.MinimumWidth = 8;
            this.Column32.Name = "Column32";
            this.Column32.Width = 150;
            // 
            // Column33
            // 
            this.Column33.DataPropertyName = "std_orthostandard";
            this.Column33.HeaderText = "标准正标";
            this.Column33.MinimumWidth = 8;
            this.Column33.Name = "Column33";
            this.Column33.Width = 150;
            // 
            // Column34
            // 
            this.Column34.DataPropertyName = "orthostandard";
            this.Column34.HeaderText = "正标";
            this.Column34.MinimumWidth = 8;
            this.Column34.Name = "Column34";
            this.Column34.Width = 150;
            // 
            // Column35
            // 
            this.Column35.DataPropertyName = "std_sticker";
            this.Column35.HeaderText = "标准标贴";
            this.Column35.MinimumWidth = 8;
            this.Column35.Name = "Column35";
            this.Column35.Width = 150;
            // 
            // Column36
            // 
            this.Column36.DataPropertyName = "sticker";
            this.Column36.HeaderText = "标贴";
            this.Column36.MinimumWidth = 8;
            this.Column36.Name = "Column36";
            this.Column36.Width = 150;
            // 
            // Column37
            // 
            this.Column37.DataPropertyName = "std_back_label";
            this.Column37.HeaderText = "标准背标";
            this.Column37.MinimumWidth = 8;
            this.Column37.Name = "Column37";
            this.Column37.Width = 150;
            // 
            // Column38
            // 
            this.Column38.DataPropertyName = "back_label";
            this.Column38.HeaderText = "背标";
            this.Column38.MinimumWidth = 8;
            this.Column38.Name = "Column38";
            this.Column38.Width = 150;
            // 
            // Column39
            // 
            this.Column39.DataPropertyName = "std_cover";
            this.Column39.HeaderText = "标准盖";
            this.Column39.MinimumWidth = 8;
            this.Column39.Name = "Column39";
            this.Column39.Width = 150;
            // 
            // Column40
            // 
            this.Column40.DataPropertyName = "cover";
            this.Column40.HeaderText = "盖";
            this.Column40.MinimumWidth = 8;
            this.Column40.Name = "Column40";
            this.Column40.Width = 150;
            // 
            // Column41
            // 
            this.Column41.DataPropertyName = "first_inspection_result";
            this.Column41.HeaderText = "校称结果";
            this.Column41.MinimumWidth = 8;
            this.Column41.Name = "Column41";
            this.Column41.Width = 150;
            // 
            // Column42
            // 
            this.Column42.DataPropertyName = "std_grid_block";
            this.Column42.HeaderText = "标准格挡";
            this.Column42.MinimumWidth = 8;
            this.Column42.Name = "Column42";
            this.Column42.Width = 150;
            // 
            // Column43
            // 
            this.Column43.DataPropertyName = "grid_block";
            this.Column43.HeaderText = "格挡";
            this.Column43.MinimumWidth = 8;
            this.Column43.Name = "Column43";
            this.Column43.Width = 150;
            // 
            // Column44
            // 
            this.Column44.DataPropertyName = "std_diversio_channel";
            this.Column44.HeaderText = "标准导流槽";
            this.Column44.MinimumWidth = 8;
            this.Column44.Name = "Column44";
            this.Column44.Width = 150;
            // 
            // Column45
            // 
            this.Column45.DataPropertyName = "diversio_channel";
            this.Column45.HeaderText = "导流槽";
            this.Column45.MinimumWidth = 8;
            this.Column45.Name = "Column45";
            this.Column45.Width = 150;
            // 
            // button20
            // 
            this.button20.AutoSize = true;
            this.button20.Location = new System.Drawing.Point(1745, 141);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(147, 49);
            this.button20.TabIndex = 49;
            this.button20.Text = "录像路径";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Visible = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox11);
            this.tabPage6.Location = new System.Drawing.Point(4, 36);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1894, 861);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "工艺配置";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button14);
            this.groupBox11.Controls.Add(this.button13);
            this.groupBox11.Controls.Add(this.textBox23);
            this.groupBox11.Controls.Add(this.comboBox11);
            this.groupBox11.Controls.Add(this.label39);
            this.groupBox11.Controls.Add(this.label41);
            this.groupBox11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox11.Location = new System.Drawing.Point(70, 24);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1678, 85);
            this.groupBox11.TabIndex = 45;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "产品基本信息";
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button14.Location = new System.Drawing.Point(1075, 32);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 49);
            this.button14.TabIndex = 3;
            this.button14.Text = "上传";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.Location = new System.Drawing.Point(898, 32);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 49);
            this.button13.TabIndex = 3;
            this.button13.Text = "确定";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // textBox23
            // 
            this.textBox23.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox23.Location = new System.Drawing.Point(668, 33);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(143, 34);
            this.textBox23.TabIndex = 2;
            this.textBox23.Text = "无任务";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox11
            // 
            this.comboBox11.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(184, 33);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(218, 35);
            this.comboBox11.TabIndex = 1;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.Location = new System.Drawing.Point(489, 37);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(92, 27);
            this.label39.TabIndex = 0;
            this.label39.Text = "关键字：";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.Location = new System.Drawing.Point(25, 37);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 27);
            this.label41.TabIndex = 0;
            this.label41.Text = "线号：";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox16);
            this.tabPage5.Controls.Add(this.txtLog);
            this.tabPage5.Location = new System.Drawing.Point(4, 36);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage5.Size = new System.Drawing.Size(1894, 861);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "基础信息";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.comboBox1);
            this.groupBox16.Controls.Add(this.button24);
            this.groupBox16.Controls.Add(this.label55);
            this.groupBox16.Controls.Add(this.button3);
            this.groupBox16.Controls.Add(this.textBox5);
            this.groupBox16.Controls.Add(this.label54);
            this.groupBox16.Location = new System.Drawing.Point(6, 6);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(730, 558);
            this.groupBox16.TabIndex = 10;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "人员信息管理";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(210, 208);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 35);
            this.comboBox1.TabIndex = 15;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(420, 208);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(139, 47);
            this.button24.TabIndex = 14;
            this.button24.Text = "确认删除";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click_1);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(112, 218);
            this.label55.Name = "label55";
            this.label55.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label55.Size = new System.Drawing.Size(97, 27);
            this.label55.TabIndex = 13;
            this.label55.Text = "人员删除:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 47);
            this.button3.TabIndex = 12;
            this.button3.Text = "确认添加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(210, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.ShortcutsEnabled = false;
            this.textBox5.Size = new System.Drawing.Size(167, 34);
            this.textBox5.TabIndex = 11;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(112, 139);
            this.label54.Name = "label54";
            this.label54.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label54.Size = new System.Drawing.Size(97, 27);
            this.label54.TabIndex = 10;
            this.label54.Text = "人员添加:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(742, 6);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(889, 558);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox10);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 36);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(1894, 861);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SOP管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dataGridView2);
            this.groupBox10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox10.Location = new System.Drawing.Point(35, 182);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1746, 580);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "文件基本信息";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Location = new System.Drawing.Point(32, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 5;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1690, 509);
            this.dataGridView2.TabIndex = 43;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "文件编号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "文件名称";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn3.HeaderText = "文件路径";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "文件备注";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.comboBox5);
            this.groupBox5.Controls.Add(this.comboBox4);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(35, 52);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1746, 100);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "基本操作";
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(1178, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 49);
            this.button6.TabIndex = 2;
            this.button6.Text = "预览";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(988, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 49);
            this.button5.TabIndex = 2;
            this.button5.Text = "确定";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(707, 42);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(189, 35);
            this.comboBox5.TabIndex = 1;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(242, 42);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(189, 35);
            this.comboBox4.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(523, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "关键字：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 27);
            this.label14.TabIndex = 0;
            this.label14.Text = "搜索条件：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox14);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(1894, 861);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "抽检信息记录";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.time16_label);
            this.groupBox14.Controls.Add(this.time15_label);
            this.groupBox14.Controls.Add(this.time14_label);
            this.groupBox14.Controls.Add(this.time13_label);
            this.groupBox14.Controls.Add(this.time12_label);
            this.groupBox14.Controls.Add(this.time11_label);
            this.groupBox14.Controls.Add(this.time10_label);
            this.groupBox14.Controls.Add(this.time9_label);
            this.groupBox14.Controls.Add(this.time8_label);
            this.groupBox14.Controls.Add(this.time7_label);
            this.groupBox14.Controls.Add(this.time6_label);
            this.groupBox14.Controls.Add(this.time5_label);
            this.groupBox14.Controls.Add(this.time4_label);
            this.groupBox14.Controls.Add(this.time3_label);
            this.groupBox14.Controls.Add(this.time2_label);
            this.groupBox14.Controls.Add(this.time1_label);
            this.groupBox14.Controls.Add(this.dataGridView6);
            this.groupBox14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox14.Location = new System.Drawing.Point(28, 335);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1765, 416);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "状态展示";
            // 
            // time16_label
            // 
            this.time16_label.AutoSize = true;
            this.time16_label.Location = new System.Drawing.Point(1636, 24);
            this.time16_label.Name = "time16_label";
            this.time16_label.Size = new System.Drawing.Size(74, 21);
            this.time16_label.TabIndex = 31;
            this.time16_label.Text = "待检入中";
            // 
            // time15_label
            // 
            this.time15_label.AutoSize = true;
            this.time15_label.Location = new System.Drawing.Point(1531, 24);
            this.time15_label.Name = "time15_label";
            this.time15_label.Size = new System.Drawing.Size(74, 21);
            this.time15_label.TabIndex = 30;
            this.time15_label.Text = "待检入中";
            // 
            // time14_label
            // 
            this.time14_label.AutoSize = true;
            this.time14_label.Location = new System.Drawing.Point(1426, 24);
            this.time14_label.Name = "time14_label";
            this.time14_label.Size = new System.Drawing.Size(74, 21);
            this.time14_label.TabIndex = 29;
            this.time14_label.Text = "待检入中";
            // 
            // time13_label
            // 
            this.time13_label.AutoSize = true;
            this.time13_label.Location = new System.Drawing.Point(1321, 24);
            this.time13_label.Name = "time13_label";
            this.time13_label.Size = new System.Drawing.Size(74, 21);
            this.time13_label.TabIndex = 28;
            this.time13_label.Text = "待检入中";
            // 
            // time12_label
            // 
            this.time12_label.AutoSize = true;
            this.time12_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time12_label.Location = new System.Drawing.Point(1215, 23);
            this.time12_label.Name = "time12_label";
            this.time12_label.Size = new System.Drawing.Size(74, 21);
            this.time12_label.TabIndex = 16;
            this.time12_label.Text = "待检入中";
            this.time12_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time11_label
            // 
            this.time11_label.AutoSize = true;
            this.time11_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time11_label.Location = new System.Drawing.Point(1109, 23);
            this.time11_label.Name = "time11_label";
            this.time11_label.Size = new System.Drawing.Size(74, 21);
            this.time11_label.TabIndex = 17;
            this.time11_label.Text = "待检入中";
            this.time11_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time10_label
            // 
            this.time10_label.AutoSize = true;
            this.time10_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time10_label.Location = new System.Drawing.Point(1003, 23);
            this.time10_label.Name = "time10_label";
            this.time10_label.Size = new System.Drawing.Size(74, 21);
            this.time10_label.TabIndex = 18;
            this.time10_label.Text = "待检入中";
            this.time10_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time9_label
            // 
            this.time9_label.AutoSize = true;
            this.time9_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time9_label.Location = new System.Drawing.Point(897, 23);
            this.time9_label.Name = "time9_label";
            this.time9_label.Size = new System.Drawing.Size(74, 21);
            this.time9_label.TabIndex = 19;
            this.time9_label.Text = "待检入中";
            this.time9_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time8_label
            // 
            this.time8_label.AutoSize = true;
            this.time8_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time8_label.Location = new System.Drawing.Point(791, 23);
            this.time8_label.Name = "time8_label";
            this.time8_label.Size = new System.Drawing.Size(74, 21);
            this.time8_label.TabIndex = 20;
            this.time8_label.Text = "待检入中";
            this.time8_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time7_label
            // 
            this.time7_label.AutoSize = true;
            this.time7_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time7_label.Location = new System.Drawing.Point(685, 23);
            this.time7_label.Name = "time7_label";
            this.time7_label.Size = new System.Drawing.Size(74, 21);
            this.time7_label.TabIndex = 21;
            this.time7_label.Text = "待检入中";
            this.time7_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time6_label
            // 
            this.time6_label.AutoSize = true;
            this.time6_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time6_label.Location = new System.Drawing.Point(579, 23);
            this.time6_label.Name = "time6_label";
            this.time6_label.Size = new System.Drawing.Size(74, 21);
            this.time6_label.TabIndex = 22;
            this.time6_label.Text = "待检入中";
            this.time6_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time5_label
            // 
            this.time5_label.AutoSize = true;
            this.time5_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time5_label.Location = new System.Drawing.Point(473, 23);
            this.time5_label.Name = "time5_label";
            this.time5_label.Size = new System.Drawing.Size(74, 21);
            this.time5_label.TabIndex = 23;
            this.time5_label.Text = "待检入中";
            this.time5_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time4_label
            // 
            this.time4_label.AutoSize = true;
            this.time4_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time4_label.Location = new System.Drawing.Point(367, 23);
            this.time4_label.Name = "time4_label";
            this.time4_label.Size = new System.Drawing.Size(74, 21);
            this.time4_label.TabIndex = 24;
            this.time4_label.Text = "待检入中";
            this.time4_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time3_label
            // 
            this.time3_label.AutoSize = true;
            this.time3_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time3_label.Location = new System.Drawing.Point(261, 23);
            this.time3_label.Name = "time3_label";
            this.time3_label.Size = new System.Drawing.Size(74, 21);
            this.time3_label.TabIndex = 25;
            this.time3_label.Text = "待检入中";
            this.time3_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time2_label
            // 
            this.time2_label.AutoSize = true;
            this.time2_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time2_label.Location = new System.Drawing.Point(155, 23);
            this.time2_label.Name = "time2_label";
            this.time2_label.Size = new System.Drawing.Size(74, 21);
            this.time2_label.TabIndex = 26;
            this.time2_label.Text = "待检入中";
            this.time2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time1_label
            // 
            this.time1_label.AutoSize = true;
            this.time1_label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time1_label.Location = new System.Drawing.Point(49, 23);
            this.time1_label.Name = "time1_label";
            this.time1_label.Size = new System.Drawing.Size(74, 21);
            this.time1_label.TabIndex = 27;
            this.time1_label.Text = "待检入中";
            this.time1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(37, 56);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowHeadersWidth = 62;
            this.dataGridView6.RowTemplate.Height = 23;
            this.dataGridView6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView6.Size = new System.Drawing.Size(1689, 328);
            this.dataGridView6.TabIndex = 15;
            this.dataGridView6.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView6_CellFormatting);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button10);
            this.groupBox7.Controls.Add(this.comboBox6);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.taskStatus1);
            this.groupBox7.Controls.Add(this.redCountBox);
            this.groupBox7.Controls.Add(this.detectType2_Box);
            this.groupBox7.Controls.Add(this.spotCheckCountBox);
            this.groupBox7.Controls.Add(this.yellowCountBox);
            this.groupBox7.Controls.Add(this.projectNameBox);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.line2_comboBox);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.inspector2_comboBox);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.stdPrintCodeBox);
            this.groupBox7.Controls.Add(this.sapCodeBox);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(51, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(834, 311);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "抽检人员及线体选择";
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(690, 259);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 41);
            this.button10.TabIndex = 6;
            this.button10.Text = "返工记录表";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(211, 260);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(416, 29);
            this.comboBox6.TabIndex = 5;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(26, 264);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(122, 21);
            this.label31.TabIndex = 4;
            this.label31.Text = "返工代码查询：";
            // 
            // taskStatus1
            // 
            this.taskStatus1.Image = ((System.Drawing.Image)(resources.GetObject("taskStatus1.Image")));
            this.taskStatus1.Location = new System.Drawing.Point(435, 30);
            this.taskStatus1.Name = "taskStatus1";
            this.taskStatus1.Size = new System.Drawing.Size(40, 40);
            this.taskStatus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.taskStatus1.TabIndex = 3;
            this.taskStatus1.TabStop = false;
            // 
            // redCountBox
            // 
            this.redCountBox.Location = new System.Drawing.Point(152, 204);
            this.redCountBox.Name = "redCountBox";
            this.redCountBox.ShortcutsEnabled = false;
            this.redCountBox.Size = new System.Drawing.Size(100, 29);
            this.redCountBox.TabIndex = 2;
            this.redCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detectType2_Box
            // 
            this.detectType2_Box.Location = new System.Drawing.Point(152, 81);
            this.detectType2_Box.Name = "detectType2_Box";
            this.detectType2_Box.ShortcutsEnabled = false;
            this.detectType2_Box.Size = new System.Drawing.Size(100, 29);
            this.detectType2_Box.TabIndex = 2;
            this.detectType2_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // spotCheckCountBox
            // 
            this.spotCheckCountBox.Location = new System.Drawing.Point(670, 204);
            this.spotCheckCountBox.Name = "spotCheckCountBox";
            this.spotCheckCountBox.ShortcutsEnabled = false;
            this.spotCheckCountBox.Size = new System.Drawing.Size(117, 29);
            this.spotCheckCountBox.TabIndex = 2;
            this.spotCheckCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yellowCountBox
            // 
            this.yellowCountBox.Location = new System.Drawing.Point(416, 204);
            this.yellowCountBox.Name = "yellowCountBox";
            this.yellowCountBox.ShortcutsEnabled = false;
            this.yellowCountBox.Size = new System.Drawing.Size(90, 29);
            this.yellowCountBox.TabIndex = 2;
            this.yellowCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // projectNameBox
            // 
            this.projectNameBox.Location = new System.Drawing.Point(452, 81);
            this.projectNameBox.Name = "projectNameBox";
            this.projectNameBox.ShortcutsEnabled = false;
            this.projectNameBox.Size = new System.Drawing.Size(338, 29);
            this.projectNameBox.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(543, 208);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 21);
            this.label23.TabIndex = 0;
            this.label23.Text = "抽检总数：";
            // 
            // line2_comboBox
            // 
            this.line2_comboBox.FormattingEnabled = true;
            this.line2_comboBox.Items.AddRange(new object[] {
            "X线",
            "Y线",
            "Z线"});
            this.line2_comboBox.Location = new System.Drawing.Point(152, 37);
            this.line2_comboBox.Name = "line2_comboBox";
            this.line2_comboBox.Size = new System.Drawing.Size(100, 29);
            this.line2_comboBox.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(291, 208);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 21);
            this.label22.TabIndex = 0;
            this.label22.Text = "黄灯总数：";
            // 
            // inspector2_comboBox
            // 
            this.inspector2_comboBox.FormattingEnabled = true;
            this.inspector2_comboBox.Items.AddRange(new object[] {
            "齐鲁磊",
            "黄亚萍",
            "何秀秀",
            "周本荣",
            "钟家桂",
            "程永康",
            "何玉清",
            "齐传兵",
            "王华玲"});
            this.inspector2_comboBox.Location = new System.Drawing.Point(673, 31);
            this.inspector2_comboBox.Name = "inspector2_comboBox";
            this.inspector2_comboBox.Size = new System.Drawing.Size(117, 29);
            this.inspector2_comboBox.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(291, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "项目名称：";
            // 
            // stdPrintCodeBox
            // 
            this.stdPrintCodeBox.Location = new System.Drawing.Point(152, 146);
            this.stdPrintCodeBox.Name = "stdPrintCodeBox";
            this.stdPrintCodeBox.ShortcutsEnabled = false;
            this.stdPrintCodeBox.Size = new System.Drawing.Size(212, 29);
            this.stdPrintCodeBox.TabIndex = 2;
            // 
            // sapCodeBox
            // 
            this.sapCodeBox.Location = new System.Drawing.Point(531, 131);
            this.sapCodeBox.Multiline = true;
            this.sapCodeBox.Name = "sapCodeBox";
            this.sapCodeBox.ShortcutsEnabled = false;
            this.sapCodeBox.Size = new System.Drawing.Size(258, 57);
            this.sapCodeBox.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(529, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 21);
            this.label20.TabIndex = 0;
            this.label20.Text = "抽检人员：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 208);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 21);
            this.label21.TabIndex = 0;
            this.label21.Text = "红灯总数：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(291, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "任务状态：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "检查类型：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(25, 149);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 21);
            this.label25.TabIndex = 0;
            this.label25.Text = "瓶身批号：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(421, 149);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 21);
            this.label26.TabIndex = 0;
            this.label26.Text = "外箱批号：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "线号：";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button26);
            this.groupBox9.Controls.Add(this.label80);
            this.groupBox9.Controls.Add(this.label79);
            this.groupBox9.Controls.Add(this.label78);
            this.groupBox9.Controls.Add(this.label77);
            this.groupBox9.Controls.Add(this.label76);
            this.groupBox9.Controls.Add(this.label75);
            this.groupBox9.Controls.Add(this.label74);
            this.groupBox9.Controls.Add(this.button32);
            this.groupBox9.Controls.Add(this.tubWeightBox);
            this.groupBox9.Controls.Add(this.LabelWight6);
            this.groupBox9.Controls.Add(this.LabelWight5);
            this.groupBox9.Controls.Add(this.LabelWight4);
            this.groupBox9.Controls.Add(this.LabelWight3);
            this.groupBox9.Controls.Add(this.LabelWight2);
            this.groupBox9.Controls.Add(this.LabelWight1);
            this.groupBox9.Controls.Add(this.taskStatus2);
            this.groupBox9.Controls.Add(this.endBtn);
            this.groupBox9.Controls.Add(this.button22);
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.button11);
            this.groupBox9.Controls.Add(this.tubWeightBox6);
            this.groupBox9.Controls.Add(this.tubWeightBox5);
            this.groupBox9.Controls.Add(this.tubWeightBox4);
            this.groupBox9.Controls.Add(this.tubWeightBox3);
            this.groupBox9.Controls.Add(this.tubWeightBox2);
            this.groupBox9.Controls.Add(this.tubWeightBox1);
            this.groupBox9.Controls.Add(this.defect_comboBox);
            this.groupBox9.Controls.Add(this.line3_comboBox);
            this.groupBox9.Controls.Add(this.inspector3_comboBox);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox9.Location = new System.Drawing.Point(902, 18);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(847, 311);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "本次抽检数据录入";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(21, 189);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(120, 40);
            this.button26.TabIndex = 3;
            this.button26.Text = "NG重置";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click_2);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(459, 94);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(20, 21);
            this.label80.TabIndex = 17;
            this.label80.Text = "g";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(231, 149);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(20, 21);
            this.label79.TabIndex = 16;
            this.label79.Text = "g";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(345, 149);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(20, 21);
            this.label78.TabIndex = 15;
            this.label78.Text = "g";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(459, 149);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(20, 21);
            this.label77.TabIndex = 14;
            this.label77.Text = "g";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(570, 149);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(20, 21);
            this.label76.TabIndex = 13;
            this.label76.Text = "g";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(687, 149);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(20, 21);
            this.label75.TabIndex = 12;
            this.label75.Text = "g";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(801, 149);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(20, 21);
            this.label74.TabIndex = 11;
            this.label74.Text = "g";
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(273, 93);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(66, 27);
            this.button32.TabIndex = 10;
            this.button32.Text = "去皮";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // tubWeightBox
            // 
            this.tubWeightBox.Location = new System.Drawing.Point(386, 91);
            this.tubWeightBox.Name = "tubWeightBox";
            this.tubWeightBox.ReadOnly = true;
            this.tubWeightBox.ShortcutsEnabled = false;
            this.tubWeightBox.Size = new System.Drawing.Size(67, 29);
            this.tubWeightBox.TabIndex = 9;
            // 
            // LabelWight6
            // 
            this.LabelWight6.AutoSize = true;
            this.LabelWight6.Location = new System.Drawing.Point(762, 189);
            this.LabelWight6.Name = "LabelWight6";
            this.LabelWight6.Size = new System.Drawing.Size(0, 21);
            this.LabelWight6.TabIndex = 3;
            // 
            // LabelWight5
            // 
            this.LabelWight5.AutoSize = true;
            this.LabelWight5.Location = new System.Drawing.Point(649, 189);
            this.LabelWight5.Name = "LabelWight5";
            this.LabelWight5.Size = new System.Drawing.Size(0, 21);
            this.LabelWight5.TabIndex = 4;
            // 
            // LabelWight4
            // 
            this.LabelWight4.AutoSize = true;
            this.LabelWight4.Location = new System.Drawing.Point(535, 189);
            this.LabelWight4.Name = "LabelWight4";
            this.LabelWight4.Size = new System.Drawing.Size(0, 21);
            this.LabelWight4.TabIndex = 5;
            // 
            // LabelWight3
            // 
            this.LabelWight3.AutoSize = true;
            this.LabelWight3.Location = new System.Drawing.Point(421, 189);
            this.LabelWight3.Name = "LabelWight3";
            this.LabelWight3.Size = new System.Drawing.Size(0, 21);
            this.LabelWight3.TabIndex = 6;
            // 
            // LabelWight2
            // 
            this.LabelWight2.AutoSize = true;
            this.LabelWight2.Location = new System.Drawing.Point(300, 189);
            this.LabelWight2.Name = "LabelWight2";
            this.LabelWight2.Size = new System.Drawing.Size(0, 21);
            this.LabelWight2.TabIndex = 7;
            // 
            // LabelWight1
            // 
            this.LabelWight1.AutoSize = true;
            this.LabelWight1.Location = new System.Drawing.Point(186, 189);
            this.LabelWight1.Name = "LabelWight1";
            this.LabelWight1.Size = new System.Drawing.Size(0, 21);
            this.LabelWight1.TabIndex = 8;
            // 
            // taskStatus2
            // 
            this.taskStatus2.Image = ((System.Drawing.Image)(resources.GetObject("taskStatus2.Image")));
            this.taskStatus2.Location = new System.Drawing.Point(431, 33);
            this.taskStatus2.Name = "taskStatus2";
            this.taskStatus2.Size = new System.Drawing.Size(40, 40);
            this.taskStatus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.taskStatus2.TabIndex = 3;
            this.taskStatus2.TabStop = false;
            // 
            // endBtn
            // 
            this.endBtn.AutoSize = true;
            this.endBtn.Enabled = false;
            this.endBtn.Location = new System.Drawing.Point(626, 230);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(201, 68);
            this.endBtn.TabIndex = 2;
            this.endBtn.Text = "数据录入";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.button12_Click);
            this.endBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.endBtn_MouseDown);
            // 
            // button22
            // 
            this.button22.AutoSize = true;
            this.button22.Location = new System.Drawing.Point(21, 259);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(154, 41);
            this.button22.TabIndex = 2;
            this.button22.Text = "黄/红灯选择";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(21, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 41);
            this.button4.TabIndex = 2;
            this.button4.Text = "开始称重";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.Location = new System.Drawing.Point(484, 244);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 41);
            this.button11.TabIndex = 2;
            this.button11.Text = "模拟称重";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // tubWeightBox6
            // 
            this.tubWeightBox6.Location = new System.Drawing.Point(729, 146);
            this.tubWeightBox6.Name = "tubWeightBox6";
            this.tubWeightBox6.ReadOnly = true;
            this.tubWeightBox6.ShortcutsEnabled = false;
            this.tubWeightBox6.Size = new System.Drawing.Size(66, 29);
            this.tubWeightBox6.TabIndex = 7;
            this.tubWeightBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tubWeightBox6.Leave += new System.EventHandler(this.tubWeightBox6_Leave);
            // 
            // tubWeightBox5
            // 
            this.tubWeightBox5.Location = new System.Drawing.Point(615, 146);
            this.tubWeightBox5.Name = "tubWeightBox5";
            this.tubWeightBox5.ReadOnly = true;
            this.tubWeightBox5.ShortcutsEnabled = false;
            this.tubWeightBox5.Size = new System.Drawing.Size(66, 29);
            this.tubWeightBox5.TabIndex = 6;
            this.tubWeightBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tubWeightBox4
            // 
            this.tubWeightBox4.Location = new System.Drawing.Point(501, 146);
            this.tubWeightBox4.Name = "tubWeightBox4";
            this.tubWeightBox4.ReadOnly = true;
            this.tubWeightBox4.ShortcutsEnabled = false;
            this.tubWeightBox4.Size = new System.Drawing.Size(66, 29);
            this.tubWeightBox4.TabIndex = 5;
            this.tubWeightBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tubWeightBox3
            // 
            this.tubWeightBox3.Location = new System.Drawing.Point(387, 146);
            this.tubWeightBox3.Name = "tubWeightBox3";
            this.tubWeightBox3.ReadOnly = true;
            this.tubWeightBox3.ShortcutsEnabled = false;
            this.tubWeightBox3.Size = new System.Drawing.Size(66, 29);
            this.tubWeightBox3.TabIndex = 4;
            this.tubWeightBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tubWeightBox2
            // 
            this.tubWeightBox2.Location = new System.Drawing.Point(273, 146);
            this.tubWeightBox2.Name = "tubWeightBox2";
            this.tubWeightBox2.ReadOnly = true;
            this.tubWeightBox2.ShortcutsEnabled = false;
            this.tubWeightBox2.Size = new System.Drawing.Size(66, 29);
            this.tubWeightBox2.TabIndex = 3;
            this.tubWeightBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tubWeightBox1
            // 
            this.tubWeightBox1.Location = new System.Drawing.Point(159, 146);
            this.tubWeightBox1.Name = "tubWeightBox1";
            this.tubWeightBox1.ReadOnly = true;
            this.tubWeightBox1.ShortcutsEnabled = false;
            this.tubWeightBox1.Size = new System.Drawing.Size(66, 29);
            this.tubWeightBox1.TabIndex = 2;
            this.tubWeightBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tubWeightBox1.Click += new System.EventHandler(this.tubWeightBox1_Click);
            this.tubWeightBox1.TextChanged += new System.EventHandler(this.tubWeightBox1_TextChanged);
            // 
            // defect_comboBox
            // 
            this.defect_comboBox.FormattingEnabled = true;
            this.defect_comboBox.Items.AddRange(new object[] {
            "塑料瓶",
            "软袋"});
            this.defect_comboBox.Location = new System.Drawing.Point(111, 87);
            this.defect_comboBox.Name = "defect_comboBox";
            this.defect_comboBox.Size = new System.Drawing.Size(100, 29);
            this.defect_comboBox.TabIndex = 1;
            this.defect_comboBox.SelectedIndexChanged += new System.EventHandler(this.defect_comboBox_SelectedIndexChanged);
            // 
            // line3_comboBox
            // 
            this.line3_comboBox.FormattingEnabled = true;
            this.line3_comboBox.Items.AddRange(new object[] {
            "X线",
            "Y线",
            "Z线"});
            this.line3_comboBox.Location = new System.Drawing.Point(111, 37);
            this.line3_comboBox.Name = "line3_comboBox";
            this.line3_comboBox.Size = new System.Drawing.Size(100, 29);
            this.line3_comboBox.TabIndex = 1;
            // 
            // inspector3_comboBox
            // 
            this.inspector3_comboBox.FormattingEnabled = true;
            this.inspector3_comboBox.Items.AddRange(new object[] {
            "齐鲁磊",
            "黄亚萍",
            "何秀秀",
            "周本荣",
            "钟家桂",
            "程永康",
            "何玉清",
            "齐传兵",
            "王华玲"});
            this.inspector3_comboBox.Location = new System.Drawing.Point(677, 39);
            this.inspector3_comboBox.Name = "inspector3_comboBox";
            this.inspector3_comboBox.Size = new System.Drawing.Size(117, 29);
            this.inspector3_comboBox.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(529, 43);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 21);
            this.label27.TabIndex = 0;
            this.label27.Text = "抽检人员：";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(299, 43);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 21);
            this.label29.TabIndex = 0;
            this.label29.Text = "任务状态";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(25, 91);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(90, 21);
            this.label30.TabIndex = 0;
            this.label30.Text = "包装类型：";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(25, 43);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(58, 21);
            this.label32.TabIndex = 0;
            this.label32.Text = "线号：";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox15);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1894, 861);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "作业指导";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.status3);
            this.groupBox15.Controls.Add(this.status2);
            this.groupBox15.Controls.Add(this.arrow3);
            this.groupBox15.Controls.Add(this.arrow2);
            this.groupBox15.Controls.Add(this.status1);
            this.groupBox15.Controls.Add(this.statusCountLabel);
            this.groupBox15.Controls.Add(this.label48);
            this.groupBox15.Controls.Add(this.label47);
            this.groupBox15.Controls.Add(this.label46);
            this.groupBox15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox15.Location = new System.Drawing.Point(45, 686);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(557, 135);
            this.groupBox15.TabIndex = 43;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "状态展示";
            // 
            // status3
            // 
            this.status3.Image = ((System.Drawing.Image)(resources.GetObject("status3.Image")));
            this.status3.Location = new System.Drawing.Point(445, 46);
            this.status3.Name = "status3";
            this.status3.Size = new System.Drawing.Size(50, 50);
            this.status3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status3.TabIndex = 50;
            this.status3.TabStop = false;
            // 
            // status2
            // 
            this.status2.Image = ((System.Drawing.Image)(resources.GetObject("status2.Image")));
            this.status2.Location = new System.Drawing.Point(239, 46);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(50, 50);
            this.status2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status2.TabIndex = 50;
            this.status2.TabStop = false;
            // 
            // arrow3
            // 
            this.arrow3.BackColor = System.Drawing.Color.Transparent;
            this.arrow3.Image = ((System.Drawing.Image)(resources.GetObject("arrow3.Image")));
            this.arrow3.Location = new System.Drawing.Point(353, 49);
            this.arrow3.Name = "arrow3";
            this.arrow3.Size = new System.Drawing.Size(60, 47);
            this.arrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow3.TabIndex = 50;
            this.arrow3.TabStop = false;
            // 
            // arrow2
            // 
            this.arrow2.BackColor = System.Drawing.Color.Transparent;
            this.arrow2.Image = ((System.Drawing.Image)(resources.GetObject("arrow2.Image")));
            this.arrow2.Location = new System.Drawing.Point(143, 49);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(60, 47);
            this.arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow2.TabIndex = 50;
            this.arrow2.TabStop = false;
            // 
            // status1
            // 
            this.status1.Image = ((System.Drawing.Image)(resources.GetObject("status1.Image")));
            this.status1.Location = new System.Drawing.Point(49, 46);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(50, 50);
            this.status1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status1.TabIndex = 50;
            this.status1.TabStop = false;
            // 
            // statusCountLabel
            // 
            this.statusCountLabel.AutoSize = true;
            this.statusCountLabel.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusCountLabel.ForeColor = System.Drawing.Color.Gray;
            this.statusCountLabel.Location = new System.Drawing.Point(299, 44);
            this.statusCountLabel.Name = "statusCountLabel";
            this.statusCountLabel.Size = new System.Drawing.Size(48, 52);
            this.statusCountLabel.TabIndex = 0;
            this.statusCountLabel.Text = "0";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(449, 105);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(42, 21);
            this.label48.TabIndex = 0;
            this.label48.Text = "尾检";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(234, 105);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 21);
            this.label47.TabIndex = 0;
            this.label47.Text = "CRQS";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(53, 105);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(42, 21);
            this.label46.TabIndex = 0;
            this.label46.Text = "首检";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelControlRoi1);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.hSmartWin11);
            this.groupBox6.Controls.Add(this.label52);
            this.groupBox6.Controls.Add(this.textBox_ip);
            this.groupBox6.Controls.Add(this.label53);
            this.groupBox6.Controls.Add(this.textBox_port);
            this.groupBox6.Controls.Add(this.textBox11);
            this.groupBox6.Controls.Add(this.button12);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.textBox12);
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.textBox14);
            this.groupBox6.Controls.Add(this.textBox13);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.textBox16);
            this.groupBox6.Controls.Add(this.textBox15);
            this.groupBox6.Controls.Add(this.label42);
            this.groupBox6.Controls.Add(this.textBox18);
            this.groupBox6.Controls.Add(this.textBox17);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(608, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1230, 793);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // labelControlRoi1
            // 
            this.labelControlRoi1.AutoSize = true;
            this.labelControlRoi1.Location = new System.Drawing.Point(474, 726);
            this.labelControlRoi1.Name = "labelControlRoi1";
            this.labelControlRoi1.Size = new System.Drawing.Size(58, 21);
            this.labelControlRoi1.TabIndex = 48;
            this.labelControlRoi1.Text = "0,0,0,0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button23);
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(6, 657);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 110);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "设置参数";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(272, 32);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(104, 40);
            this.button23.TabIndex = 2;
            this.button23.Text = "修改";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click_1);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown2.Location = new System.Drawing.Point(128, 70);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 34);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(129, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 34);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(30, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "相机增益";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(30, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 27);
            this.label13.TabIndex = 0;
            this.label13.Text = "曝光";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button33);
            this.groupBox3.Controls.Add(this.textBox35);
            this.groupBox3.Controls.Add(this.textBox34);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.outerSapBox);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.outerProductBatchBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(6, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 177);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "外箱喷码确认";
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(306, 129);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(110, 40);
            this.button33.TabIndex = 51;
            this.button33.Text = "人工确认";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // textBox35
            // 
            this.textBox35.BackColor = System.Drawing.SystemColors.Window;
            this.textBox35.Location = new System.Drawing.Point(296, 90);
            this.textBox35.Name = "textBox35";
            this.textBox35.ShortcutsEnabled = false;
            this.textBox35.Size = new System.Drawing.Size(140, 29);
            this.textBox35.TabIndex = 50;
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox34
            // 
            this.textBox34.BackColor = System.Drawing.SystemColors.Window;
            this.textBox34.Location = new System.Drawing.Point(296, 37);
            this.textBox34.Name = "textBox34";
            this.textBox34.ShortcutsEnabled = false;
            this.textBox34.Size = new System.Drawing.Size(140, 29);
            this.textBox34.TabIndex = 49;
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "外箱追溯码：";
            // 
            // outerSapBox
            // 
            this.outerSapBox.BackColor = System.Drawing.SystemColors.Window;
            this.outerSapBox.Location = new System.Drawing.Point(139, 90);
            this.outerSapBox.Name = "outerSapBox";
            this.outerSapBox.ReadOnly = true;
            this.outerSapBox.ShortcutsEnabled = false;
            this.outerSapBox.Size = new System.Drawing.Size(140, 29);
            this.outerSapBox.TabIndex = 48;
            this.outerSapBox.Text = "N/A";
            this.outerSapBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(158, 125);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 50);
            this.button9.TabIndex = 0;
            this.button9.Text = "OK提交";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // outerProductBatchBox
            // 
            this.outerProductBatchBox.BackColor = System.Drawing.SystemColors.Window;
            this.outerProductBatchBox.Location = new System.Drawing.Point(141, 37);
            this.outerProductBatchBox.Name = "outerProductBatchBox";
            this.outerProductBatchBox.ReadOnly = true;
            this.outerProductBatchBox.ShortcutsEnabled = false;
            this.outerProductBatchBox.Size = new System.Drawing.Size(138, 29);
            this.outerProductBatchBox.TabIndex = 48;
            this.outerProductBatchBox.Text = "N/A";
            this.outerProductBatchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(6, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "外箱SAP码：";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label60);
            this.groupBox8.Controls.Add(this.label59);
            this.groupBox8.Controls.Add(this.backlabelingprojectnum);
            this.groupBox8.Controls.Add(this.textBox22);
            this.groupBox8.Controls.Add(this.labelingprojectnum);
            this.groupBox8.Controls.Add(this.textBox25);
            this.groupBox8.Controls.Add(this.button29);
            this.groupBox8.Controls.Add(this.button27);
            this.groupBox8.Controls.Add(this.label57);
            this.groupBox8.Controls.Add(this.label56);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.stdProductBatchBox);
            this.groupBox8.Controls.Add(this.detectResultBox);
            this.groupBox8.Location = new System.Drawing.Point(6, 39);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(442, 403);
            this.groupBox8.TabIndex = 60;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "瓶身码检测";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(44, 328);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(64, 21);
            this.label60.TabIndex = 62;
            this.label60.Text = "label60";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(44, 209);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(64, 21);
            this.label59.TabIndex = 61;
            this.label59.Text = "label59";
            // 
            // backlabelingprojectnum
            // 
            this.backlabelingprojectnum.Enabled = false;
            this.backlabelingprojectnum.Location = new System.Drawing.Point(170, 267);
            this.backlabelingprojectnum.Name = "backlabelingprojectnum";
            this.backlabelingprojectnum.ReadOnly = true;
            this.backlabelingprojectnum.ShortcutsEnabled = false;
            this.backlabelingprojectnum.Size = new System.Drawing.Size(204, 29);
            this.backlabelingprojectnum.TabIndex = 59;
            this.backlabelingprojectnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.Enabled = false;
            this.textBox22.Location = new System.Drawing.Point(170, 325);
            this.textBox22.Name = "textBox22";
            this.textBox22.ShortcutsEnabled = false;
            this.textBox22.Size = new System.Drawing.Size(204, 29);
            this.textBox22.TabIndex = 60;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged_1);
            // 
            // labelingprojectnum
            // 
            this.labelingprojectnum.Enabled = false;
            this.labelingprojectnum.Location = new System.Drawing.Point(170, 153);
            this.labelingprojectnum.Name = "labelingprojectnum";
            this.labelingprojectnum.ReadOnly = true;
            this.labelingprojectnum.ShortcutsEnabled = false;
            this.labelingprojectnum.Size = new System.Drawing.Size(204, 29);
            this.labelingprojectnum.TabIndex = 57;
            this.labelingprojectnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.Enabled = false;
            this.textBox25.Location = new System.Drawing.Point(170, 201);
            this.textBox25.Name = "textBox25";
            this.textBox25.ShortcutsEnabled = false;
            this.textBox25.Size = new System.Drawing.Size(204, 29);
            this.textBox25.TabIndex = 58;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox25.TextChanged += new System.EventHandler(this.textBox25_TextChanged_1);
            // 
            // button29
            // 
            this.button29.AutoSize = true;
            this.button29.BackColor = System.Drawing.Color.White;
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Location = new System.Drawing.Point(23, 278);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(123, 35);
            this.button29.TabIndex = 56;
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button27
            // 
            this.button27.AutoSize = true;
            this.button27.BackColor = System.Drawing.Color.White;
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Location = new System.Drawing.Point(23, 164);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(178, 41);
            this.button27.TabIndex = 55;
            this.button27.Text = "卷膜/袋身拍照";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(292, 164);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(64, 21);
            this.label57.TabIndex = 54;
            this.label57.Text = "label57";
            this.label57.Visible = false;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(44, 103);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(64, 21);
            this.label56.TabIndex = 53;
            this.label56.Text = "label56";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(23, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "批号拍照";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stdProductBatchBox
            // 
            this.stdProductBatchBox.Enabled = false;
            this.stdProductBatchBox.Location = new System.Drawing.Point(170, 44);
            this.stdProductBatchBox.Name = "stdProductBatchBox";
            this.stdProductBatchBox.ReadOnly = true;
            this.stdProductBatchBox.ShortcutsEnabled = false;
            this.stdProductBatchBox.Size = new System.Drawing.Size(204, 29);
            this.stdProductBatchBox.TabIndex = 48;
            this.stdProductBatchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stdProductBatchBox.TextChanged += new System.EventHandler(this.stdProductBatchBox_TextChanged);
            // 
            // detectResultBox
            // 
            this.detectResultBox.Enabled = false;
            this.detectResultBox.Location = new System.Drawing.Point(170, 95);
            this.detectResultBox.Name = "detectResultBox";
            this.detectResultBox.ShortcutsEnabled = false;
            this.detectResultBox.Size = new System.Drawing.Size(204, 29);
            this.detectResultBox.TabIndex = 48;
            this.detectResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.detectResultBox.TextChanged += new System.EventHandler(this.detectResultBox_TextChanged);
            // 
            // hSmartWin11
            // 
            this.hSmartWin11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWin11.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWin11.HDoubleClickToFitContent = true;
            this.hSmartWin11.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWin11.HImagePart = new System.Drawing.Rectangle(0, 0, 2448, 1440);
            this.hSmartWin11.HKeepAspectRatio = true;
            this.hSmartWin11.HMoveContent = true;
            this.hSmartWin11.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWin11.Location = new System.Drawing.Point(469, 50);
            this.hSmartWin11.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWin11.Name = "hSmartWin11";
            this.hSmartWin11.Size = new System.Drawing.Size(733, 693);
            this.hSmartWin11.TabIndex = 58;
            this.hSmartWin11.WindowSize = new System.Drawing.Size(733, 693);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(67, 176);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(58, 21);
            this.label52.TabIndex = 46;
            this.label52.Text = "端口：";
            this.label52.Visible = false;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(146, 125);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(137, 29);
            this.textBox_ip.TabIndex = 45;
            this.textBox_ip.Text = "192.168.1.99";
            this.textBox_ip.Visible = false;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(67, 132);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(73, 21);
            this.label53.TabIndex = 44;
            this.label53.Text = "IP地址：";
            this.label53.Visible = false;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(146, 166);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(93, 29);
            this.textBox_port.TabIndex = 47;
            this.textBox_port.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(398, 227);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(161, 21);
            this.textBox11.TabIndex = 8;
            this.textBox11.Visible = false;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.Location = new System.Drawing.Point(527, 72);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(216, 40);
            this.button12.TabIndex = 52;
            this.button12.Text = "贴标瓶/袋/膜项目号拍照";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_2);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(22, 227);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(136, 21);
            this.label24.TabIndex = 6;
            this.label24.Text = "袋/膜/瓶项目号：";
            this.label24.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(496, 92);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(161, 29);
            this.textBox7.TabIndex = 50;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.Visible = false;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(164, 227);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(161, 21);
            this.textBox12.TabIndex = 7;
            this.textBox12.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(513, 139);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(161, 29);
            this.textBox8.TabIndex = 51;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(49, 258);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(106, 21);
            this.label33.TabIndex = 9;
            this.label33.Text = "标贴项目号：";
            this.label33.Visible = false;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(164, 258);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(161, 21);
            this.textBox14.TabIndex = 10;
            this.textBox14.Visible = false;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Window;
            this.textBox13.Location = new System.Drawing.Point(398, 258);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(161, 21);
            this.textBox13.TabIndex = 11;
            this.textBox13.Visible = false;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(49, 287);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(106, 21);
            this.label38.TabIndex = 12;
            this.label38.Text = "正标项目号：";
            this.label38.Visible = false;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(164, 287);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(161, 21);
            this.textBox16.TabIndex = 13;
            this.textBox16.Visible = false;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(398, 287);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(161, 21);
            this.textBox15.TabIndex = 14;
            this.textBox15.Visible = false;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(49, 314);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(106, 21);
            this.label42.TabIndex = 15;
            this.label42.Text = "背标项目号：";
            this.label42.Visible = false;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(164, 314);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(161, 21);
            this.textBox18.TabIndex = 16;
            this.textBox18.Visible = false;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(398, 314);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(161, 21);
            this.textBox17.TabIndex = 17;
            this.textBox17.Visible = false;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.SureButton);
            this.groupBox2.Controls.Add(this.textBox_Name);
            this.groupBox2.Controls.Add(this.label63);
            this.groupBox2.Controls.Add(this.textBox33);
            this.groupBox2.Controls.Add(this.textBox32);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox29);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox21);
            this.groupBox2.Controls.Add(this.textBox24);
            this.groupBox2.Controls.Add(this.label61);
            this.groupBox2.Controls.Add(this.textBox19);
            this.groupBox2.Controls.Add(this.textBox20);
            this.groupBox2.Controls.Add(this.label58);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(45, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 421);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "打码格式及重量标准";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(22, 141);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(87, 25);
            this.checkBox4.TabIndex = 32;
            this.checkBox4.Text = "自动改P";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // SureButton
            // 
            this.SureButton.Location = new System.Drawing.Point(371, 380);
            this.SureButton.Name = "SureButton";
            this.SureButton.Size = new System.Drawing.Size(99, 33);
            this.SureButton.TabIndex = 31;
            this.SureButton.Text = "数据确认";
            this.SureButton.UseVisualStyleBackColor = true;
            this.SureButton.Visible = false;
            this.SureButton.Click += new System.EventHandler(this.SureButton_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(342, 70);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.ShortcutsEnabled = false;
            this.textBox_Name.Size = new System.Drawing.Size(128, 29);
            this.textBox_Name.TabIndex = 30;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(341, 35);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(90, 21);
            this.label63.TabIndex = 29;
            this.label63.Text = "项目名称：";
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(14, 382);
            this.textBox33.Name = "textBox33";
            this.textBox33.ShortcutsEnabled = false;
            this.textBox33.Size = new System.Drawing.Size(134, 29);
            this.textBox33.TabIndex = 28;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(174, 383);
            this.textBox32.Name = "textBox32";
            this.textBox32.ShortcutsEnabled = false;
            this.textBox32.Size = new System.Drawing.Size(147, 29);
            this.textBox32.TabIndex = 27;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(760, 426);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ShortcutsEnabled = false;
            this.textBox4.Size = new System.Drawing.Size(128, 27);
            this.textBox4.TabIndex = 26;
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox29
            // 
            this.textBox29.Enabled = false;
            this.textBox29.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox29.Location = new System.Drawing.Point(143, 328);
            this.textBox29.Multiline = true;
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.ShortcutsEnabled = false;
            this.textBox29.Size = new System.Drawing.Size(178, 27);
            this.textBox29.TabIndex = 25;
            this.textBox29.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "导流槽项目号：";
            this.label7.Visible = false;
            // 
            // textBox21
            // 
            this.textBox21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox21.Location = new System.Drawing.Point(342, 283);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ShortcutsEnabled = false;
            this.textBox21.Size = new System.Drawing.Size(128, 27);
            this.textBox21.TabIndex = 23;
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // textBox24
            // 
            this.textBox24.Enabled = false;
            this.textBox24.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox24.Location = new System.Drawing.Point(143, 283);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.ShortcutsEnabled = false;
            this.textBox24.Size = new System.Drawing.Size(178, 27);
            this.textBox24.TabIndex = 22;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(10, 279);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(106, 21);
            this.label61.TabIndex = 21;
            this.label61.Text = "格挡项目号：";
            // 
            // textBox19
            // 
            this.textBox19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox19.Location = new System.Drawing.Point(342, 240);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.ShortcutsEnabled = false;
            this.textBox19.Size = new System.Drawing.Size(128, 27);
            this.textBox19.TabIndex = 20;
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // textBox20
            // 
            this.textBox20.Enabled = false;
            this.textBox20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox20.Location = new System.Drawing.Point(143, 240);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.ShortcutsEnabled = false;
            this.textBox20.Size = new System.Drawing.Size(178, 27);
            this.textBox20.TabIndex = 19;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(12, 236);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(90, 21);
            this.label58.TabIndex = 18;
            this.label58.Text = "盖项目号：";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(342, 195);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ShortcutsEnabled = false;
            this.textBox10.Size = new System.Drawing.Size(128, 27);
            this.textBox10.TabIndex = 5;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(143, 195);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.ShortcutsEnabled = false;
            this.textBox9.Size = new System.Drawing.Size(180, 27);
            this.textBox9.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "外箱项目号：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "瓶/袋重量(g):";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(342, 139);
            this.textBox6.Name = "textBox6";
            this.textBox6.ShortcutsEnabled = false;
            this.textBox6.Size = new System.Drawing.Size(128, 29);
            this.textBox6.TabIndex = 2;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(143, 70);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ShortcutsEnabled = false;
            this.textBox3.Size = new System.Drawing.Size(180, 98);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(143, 32);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(180, 29);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "外箱打码格式：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "瓶身打码格式：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.detectType1_comboBox);
            this.groupBox1.Controls.Add(this.inspector1_comboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.line1_comboBox);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(45, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "抽检人员及线体选择";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(435, 143);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 25);
            this.checkBox3.TabIndex = 46;
            this.checkBox3.Text = "外销";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(108, 143);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 25);
            this.checkBox2.TabIndex = 44;
            this.checkBox2.Text = "手动改码";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkBox2_MouseDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(342, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 25);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "半成品";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Location = new System.Drawing.Point(414, 188);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 40);
            this.button8.TabIndex = 44;
            this.button8.Text = "导入数据";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_2);
            // 
            // startBtn
            // 
            this.startBtn.AutoSize = true;
            this.startBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(14, 185);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(144, 41);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "项目号确认";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button17.Location = new System.Drawing.Point(280, 188);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(172, 40);
            this.button17.TabIndex = 3;
            this.button17.Text = "重置所有流程";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            this.button17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button17_MouseDown);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Location = new System.Drawing.Point(143, 188);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 40);
            this.button7.TabIndex = 3;
            this.button7.Text = "流程重置";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button7_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(342, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(144, 34);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // detectType1_comboBox
            // 
            this.detectType1_comboBox.FormattingEnabled = true;
            this.detectType1_comboBox.Items.AddRange(new object[] {
            "首检",
            "PQS",
            "尾检",
            "停机30分钟后首检",
            "设备维修后首检"});
            this.detectType1_comboBox.Location = new System.Drawing.Point(108, 107);
            this.detectType1_comboBox.Name = "detectType1_comboBox";
            this.detectType1_comboBox.Size = new System.Drawing.Size(117, 29);
            this.detectType1_comboBox.TabIndex = 1;
            this.detectType1_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // inspector1_comboBox
            // 
            this.inspector1_comboBox.FormattingEnabled = true;
            this.inspector1_comboBox.Location = new System.Drawing.Point(342, 57);
            this.inspector1_comboBox.Name = "inspector1_comboBox";
            this.inspector1_comboBox.Size = new System.Drawing.Size(102, 29);
            this.inspector1_comboBox.TabIndex = 1;
            this.inspector1_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "项目号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "抽检人员：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "检查类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "线体号：";
            // 
            // line1_comboBox
            // 
            this.line1_comboBox.FormattingEnabled = true;
            this.line1_comboBox.Items.AddRange(new object[] {
            "I线"});
            this.line1_comboBox.Location = new System.Drawing.Point(108, 57);
            this.line1_comboBox.Name = "line1_comboBox";
            this.line1_comboBox.Size = new System.Drawing.Size(117, 29);
            this.line1_comboBox.TabIndex = 1;
            this.line1_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(468, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label73);
            this.tabPage8.Controls.Add(this.label72);
            this.tabPage8.Controls.Add(this.label71);
            this.tabPage8.Controls.Add(this.label70);
            this.tabPage8.Controls.Add(this.label69);
            this.tabPage8.Controls.Add(this.label64);
            this.tabPage8.Controls.Add(this.label65);
            this.tabPage8.Controls.Add(this.label66);
            this.tabPage8.Controls.Add(this.label67);
            this.tabPage8.Controls.Add(this.label68);
            this.tabPage8.Controls.Add(this.wightLable5);
            this.tabPage8.Controls.Add(this.wightLable4);
            this.tabPage8.Controls.Add(this.wightLable3);
            this.tabPage8.Controls.Add(this.wightLable2);
            this.tabPage8.Controls.Add(this.wightLable1);
            this.tabPage8.Controls.Add(this.label62);
            this.tabPage8.Controls.Add(this.button31);
            this.tabPage8.Controls.Add(this.textBox28);
            this.tabPage8.Controls.Add(this.textBox27);
            this.tabPage8.Controls.Add(this.textBox26);
            this.tabPage8.Controls.Add(this.textBox31);
            this.tabPage8.Controls.Add(this.textBox30);
            this.tabPage8.Controls.Add(this.button30);
            this.tabPage8.Location = new System.Drawing.Point(4, 36);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage8.Size = new System.Drawing.Size(1894, 861);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "首次称重";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(777, 205);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(25, 27);
            this.label73.TabIndex = 60;
            this.label73.Text = "g";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(957, 205);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(25, 27);
            this.label72.TabIndex = 59;
            this.label72.Text = "g";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(1139, 205);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(25, 27);
            this.label71.TabIndex = 58;
            this.label71.Text = "g";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(1498, 205);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(25, 27);
            this.label70.TabIndex = 57;
            this.label70.Text = "g";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(1322, 205);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(25, 27);
            this.label69.TabIndex = 56;
            this.label69.Text = "g";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(1406, 160);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(52, 27);
            this.label64.TabIndex = 51;
            this.label64.Text = "右后";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(1226, 160);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(52, 27);
            this.label65.TabIndex = 52;
            this.label65.Text = "左后";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(1040, 160);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(52, 27);
            this.label66.TabIndex = 53;
            this.label66.Text = "居中";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(861, 160);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(52, 27);
            this.label67.TabIndex = 54;
            this.label67.Text = "右前";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(682, 160);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(52, 27);
            this.label68.TabIndex = 55;
            this.label68.Text = "左前";
            // 
            // wightLable5
            // 
            this.wightLable5.AutoSize = true;
            this.wightLable5.Location = new System.Drawing.Point(1382, 255);
            this.wightLable5.Name = "wightLable5";
            this.wightLable5.Size = new System.Drawing.Size(0, 27);
            this.wightLable5.TabIndex = 13;
            // 
            // wightLable4
            // 
            this.wightLable4.AutoSize = true;
            this.wightLable4.Location = new System.Drawing.Point(1214, 255);
            this.wightLable4.Name = "wightLable4";
            this.wightLable4.Size = new System.Drawing.Size(0, 27);
            this.wightLable4.TabIndex = 12;
            // 
            // wightLable3
            // 
            this.wightLable3.AutoSize = true;
            this.wightLable3.Location = new System.Drawing.Point(1031, 255);
            this.wightLable3.Name = "wightLable3";
            this.wightLable3.Size = new System.Drawing.Size(0, 27);
            this.wightLable3.TabIndex = 11;
            // 
            // wightLable2
            // 
            this.wightLable2.AutoSize = true;
            this.wightLable2.Location = new System.Drawing.Point(845, 255);
            this.wightLable2.Name = "wightLable2";
            this.wightLable2.Size = new System.Drawing.Size(0, 27);
            this.wightLable2.TabIndex = 10;
            // 
            // wightLable1
            // 
            this.wightLable1.AutoSize = true;
            this.wightLable1.Location = new System.Drawing.Point(665, 255);
            this.wightLable1.Name = "wightLable1";
            this.wightLable1.Size = new System.Drawing.Size(0, 27);
            this.wightLable1.TabIndex = 9;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(640, 333);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(414, 27);
            this.label62.TabIndex = 8;
            this.label62.Text = "校称标准：1KG误差1G、500G误差0.5G以内";
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(369, 242);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(174, 52);
            this.button31.TabIndex = 7;
            this.button31.Text = "提交数据";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(1007, 202);
            this.textBox28.Name = "textBox28";
            this.textBox28.ShortcutsEnabled = false;
            this.textBox28.Size = new System.Drawing.Size(126, 34);
            this.textBox28.TabIndex = 6;
            this.textBox28.TextChanged += new System.EventHandler(this.textBox28_TextChanged);
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(825, 202);
            this.textBox27.Name = "textBox27";
            this.textBox27.ShortcutsEnabled = false;
            this.textBox27.Size = new System.Drawing.Size(126, 34);
            this.textBox27.TabIndex = 5;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(645, 202);
            this.textBox26.Name = "textBox26";
            this.textBox26.ShortcutsEnabled = false;
            this.textBox26.Size = new System.Drawing.Size(126, 34);
            this.textBox26.TabIndex = 4;
            this.textBox26.TextChanged += new System.EventHandler(this.textBox26_TextChanged);
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(1366, 202);
            this.textBox31.Name = "textBox31";
            this.textBox31.ShortcutsEnabled = false;
            this.textBox31.Size = new System.Drawing.Size(126, 34);
            this.textBox31.TabIndex = 3;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(1190, 202);
            this.textBox30.Name = "textBox30";
            this.textBox30.ShortcutsEnabled = false;
            this.textBox30.Size = new System.Drawing.Size(126, 34);
            this.textBox30.TabIndex = 2;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(369, 151);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(174, 52);
            this.button30.TabIndex = 1;
            this.button30.Text = "开始校秤";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = " ";
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(10, 142);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1902, 901);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(135)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.lightUpDown);
            this.Controls.Add(this.recordStatus);
            this.Controls.Add(this.callStatus);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lightStatus);
            this.Controls.Add(this.scanGunStatus);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.timeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.lightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanGunStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordStatus)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatus1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatus2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort balanceSerialPort;
        private System.IO.Ports.SerialPort lightSerialPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox scanGunStatus;
        private System.Windows.Forms.PictureBox callStatus;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.PictureBox lightStatus;
        private System.Windows.Forms.NumericUpDown lightUpDown;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label28;
        private Label label43;
        private PictureBox recordStatus;
        private Label label49;
        private Label label50;
        private Label label51;
        private TabPage tabPage7;
        private GroupBox groupBox13;
        private Button button28;
        private Label label36;
        private Label label37;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private DataGridView dataGridView5;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn Column27;
        private DataGridViewTextBoxColumn Column28;
        private DataGridViewTextBoxColumn Column29;
        private GroupBox groupBox12;
        private Button button25;
        private Button button19;
        private Button button21;
        private Button button20;
        private Button button18;
        private Button button16;
        private Button button15;
        private Label label35;
        private Label label34;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView4;
        private TabPage tabPage6;
        private GroupBox groupBox11;
        private Button button14;
        private Button button13;
        private TextBox textBox23;
        private ComboBox comboBox11;
        private Label label39;
        private Label label41;
        private TabPage tabPage5;
        private GroupBox groupBox16;
        private ComboBox comboBox1;
        private Button button24;
        private Label label55;
        private Button button3;
        private TextBox textBox5;
        private Label label54;
        private TextBox txtLog;
        private TabPage tabPage4;
        private GroupBox groupBox10;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private GroupBox groupBox5;
        private Button button6;
        private Button button5;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private Label label15;
        private Label label14;
        private TabPage tabPage3;
        private GroupBox groupBox14;
        private Label time12_label;
        private Label time11_label;
        private Label time10_label;
        private Label time9_label;
        private Label time8_label;
        private Label time7_label;
        private Label time6_label;
        private Label time5_label;
        private Label time4_label;
        private Label time3_label;
        private Label time2_label;
        private Label time1_label;
        private DataGridView dataGridView6;
        private GroupBox groupBox7;
        private Button button10;
        private ComboBox comboBox6;
        private Label label31;
        private PictureBox taskStatus1;
        private TextBox redCountBox;
        private TextBox detectType2_Box;
        private TextBox spotCheckCountBox;
        private TextBox yellowCountBox;
        private TextBox projectNameBox;
        private Label label23;
        private ComboBox line2_comboBox;
        private Label label22;
        private ComboBox inspector2_comboBox;
        private Label label16;
        private TextBox stdPrintCodeBox;
        private TextBox sapCodeBox;
        private Label label20;
        private Label label21;
        private Label label17;
        private Label label18;
        private Label label25;
        private Label label26;
        private Label label19;
        private GroupBox groupBox9;
        private Label label80;
        private Label label79;
        private Label label78;
        private Label label77;
        private Label label76;
        private Label label75;
        private Label label74;
        private Button button32;
        private TextBox tubWeightBox;
        private Label LabelWight6;
        private Label LabelWight5;
        private Label LabelWight4;
        private Label LabelWight3;
        private Label LabelWight2;
        private Label LabelWight1;
        private PictureBox taskStatus2;
        private Button endBtn;
        private Button button22;
        private Button button4;
        private Button button11;
        private TextBox tubWeightBox6;
        private TextBox tubWeightBox5;
        private TextBox tubWeightBox4;
        private TextBox tubWeightBox3;
        private TextBox tubWeightBox2;
        private TextBox tubWeightBox1;
        private ComboBox defect_comboBox;
        private ComboBox line3_comboBox;
        private ComboBox inspector3_comboBox;
        private Label label27;
        private Label label29;
        private Label label30;
        private Label label32;
        private TabPage tabPage1;
        private GroupBox groupBox15;
        private PictureBox status3;
        private PictureBox status2;
        private PictureBox arrow3;
        private PictureBox arrow2;
        private PictureBox status1;
        private Label statusCountLabel;
        private Label label48;
        private Label label47;
        private Label label46;
        private GroupBox groupBox6;
        private Label labelControlRoi1;
        private GroupBox groupBox4;
        private Button button23;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label12;
        private Label label13;
        private GroupBox groupBox3;
        private Button button33;
        private TextBox textBox35;
        private TextBox textBox34;
        private Label label9;
        private TextBox outerSapBox;
        private Button button9;
        private TextBox outerProductBatchBox;
        private Label label10;
        private GroupBox groupBox8;
        private Label label60;
        private Label label59;
        private TextBox backlabelingprojectnum;
        private TextBox textBox22;
        private TextBox labelingprojectnum;
        private TextBox textBox25;
        private Button button29;
        private Button button27;
        private Label label57;
        private Label label56;
        private Button button12;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button2;
        private TextBox stdProductBatchBox;
        private TextBox detectResultBox;
        private HalconDotNet.HSmartWindowControl hSmartWin11;
        private Label label52;
        private TextBox textBox_ip;
        private Label label53;
        private TextBox textBox_port;
        private TextBox textBox11;
        private Label label24;
        private TextBox textBox12;
        private Label label33;
        private TextBox textBox14;
        private TextBox textBox13;
        private Label label38;
        private TextBox textBox16;
        private TextBox textBox15;
        private Label label42;
        private TextBox textBox18;
        private TextBox textBox17;
        private GroupBox groupBox2;
        private Button SureButton;
        private TextBox textBox_Name;
        private Label label63;
        private TextBox textBox33;
        private TextBox textBox32;
        private TextBox textBox4;
        private TextBox textBox29;
        private Label label7;
        private TextBox textBox21;
        private TextBox textBox24;
        private Label label61;
        private TextBox textBox19;
        private TextBox textBox20;
        private Label label58;
        private TextBox textBox10;
        private TextBox textBox9;
        private Label label5;
        private Label label11;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label8;
        private GroupBox groupBox1;
        private Button button8;
        private Button startBtn;
        private Button button17;
        private Button button7;
        private TextBox textBox1;
        private ComboBox detectType1_comboBox;
        private ComboBox inspector1_comboBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox line1_comboBox;
        private PictureBox pictureBox4;
        private TabPage tabPage8;
        private Label label73;
        private Label label72;
        private Label label71;
        private Label label70;
        private Label label69;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label wightLable5;
        private Label wightLable4;
        private Label wightLable3;
        private Label wightLable2;
        private Label wightLable1;
        private Label label62;
        private Button button31;
        private TextBox textBox28;
        private TextBox textBox27;
        private TextBox textBox26;
        private TextBox textBox31;
        private TextBox textBox30;
        private Button button30;
        private TabControl tabControl1;
        private Button button1;
        private DataGridViewTextBoxColumn Column30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column46;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column22;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column24;
        private DataGridViewTextBoxColumn Column25;
        private DataGridViewTextBoxColumn Column26;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column31;
        private DataGridViewTextBoxColumn Column32;
        private DataGridViewTextBoxColumn Column33;
        private DataGridViewTextBoxColumn Column34;
        private DataGridViewTextBoxColumn Column35;
        private DataGridViewTextBoxColumn Column36;
        private DataGridViewTextBoxColumn Column37;
        private DataGridViewTextBoxColumn Column38;
        private DataGridViewTextBoxColumn Column39;
        private DataGridViewTextBoxColumn Column40;
        private DataGridViewTextBoxColumn Column41;
        private DataGridViewTextBoxColumn Column42;
        private DataGridViewTextBoxColumn Column43;
        private DataGridViewTextBoxColumn Column44;
        private DataGridViewTextBoxColumn Column45;
        private CheckBox checkBox1;
        private Button button26;
        private Timer timer2;
        private CheckBox checkBox2;
        private Label time16_label;
        private Label time15_label;
        private Label time14_label;
        private Label time13_label;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}

