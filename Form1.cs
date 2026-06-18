using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using System.Collections.Concurrent;
using WindowsFormsApp5.Properties;
using System.Diagnostics;
using NAudio;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using DeviceControllor;
using IniReadWrite;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;
using System.Timers;
using System.Globalization;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            // 初始化 Form2 实例
            form2 = new Form2();
            form3 = new Form3();
            form2.ButtonClicked += Form2_ButtonClicked; // 订阅 Form2 的 ButtonClicked 事件
            form3.ButtonClicked += Form3_ButtonClicked; // 订阅 Form2 的 ButtonClicked 事件
            InitializeTimer();
            OnInitDialog();

            m_form = this;
            m_SyncContext = SynchronizationContext.Current;
        }
        public bool cleanInfofg { get; set; } = false;//form3信息清零
        public bool cleanInfory { get; set; } = false;//form2信息清零
        SynchronizationContext m_SyncContext = null;
        private uint m_iCurrentDeviceId = 0;
        private ZHLED.LedAgent.OnDeviceNotify m_fCallback = new ZHLED.LedAgent.OnDeviceNotify(OnDeviceNotified);
        private static readonly Mutex LogMutex = new Mutex(); // 在类的成员变量中声明互斥锁
        private int m_isReady = 0;
        private static Form1 m_form = null;
        Socket socketSend;  // 服务器网络
        string socketreceive;
        private VideoCapture capture;
        bool isCapturing = true;
        MySqlConnection connection; // 创建数据库连接对象
        MySqlConnection connection2; // 创建数据库连接对象
        private const string ReadDbConnectionString = "server=172.16.16.13;user=ecrqs_xy;password=ecrqs_xy;database=unilevermes_production;Connection Timeout=3;Default Command Timeout=5;Pooling=true";
        private const string WriteDbConnectionString = "server=172.16.19.1;user=ecrqs_xy;password=ecrqs_xy;database=ecrqs_data;Charset=utf8mb4;Connection Timeout=3;Default Command Timeout=5;Pooling=true";
        private DateTime lastDbHealthCheckTime = DateTime.MinValue;
        private volatile bool isDbHealthChecking = false;
        private volatile bool readDbOk = false;
        private volatile bool writeDbOk = false;
        string detect_type = "";
        string line;
        string inspector;  // 抽检人
        string project_num;  // 项目号
        string project_name;//项目名称
        string version_num;//SAP码
        string name_textbox_text;
        string labeling_project_num; //正标
        string back_label_project_num;//背标
        string cover_project_num;//盖子
        int sleep = 1000;
        string product_name;  // 产品名称
        float bead_weight;  // 凝珠重量
        float tub_weight;  // 小盒重量
        int tub_count;  // 小盒数量
        string tub_bar_code; // 小盒扫码
        string bead_project_num;    // 凝珠项目号   ？？？
        string tub_project_num;    // 凝珠项目号
        string outer_project_num;   // 外箱项目号
        int print_code_delay = 0;  // 打印延期
        string tub_print_rule; // 小盒喷码规则
        string outer_print_rule; // 外箱喷码规则
        string Current_weighing_time;//首次称重时间
        int board_box_count; // 整板数
        string Weighing_status;
        string project_id;
        string order_id;//订单号
        string grid_block; //格挡
        string strick;
        string sapCode;
        object tubweight; //重量
        int stamp_box_num;// 板数
        int num = 6;
        int firstweight = 5;
        bool openweight = false;
        bool qupi = false;
        DateTime detect_time; // 抽检时间
        DateTime rework_time; // 抽检时间
        TextBox[] textBoxes = new TextBox[8]; // 称重数组
        TextBox[] firsttextBoxes = new TextBox[5]; // 称重数组
        Label[] fistWiG_OK_NG = new Label[5];//首次称重提示label
        Label[] wight_OK_NG = new Label[6];//称重提示label
        TextBox[] readInfo = new TextBox[4];//打码格式及称重标准中接收的数据
        TextBox[] writeInfo = new TextBox[4];//写入的数据

        Label[] labels = new Label[16];
        float[] tub_weights = new float[6];
        float[] firstub_weights = new float[5];
        string[] texts = new string[6];
        string classes = "白夜班";
        string shift = ""; // 班次
        bool personSure = false;
        string sap_code = "SAP号";
        string product_batch = "12位码";
        int yellow_light_count = 0;
        int red_light_count = 0;

        string detailed_information = "细节描述";
        string defect_rework_description = "";
        int rework_count = 0;
        int ng_count = 0;
        string notes = "备注";
        int total_count = 6;
        public string rework_result = "无";  // *重置
        string stdPrintCode = "";
        bool wightWriteInfo;//是否提交过称重数据
        int spotCheckCount = 0;   // 抽检总数
        int yellowLightTotalCount = 0; // 黄灯总数
        int redLightTotalCount = 0; // 黄灯总数
        // 获取桌面路径
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        // 配置文件类
        private IniConfig sys_ini;
        int locktime = 0;
        string pathuser = Application.StartupPath + "\\temporary.ini";
        Thread startListen_th;
        Thread Listen_th;
        Thread Recive_th;
        Socket socketWatch;
        bool weightresult = false;
        bool selectpage = false;
        bool fistWeighing = false;//判断是否进行称重首检
        string photograph = "";
        //bool btnSure = false;//数据确认是否通过
        bool camOn = false;
        string picName;
        string picFile = @"D:\Saveimage\";
        string[] nameSql = new string[5];
        string[] nameNoRead = new string[8];
        bool isDoing = false;//是否处于检测状态中
        bool endDoing = false;//若计时到时，处于检测状态，为true，在结束后清除
        //9.12新增mes抓取，breakpoint1
        string printlabel = ""; // mes抓取保质期字段
        string bottle_printing = ""; // mes抓取瓶身打码字段

        #region 流程管理
        // B线
        int processX_1;
        int processX_2;
        int processX_3;
        // Y线
        int processY_1;
        int processY_2;
        int processY_3;

        // Z线
        int processZ_1;
        int processZ_2;
        int processZ_3;
        // 灯
        int yellow_total_lightX;
        int red_total_lightX;
        int OK_total_lightX;
        int detect_total_countX;
        int yellow_total_lightY;
        int red_total_lightY;
        int OK_total_lightY;
        int detect_total_countY;
        int yellow_total_lightZ;
        int red_total_lightZ;
        int OK_total_lightZ;
        int detect_total_countZ;

        string[] defect_status_X = new string[192];
        string[] defect_status_Y = new string[144];
        string[] defect_status_Z = new string[144];

        string[] time_labelX = { "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中" };
        string[] time_labelY = { "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中" };
        string[] time_labelZ = { "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中", "待检入中" };

        int delay_timeX = 0;
        int delay_timeY = 0;
        int delay_timeZ = 0;

        string transfer = ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,";

        //  string transfer = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
        string transfer_label = "待检入中,待检入中,待检入中,待检入中,待检入中,待检入中,待检入中,待检入中,待检入中,待检入中,待检入中,待检入中,待检入中,待检入中,待检入中,待检入中";
        #endregion

        // 光源亮度值
        int lightValue;

        string[] red_bag_defects = { "1-印刷-颜色", "2-印刷-包装", "3-印刷-文字", "4-清洁-灰尘", "5-清洁-污渍/脏/油腻", "6-产品外观", "7-净重偏差", "8-灌装高度偏差", "9-异物", "10-产品颜色/分层/相分离", "11-组装-缺失", "12-组装-错误", "13-包装材料分层", "14-破损-开裂", "15-损坏-挤压/变形/褶痕/撕开", "16-损坏-破孔", "17-损坏-划痕/磨损", "18-开启装置-配合松弛", "19-封边-对齐", "20-封边-烧焦", "21-封边-损坏", "22-封边-叠接", "23-包装外的收缩膜-完整性", "24-条形码-可读性/缺失/位置", "25-生产打码-缺失/不清楚/位置" };

        string[] red_bottle_defects = { "1-标贴/束膜/包装纸(膜)-位置", "2-标贴/束膜-附贴", "3-标贴/束膜-损坏", "4-印刷-颜色", "5-印刷-文字", "6-印刷-包装,标贴或小袋膜切割/定位", "7-清洁-灰尘", "8-清洁-污渍/脏/油腻", "9-气泡/空气窝眼", "10-净重偏差", "11-灌装高度偏差", "12-异物", "13-产品外观(指透明包装)", "14-产品颜色/分层/相分离", "15-组装-缺失", "16-组装-错误", "17-锋利边缘", "18-防篡改装置", "19-破损-开裂", "20-损坏-挤压/变形/褶痕/撕裂", "21-损坏-破孔", "22-损坏-划痕/磨损", "23-锁紧装置", "24-开启装置-配合松弛", "25-喷枪/泵/驱动装置-错位", "26-条形码-可读性/缺失/位置", "27-生产打码-缺失/不清楚/位置" };

        //音频播放全局变量
        WaveOutEvent waveOut; // WaveOutEvent对象
        AudioFileReader audioFileReader;// 音频文件



        // 定义委托来接收子窗口传来的文本 
        private Form2 form2;
        private Form3 form3;

        bool b7b17 = false;

        private System.Timers.Timer timer;

        // Form1加载 
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button27.Enabled = false;
            button29.Enabled = false;
            for (int i = 0; i < IniAPI.INIGetAllItemKeys(pathuser, "员工信息").Length; i++)
            {
                inspector1_comboBox.Items.Add(IniAPI.INIGetAllItemKeys(pathuser, "员工信息")[i]);
                comboBox1.Items.Add(IniAPI.INIGetAllItemKeys(pathuser, "员工信息")[i]);

            }
            fistWeighing = Convert.ToBoolean(IniAPI.INIGetStringValue(pathuser, "是否首检", "首检", ""));
            inspector1_comboBox.Text = IniAPI.INIGetStringValue(pathuser, "当班主操", "主操", "");
            fistWeighing = Convert.ToBoolean(IniAPI.INIGetStringValue(pathuser, "是否首检", "首检", ""));
            tubWeightBox.Text = IniAPI.INIGetStringValue(pathuser, "去皮", "皮重", "");
            tubWeightBox1.Enabled = false;
            tubWeightBox2.Enabled = false;
            tubWeightBox3.Enabled = false;
            tubWeightBox4.Enabled = false;
            tubWeightBox5.Enabled = false;
            tubWeightBox6.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            line1_comboBox.Text = "B线";
            textBox26.Enabled = false;
            textBox27.Enabled = false;
            textBox28.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;

            label56.Text = label57.Text = label59.Text = label60.Text = "";
            WindowState = FormWindowState.Maximized;
            AppBaseDir = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            HOperatorSet.SetSystem("clip_region", "false");

            textBoxes[0] = tubWeightBox1;
            textBoxes[1] = tubWeightBox2;
            textBoxes[2] = tubWeightBox3;
            textBoxes[3] = tubWeightBox4;
            textBoxes[4] = tubWeightBox5;
            textBoxes[5] = tubWeightBox6;

            firsttextBoxes[0] = textBox26;
            firsttextBoxes[1] = textBox27;
            firsttextBoxes[2] = textBox28;
            firsttextBoxes[3] = textBox30;
            firsttextBoxes[4] = textBox31;

            wight_OK_NG[0] = LabelWight1;
            wight_OK_NG[1] = LabelWight2;
            wight_OK_NG[2] = LabelWight3;
            wight_OK_NG[3] = LabelWight4;
            wight_OK_NG[4] = LabelWight5;
            wight_OK_NG[5] = LabelWight6;

            fistWiG_OK_NG[0] = wightLable1;
            fistWiG_OK_NG[1] = wightLable2;
            fistWiG_OK_NG[2] = wightLable3;
            fistWiG_OK_NG[3] = wightLable4;
            fistWiG_OK_NG[4] = wightLable5;

            readInfo[0] = textBox9;
            //readInfo[1] = textBox12;
            //readInfo[2] = textBox14;
            //readInfo[3] = textBox16;
            //readInfo[4] = textBox18;
            readInfo[1] = textBox20;
            readInfo[2] = textBox24;
            readInfo[3] = textBox29;

            writeInfo[0] = textBox10;
            //writeInfo[1] = textBox11;
            //writeInfo[2] = textBox13;
            //writeInfo[3] = textBox15;
            //writeInfo[4] = textBox17;
            writeInfo[1] = textBox19;
            writeInfo[2] = textBox21;
            writeInfo[3] = textBox4;


            labels[0] = time1_label;
            labels[1] = time2_label;
            labels[2] = time3_label;
            labels[3] = time4_label;
            labels[4] = time5_label;
            labels[5] = time6_label;
            labels[6] = time7_label;
            labels[7] = time8_label;
            labels[8] = time9_label;
            labels[9] = time10_label;
            labels[10] = time11_label;
            labels[11] = time12_label;
            labels[12] = time13_label;
            labels[13] = time14_label;
            labels[14] = time15_label;
            labels[15] = time16_label;

            defect_comboBox.Text = "软袋";
            timer1.Start();
            sys_ini = new IniConfig("./config.ini");
            serialPort1.PortName = sys_ini.ReadKey("scan_gun_protName");
            scan_gun_start();
            lightSerialPort.PortName = sys_ini.ReadKey("light_protName");
            balanceSerialPort.PortName = sys_ini.ReadKey("balance_protName");
            // 
            // B线
            processX_1 = Convert.ToInt32(sys_ini.ReadKey("processX_1"));   // 读取配置
            processX_2 = Convert.ToInt32(sys_ini.ReadKey("processX_2"));   // 读取配置
            processX_3 = Convert.ToInt32(sys_ini.ReadKey("processX_3"));   // 读取配置
            // Y线
            processY_1 = Convert.ToInt32(sys_ini.ReadKey("processY_1"));   // 读取配置
            processY_2 = Convert.ToInt32(sys_ini.ReadKey("processY_2"));   // 读取配置
            processY_3 = Convert.ToInt32(sys_ini.ReadKey("processY_3"));   // 读取配置

            // Z线
            processZ_1 = Convert.ToInt32(sys_ini.ReadKey("processZ_1"));   // 读取配置
            processZ_2 = Convert.ToInt32(sys_ini.ReadKey("processZ_2"));   // 读取配置
            processZ_3 = Convert.ToInt32(sys_ini.ReadKey("processZ_3"));   // 读取配置

            // 数量计数
            yellow_total_lightX = Convert.ToInt32(sys_ini.ReadKey("yellow_total_lightX"));    // 读取配置
            red_total_lightX = Convert.ToInt32(sys_ini.ReadKey("red_total_lightX"));          // 读取配置
            detect_total_countX = Convert.ToInt32(sys_ini.ReadKey("detect_total_countX"));    // 读取配置
            yellow_total_lightY = Convert.ToInt32(sys_ini.ReadKey("yellow_total_lightY"));    // 读取配置
            red_total_lightY = Convert.ToInt32(sys_ini.ReadKey("red_total_lightY"));          // 读取配置
            detect_total_countY = Convert.ToInt32(sys_ini.ReadKey("detect_total_countY"));    // 读取配置
            yellow_total_lightZ = Convert.ToInt32(sys_ini.ReadKey("yellow_total_lightZ"));    // 读取配置
            red_total_lightZ = Convert.ToInt32(sys_ini.ReadKey("red_total_lightZ"));          // 读取配置
            detect_total_countZ = Convert.ToInt32(sys_ini.ReadKey("detect_total_countZ"));    // 读取配置



            string aa = sys_ini.ReadKey("defect_status_X");
            int hah = aa.Length;
            // 状态展示
            defect_status_X = sys_ini.ReadKey("defect_status_X").Split(',');   // 读取配置
            defect_status_Y = sys_ini.ReadKey("defect_status_Y").Split(',');   // 读取配置
            defect_status_Z = sys_ini.ReadKey("defect_status_Z").Split(',');   // 读取配置

            time_labelX = sys_ini.ReadKey("time_labelX").Split(',');   // 读取配置
            time_labelY = sys_ini.ReadKey("time_labelY").Split(',');   // 读取配置
            time_labelZ = sys_ini.ReadKey("time_labelZ").Split(',');   // 读取配置

            dataGridInit(); // 展示dataGrid初始化
            // 更新ROI
            string roi = "";
            roi = sys_ini.ReadKey("roi1");
            LoadROI(roi);
            labelControlRoi1.Text = roi;
            HOperatorSet.GenEmptyObj(out ho_Image1);
            HOperatorSet.GenEmptyObj(out ho_ROI_0);

            hwin11 = hSmartWin11.HalconWindow;

            open_mysql_connect(); // 连接数据库



            Thread th_deep = new Thread(load_deep);
            th_deep.IsBackground = true;
            th_deep.Start();

            //初始化
            Initialize();
            //打开添加LED  
            openLED();

            //称启动
            startListen();


            update_text("B线PQS检测台" + "             ");

            line1_comboBox.Text = "B线";
            line3_comboBox.Text = line2_comboBox.Text = line = line1_comboBox.Text;

        }
        private void InitializeTimer()//每500ms检查一下时间
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(TimerElapsed);
            timer.Interval = 500; // 1 minute (adjust this interval as needed)
            timer.Enabled = true;
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)//判断当前时间是否为7：00或12：00
        {
            // Check the time and set isButtonClicked to false if it's 7:00 or 12:00
            if (DateTime.Now.ToString("HH:mm:ss") == new TimeSpan(07, 30, 00).ToString() || DateTime.Now.ToString("HH:mm:ss") == new TimeSpan(12, 00, 00).ToString() || DateTime.Now.ToString("HH:mm:ss") == new TimeSpan(19, 30, 00).ToString() || DateTime.Now.ToString("HH:mm:ss") == new TimeSpan(00, 00, 00).ToString())
            {
                fistWeighing = false;
                IniAPI.INIWriteValue(pathuser, "是否首检", "首检", fistWeighing.ToString());
                if (!isDoing)
                {
                    inspector1_comboBox.Text = "";
                    IniAPI.INIWriteValue(pathuser, "当班主操", "主操", inspector1_comboBox.Text);
                }
                else
                {
                    endDoing = true;
                }
            }
           
        }


        // 加载深度模型
        private void load_deep()
        {
            //加载深度学习
            hv_DeepOcrHandle.Dispose();
            HOperatorSet.CreateDeepOcr(new HTuple(), new HTuple(), out hv_DeepOcrHandle);
            set_suitable_device(hv_DeepOcrHandle);
        }
        //开始监听
        void startListen()
        {
            try
            {
                // 当点击监听的时候，在服务器端创建一个负责监听IP地址跟端口好的Socket
                socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;
                // 创建端口对象
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(81));
                //监听
                socketWatch.Bind(point);
                ShowMsg("监听成功");
                socketWatch.Listen(1);

                startListen_th = new Thread(Listen);
                startListen_th.IsBackground = true;
                startListen_th.Start(socketWatch);
            }
            catch (Exception ex)
            {
                ShowMsg("启动监听过程中出现了异常");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
        }

        //客户端监听
        void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            // 等待客户端的连接，并且创建一个负责通信的Socket
            while (true)
            {
                try
                {
                    // 负责跟客户端通信的Socket
                    socketSend = socketWatch.Accept();
                    // 将远程连接客户端的IP地址和Socket存入集合中

                    IPEndPoint remoteIpEndPoint = (IPEndPoint)socketSend.RemoteEndPoint;
                    IPAddress clientIP = remoteIpEndPoint.Address;
                    ShowMsg(clientIP.ToString());


                    // 开启一个新的线程不停地接收客户端发送过来的消息
                    Listen_th = new Thread(Recive);
                    Listen_th.IsBackground = true;
                    Listen_th.Start(socketSend);
                }
                catch (Exception ex)
                {
                    ShowMsg("监听过程中出现了异常");
                    ShowMsg("错误行：" + ex.StackTrace.ToString());
                }


            }

        }
        //客户端接受
        void Recive(object o)
        {

            int r = 0;
            Socket socketSend = o as Socket;
            IPAddress clientIP = ((IPEndPoint)socketSend.RemoteEndPoint).Address;
            while (true)
            {
                try
                {
                    // 客户端连接成功后，服务器应该接收客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    // 实际接收到的额有效自己说
                    r = socketSend.Receive(buffer);

                    socketreceive = Encoding.UTF8.GetString(buffer, 0, r);
                    if (openweight)
                    {
                        string str = socketreceive.Trim();
                        string weight_word = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[5];//[50];
                        float tub_weight = (float.Parse(weight_word));// * 1000
                        if (num < 6)
                        {
                            Thread.Sleep(10);
                            tub_weights[num] = tub_weight - (float)Convert.ToDouble(tubWeightBox.Text);
                            textBoxes[num].Text = tub_weights[num].ToString();
                            double a = Convert.ToDouble(textBoxes[num].Text);
                            if (a < (Convert.ToDouble(tubweight)))
                            {
                                wight_OK_NG[num].Text = "NG";
                                wight_OK_NG[num].ForeColor = Color.Red;
                                //weightresult = true;
                            }
                            num += 1;
                        }
                        if (firstweight < 5)
                        {
                            firstub_weights[firstweight] = tub_weight;
                            firsttextBoxes[firstweight].Text = firstub_weights[firstweight].ToString();
                            double a = Convert.ToDouble(firsttextBoxes[firstweight].Text);
                            bool isOKorNG = false;
                            if (a > 499.5 && a < 500.5)
                            {
                                isOKorNG = true;
                            }
                            else if (a > 999 && a < 1001)
                            {
                                isOKorNG = true;
                            }

                            if (!isOKorNG)
                            {
                                fistWiG_OK_NG[firstweight].Text = "NG";
                                fistWiG_OK_NG[firstweight].ForeColor = Color.Red;
                            }
                            //else//暂时注掉，NG显示就好
                            //{
                            //    fistWiG_OK_NG[firstweight].Text = "OK";
                            //    fistWiG_OK_NG[firstweight].ForeColor = Color.Green ;
                            //}
                            firstweight += 1;
                        }
                        else
                        {
                            continue;
                        }
                        ShowMsg(socketreceive);
                    }
                    else if (qupi)
                    {
                        string str = socketreceive.Trim();
                        string weight_word = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[5];//[50];
                        float tub_weight = (float.Parse(weight_word));// * 1000
                        this.tubWeightBox.Enabled = true;
                        this.tubWeightBox.ReadOnly = true;
                        Thread.Sleep(10);
                        Task.Run(() => { this.tubWeightBox.Text = weight_word; });
                        Thread.Sleep(10);
                        qupi = true;
                    }
                    else
                    {
                        continue;
                    }

                }
                catch (Exception ex)
                {

                    if (ex.Message != "远程主机强迫关闭了一个现有的连接。")
                    {
                        ShowMsg("【异常】" + ex.Message);
                        ShowMsg("错误行：" + ex.StackTrace.ToString());
                        break;
                    }
                }
            }

            //if (weightresult)
            //{
            //   MessageBoxShow("重量NG，请录入");
            //    form2.MessageFromForm1 = defect_comboBox.Text;
            //    // 显示 Form2 窗口
            //    form2.Show();
            //    form2.updataFrom();

            //}
        }
        //构造函数，禁用跨线程调用检查 

        // 扫码枪关闭
        private void button8_Click(object sender, EventArgs e)
        {
            textBox34.ReadOnly = false;
            textBox35.ReadOnly = false;
            textBox34.BackColor = Color.White;
            textBox35.BackColor = Color.White;
            outerProductBatchBox.BackColor = Color.White;
            outerSapBox.BackColor = Color.White;
            project_id = "";
            order_id = "";
            version_num = "";
            product_name = "";
            tub_weight = 0;
            tub_count = 0;
            stamp_box_num = 0;
            detectType1_comboBox.Enabled = false;
            outer_project_num = "";
            bead_project_num = "";
            labeling_project_num = "";
            strick = "";
            back_label_project_num = "";
            cover_project_num = "";
            grid_block = "";
            textBox1.Enabled = false;

            fistWeighing = Convert.ToBoolean(IniAPI.INIGetStringValue(pathuser, "是否首检", "首检", ""));
            if (!fistWeighing)
            {
               MessageBox.Show("请进行首次称重", "警告!", MessageBoxButtons.OK);
                detectType1_comboBox.Enabled = true;
                return;
            }
            if (line1_comboBox.Text == "" || inspector1_comboBox.Text == "" || detectType1_comboBox.Text == "")
            {
               MessageBoxShow("输入数据不完整，请重新输入");
                detectType1_comboBox.Enabled = true;
                return;
            }
            IniAPI.INIWriteValue(pathuser, "当班主操", "主操", inspector1_comboBox.Text);

            if (detect_type == "首检" || detectType1_comboBox.Text == "停机30分钟后首检" || detectType1_comboBox.Text == "设备维修后首检")
            {
                //if (processX_1 == 1)
                //{
                //   MessageBoxShow("您还没有进行PQS和尾检！");
                //    return;
                //}
            }
            //数据库流程

            if (detectType1_comboBox.Text == "PQS")
            {
                if (processX_1 == 0)
                {
                   MessageBoxShow("请先进行首检");
                    detectType1_comboBox.Enabled = true;
                    return;
                }
            }

            string line_code = "";
            int shelfLifeYears = 0;

            try
            {
                using (MySqlConnection readConnection = OpenReadConnection())
                {
                    string query1 = $"select * from msp_daily_plan where line_num = 'B' AND production_state = '1'";
                    using (MySqlCommand command = new MySqlCommand(query1, readConnection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Thread.Sleep(10);
                        if (reader.Read())
                        {
                            project_id = reader.GetString("project_id");
                            order_id = reader.GetString("id");//订单号
                            version_num = reader.GetString("version_num"); // SAP码
                            product_name = reader.GetString("name");
                        }
                        else
                        {
                            MessageBoxShow("未查询到订单");
                            return;
                        }
                    }

                string query2 = $"select * from msp_basicdata_product where code = '{project_id}' AND version_num = '{version_num}'";
                    using (MySqlCommand command2 = new MySqlCommand(query2, readConnection))
                    using (MySqlDataReader reader2 = command2.ExecuteReader())
                    {
                        Thread.Sleep(10);
                        if (reader2.Read())
                {
                    project_num = reader2.GetString("code");//项目号
                    bead_weight = reader2.GetFloat("weight_lower");//重量
                    tub_weight = reader2.GetFloat("weight_lower");//重量
                    project_name = reader2.GetString("name");//项目名称                             // board_count.Text = reader2.GetString("stamp_box_num"); 
                    stamp_box_num = Convert.ToInt32(ExtractNumberFromString(reader2.GetString("stamp_box_num")));// 板数
                    tub_count = Convert.ToInt32(ExtractNumberFromString(reader2.GetString("packaging_spec")));// 箱数                                                   
                }
                    }

                string query3 = $"select * from msp_basicdata_packing_material where product_spec = '{project_id}' AND version_num = '{version_num}'";
                    using (MySqlCommand command3 = new MySqlCommand(query3, readConnection))
                    using (MySqlDataReader reader3 = command3.ExecuteReader())
                    {
                Thread.Sleep(10);

            while (reader3.Read())
            {

                if (reader3.GetString("model") == "外箱")
                {
                    outer_project_num = reader3.GetString("code"); // 外箱

                }
                if (reader3.GetString("model").Contains("瓶"))
                {
                    bead_project_num = reader3.GetString("code"); // 标瓶，正背标没有的话用这个
                    if (bead_project_num == "")
                    {
                        nameSql[0] = "瓶";
                    }
                }
                else
                {
                    nameSql[0] = "瓶";

                }
                if (reader3.GetString("model") == "卷膜")
                {
                    bead_project_num = reader3.GetString("code"); // 标瓶，正背标没有的话用这个
                    if (bead_project_num == "")
                    {
                        nameSql[1] = "卷膜";

                    }
                }
                else
                {
                    nameSql[1] = "卷膜";

                }
                if (reader3.GetString("model") == "正标")
                {
                    labeling_project_num = reader3.GetString("code"); // 箱数
                    if (labeling_project_num == "")
                    {
                        nameSql[2] = "正标";

                    }
                }
                else
                {
                    nameSql[2] = "正标";

                }
                if (reader3.GetString("model") == " 标贴")
                {
                    strick = reader3.GetString("code"); // 箱数  

                }

                if (reader3.GetString("model") == "背标")
                {
                    back_label_project_num = reader3.GetString("code"); // 箱数  
                    if (back_label_project_num == "")
                    {
                        nameSql[3] = "背标";

                    }
                }
                else
                {
                    nameSql[3] = "背标";

                }
                if (reader3.GetString("model") == "盖子")
                {
                    cover_project_num = reader3.GetString("code"); // 箱数
                    if (cover_project_num == "")
                    {
                        nameSql[4] = "盖子";

                    }
                }
                else
                {
                    nameSql[4] = "盖子";

                }
                if (reader3.GetString("model") == "隔挡" || reader3.GetString("model") == "格挡" || reader3.GetString("model") == "格档" | reader3.GetString("model") == "隔档")
                {
                    grid_block = reader3.GetString("code"); // 箱数  

                }
            }
                    }
            if (cover_project_num == "" || bead_project_num == "" || labeling_project_num == "" || back_label_project_num == "")
            {
                //有时会出现数据库存在数据读不到的情况，再加上对应的model单独搜索一遍
                for (int i = 0; i < nameSql.Length; i++)
                {
                    if (nameSql[i] != "")
                    {
                        string query4 = $"select * from msp_basicdata_packing_material where product_spec = '{project_id}' AND version_num = '{version_num}'AND model='{nameSql[i]}' ";
                            using (MySqlCommand command4 = new MySqlCommand(query4, readConnection))
                            using (MySqlDataReader reader4 = command4.ExecuteReader())
                            {
                        if (reader4.Read())
                        {
                            switch (i)
                            {
                                case 0:
                                    bead_project_num = reader4.GetString("code");
                                    break;
                                case 1:
                                    bead_project_num = reader4.GetString("code");
                                    break;
                                case 2:
                                    labeling_project_num = reader4.GetString("code");
                                    break;
                                case 3:
                                    back_label_project_num = reader4.GetString("code");
                                    break;
                                case 4:
                                    cover_project_num = reader4.GetString("code");
                                    break;
                                default:
                                    break;
                            }
                        }
                            }
                    }
                }
            }
            if (back_label_project_num == "")
            {
                // back_label_project_num = bead_project_num;
                // textBox22.Enabled = false;
            }

            if (labeling_project_num == "")
            {
                labeling_project_num = bead_project_num;
                // textBox25.Enabled = false; 
            }
            selectpage = true;


            #region 流程管理
            if (line == "B线")
            {

                if (detect_type == "PQS")
                {
                    if (processX_1 == 0)
                    {
                       MessageBoxShow("您还没有进行首检");
                        return;
                    }

                    //processX_2 += 1;
                    if (processX_2 >= 12)
                    {
                        goto gotohere;
                    }
                    //sys_ini.WriteKey("processX_2", processX_2.ToString()); // 更新配置文件
                }
                else if (detect_type == "尾检")
                {
                    if (processX_1 == 0)
                    {
                       MessageBoxShow("您还没有进行首检");
                        return;
                    }
                    processX_3 += 1;
                    sys_ini.WriteKey("processX_3", processX_3.ToString()); // 更新配置文件
                }
                //detect_total_countX += 1;
                spotCheckCountBox.Text = (detect_total_countX * 6).ToString();
                sys_ini.WriteKey("detect_total_countX", detect_total_countX.ToString()); // 更新配置文件
                yellowCountBox.Text = yellow_total_lightX.ToString();
                redCountBox.Text = red_total_lightX.ToString();
                for (int i = 0; i < 32; i++)
                {

                    for (int j = 0; j < 6; j++)
                    {
                        int dataIndex = 6 * i + j; // 根据您的需求计算数据索引
                        dataGridView6.Rows[j + 1].Cells[i].Value = defect_status_X[dataIndex];
                    }
                }
                for (int i = 0; i < 16; i++)
                {
                    labels[i].Text = time_labelX[i];
                }
            }

        #endregion

        gotohere:
            detect_time = DateTime.Now;
            scan_gun_end();
            #region 数据库流程

            ShowMsg("OK");

            shift = GetShift();
            projectNameBox.Text = product_name;
            textBox1.Text = project_num;
            textBox2.Text = tub_print_rule;
            textBox_Name.Text = product_name;

            outer_print_rule = "YYYYMMDD XXXX" + "#" + "YYWWDXX";

            textBox6.Text = tub_weight.ToString();
            taskStatus1.Image = Resources.green_circle;
            taskStatus2.Image = Resources.green_circle;
            if (line != null)
            {
                line_code = line.Substring(0, 1);
            }
            else
            {
               MessageBoxShow("当前未开始生产！");
                return;
            }

            string changeP = "S0";
            if (checkBox4.Checked)
            {
                changeP = "P0";
             }

            outerSapBox.Text = sapCode = getSapCode(changeP);
            tub_print_rule = "YYYYMMDD XXXX";
            //stdPrintCode = std_product_batch(tub_print_rule, line_code);
            //stdPrintCode = stdPrintCode.Replace(" ", "");
            //int useYear = 0;//使用年限
            //useYear = Convert.ToInt32(stdPrintCode.Substring(0, 4)) + 3;
            //stdPrintCode = stdPrintCode.Substring(4, stdPrintCode.Length - 4);
            //stdPrintCode = useYear.ToString() + stdPrintCode;
                string queryPrint = "SELECT printlabel, bottle_printing FROM msp_basicdata_product WHERE code = @project_num AND version_num = @version_num";
                    using (var command2 = new MySqlCommand(queryPrint, readConnection))
                {
                    command2.Parameters.AddWithValue("@project_num", project_num);
                    command2.Parameters.AddWithValue("@version_num", version_num);

                    using (var reader2 = command2.ExecuteReader())
                    {
                        if (reader2.Read())
                        {
                            printlabel = reader2.IsDBNull(reader2.GetOrdinal("printlabel")) ? "" : reader2.GetString("printlabel");
                            bottle_printing = reader2.IsDBNull(reader2.GetOrdinal("bottle_printing")) ? "" : reader2.GetString("bottle_printing");

                            // 根据保质期字段确定年数
                            if (printlabel.Contains("两年半") || printlabel.Contains("30个月"))
                            {
                                shelfLifeYears = 30; // 两年半
                            }
                            else if (printlabel.Contains("两年") || printlabel.Contains("2年") || printlabel.Contains("24个月"))
                            {
                                shelfLifeYears = 24;
                            }
                            else if (printlabel.Contains("三年") || printlabel.Contains("36个月"))
                            {
                                shelfLifeYears = 36;
                            }
                            else if (printlabel.Contains("0年") || printlabel.Contains("0个月"))
                            {
                                shelfLifeYears = 0;
                            }
                            else if (printlabel.Contains("18个月") || printlabel.Contains("一年半") || printlabel.Contains("1年半"))
                            {
                                shelfLifeYears = 18;
                            }
                            else
                            {
                                MessageBoxShow("未查询到对应日期");
                                return;
                            }

                            ShowMsg($"日期：{printlabel} ({shelfLifeYears}年)");
                        }
                        else
                        {
                            MessageBoxShow("未在数据库中查询到对应的日期，请检查项目号是否正确");
                            return;
                        }
                    }
                }
                }
            }
            catch (Exception ex)
            {
                readDbOk = false;
                MySqlConnection.ClearAllPools();
                ShowMsg("读取数据库异常：" + ex.Message);
                ShowMsg("错误行：" + ex.StackTrace.ToString());
                MessageBoxShow("数据库连接异常，请稍后重试");
                detectType1_comboBox.Enabled = true;
                textBox1.Enabled = true;
                return;
            }
            // 使用从MES数据库获取的保质期信息
            //int useYear = 0;
            //useYear = Convert.ToInt32(stdPrintCode.Substring(0, 4)) + shelfLifeYears;
            //stdPrintCode = stdPrintCode.Substring(4, stdPrintCode.Length - 4);
            //stdPrintCode = useYear.ToString() + stdPrintCode;
            //外箱打码
            //if (DateTime.TryParseExact(bottle_printing.Substring(0, 8), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime dt))
            //{
            //    // 计算过期日期并拼接后缀
            //    stdPrintCode = dt.AddMonths(shelfLifeYears).ToString("yyyyMMdd") + bottle_printing.Substring(8);
            //}
            //else
            //{
            //    MessageBoxShow("box_printing日期格式错误");
            //    return;
            //}
            //breakpoint(962-965)
            // 获取原始字段后直接处理
            if (bottle_printing.Contains("半成品"))
            {
                // 半成品检测不打码
                stdPrintCode = "";
            }
            else
            {   
                bottle_printing = ExtractLetters(bottle_printing);
                stdPrintCode = std_product_batch(bottle_printing, line_code, shelfLifeYears);
            }

            stdPrintCode = stdPrintCode.Replace(" ", "");
            outerProductBatchBox.Text = product_batch = stdProductBatchBox.Text = stdPrintCodeBox.Text = textBox2.Text = stdPrintCode;



            textBox33.Text = project_id;
            textBox32.Text = version_num;
            textBox7.Text = bead_project_num;
            textBox14.Text = strick;
            textBox9.Text = outer_project_num;//外向项目号
            textBox12.Text = bead_project_num;//袋/膜瓶项目号
            textBox16.Text = labeling_project_num;//正标项目号
            labelingprojectnum.Text = labeling_project_num;
            backlabelingprojectnum.Text = back_label_project_num;
            textBox18.Text = back_label_project_num;//背标项目号
            textBox20.Text = cover_project_num;//盖子
            textBox24.Text = grid_block;
            textBox1.Text = project_num;

            //有报错
            if (outer_print_rule.Split('#')[1] != "")
            {
                if (checkBox1.Checked || product_name.Contains("半成品"))
                {

                    sapCodeBox.Text = textBox3.Text = "";//stdPrintCode;
                    outerProductBatchBox.Text = outerSapBox.Text = "";
                    textBox34.ReadOnly = true;
                    textBox35.ReadOnly = true;
                    textBox34.BackColor = SystemColors.ScrollBar;
                    textBox35.BackColor = SystemColors.ScrollBar;
                    outerProductBatchBox.BackColor = SystemColors.ScrollBar;
                    outerSapBox.BackColor = SystemColors.ScrollBar;
                    personSure = true;
                }
                else
                {
                    sapCodeBox.Text = textBox3.Text = stdPrintCode + "\r\n" + sapCode;
                }
                //if (!product_name.Contains("半成品"))
                //{
                //    sapCodeBox.Text = textBox3.Text = stdPrintCode + "\r\n" + sapCode;
                //}
                //else
                //{
                //    sapCodeBox.Text = textBox3.Text = "";//stdPrintCode;
                //    outerProductBatchBox.Text = outerSapBox.Text = "";
                //    personSure = true;
                //}

            }
            else
            {
                sapCodeBox.Text = textBox3.Text = stdPrintCode;
            }
            //if (outer_print_rule.Split('#')[1] != "")
            //{

            //    sapCodeBox.Text = textBox3.Text = stdPrintCode + "\r\n" + sapCode;
            //}
            //else
            //{
            //    sapCodeBox.Text = textBox3.Text = stdPrintCode;
            //}

            yellowCountBox.Text = yellowLightTotalCount.ToString();
            redCountBox.Text = redLightTotalCount.ToString();
            line1_comboBox.Enabled = false;
            startBtn.BackColor = Color.Gray;
            startBtn.Enabled = false;
            endBtn.Enabled = true;

            #endregion



            //调用录像相机
            try
            {
                capture = new VideoCapture("rtsp://admin:xyzdh888@192.168.1.108"); // 创建 VideoCapture 对象
            }
            catch (Exception ex)
            {
                ShowMsg("调用相机失败");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
            //打开摄像头
            //capture = new VideoCapture(0); // 创建 VideoCapture 对象
            if (!capture.IsOpened())
            {
                ShowMsg("无法打开摄像头");
                //MessageBox.Show("无法打开摄像头。");
                //return;
            }
            else
            {
                isCapturing = true;
                Thread video_th = new Thread(StartCapturing);
                video_th.IsBackground = true;
                video_th.Start();
            }



            //读取图片
            //try
            //{
            //    pictureBox1.Image = Image.FromFile(@"D:\image\" + textBox1.Text.ToString() + ".bmp");
            //}
            //catch (Exception)
            //{
            //    ShowMsg("图片读取失败");

            //}

            //客户要求本项数据没有的话输入框要只读
            for (int i = 0; i < readInfo.Length; i++)
            {
                if (readInfo[i].Text == "")
                {
                    writeInfo[i].Text = "";
                    writeInfo[i].ReadOnly = true;
                    writeInfo[i].BackColor = SystemColors.ScrollBar;
                }
                else if (i == 3)
                {
                    writeInfo[i].Text = "";
                    writeInfo[i].ReadOnly = true;
                    writeInfo[i].BackColor = SystemColors.ScrollBar;
                }
            }
            if (stdProductBatchBox.Text != "")
            {
                detectResultBox.Text = "";
                //detectResultBox.ReadOnly = true;
                button2.Enabled = true;
            }
            if (textBox7.Text == "")
            {
                textBox8.Text = "";
                textBox8.ReadOnly = true;
                button12.Enabled = false;
            }
            if (labelingprojectnum.Text != "")
            {
                textBox25.Text = "";
                //textBox25.ReadOnly = true;
                button27.Enabled = true;
            }
            if (backlabelingprojectnum.Text != "")
            {
                textBox22.Text = "";
                textBox22.ReadOnly = true;
                button29.Enabled = true;
            }

            wightWriteInfo = false;
            isDoing = true;
        }


        static string ExtractNumberFromString(string input)
        {
            string pattern = @"\d+"; // 正则表达式模式匹配一个或多个数字

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                return match.Value;
            }
            else
            {
                return null; // 或者抛出异常，取决于你的需求
            }
        }
        static string ExtractLetters(string input)
        {
            string a = "";
            // 匹配英文字母和数字，并将它们连接起来
            if (input != "")
            {
                string pattern = @"[A-Za-z]+"; // 匹配字母和数字的组合
                MatchCollection matches = Regex.Matches(input, pattern);

                // 将匹配的结果连接为一个字符串
                a = string.Concat(matches.Cast<Match>().Select(m => m.Value));

            }
            else
            {
                a = "";
            }
            return a;
        }

        // 生成标准打码信息
        private string std_product_batch(string print_rule, string line_code,int shelfLifeYears)
        {
            string rule="";
            string changeP = "S0";
            if (checkBox4.Checked)
            {
                changeP = "P0";
            }
            print_code_delay = shelfLifeYears;
            if (checkBox3.Checked)
            {
                if (print_rule.Contains("XXXX"))
                {
                    if (print_rule.StartsWith("XXXX"))
                    {
                        rule = print_rule.Replace("XXXX", "").Replace("YYYY", "yyyy").Replace("DD", "dd");
                        string now = DateTime.Now.AddHours(-7).AddMinutes(-30).ToString("MMdd");
                        if (now == "0229")
                        {
                            return $"S2{line_code}0" + DateTime.Now.AddMonths(print_code_delay).AddDays(-1).AddHours(-7).AddMinutes(-30).ToString(rule);
                        }
                        else if (DateTime.Today.ToString("MMdd") == "0301" && DateTime.Now <= DateTime.Today.AddHours(7).AddMinutes(30))
                        {
                            if (Convert.ToInt32(DateTime.Today.ToString("yyyy")) % 4 == 0)
                            {
                                return $"S2{line_code}0" + DateTime.Now.AddMonths(print_code_delay).AddDays(-2).AddHours(-7).AddMinutes(-30).ToString(rule);
                            }
                        }

                        return $"S1{line_code}0" + DateTime.Now.AddMonths(print_code_delay).AddHours(-7).AddMinutes(-30).ToString(rule);

                    }
                    else
                    {
                        rule = print_rule.Replace("XXXX", "").Replace("YYYY", "yyyy").Replace("DD", "dd");
                        //string now = DateTime.Now.ToString("MMdd");
                        string now = DateTime.Now.AddHours(-7).AddMinutes(-30).ToString("MMdd");

                        if (now == "0229")
                        {
                            return DateTime.Now.AddMonths(print_code_delay).AddDays(-1).AddHours(-7).AddMinutes(-30).ToString(rule) + $"S2{line_code}0";
                        }
                        else if (DateTime.Today.ToString("MMdd") == "0301" && DateTime.Now <= DateTime.Today.AddHours(7).AddMinutes(30))
                        {
                            if (Convert.ToInt32(DateTime.Today.ToString("yyyy")) % 4 == 0)
                            {
                                return DateTime.Now.AddMonths(print_code_delay).AddDays(-2).AddHours(-7).AddMinutes(-30).ToString(rule) + $"S2{line_code}0";
                            }
                        }
                        return DateTime.Now.AddMonths(print_code_delay).AddHours(-7).AddMinutes(-30).ToString(rule) + $"S1{line_code}0";
                    }
                }
                else
                {
                    rule = print_rule.Replace("XXXX", "").Replace("YYYY", "yyyy").Replace("DD", "dd");
                    string now = DateTime.Now.AddHours(-7).AddMinutes(-30).ToString("MMdd");
                    if (now == "0229")
                    {
                        return DateTime.Now.AddMonths(print_code_delay).AddDays(-1).AddHours(-7).AddMinutes(-30).ToString(rule);
                    }
                    else if (DateTime.Today.ToString("MMdd") == "0301" && DateTime.Now <= DateTime.Today.AddHours(7).AddMinutes(30))
                    {
                        if (Convert.ToInt32(DateTime.Today.ToString("yyyy")) % 4 == 0)
                        {
                            return DateTime.Now.AddMonths(print_code_delay).AddDays(-2).AddHours(-7).AddMinutes(-30).ToString(rule);
                        }
                    }
                }
            }
            else
            {
                if (print_rule.Contains("XXXX"))
                {
                    if (print_rule.StartsWith("XXXX"))
                    {
                        rule = print_rule.Replace("XXXX", "").Replace("YYYY", "yyyy").Replace("DD", "dd");
                        string now = DateTime.Now.AddHours(-7).AddMinutes(-30).ToString("MMdd");
                        if (now == "0229")
                        {
                            return changeP + DateTime.Now.AddMonths(print_code_delay).AddDays(-1).AddHours(-7).AddMinutes(-30).ToString(rule);
                        }
                        else if (DateTime.Today.ToString("MMdd") == "0301" && DateTime.Now <= DateTime.Today.AddHours(7).AddMinutes(30))
                        {
                            if (Convert.ToInt32(DateTime.Today.ToString("yyyy")) % 4 == 0)
                            {
                                return changeP + DateTime.Now.AddMonths(print_code_delay).AddDays(-2).AddHours(-7).AddMinutes(-30).ToString(rule);
                            }
                        }

                        return changeP + DateTime.Now.AddMonths(print_code_delay).AddHours(-7).AddMinutes(-30).ToString(rule);

                    }
                    else
                    {
                        rule = print_rule.Replace("XXXX", "").Replace("YYYY", "yyyy").Replace("DD", "dd");
                        //string now = DateTime.Now.ToString("MMdd");
                        string now = DateTime.Now.AddHours(-7).AddMinutes(-30).ToString("MMdd");

                        if (now == "0229")
                        {
                            return DateTime.Now.AddMonths(print_code_delay).AddDays(-1).AddHours(-7).AddMinutes(-30).ToString(rule) + changeP;
                        }
                        else if (DateTime.Today.ToString("MMdd") == "0301" && DateTime.Now <= DateTime.Today.AddHours(7).AddMinutes(30))
                        {
                            if (Convert.ToInt32(DateTime.Today.ToString("yyyy")) % 4 == 0)
                            {
                                return DateTime.Now.AddMonths(print_code_delay).AddDays(-2).AddHours(-7).AddMinutes(-30).ToString(rule) + changeP;
                            }
                        }
                        return DateTime.Now.AddMonths(print_code_delay).AddHours(-7).AddMinutes(-30).ToString(rule) + changeP;
                    }
                }
                else
                {
                    rule = print_rule.Replace("XX", "").Replace("YYYY", "yyyy").Replace("DD", "dd");
                    string now = DateTime.Now.AddHours(-7).AddMinutes(-30).ToString("MMdd");
                    if (now == "0229")
                    {
                        return DateTime.Now.AddMonths(print_code_delay).AddDays(-1).AddHours(-7).AddMinutes(-30).ToString(rule)+ changeP;
                    }
                    else if (DateTime.Today.ToString("MMdd") == "0301" && DateTime.Now <= DateTime.Today.AddHours(7).AddMinutes(30))
                    {
                        if (Convert.ToInt32(DateTime.Today.ToString("yyyy")) % 4 == 0)
                        {
                            return DateTime.Now.AddMonths(print_code_delay).AddDays(-2).AddHours(-7).AddMinutes(-30).ToString(rule)+ changeP;
                        }
                    }
                }
            }
            return DateTime.Now.AddMonths(print_code_delay).AddHours(-7).AddMinutes(-30).ToString(rule)+ changeP;
        }
    
           

        private void StartCapturing()
        {
            Mat frame = new Mat();
            DateTime now = DateTime.Now;
            DateTime folderDate;
            if (now.Hour < 7 || (now.Hour == 7 && now.Minute < 30))
            {
                folderDate = now.Date.AddDays(-1);
            }
            else
            {
                folderDate = now.Date;
            }
            string videopath = "D://视频//" + folderDate.ToString("yyyy-MM-dd");
            string date_path = videopath + "//" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            if (!Directory.Exists(videopath))
            {
                Directory.CreateDirectory(videopath);
            }
            VideoWriter writer = new VideoWriter($"{date_path}.mp4", VideoWriter.FourCC(@"MP4V"), 24, new OpenCvSharp.Size(1920, 1080));
            while (isCapturing)
            {
                capture.Read(frame); // 读取帧图像

                if (frame.Empty())
                    break;


                writer.Write(frame);
                // 在这里可以对帧图像进行处理

                // 将帧图像转换为 Bitmap，然后在 PictureBox 中显示
                //   Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                //   pictureBox1.Image = bitmap;
                //  pictureBox1.Refresh();
            }
            writer.Release();
            capture.Release();
        }
        #region 串口相关函数
        // 扫码枪打开函数
        private void scan_gun_start()
        {
            try
            {
                serialPort1.Open();
                serialPort1.DataReceived += serialPort1_DataReceived;
                scanGunStatus.Image = Resources.green_circle;
            }
            catch (Exception ex)
            {
                ShowMsg($"【串口开启】：{ex.Message}");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }

        }
        // 扫码枪关闭函数
        private void scan_gun_end()
        {
            try
            {
                serialPort1.DataReceived -= serialPort1_DataReceived;
                serialPort1.Close();
                scanGunStatus.Image = Resources.gray_circle;
            }
            catch (Exception ex)
            {
                ShowMsg($"【串口关闭】：{ex.Message}");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }

        }
        // 扫码枪回调函数+
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(100);
                SerialPort serialPort = (SerialPort)sender;
                string data = serialPort.ReadExisting(); // 数据读取
                string barCode = data.Trim();                  // 默认收到的扫码枪的数据带空格，需要去除
                ShowMsg($"扫码结果为：{barCode}");
                //string query1 = $"SELECT * FROM product_sku1 WHERE tub_bar_code = '{barCode}';";
                string query1 = $"SELECT * FROM product_barcode WHERE barcode = '{barCode}';";
                using (MySqlConnection readConnection = OpenReadConnection())
                using (MySqlCommand command = new MySqlCommand(query1, readConnection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        project_num = reader.GetString("project_num");


                        // 使用接收到的字段值进行后续操作
                    }
                    else
                    {
                       MessageBoxShow("输入的条形码有误，请重新输入");
                        return;
                    }
                }
                ShowMsg($"line：project_num：{project_num}");

                textBox1.Text = project_num;
            }
            catch (Exception ex)
            {
                ShowMsg($"【扫码枪查询】：{ex.Message}");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
        }
        // 开始称重
        private void start_weigh()
        {
            try
            {
                string query1 = $"SELECT tub_weight FROM product_sku1 WHERE project_num = {Convert.ToInt32(textBox1.Text)}";
                using (MySqlConnection readConnection = OpenReadConnection())
                using (MySqlCommand command = new MySqlCommand(query1, readConnection))
                {
                    tubweight = command.ExecuteScalar();
                }
                balanceSerialPort.Open();
                balanceSerialPort.DataReceived += balanceTubSerialPort_DataReceived;
                callStatus.Image = Resources.green_circle;
            }
            catch (Exception ex)
            {
                ShowMsg($"【称重开启】：{ex.Message}");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
        }


        // 结束称重
        private void end_weigh()
        {
            balanceSerialPort.DataReceived -= balanceTubSerialPort_DataReceived;
            balanceSerialPort.Close();
            callStatus.Image = Resources.gray_circle;
        }
        // 开始称重回调函数
        private void balanceTubSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            Thread.Sleep(300);
            SerialPort serialPort = (SerialPort)sender;
            string data = serialPort.ReadExisting(); // 数据读取
            string str = data.Trim();                  // 默认收到的扫码枪的数据带空格，需要去除
            string weight_word = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[3];//[50];
            // 将公斤转为毫千克,乘以 1000 
            int tub_weight = (int)(double.Parse(weight_word));// * 1000
            if (num < 6)
            {
                tub_weights[num] = tub_weight;
                textBoxes[num].Text = tub_weights[num].ToString();
                num += 1;
            }
            else
            {


                end_weigh();
                return;
            }
            //     if (num == 6)
            //     {
            //         num = 0;
            //         for (int i = 0; i < 5; i++)
            //         {
            //             if (tub_weights[i] <(Convert.ToDouble(tubweight)))
            //             {
            //                 weightresult = true;
            //             }
            //         }


            //     }
            //;
            //     if (weightresult)
            //     {
            //        MessageBoxShow("重量NG，请录入");
            //         button22.PerformClick();
            //         weightresult = false;
            //     }

        }

        // 重量随机数
        Random weight_random = new Random();

        //音频播放
        private void music_play(object o)
        {
            string path = o as string;
            int delay_time = Convert.ToInt32(path.Split(',')[1]);
            if (path.Split(',')[0] == "X")
            {
                delay_timeX = delay_time;
            }
            else if (path.Split(',')[0] == "Y")
            {
                delay_timeY = delay_time;
            }
            else if (path.Split(',')[0] == "Z")
            {
                delay_timeZ = delay_time;
            }
            try
            {
                Thread.Sleep(delay_time * 1000);
                // 创建一个WaveOutEvent对象
                waveOut = new WaveOutEvent();
                // 加载音频文件
                audioFileReader = new AudioFileReader(path.Split(',')[2]);

                // 创建一个增益效果器对象
                var volumeProvider = new VolumeSampleProvider(audioFileReader.ToSampleProvider());
                // 将音频文件添加到WaveOutEvent对象中
                waveOut.Init(volumeProvider);
                // 设置音量增益为2倍
                volumeProvider.Volume = 2.0f;
                // 开始播放音频
                waveOut.Play();
            }
            catch (Exception ex)
            {
                ShowMsg($"{path.Split(',')[0]} [报错]{ex.Message}");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }

        }


        #endregion
        #region pictureBox缩放
        private System.Drawing.Point lastPoint;
        private float scale = 1.0f;






        #endregion



        // 数据库连接
        private void open_mysql_connect()
        {
            //读取数据库
            DisposeMysqlConnection(ref connection);
            try
            {
                connection = OpenReadConnection();
                readDbOk = true;
            }
            catch (Exception ex)
            {
                readDbOk = false;
                MySqlConnection.ClearAllPools();
                Console.WriteLine(ex.Message);
                ShowMsg("读取数据库连接失败：" + ex.Message);
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
            //写入数据库
            DisposeMysqlConnection(ref connection2);
            try
            {
                connection2 = OpenWriteConnection();
                writeDbOk = true;
            }
            catch (Exception ex)
            {
                writeDbOk = false;
                MySqlConnection.ClearAllPools();
                Console.WriteLine(ex.Message);
                ShowMsg("写入数据库连接失败：" + ex.Message);
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
        }

        // 关闭数据库连接
        private void close_mysql_connect()
        {
            try
            {
                DisposeMysqlConnection(ref connection);
                DisposeMysqlConnection(ref connection2);

            }
            catch (Exception ex)
            {
                ShowMsg("数据库关闭失败");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
        }

        private MySqlConnection OpenReadConnection()
        {
            return OpenMysqlConnection(ReadDbConnectionString);
        }

        private MySqlConnection OpenWriteConnection()
        {
            return OpenMysqlConnection(WriteDbConnectionString);
        }

        private MySqlConnection OpenMysqlConnection(string connectionString)
        {
            MySqlConnection mysqlConnection = new MySqlConnection(connectionString);
            mysqlConnection.Open();
            return mysqlConnection;
        }

        private void DisposeMysqlConnection(ref MySqlConnection mysqlConnection)
        {
            if (mysqlConnection == null)
            {
                return;
            }

            try
            {
                mysqlConnection.Close();
                mysqlConnection.Dispose();
            }
            finally
            {
                mysqlConnection = null;
            }
        }

        private bool TestMysqlConnection(string connectionString)
        {
            try
            {
                using (MySqlConnection mysqlConnection = OpenMysqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand("SELECT 1", mysqlConnection))
                {
                    command.CommandTimeout = 3;
                    command.ExecuteScalar();
                    return true;
                }
            }
            catch
            {
                MySqlConnection.ClearAllPools();
                return false;
            }
        }

        private void CheckDatabaseHealthIfDue()
        {
            if (isDbHealthChecking || (DateTime.Now - lastDbHealthCheckTime).TotalSeconds < 30)
            {
                return;
            }

            lastDbHealthCheckTime = DateTime.Now;
            isDbHealthChecking = true;
            bool oldDbOk = readDbOk && writeDbOk;

            Task.Run(() =>
            {
                bool newReadDbOk = TestMysqlConnection(ReadDbConnectionString);
                bool newWriteDbOk = TestMysqlConnection(WriteDbConnectionString);
                readDbOk = newReadDbOk;
                writeDbOk = newWriteDbOk;

                bool newDbOk = newReadDbOk && newWriteDbOk;
                if (oldDbOk != newDbOk && !IsDisposed && IsHandleCreated)
                {
                    BeginInvoke(new Action(() =>
                    {
                        ShowMsg(newDbOk ? "数据库连接恢复！" : "数据库断开，短连接健康检查失败！");
                    }));
                }
            }).ContinueWith(task =>
            {
                isDbHealthChecking = false;
            });
        }


        // 日志打印函数
        private void ShowMsg(string str)
        {
            try
            {
                txtLog.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + str + "\r\n");
                LogMutex.WaitOne(); // 获取互斥锁
                string fileName = DateTime.Now.ToString("yyyy_MM_dd_") + "log.txt";
                using (StreamWriter writer = File.AppendText(fileName))
                {
                    writer.WriteLine($"{DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]")} - {str}");
                }
            }
            finally
            {
                LogMutex.ReleaseMutex(); // 释放互斥锁

            }
        }
        // 线体选择
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            line3_comboBox.Text = line2_comboBox.Text = line = line1_comboBox.Text;
        }
        // 抽检人员选择
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            inspector3_comboBox.Text = inspector2_comboBox.Text = inspector = inspector1_comboBox.Text;
        }
        // 检测类型选择
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            detectType2_Box.Text = detect_type = detectType1_comboBox.Text;

        }
        // form1关闭函数
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            close_mysql_connect();
            closeLight();
        }
        // 启动缺陷选择
        private void button22_Click(object sender, EventArgs e)
        {
            weightresult = false;
            if (defect_comboBox.Text == "")
            {
               MessageBoxShow("请选择缺陷类型");
                return;
            }
            // 将需要传递的变量赋值给 Form2 的属性
            form2.MessageFromForm1 = defect_comboBox.Text;
            // 显示 Form2 窗口
            form2.Show();
            form2.updataFrom();
        }
        // 接收form2的数据
        //private void Form2_ButtonClicked(string[] text)
        //{
        //    // 在 Form2 的按钮点击事件中触发该方法，以获取提交的文本内容
        //    //ShowMsg(text[0] + " " + text[1] + " " + text[2] + " " + text[3] + " " + text[4] + " " + text[5] + " " + text[6] + " " + text[7] + " " + text[8] + " " + text[9] + " " + text[10] + " " + text[11]);


        //    int yellow_light = 0;
        //    int red_light = 0;
        //    int ok_light = 0;
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (i < 6)
        //        {
        //            if (text[i] != "")
        //            {
        //                yellow_light += 1;
        //            }
        //            else
        //            {
        //                ok_light += 1;    
        //            }

        //        }
        //        else
        //        {
        //            if (text[i] != "")
        //            {
        //                red_light += 1;
        //            }
        //            else
        //            {
        //                ok_light += 1;
        //            }
        //        }
        //    }

        //    for (int i = 0; i < 6; i++)
        //    {
        //        if (text[i] != "" && text[i + 6] != "")
        //        {
        //            if (text[i] != "")
        //            {
        //                defect_rework_description += "[产品" + (i + 1) + "]  黄灯:";
        //                defect_rework_description += text[i] + ",";
        //            }

        //            if (text[i + 6] != "")
        //            {
        //                defect_rework_description += "红灯:";
        //                defect_rework_description += text[i + 6] + ";";
        //            }
        //        }
        //        else
        //        {
        //            if (text[i] != "")
        //            {
        //                defect_rework_description += "[产品" + (i + 1) + "]  黄灯:";
        //                defect_rework_description += text[i]+ ",";
        //            }
        //            else
        //            {
        //                defect_rework_description += "[产品" + (i + 1) + "]  OK";
        //                defect_rework_description += text[i] + ",";
        //            }
        //            if (text[i + 6] != "")
        //            {
        //                defect_rework_description += "[产品" + (i + 1) + "]" + "红灯:";
        //                defect_rework_description += text[i + 6] + ";";
        //            }
        //            else
        //            {
        //                defect_rework_description += "[产品" + (i + 1) + "]  OK";
        //                defect_rework_description += text[i] + ",";
        //            }
        //        }
        //    }

        //    texts = text;
        //    if (line == "I线")
        //    {
        //        yellow_total_lightX += yellow_light;
        //        red_total_lightX += red_light;
        //        OK_total_lightX += ok_light;
        //        sys_ini.WriteKey("yellow_total_lightX", yellow_total_lightX.ToString()); // 更新配置文件
        //        sys_ini.WriteKey("red_total_lightX", red_total_lightX.ToString()); // 更新配置文件
        //        sys_ini .WriteKey("OK_total_lightX", OK_total_lightX.ToString());
        //        yellowCountBox.Text = $"{yellow_total_lightX}";
        //        redCountBox.Text = $"{red_total_lightX}";
        //        yellow_light_count = yellow_light;
        //        red_light_count = red_light;
        //        OK_light_count = red_light;
        //    }
        //    else if (line == "Y线")
        //    {
        //        yellow_total_lightY += yellow_light;
        //        red_total_lightY += red_light;
        //        sys_ini.WriteKey("yellow_total_lightY", yellow_total_lightY.ToString()); // 更新配置文件
        //        sys_ini.WriteKey("red_total_lightY", red_total_lightY.ToString()); // 更新配置文件
        //        yellowCountBox.Text = $"{yellow_total_lightY}";
        //        redCountBox.Text = $"{red_total_lightY}";
        //        yellow_light_count = yellow_light;
        //        red_light_count = red_light;
        //    }
        //    else if (line == "Z线")
        //    {
        //        yellow_total_lightZ += yellow_light;
        //        red_total_lightZ += red_light;
        //        sys_ini.WriteKey("yellow_total_lightZ", yellow_total_lightZ.ToString()); // 更新配置文件
        //        sys_ini.WriteKey("red_total_lightZ", red_total_lightZ.ToString()); // 更新配置文件
        //        yellowCountBox.Text = $"{yellow_total_lightZ}";
        //        redCountBox.Text = $"{red_total_lightZ}";
        //        yellow_light_count = yellow_light;
        //        red_light_count = red_light;
        //    }


        //    form3.detectTimeBox.Text = detect_time.ToString("HH分mm秒");
        //    form3.classesBox.Text = classes;
        //    form3.shiftBox.Text = shift;

        //    form3.lineBox.Text = line;
        //    form3.productLotNumBox.Text = product_batch;
        //    form3.sapBox.Text = sapCode;
        //    form3.productNameBox.Text = product_name;
        //    form3.defectReworkDescriptionBox.Text = defect_rework_description.Replace(";", "\r\n");
        //    form3.Show();


        //}
        // form3中的提交按钮
        private void Form2_ButtonClicked(string[] text)
        {
            // 在 Form2 的按钮点击事件中触发该方法，以获取提交的文本内容
            //ShowMsg(text[0] + " " + text[1] + " " + text[2] + " " + text[3] + " " + text[4] + " " + text[5] + " " + text[6] + " " + text[7] + " " + text[8] + " " + text[9] + " " + text[10] + " " + text[11]);


            int yellow_light = 0;
            int red_light = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (i < 6)
                {
                    if (text[i] != "")
                    {
                        yellow_light += 1;
                    }
                }
                else
                {
                    if (text[i] != "")
                    {
                        red_light += 1;
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (text[i] != "" && text[i + 6] != "")
                {
                    if (text[i] != "")
                        defect_rework_description += "[产品" + (i + 1) + "]  黄灯:";
                    defect_rework_description += text[i] + ",";
                    if (text[i + 6] != "")
                        defect_rework_description += "红灯:";
                    defect_rework_description += text[i + 6] + ",";
                }
                else
                {
                    if (text[i] != "")
                    {
                        defect_rework_description += "[产品" + (i + 1) + "]  黄灯:";
                        defect_rework_description += text[i] + ",";
                    }

                    if (text[i + 6] != "")
                    {
                        defect_rework_description += "[产品" + (i + 1) + "]" + "红灯:";
                        defect_rework_description += text[i + 6] + ",";
                    }

                }
            }

            texts = text;
            if (line == "B线")
            {
                yellow_total_lightX += yellow_light;
                red_total_lightX += red_light;
                sys_ini.WriteKey("yellow_total_lightX", yellow_total_lightX.ToString()); // 更新配置文件
                sys_ini.WriteKey("red_total_lightX", red_total_lightX.ToString()); // 更新配置文件
                yellowCountBox.Text = $"{yellow_total_lightX}";
                redCountBox.Text = $"{red_total_lightX}";
                yellow_light_count = yellow_light;
                red_light_count = red_light;
            }
            else if (line == "Y线")
            {
                yellow_total_lightY += yellow_light;
                red_total_lightY += red_light;
                sys_ini.WriteKey("yellow_total_lightY", yellow_total_lightY.ToString()); // 更新配置文件
                sys_ini.WriteKey("red_total_lightY", red_total_lightY.ToString()); // 更新配置文件
                yellowCountBox.Text = $"{yellow_total_lightY}";
                redCountBox.Text = $"{red_total_lightY}";
                yellow_light_count = yellow_light;
                red_light_count = red_light;
            }
            else if (line == "Z线")
            {
                yellow_total_lightZ += yellow_light;
                red_total_lightZ += red_light;
                sys_ini.WriteKey("yellow_total_lightZ", yellow_total_lightZ.ToString()); // 更新配置文件
                sys_ini.WriteKey("red_total_lightZ", red_total_lightZ.ToString()); // 更新配置文件
                yellowCountBox.Text = $"{yellow_total_lightZ}";
                redCountBox.Text = $"{red_total_lightZ}";
                yellow_light_count = yellow_light;
                red_light_count = red_light;
            }


            form3.detectTimeBox.Text = detect_time.ToString("HH分mm秒");
            form3.classesBox.Text = classes;
            form3.shiftBox.Text = shift;

            form3.lineBox.Text = line;
            form3.productLotNumBox.Text = product_batch;
            form3.sapBox.Text = sapCode;
            form3.productNameBox.Text = product_name;
            form3.defectReworkDescriptionBox.Text = defect_rework_description.Replace(";", "\r\n");
            form3.Show();


        }
        private void Form3_ButtonClicked(string[] text)
        {
            defect_rework_description = text[0].Replace("\r\n", ";");
            rework_count = Convert.ToInt32(text[1]);
            ng_count = Convert.ToInt32(text[2]);
            rework_result = text[3];

        }




        // 白夜班计算函数
        private string GetShift()
        {
            DateTime currentTime = DateTime.Now;
            // 设置白班和夜班的时间范围
            TimeSpan dayShiftStart = new TimeSpan(7, 30, 0);
            TimeSpan dayShiftEnd = new TimeSpan(19, 30, 0);

            // 判断当前时间是否在白班范围内
            if (currentTime.TimeOfDay >= dayShiftStart && currentTime.TimeOfDay <= dayShiftEnd)
            {
                return "白班";
            }
            else
            {
                return "夜班";
            }
        }

        // 模拟称重
        private void button11_Click(object sender, EventArgs e)
        {
            bool weightresult = false;
            for (int i = 0; i < 6; i++)
            {
                if (tub_weights[num] < (float)tubweight)
                {
                    weightresult = true;
                }
                if (weightresult)
                {
                   MessageBoxShow("标准重量NG，确定录入？");
                    form3.detectTimeBox.Text = detect_time.ToString("HH分mm秒");
                    form3.classesBox.Text = classes;
                    form3.shiftBox.Text = shift;

                    form3.lineBox.Text = line;
                    form3.productLotNumBox.Text = product_batch;
                    form3.sapBox.Text = sapCode;
                    form3.productNameBox.Text = product_name;
                    form3.defectReworkDescriptionBox.Text = defect_rework_description.Replace(";", "\r\n");
                    form3.Show();
                }
            }
            if (num < 6)
            {
                tub_weights[num] = weight_random.Next(125, 265);
                textBoxes[num].Text = tub_weights[num].ToString();
                num += 1;
            }
        }
        // 存储检测结果到数据库
        private void save_database()
        {
            try
            {
                using (MySqlConnection writeConnection = OpenWriteConnection())
                {
                    string sq1 = $"SELECT * FROM scale_check WHERE line='B' ORDER BY verification_time  DESC LIMIT 1";
                    using (MySqlCommand newcommand = new MySqlCommand(sq1, writeConnection))
                    using (MySqlDataReader reader = newcommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Weighing_status = reader.GetString("status");
                        }
                    }

                    // string sql = $"INSERT INTO detect_record (detect_time,detect_type,line,classes,shift,project_num,product_batch,sap_code,product_name,detailed_information,total_count,yellow_light_count,red_light_count,tub_weight_1,tub_weight_2,tub_weight_3,tub_weight_4,tub_weight_5,tub_weight_6,defect_rework_description,rework_count,ng_count,rework_result,notes,inspector) VALUES ('{detect_time}','{detect_type}','{line}','{classes}','{shift}','{project_num}','{product_batch}','{sap_code}','{product_name}','{detailed_information}','{total_count}','{yellow_light_count}','{red_light_count}','{tub_weights[0]}','{tub_weights[1]}','{tub_weights[2]}','{tub_weights[3]}','{tub_weights[4]}','{tub_weights[5]}','{defect_rework_description}','{rework_count}','{ng_count}','{rework_result}','{notes}','{inspector}')";
                    string sq2 = $"INSERT INTO detect_record(factory, line, detect_time, order_id, detect_type, classes, shift, project_num, std_product_batch, product_batch, std_sap_code, sap_code, product_name, detailed_information, total_count, red_light_count, yellow_light_count, tub_weight_1, tub_weight_2, tub_weight_3, tub_weight_4, tub_weight_5, tub_weight_6, min_weight, defect_rework_description, rework_count, ng_count, rework_result, notes, inspector, std_outer_box, outer_box, std_bag_bottle_project_number, bag_bottle_project_number, std_orthostandard, orthostandard, std_sticker, sticker, std_back_label, back_label, std_cover, cover, first_inspection_result, std_grid_block, grid_block, std_diversio_channel, diversio_channel,std_box_product_batch,box_product_batch) VALUES('SP', 'B', '{detect_time}', '{order_id}', '{detectType1_comboBox.Text }', '{classes}', '{shift}', '{project_num}', '{product_batch}', '{product_batch}', '{sapCode}', '{sapCode}', '{project_name}', '详细信息', '{total_count}', '{red_light_count}', '{yellow_light_count}', '{tub_weights[0]}', '{tub_weights[1]}',{tub_weights[2]},{tub_weights[3]},'{tub_weights[4]}','{tub_weights[5]}', '{bead_weight}', '{defect_rework_description}', '{rework_count}', '{ng_count}', '{rework_result}', '{notes}', '{inspector}'," +
                      $" '{textBox9.Text}', '{textBox10.Text}', '{textBox12.Text}', '{textBox12.Text}', '{labelingprojectnum.Text}', '{textBox25.Text}', '{textBox14.Text}', '{textBox13.Text}', '{backlabelingprojectnum.Text}', '{textBox22.Text}', '{textBox20.Text}', '{textBox19.Text}','{Weighing_status}' ,'{textBox24.Text}', '{textBox21.Text}', '{textBox29.Text}', '{textBox4.Text}', '{outerProductBatchBox.Text}', '{textBox34.Text}')";
                    using (MySqlCommand command = new MySqlCommand(sq2, writeConnection))//text12=text11
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                writeDbOk = false;
                MySqlConnection.ClearAllPools();
               MessageBoxShow("数据库连接失败，请检查网络！" + ex.ToString());
            }

        }
        // 存储返工数据到数据库
        private void save_rework()
        {
            try
            {
                Console.WriteLine(defect_rework_description.Length + "haha");
                string sql = $"INSERT INTO rework_record(rework_time,classes,shift,line,project_num,product_batch,sap_code,product_name,defect_rework_description,rework_count,ng_count,rework_result) VALUES ('{rework_time}','{classes}','{shift}','{line}','{project_num}','{product_batch}','{sap_code}','{product_name}','[产品1]  黄灯:2-标贴/束膜-附贴,红灯:2-标贴/束膜-附贴;[产品2]  黄灯:2-标贴/束膜-附贴,红灯:2-标贴/束膜-附贴;[产品3]  黄灯:1-标贴/束膜/包装纸(膜)-位置,红灯:6-印刷-包装,标贴或小袋膜切割/定位;[产品4]  黄灯:2-标贴/束膜-附贴,红灯:6-印刷-包装,标贴或小袋膜切 ;[产品5]  黄灯:6-印刷-包装,标贴或小袋膜切割/定位,红灯:6-印刷-包装,标贴或小袋膜切割/定位;[产品6]  黄灯:14-产品颜色/分层/相分离,红灯:11-灌装高度偏差;','{rework_count}','{ng_count}','{rework_result}')";
                using (MySqlConnection writeConnection = OpenWriteConnection())
                using (MySqlCommand command = new MySqlCommand(sql, writeConnection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                writeDbOk = false;
                MySqlConnection.ClearAllPools();
               MessageBoxShow("数据库连接失败，请检查网络！");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            fistWeighing = Convert.ToBoolean(IniAPI.INIGetStringValue(pathuser, "是否首检", "首检", ""));
            if (!fistWeighing)//如果为false说明未进行首次称重
            {
               MessageBox.Show("未进行称重首检", "警告!", MessageBoxButtons.OK);
                return;
            }
            if (tubWeightBox1.Text == "" || tubWeightBox2.Text == "" || tubWeightBox3.Text == "" || tubWeightBox4.Text == "" || tubWeightBox5.Text == "" || tubWeightBox6.Text == "")
            {
               MessageBoxShow("需要有称重数量");
                return;
            }
            for (int i = 0; i < wight_OK_NG.Length; i++)
            {
                if (wight_OK_NG[i].Text == "NG")
                {
                    weightresult = true;
                }
            }
            if (weightresult != true)
            {
                selectpage = false;
                openweight = false;
                tubWeightBox1.Enabled = false;
                tubWeightBox2.Enabled = false;
                tubWeightBox3.Enabled = false;
                tubWeightBox4.Enabled = false;
                tubWeightBox5.Enabled = false;
                tubWeightBox6.Enabled = false;
                tubWeightBox1.ForeColor = Color.Black;
                tubWeightBox2.ForeColor = Color.Black;
                tubWeightBox3.ForeColor = Color.Black;
                tubWeightBox4.ForeColor = Color.Black;
                tubWeightBox5.ForeColor = Color.Black;
                tubWeightBox6.ForeColor = Color.Black;
                tub_weights[0] = (float)Convert.ToDouble(tubWeightBox1.Text);
                tub_weights[1] = (float)Convert.ToDouble(tubWeightBox2.Text);
                tub_weights[2] = (float)Convert.ToDouble(tubWeightBox3.Text);
                tub_weights[3] = (float)Convert.ToDouble(tubWeightBox4.Text);
                tub_weights[4] = (float)Convert.ToDouble(tubWeightBox5.Text);
                tub_weights[5] = (float)Convert.ToDouble(tubWeightBox6.Text);

                //称重手动传送

                num = 6;
                if (yellow_light_count > 0 && red_light_count > 0)
                {
                    rework_time = DateTime.Now;
                    // 打开返工录入窗口
                    save_rework();
                }

                //if (texts.Length !=12)
                //{
                //    string[] txt = new string[12];
                //    for (int i = 0; i < txt.Length; i++)
                //    {
                //        txt[i] = "";
                //    }
                //    texts = txt;
                //}
                for (int i = 0; i < texts.Length; i++)
                {
                    if (texts[i] == null)
                    {
                        texts[i] = "";
                    }
                }
                if (detectType1_comboBox.Text == "首检" || detectType1_comboBox.Text == "停机30分钟后首检" || detectType1_comboBox.Text == "设备维修后首检")
                {
                    processX_1 = processX_2 = processX_3 = 0;
                    sys_ini.WriteKey("processX_1", processX_1.ToString()); // 更新配置文件
                    sys_ini.WriteKey("processX_2", processX_2.ToString()); // 更新配置文件
                    sys_ini.WriteKey("processX_3", processX_3.ToString()); // 更新配置文件
                }
                // 更新状态到界面
                if (line == "B线")
                {

                    //这里首检清掉所有ini里的数据
                    if (detect_type == "首检" || detectType1_comboBox.Text == "停机30分钟后首检" || detectType1_comboBox.Text == "设备维修后首检")
                    {

                        defect_status_X = transfer.Split(',');
                        sys_ini.WriteKey("defect_status_X", transfer); // 更新配置文件
                        detect_total_countX = yellow_total_lightX = red_total_lightX = 0;
                        sys_ini.WriteKey("detect_total_countX", detect_total_countX.ToString()); // 更新配置文件
                        sys_ini.WriteKey("yellow_total_lightX", yellow_total_lightX.ToString()); // 更新配置文件
                        sys_ini.WriteKey("red_total_lightX", red_total_lightX.ToString()); // 更新配置文件
                        for (int i = 0; i < 16; i++)
                        {
                            labels[i].Text = "待检入中";
                        }
                        time_labelX = transfer_label.Split(',');
                        sys_ini.WriteKey("time_labelX", transfer_label);
                        clear_dataGrid();
                        processX_1 = 1;
                        sys_ini.WriteKey("processX_1", processX_1.ToString()); // 更新配置文件

                    }
                    if (detect_type == "PQS")
                    {
                        processX_2 += 1;
                        sys_ini.WriteKey("processX_2", processX_2.ToString()); // 更新配置文件
                    }
                    detect_total_countX += 1;
                    sys_ini.WriteKey("detect_total_countX", detect_total_countX.ToString()); // 更新配置文件
                    if (processX_2 < 16)
                    {
                        try
                        {
                            time_labelX[detect_total_countX - 1] = labels[detect_total_countX - 1].Text = detect_type + " " + detect_time.ToString("HH:mm");
                        }
                        catch
                        {
                            ShowMsg($"[异常]detect_total_countX:{detect_total_countX}");
                            ShowMsg($"[异常]time_labelX:{time_labelX.Length}");
                            ShowMsg($"[异常]labels:{labels.Length}");
                        }
                        sys_ini.WriteKey("time_labelX", string.Join(",", time_labelX));

                        if (texts[1] != null)
                        {
                            if (defect_comboBox.Text == "塑料瓶")
                            {
                                int num_code = 0; ;
                                for (int i = 0; i < 16; i++)
                                {
                                    num_code = Array.IndexOf(red_bottle_defects, texts[i]) + 1;
                                    dataGridView6.Rows[i % 6 + 1].Cells[(detect_total_countX - 1) * 2 + i / 6].Value = num_code;
                                    defect_status_X[(detect_total_countX - 1) * 12 + i] = num_code.ToString();
                                }
                            }
                            else if (defect_comboBox.Text == "软袋")
                            {
                                if (texts.Length != 12)
                                {
                                    string[] txt = new string[12];
                                    for (int i = 0; i < txt.Length; i++)
                                    {
                                        txt[i] = "";
                                    }
                                    texts = txt;
                                }
                                for (int i = 0; i < 12; i++)
                                {
                                    int num_code;
                                    if (texts[i] == "")
                                    {
                                        num_code = 0;
                                    }
                                    else
                                    {
                                        num_code = Array.IndexOf(red_bag_defects, texts[i]) + 1;
                                    }

                                    dataGridView6.Rows[i % 6 + 1].Cells[(detect_total_countX - 1) * 2 + i / 6].Value = num_code;
                                    defect_status_X[(detect_total_countX - 1) * 12 + i] = num_code.ToString();
                                    //sys_ini.WriteKey("defect_status_X", string.Join(num_code .ToString (), defect_status_X));
                                }
                            }

                        }
                        sys_ini.WriteKey("defect_status_X", string.Join(",", defect_status_X));
                    }


                }

                if (line == "B线")
                {
                    if (processX_3 >= 1)//尾检
                    {
                        processX_1 = processX_2 = processX_3 = 0;
                        sys_ini.WriteKey("processX_1", processX_1.ToString()); // 更新配置文件
                        sys_ini.WriteKey("processX_2", processX_2.ToString()); // 更新配置文件
                        sys_ini.WriteKey("processX_3", processX_3.ToString()); // 更新配置文件
                    }
                }

                if (line == "B线")
                {
                    int delay_time = (int)(detect_time.AddHours(1) - DateTime.Now).TotalSeconds;
                    Thread th_audio = new Thread(music_play);
                    th_audio.IsBackground = true;
                    th_audio.Start("B," + delay_time.ToString() + ",b_line.mp3");
                    update_text("请开始B线产品质量检测" + "             ");
                }




                weightresult = false;
                endBtn.Enabled = false;
                startBtn.Enabled = true;
                line1_comboBox.Enabled = true;

                save_database();
                //InitStatus();
                Array.Clear(texts, 0, texts.Length);
               MessageBoxShow("成功提交！");
                InitStatus();//数据录入后清空窗体上的数据
                wightWriteInfo = true;
                //数据确认复位
                //btnSure = false;
                qupi = false;
                CleanImageInfo();
                CleanLineChange();
                CleanProject();
                CleanWriteInfo();
            }
            else
            {
               MessageBoxShow("重量NG，请进行录入");
            }
            IniAPI.INIWriteValue(pathuser, "去皮", "皮重", tubWeightBox.Text);
        }

        private void clear_dataGrid()
        {
            for (int i = 0; i < 32; i++)
            {
                for (int j = 1; j < 7; j++)
                {

                    dataGridView6.Rows[j].Cells[i].Value = null;
                }

            }
        }

        // 数据查询
        private void button15_Click(object sender, EventArgs e)
        {
            string start_time = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 7:30";
            string end_time = dateTimePicker2.Value.AddDays(1).ToString("yyyy-MM-dd") + " 7:30";
            try
            {
                string query1 = $"SELECT * FROM detect_record WHERE line='B' AND detect_time >= '{start_time}' AND detect_time < '{end_time}'";
                //  string query1 = $"SELECT(detect_time,detect_type,line,classes,shift,project_num,product_batch,sap_code,product_name,detailed_information,total_count,red_light_count,yellow_light_count,tub_weight_1,tub_weight_2,tub_weight_3,tub_weight_4,tub_weight_5,tub_weight_6,defect_rework_description,rework_count,ng_count,rework_result,notes,inspector) FROM detect_record WHERE detect_time >= '{start_time}' AND detect_time < '{end_time}'";
                using (MySqlConnection writeConnection = OpenWriteConnection())
                using (MySqlCommand command = new MySqlCommand(query1, writeConnection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    // 创建数据表
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    // 填充数据表
                    adapter.Fill(dataTable);
                    // 将数据表绑定到DataGridView

                    dataGridView4.DataSource = dataTable;
                }
            }
            catch (Exception)
            {
                writeDbOk = false;
                MySqlConnection.ClearAllPools();
               MessageBoxShow("数据库连接失败，请检查网络！");
                return;
            }


            // 为第一列添加序号
            int columnIndex = 0;
            int number = 1;
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                row.Cells[columnIndex].Value = number;
                number++;
            }

            // 删除列名为id的这一列
            //string columnName = "id";
            //DataGridViewColumn columnToRemove = dataGridView4.Columns[columnName];
            //if (columnToRemove != null)
            //{
            //    dataGridView4.Columns.Remove(columnToRemove);
            //}

            taskStatus1.Image = Resources.gray_circle;
            taskStatus2.Image = Resources.gray_circle;
        }
        // 数据导出
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // 添加列标题行
                for (int i = 0; i < dataGridView4.Columns.Count; i++)
                {
                    sb.Append(dataGridView4.Columns[i].HeaderText);
                    sb.Append(",");
                }
                sb.AppendLine();

                // 添加数据行
                for (int row = 0; row < dataGridView4.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView4.Columns.Count; col++)
                    {
                        sb.Append(dataGridView4.Rows[row].Cells[col].Value);
                        sb.Append(",");
                    }
                    sb.AppendLine();
                }
                string filePath;
                // 指定CSV文件路径
                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    string start_time = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    filePath = $"{desktopPath}/{start_time}.csv";
                }
                else
                {
                    string start_time = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string end_time = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    filePath = $"{desktopPath}/{start_time}to{end_time}.csv";
                }


                // 保存CSV文件
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);

               MessageBoxShow("导出成功！");
            }
            catch (Exception ex)
            {
               MessageBoxShow("导出失败：" + ex.Message);
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
        }

        // 状态初始化
        private void InitStatus()
        {
            // 清空称重参数
            Array.Clear(tub_weights, 0, tub_weights.Length);
            scan_gun_start();
            end_weigh();
            if (endDoing)
            {
                inspector1_comboBox.Text = "";
                IniAPI.INIWriteValue(pathuser, "当班主操", "主操", inspector1_comboBox.Text);
            }
            // 称重框重置
            tubWeightBox1.Text = "";
            tubWeightBox2.Text = "";
            tubWeightBox3.Text = "";
            tubWeightBox4.Text = "";
            tubWeightBox5.Text = "";
            tubWeightBox6.Text = "";
            detectType1_comboBox.Enabled = true;
            // inspector1_comboBox.Text = "";
            detectType1_comboBox.Text = "";
            detectResultBox.Text = "";
            textBox8.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            isDoing = false;
            endDoing = false;
            checkBox2.Checked = false;
            textBox1.Enabled = true;


            if (detect_type == "尾检")
            {
                yellow_light_count = 0;
                yellowCountBox.Text = "";
                red_light_count = 0;
                redCountBox.Text = "";
            }


            // form3界面重置
            form3.reworkCountBox.Text = "";
            form3.ngCountBox.Text = "0";
            form3.reworkResultComboBox.Text = "";
            // form3相关界面重置
            defect_rework_description = "";
            rework_count = 0;
            ng_count = 0;
            detect_type = "";
            rework_result = "";
            startBtn.Enabled = true;
            startBtn.BackColor = Color.MediumSeaGreen;
            endBtn.Enabled = false;
            isCapturing = false;
        }
        // 搜索检测数据并且展示到datagridView
        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                string start_time = dateTimePicker4.Value.ToString("yyyy-MM-dd");
                string end_time = dateTimePicker3.Value.AddDays(1).ToString("yyyy-MM-dd");
                //  string query1 = $"SELECT () FROM detect_record WHERE detect_time >= '{start_time}' AND detect_time < '{end_time}'";
                //string query1 = $"SELECT* FROM detect_record WHERE rework_count > 0 AND detect_time >='{start_time}' AND detect_time < '{end_time}'";
                // string query1 = $"SELECT(id,detect_time,classes,shift,project_num,product_batch,sap_code,product_name,defect_rework_description,rework_count,ng_count,rework_result) FROM detect_record WHERE rework_count > 0 AND detect_time >='{start_time}' AND detect_time < '{end_time}'";
                string query1 = $"SELECT id, detect_time, classes, shift, project_num, product_batch, sap_code, product_name, defect_rework_description, rework_count, ng_count, rework_result FROM detect_record WHERE rework_count > 0  AND detect_time >= '{start_time}' AND detect_time< '{end_time}'";


                using (MySqlConnection writeConnection = OpenWriteConnection())
                using (MySqlCommand command = new MySqlCommand(query1, writeConnection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    // 创建数据表
                    DataTable dataTable = new DataTable();
                    // 填充数据表
                    adapter.Fill(dataTable);
                    // 将数据表绑定到DataGridView

                    dataGridView5.DataSource = dataTable;
                }
            }
            catch (Exception)
            {
                writeDbOk = false;
                MySqlConnection.ClearAllPools();
                MessageBoxShow("数据库连接失败，请检查网络！");
            }

            // 为第一列添加序号
            int columnIndex = 0;
            int number = 1;
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                row.Cells[columnIndex].Value = number;
                number++;
            }

            // 删除列名为id的这一列
            //string columnName = "id";
            //DataGridViewColumn columnToRemove = dataGridView5.Columns[columnName];
            //if (columnToRemove != null)
            //{
            //    dataGridView5.Columns.Remove(columnToRemove);
            //}
        }


        // 页面流程状态展示
        private void statusUpadate()
        {
            if (line == "B线")
            {
                if (processX_1 == 0)
                {
                    status1.Image = Resources.gray_circle;
                }
                else
                {
                    status1.Image = Resources.green_circle;
                }
                if (processX_2 == 0)
                {
                    arrow2.Image = Resources.grayArrow;
                    status2.Image = Resources.gray_circle;
                    statusCountLabel.ForeColor = Color.Gray;

                }
                else
                {
                    arrow2.Image = Resources.greenArrow;
                    status2.Image = Resources.green_circle;
                    statusCountLabel.ForeColor = Color.Green;


                }
                if (processX_3 == 0)
                {
                    arrow3.Image = Resources.grayArrow;
                    status3.Image = Resources.gray_circle;
                }
                else
                {
                    arrow3.Image = Resources.greenArrow;
                    status3.Image = Resources.green_circle;
                }

                statusCountLabel.Text = processX_2.ToString();
            }
        }



        // dataGridView初始化
        private void dataGridInit()
        {
            // 设置 DataGridView 的列数和行数
            dataGridView6.ColumnCount = 32;
            dataGridView6.RowCount = 7;
            // 隐藏列标题行（标题栏）
            dataGridView6.ColumnHeadersVisible = false;
            dataGridView6.RowHeadersVisible = false;
            // 设置 DataGridView 控件边框样式为无
            dataGridView6.BorderStyle = BorderStyle.None;
            int result = (int)Math.Round((double)dataGridView6.Size.Height / dataGridView6.RowCount);
            foreach (DataGridViewRow row in dataGridView6.Rows)
            {
                row.Height = result;
            }
            string[] texts = { "黄", "红" };

            // 确保 DataGridView 至少有 1 行和 24 列
            if (dataGridView6.Rows.Count > 0 && dataGridView6.Columns.Count >= 24)
            {
                // 遍历每一列，依次填充红、黄汉字
                for (int col = 0; col < 32; col++)
                {
                    int textIndex = col % texts.Length;
                    dataGridView6.Rows[0].Cells[col].Value = texts[textIndex];
                }
            }
        }
        // 对dataGridView进行格式统一
        private void dataGridView6_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // 设置单元格内容水平和垂直居中对齐
                dataGridView6.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


        // 定时器
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (locktime > 60)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
            }
            else
            {
                locktime++;
            }
            CheckDatabaseHealthIfDue();
            timeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            statusUpadate();
            if (delay_timeX > 0)
            {
                delay_timeX -= 1;
                label49.Text = "B线:" + delay_timeX.ToString();
            }
            else
            {
                label49.Text = "B线:0";
            }

            if (delay_timeY > 0)
            {
                delay_timeY -= 1;
                label50.Text = "Y线:" + delay_timeY.ToString();
            }
            else
            {
                label50.Text = "Y线:0";
            }
            if (delay_timeZ > 0)
            {
                delay_timeZ -= 1;
                label51.Text = "Z线:" + delay_timeZ.ToString();
            }
            else
            {
                label51.Text = "Z线:0";
            }
        }

        // 获取SAP码
        private string getSapCode(string line_name)
        {
            // 获取当前时间并调整时区
            DateTime adjustedTime = DateTime.Now.AddHours(-7).AddMinutes(-30);

            // 获取年份的后两位
            string year = adjustedTime.ToString("yy");

            // 获取 ISO 周数
            CultureInfo ci = CultureInfo.InvariantCulture;
            Calendar calendar = ci.Calendar;
            CalendarWeekRule weekRule = CalendarWeekRule.FirstFourDayWeek;
            DayOfWeek firstDayOfWeek = DayOfWeek.Monday;

            // 计算周数
            int weekNumber = calendar.GetWeekOfYear(adjustedTime, weekRule, firstDayOfWeek);

            // 获取今天是星期几（ISO 8601, 将周日设为7）
            int dayOfWeek = (int)adjustedTime.DayOfWeek;
            if (dayOfWeek == 0) dayOfWeek = 7;
            Console.WriteLine($"{year}{weekNumber:D2}{dayOfWeek}{line_name}");
            // 拼接结果
            return $"{year}{weekNumber:D2}{dayOfWeek}{line_name}";
        }

        // 缺陷类型代码切换
        private void defect_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Items.Clear();
            if (defect_comboBox.Text == "塑料瓶")
            {
                comboBox6.Items.AddRange(red_bottle_defects);
                form3.label12.Text = "瓶";
                form3.label13.Text = "瓶";
            }
            else if (defect_comboBox.Text == "软袋")
            {
                comboBox6.Items.AddRange(red_bag_defects);
                form3.label12.Text = "袋";
                form3.label13.Text = "袋";

            }

        }
        // 修改曝光时间
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            HOperatorSet.SetFramegrabberParam(hv_AcqHandle1, "ExposureTime", Convert.ToInt32(numericUpDown1.Value));
        }


        private void update_text(string txt)
        {
            if (m_isReady == 0 || m_iCurrentDeviceId == 0) return;

            uint uEncodeType = ConvertToEncodeType("GB2312");
            uint uColor = ConvertToColor("RED");
            uint uField = uint.Parse("1");


            StringBuilder pText = new StringBuilder(txt);
            if (ZHLED.LedAgent.ShowInstantText(m_iCurrentDeviceId, uEncodeType, uColor, pText, uField) != 0)
            {
                //this.log.AppendText("显示即时文本 :" + "设备[" + m_iCurrentDeviceId + "]" +
                //                    " 文本[" + this.textBox_instant.Text + "]\r\n");
            }
        }
        //LED
        private void OnInitDialog()
        {


            //this.comboBox_instant_color.Items.AddRange(new object[] { "RED", "GREEN", "YELLOW", "BLUE", "PURPLE", "CYAN", "WHITE" });
            //this.comboBox_instant_color.SelectedIndex = 0;

            //this.comboBox_instant_EncodingFormat.Items.AddRange(new object[] { "UNICODE", "GB2312" });
            //this.comboBox_instant_EncodingFormat.SelectedIndex = 0;

            //this.listView_devicelist.Columns.Add("地址", 120, HorizontalAlignment.Right);
            //this.listView_devicelist.Columns.Add("端口", 60, HorizontalAlignment.Right);
            //this.listView_devicelist.Columns.Add("状态", 80, HorizontalAlignment.Center);
            //this.listView_devicelist.Columns.Add("ID", 30, HorizontalAlignment.Right);

            this.textBox_ip.Text = "192.168.1.99";
            this.textBox_port.Text = "58258";




            // this.textBox_CharacterPartition.Text = "0";
        }
        private uint ConvertToEncodeType(string sText)
        {
            /*
             * 
             *  enum TEXT_ENCODE_MODE
	            {
		            TEXT_ENCODE_NONE=-1,
		            TEXT_ENCODE_UNICODE=0,
		            TEXT_ENCODE_GB2312=1
	            };
             */
            if (sText == "UNICODE")
            {
                return 0;
            }
            else if (sText == "GB2312")
            {
                return 1;
            }
            return 0;
        }
        private uint ConvertToColor(string sText)
        {
            /*
             *  enum TEXT_COLOR_TYPE
	            {
		            TEXT_COLOR_NONE,
		            TEXT_COLOR_RED=1,
		            TEXT_COLOR_GREEN=2,
		            TEXT_COLOR_YELLOW=3,
		            TEXT_COLOR_BLUE=4,
		            TEXT_COLOR_PURPLE=5,
		            TEXT_COLOR_CYAN=6,
		            TEXT_COLOR_WHITE=7,
		            TEXT_COLOR_MAXVALUE
	            };
             */
            if (sText == "RED")
            {
                return 1;
            }
            else if (sText == "GREEN")
            {
                return 2;
            }
            else if (sText == "YELLOW")
            {
                return 3;
            }
            else if (sText == "BLUE")
            {
                return 4;
            }
            else if (sText == "PURPLE")
            {
                return 5;
            }
            else if (sText == "CYAN")
            {
                return 6;
            }
            else if (sText == "WHITE")
            {
                return 7;
            }
            return 1;
        }
        public static void OnDeviceNotified(uint uDeviceId, IntPtr pNotifiedData, uint uCommand, IntPtr pUserParam)
        {
            string msg = "failure";
            if (pNotifiedData != null && (int)pNotifiedData != 0)
            {
                msg = "success";
            }
            m_form.m_SyncContext.Post(m_form.OnMessage, new DeviceMessage(uDeviceId, uCommand, msg));
        }
        private void OnMessage(object o)
        {
            //DeviceMessage msg = (DeviceMessage)o;
            //for (int i = 0; i < this.listView_devicelist.Items.Count; i++)
            //{
            //    ListViewItem item = this.listView_devicelist.Items[i];
            //    if (uint.Parse(item.SubItems[3].Text) == msg.m_deviceId)
            //    {
            //        if (msg.m_command == 0)
            //        {
            //            item.SubItems[2].Text = msg.m_content == "success" ? "在线" : "断开";
            //        }


            //        return;
            //    }
            //}


        }
        private string ConvertCommandToString(uint uCommand)
        {
            switch (uCommand)
            {
                case 0x21:
                    return ("打开屏幕");
                case 0x22:
                    return ("关闭屏幕");
                case 0x24:
                    return ("设置亮度");
                case 0x29:
                    return ("设置文本");
                case 0x2A:
                    return ("删除文本");
                case 0x3F:
                    return ("切换文本");
                case 0:
                    return "设备连接";
                default:
                    return ("未知动作");
            }
        }
        private void openLED()
        {
            if (m_isReady == 0) return;

            string sDeviceIpAddr = this.textBox_ip.Text;
            string sDevicePort = this.textBox_port.Text;
            if (sDeviceIpAddr.Trim().Length == 0 || sDevicePort.Trim().Length == 0)
            {
                return;
            }

            int isFound = 0;
            //for (int i = 0; i < this.listView_devicelist.Items.Count; i++)
            //{
            //    string sIp = this.listView_devicelist.Items[i].SubItems[0].Text;
            //    string sPort = this.listView_devicelist.Items[i].SubItems[1].Text;

            //    if (sPort == sDevicePort && sIp == sDeviceIpAddr)
            //    {
            //        isFound = 1;
            //        break;
            //    }
            //}
            if (isFound != 0) return;

            uint uDeviceId = ZHLED.LedAgent.RegisterDevice(sDeviceIpAddr,
                                                           uint.Parse(sDevicePort),
                                                           m_fCallback,
                                                           IntPtr.Zero);
            if (uDeviceId != 0)
            {
                m_iCurrentDeviceId = uDeviceId;

                ListViewItem item = new ListViewItem();
                item.Text = sDeviceIpAddr;
                item.SubItems.Add(sDevicePort);
                item.SubItems.Add("断开");
                item.SubItems.Add(Convert.ToString(uDeviceId));
                Console.WriteLine("初始化成功");
                //this.listView_devicelist.Items.Add(item);
            }

        }
        private void Initialize()
        {
            if ((m_isReady == 0) && (ZHLED.LedAgent.Init() == 1))
            {
                m_isReady = 1;
            }
            else
            {

            }
        }
        // 修改相机增益
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            HOperatorSet.SetFramegrabberParam(hv_AcqHandle1, "Gain", Convert.ToInt32(numericUpDown2.Value));
        }
        // 开始称重
        private void button4_Click(object sender, EventArgs e)
        {
            bool _ifTrue;
            IfTrue(out _ifTrue);
            if (!_ifTrue)
            {
                return;
            }
            else if (tubWeightBox == null)
            {
               MessageBoxShow("请先进行去皮！");
                return;
            }
            else if (defect_comboBox.Text == "")
            {
               MessageBoxShow("请先进行包装类型选择");

            }
            else if (wightWriteInfo)
            {
               MessageBoxShow("该产品已上传数据！");
            }
            else
            {
                openweight = true;
                button4.Enabled = false;
                num = 0;
                //string query1 = $"SELECT bag_weight FROM product_sku1 WHERE project_num = {Convert.ToInt32(textBox1.Text)}";
                //MySqlCommand command = new MySqlCommand(query1, connection);
                tubweight = bead_weight;
                for (int i = 0; i < wight_OK_NG.Length; i++)
                {
                    wight_OK_NG[i].Text = "";
                    textBoxes[i].Text = "";
                    textBoxes[i].Enabled = true;
                    textBoxes[i].ReadOnly = true;
                }
                weightresult = false;
                // start_weigh();

            }
        }

        #region halcon函数相关

        private string AppBaseDir; //当前exe程序的目录，方便在使用halcon引擎后，切换回来

        // HDevEngine
        private HTuple hv_DeepOcrHandle = new HTuple();
        private HDevEngine MyEngine = new HDevEngine();
        private String ProgramPath;
        private HDevProgram Program;
        private HDevProgramCall ProgramCall;
        private HDevProcedure Procedure;
        private HDevProcedureCall ProcedureCall;

        private Thread th1, th2;
        private HWindow hwin11, hwin12;
        private HObject ho_Image1, ho_Image2, ho_ROI_0;

        //Models
        private string modelName;  //模板名称
        private int camIndex = 1;  //相机1，相机2序号
        private bool cam_status = false;
        //ROI
        private ConcurrentDictionary<long, string> d_objects = new ConcurrentDictionary<long, string>();
        private List<HDrawingObject> drawing_objects = new List<HDrawingObject>();
        private HDrawingObject selected_drawing_object;
        private HTuple hv_AcqHandle1 = new HTuple();

        bool shotFlag = false;
        private void open_Cam()
        {

            HObject ho_Image = null;
            hv_AcqHandle1.Dispose();
            try
            {
                hv_AcqHandle1.Dispose();
                Console.WriteLine(DateTime.Now);
                //HOperatorSet.OpenFramegrabber("GenICamTL", 0, 0, 0, 0, 0, 0, "progressive",
                //   -1, "default", -1, "false", "default", "2", 0, -1, out hv_AcqHandle1);//GenICamTL  MVision
                //HOperatorSet.OpenFramegrabber("GigEVision2", 0, 0, 0, 0, 0, 0, "progressive",
                //   -1, "default", -1, "false", "default", "1", 0, -1, out hv_AcqHandle1);
                HOperatorSet.OpenFramegrabber("GenICamTL", 0, 0, 0, 0, 0, 0, "progressive",
                     -1, "default", -1, "false", "default", "2", 0, -1, out hv_AcqHandle1);

                // HOperatorSet.OpenFramegrabber("MVision", 1, 1, 0, 0, 0, 0, "progressive", 8, "default", -1, "false", "auto", "U3V:00J04361314 2", 0, -1, out hv_AcqHandle1);

                //HOperatorSet.OpenFramegrabber("GenICamTL", 0, 0, 0, 0, 0, 0, "progressive",
                //  -1, "default", -1, "false", "default", "2", 0, -1, out hv_AcqHandle1);//GenICamTL  MVision

                Console.WriteLine(DateTime.Now);
                HOperatorSet.SetFramegrabberParam(hv_AcqHandle1, "TriggerMode", "Off");

                numericUpDown1.Enabled = numericUpDown2.Enabled = true;

                HOperatorSet.GetFramegrabberParam(hv_AcqHandle1, "ExposureTime", out HTuple ExposureTimeValue);
                numericUpDown1.Value = Convert.ToInt32(ExposureTimeValue.D);
                HOperatorSet.GetFramegrabberParam(hv_AcqHandle1, "Gain", out HTuple GainValue);
                numericUpDown2.Value = Convert.ToInt32(GainValue.D);
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
                ShowMsg("错误行：" + ex.StackTrace.ToString());
                return;
            }

            while ((int)(1) != 0)
            {
                if (ho_Image != null)
                {
                    ho_Image.Dispose();
                }
                try
                {
                    HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle1, -1);
                }
                catch (Exception ex)
                {

                    ShowMsg(ex.Message);
                }
                try
                {
                    hSmartWin11.HalconWindow.DispObj(ho_Image);
                }
                catch (Exception ex)
                {
                    ShowMsg(ex.Message);
                    //MessageBox.Show("相机打开失败，请重新打开！");
                    shotFlag = false;
                    camOn = false;
                    button2.Enabled = true;
                    button27.Enabled = true;
                    closeLight();
                    return;
                }
                //
                if (shotFlag == true)
                {
                    numericUpDown1.Enabled = numericUpDown2.Enabled = false;
                    shotFlag = false;

                    try
                    {
                        Directory.SetCurrentDirectory(AppBaseDir);

                        MyEngine = new HDevEngine();
                        // MyEngine.StartDebugServer();  打开该语句，可以通过线程方式进入hdev脚本调试
                        MyEngine.Dispose();

                        ProgramPath = AppBaseDir + "hdev/process.hdev";
                        Program = new HDevProgram(ProgramPath);
                        Procedure = new HDevProcedure(Program, "fun_ocr");
                        ProcedureCall = new HDevProcedureCall(Procedure);

                        Directory.SetCurrentDirectory(AppBaseDir); //把整个程序的目录环境设置回来
                    }
                    catch (Exception ex)
                    {
                        ShowMsg(ex.Message);
                        ShowMsg("错误行：" + ex.StackTrace.ToString());
                    }
                    DispZoomObj(ho_Image, hSmartWin11);


                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    ProcessImage(ho_Image, hSmartWin11.HalconWindow);
                    stopwatch.Stop();

                    // 获取运行时间
                    TimeSpan ts = stopwatch.Elapsed;

                    // 格式化显示时间
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                    ts.Hours, ts.Minutes, ts.Seconds,
                                    ts.Milliseconds / 10);

                    Console.WriteLine("RunTime " + elapsedTime);
                    break;
                }
            }

            //  HOperatorSet.WriteImage(ho_Image, "jpg", 0, "E:/Saveimage/" + DateTime.Now.ToString("yyMMddHHmmss") + ".jpg");
            try
            {
                HOperatorSet.CloseFramegrabber(hv_AcqHandle1);
                hv_AcqHandle1.Dispose();
            }
            catch (Exception)
            {
               MessageBoxShow("请勿多次点击！");
            }
            Thread.Sleep(500);

            closeLight();

        }
        public void set_suitable_device(HTuple hv_DeepOcrHandle)
        {
            HTuple hv_name = new HTuple(), hv_DLDeviceHandles = new HTuple();
            HTuple hv_Exception = new HTuple();
            // Initialize local and output iconic variables 
            try
            {
                //*cpu  gpu
                hv_name.Dispose();
                hv_name = "cpu";
                hv_DLDeviceHandles.Dispose();
                HOperatorSet.QueryAvailableDlDevices("runtime", hv_name, out hv_DLDeviceHandles);
                if ((int)(new HTuple((new HTuple(hv_DLDeviceHandles.TupleLength())).TupleEqual(
                    1))) != 0)
                {
                    HOperatorSet.SetDeepOcrParam(hv_DeepOcrHandle, "device", hv_DLDeviceHandles);
                }

                try
                {
                    // HOperatorSet.SetDeepOcrParam(hv_DeepOcrHandle, "detection_image_width", 500);
                    // HOperatorSet.SetDeepOcrParam(hv_DeepOcrHandle, "detection_image_height", 500);

                    HOperatorSet.SetDeepOcrParam(hv_DeepOcrHandle, "detection_min_link_score", 0.15);
                }
                // catch (Exception) 
                catch (HalconException HDevExpDefaultException1)
                {
                    HDevExpDefaultException1.ToHTuple(out hv_Exception);
                }


                hv_name.Dispose();
                hv_DLDeviceHandles.Dispose();
                hv_Exception.Dispose();

                return;
            }
            catch (HalconException HDevExpDefaultException)
            {
                hv_name.Dispose();
                hv_DLDeviceHandles.Dispose();
                hv_Exception.Dispose();

                throw HDevExpDefaultException;//会报内存不足
                ShowMsg("错误行：" + HDevExpDefaultException.StackTrace.ToString());
            }
        }
        // 图片处理
        private void ProcessImage(HObject ho_Image, HWindow hwin)
        {
            int Num = 1;
            HTuple CheckStr = new HTuple();

            //设置ROI
            var m1 = labelControlRoi1.Text.Split(',');
            ho_ROI_0.Dispose();

            HOperatorSet.GenRectangle1(out ho_ROI_0, double.Parse(m1[0]), double.Parse(m1[1]),
                double.Parse(m1[2]), double.Parse(m1[3]));

            try
            {
                ProcedureCall.SetInputIconicParamObject("Image", ho_Image);
                ProcedureCall.SetInputIconicParamObject("ROI_0", ho_ROI_0);
                ProcedureCall.SetInputCtrlParamTuple("DeepOcrHandle", hv_DeepOcrHandle);
                ProcedureCall.SetInputCtrlParamTuple("CheckStr", stdPrintCode);
                ProcedureCall.Execute();
                var Region_ok = ProcedureCall.GetOutputIconicParamObject("Region_ok");
                var Region_ng = ProcedureCall.GetOutputIconicParamObject("Region_ng");
                var RecognitionStrs = ProcedureCall.GetOutputCtrlParamTuple("RecognitionStrs");
                var Result = ProcedureCall.GetOutputCtrlParamTuple("Result");
                string detect_res = "";
                // 检测结果

                if (photograph == "批号")
                {
                    try
                    {
                        detect_res = RecognitionStrs.S.Trim().Substring(0, 10);
                        char[] detect_info = detect_res.ToCharArray();

                        if (detect_info[8] == '9')
                        {
                            detect_info[8] = 'S';
                        }
                        else if (detect_info[8] == '5')
                        {
                            detect_info[8] = 'S';
                        }
                        else if (detect_info[8] == '6')
                        {
                            detect_info[8] = 'S';
                        }

                        if (detect_info[9] == 'O')
                        {
                            detect_info[9] = '0';
                        }
                        //if (detect_info[10] == '1')
                        //{
                        //    detect_info[10] = 'I';
                        //}

                        string detect_result = string.Join("", detect_info);
                        //if (detect_result == stdPrintCode)
                        //{

                        //    label56.Text = "OK";
                        //    label56.ForeColor = Color.Green;
                        //    detectResultBox.Text = detect_result;
                        //}
                        //else
                        //{
                        //    label56.Text = "NG";
                        //    label56.ForeColor = Color.Red;
                        //    detectResultBox.Text = detect_result;
                        //}
                        Thread.Sleep(10);
                        detectResultBox.Text = detect_result;
                        string path1 = saveimage("批号");// + DateTime.Now.ToString("yyyy_MM_dd") + "批号";

                        if (!Directory.Exists(path1))
                        {
                            Directory.CreateDirectory(path1);
                        }

                        HOperatorSet.WriteImage(ho_Image, "jpg", 0, path1 + "\\" + DateTime.Now.ToString("HH_mm_ss"));

                    }
                    catch (Exception)
                    {

                        detectResultBox.Text = detect_res;
                    }

                }
                if (photograph == "项目号")
                {
                    detect_res = RecognitionStrs.S.Trim().Substring(0, 8);
                    //if (detect_res == project_num)
                    //{
                    //    label57.Text = "OK";
                    //    label57.ForeColor = Color.Green;
                    //}
                    //else
                    //{
                    //    label57.Text = "NG";
                    //    label57.ForeColor = Color.Red;

                    //}

                    textBox8.Text = detect_res;
                    string path2 = saveimage("项目号");// + DateTime.Now.ToString("yyyy_MM_dd") + "项目号";

                    if (!Directory.Exists(path2))
                    {
                        Directory.CreateDirectory(path2);
                    }
                    HOperatorSet.WriteImage(ho_Image, "jpg", 0, path2 + "\\" + DateTime.Now.ToString("HH_mm_ss"));

                }
                if (photograph == "正标")
                {
                    detect_res = RecognitionStrs.S.Trim().Substring(0, 8);
                    //if (detect_res == project_num)
                    //{
                    //    label59.Text = "OK";
                    //    label59.ForeColor = Color.Green;
                    //}
                    //else
                    //{
                    //    label59.Text = "NG";
                    //    label59.ForeColor = Color.Red;

                    //}
                    textBox25.Text = detect_res;
                    string path3 = saveimage("正标");// + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + "正标";

                    if (!Directory.Exists(path3))
                    {
                        Directory.CreateDirectory(path3);
                    }
                    HOperatorSet.WriteImage(ho_Image, "jpg", 0, path3 + "\\" + DateTime.Now.ToString("HH_mm_ss"));


                }
                if (photograph == "背标")
                {
                    detect_res = RecognitionStrs.S.Trim().Substring(0, 8);
                    //if (detect_res == project_num)
                    //{
                    //    label60.Text = "OK";
                    //    label60.ForeColor = Color.Green;
                    //}
                    //else
                    //{
                    //    label60.Text = "NG";
                    //    label60.ForeColor = Color.Red;

                    //}
                    textBox22.Text = detect_res;
                    string path4 = saveimage("背标");// + DateTime.Now.ToString("yyyy_MM_dd") + "背标";
                    if (!Directory.Exists(path4))
                    {
                        Directory.CreateDirectory(path4);
                    }
                    HOperatorSet.WriteImage(ho_Image, "jpg", 0, path4 + "\\" + DateTime.Now.ToString("HH_mm_ss"));
                }
                if (photograph == "关闭")
                {

                }

                ////在图像上显示内容
                //if (Result.I == 1) //图像处理结果OK
                //{

                //    HOperatorSet.SetFont(hwin, "微软雅黑-Bold-100");
                //    HOperatorSet.DispText(hwin, "OK", "window", "top", "right", "green", "box", 0);
                //}
                //else //NG
                //{
                //    label42.Text = "NG";
                //    label42.ForeColor = Color.Red;
                //    HOperatorSet.SetFont(hwin, "微软雅黑-Bold-100");
                //    HOperatorSet.DispText(hwin, "NG", "window", "top", "right", "red", "box", 0);
                //}

                HOperatorSet.SetDraw(hwin, "margin");
                HOperatorSet.SetLineWidth(hwin, 3);
                if (Result.I == 1)
                {
                    HOperatorSet.SetColor(hwin, "green");
                    HOperatorSet.DispObj(Region_ok, hwin);
                }
                else
                {
                    HOperatorSet.SetColor(hwin, "red");
                    HOperatorSet.DispObj(Region_ng, hwin);
                }
            }

            catch (HDevEngineException ex)
            {
               MessageBoxShow(ex.Message);
                ShowMsg("错误行：" + ex.StackTrace.ToString());

            }
            catch (Exception e)
            {
                //  HOperatorSet.WriteImage(ho_Image, "jpg", 0, "D:/两面图片/" + DateTime.Now.ToString("yyMMddHHmmss") + ".png");

                ShowMsg(e.Message);
                ShowMsg("错误行：" + e.StackTrace.ToString());
            }
        }
        private void AttachDrawObj(HDrawingObject obj)
        {
            obj.SetDrawingObjectParams("color", "magenta");

            drawing_objects.Add(obj);

            // The HALCON/C# interface offers convenience methods that
            // encapsulate the set_drawing_object_callback operator.
            obj.OnDrag(SobelFilter);
            obj.OnAttach(SobelFilter);
            obj.OnResize(SobelFilter);
            obj.OnSelect(OnSelectDrawingObject);
            if (selected_drawing_object == null)
                selected_drawing_object = obj;

            if (camIndex == 1)
                hSmartWin11.HalconWindow.AttachDrawingObjectToWindow(obj);

        }
        private void SobelFilter(HDrawingObject dobj, HWindow hwin, string type)
        {
            try
            {
                var t = dobj.GetDrawingObjectParams("type");
                if (t == "circle")
                {
                    string[] paras = new string[3];
                    paras[0] = dobj.GetDrawingObjectParams("row").D.ToString("F");
                    paras[1] = dobj.GetDrawingObjectParams("column").D.ToString("F");
                    paras[2] = dobj.GetDrawingObjectParams("radius").D.ToString("F");


                    UpdateIniRoi(dobj, t, paras);
                }
                else if (t == "rectangle1")
                {
                    string[] paras = new string[4];
                    paras[0] = dobj.GetDrawingObjectParams("row1").D.ToString("F");
                    paras[1] = dobj.GetDrawingObjectParams("column1").D.ToString("F");
                    paras[2] = dobj.GetDrawingObjectParams("row2").D.ToString("F");
                    paras[3] = dobj.GetDrawingObjectParams("column2").D.ToString("F");


                    UpdateIniRoi(dobj, t, paras);
                }
            }
            catch (HalconException hex)
            {
               MessageBox.Show(hex.GetErrorMessage(), "HALCON error", MessageBoxButtons.OK);
                ShowMsg("错误行：" + hex.StackTrace.ToString());
            }
        }

        private void UpdateIniRoi(HDrawingObject obj, string type, string[] paras)
        {
            //obj确实有变化，所以用其的ID来做为KEY
            if (d_objects.ContainsKey(obj.ID))
            {
                // var index = d_objects[obj.ID];

                if (type == "circle")
                {
                    var m = paras[0] + "," + paras[1] + "," + paras[2];

                    if (camIndex == 1)
                    {
                        labelControlRoi1.Text = m;
                        sys_ini.WriteKey("roi1", m);  // 更新配置文件
                    }


                    sys_ini.WriteKey(modelName + "_roi", m); // 更新配置文件
                }
                else if (type == "rectangle1")
                {
                    var m = paras[0] + "," + paras[1] + "," + paras[2] + "," + paras[3];

                    if (camIndex == 1)
                    {
                        labelControlRoi1.Text = m;
                        sys_ini.WriteKey("roi1", m); // 更新配置文件
                    }



                }
            }
        }
        // 打开相机
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    bool _ifTrue;
        //    IfTrue(out _ifTrue);
        //    if (!_ifTrue)
        //    {
        //        return;
        //    }

        //    CamOn();
        //}
        public bool IfTrue(out bool _true)
        {
            fistWeighing = Convert.ToBoolean(IniAPI.INIGetStringValue(pathuser, "是否首检", "首检", ""));
            if (!fistWeighing)
            {
               MessageBox.Show("未进行称重首检", "警告!", MessageBoxButtons.OK);
                return _true = false;
            }
            //else  if (!btnSure)
            //{
            //   MessageBoxShow("存在未确认结果！");
            //    return _true = false;
            //}
            return _true = true;
        }
        //打开相机

        public void CamOn()
        {

            openLight();  // 开灯
            //Thread.Sleep(500);        
            Thread cam_th = new Thread(open_Cam);
            cam_th.IsBackground = true;
            cam_th.Start();
            //button2.Enabled = true;
            //button1.Enabled = false;
            //button12.Enabled = true;
            //button27.Enabled = true;
            //button29.Enabled = true;
            camOn = true;
        }
        // 拍照   要求每次拍照后不需要再次点击开启相机
        int camnum = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            camnum++;
            if (camnum != 1)
            {
               MessageBoxShow("请勿双击或多次点击！");
                return;
            }
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                camnum = 0;
            });
            button2.Enabled = false;

            bool _ifTrue;
            IfTrue(out _ifTrue);

            if (!_ifTrue)
            {
                return;
            }

            if (camOn)
            {
                photograph = "批号";
                ChangeT_F();
                shotFlag = true;
                camOn = false;
                button27.Enabled = true;
                button29.Enabled = true;
            }
            else
            {
                CamOn();
                photograph = "批号";
                //button2.Enabled = true ;
                button12.Enabled = false;
                button27.Enabled = false;
                button29.Enabled = false;
                //shotFlag = true;
            }
            button2.Enabled = true;
        }
        // 载入ROI
        private void LoadROI(string roi)
        {
            if (d_objects.Count > 0)
            {
                foreach (var dobj in drawing_objects)
                {
                    dobj.ClearDrawingObject();
                    dobj.Dispose();
                }

                drawing_objects.Clear();
                selected_drawing_object = null;
                d_objects.Clear();
            }

            hSmartWin11.Refresh();
            //hSmartWin12.Refresh();

            var m1 = roi.Split(',');
            var selected_drawing_object1 =
                new HDrawingObject(double.Parse(m1[0]), double.Parse(m1[1]), double.Parse(m1[2]), double.Parse(m1[3]));
            AttachDrawObj(selected_drawing_object1);
            d_objects.TryAdd(selected_drawing_object1.ID, "1");
        }
        public void DispZoomObj(HObject ho_Image, HSmartWindowControl smartWin)
        {
            HTuple hv_Width = new HTuple(), hv_Height = new HTuple();
            HTuple hv_winWHRatio = new HTuple(), hv_picWHRatio = new HTuple();
            HTuple hv_partWidth = new HTuple(), hv_partHeight = new HTuple();
            HTuple hv_winWidth = new HTuple(), hv_winHeight = new HTuple();
            HOperatorSet.SetSystem("int_zooming", "false");
            HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Height);
            hv_winWidth = smartWin.Size.Width;
            hv_winHeight = smartWin.Size.Height;
            hv_picWHRatio = 1.0 * hv_Width / hv_Height;
            hv_winWHRatio = 1.0 * hv_winWidth / hv_winHeight;
            smartWin.HalconWindow.ClearWindow();
            if (new HTuple(hv_Width.TupleGreater(hv_winWidth)).TupleOr(new HTuple(hv_Height.TupleGreater(
                hv_winHeight))) != 0)
            {
                //超宽图像
                //如果图片宽高比 大于 窗口宽高比
                //则宽度方向顶格
                if (new HTuple(hv_picWHRatio.TupleGreaterEqual(hv_winWHRatio)) != 0)
                {
                    hv_partWidth = hv_Width.Clone();
                    hv_partHeight = hv_Width / hv_winWHRatio;
                    var m = (hv_partHeight - hv_Height) / 2.0;
                    HOperatorSet.SetPart(smartWin.HalconWindow, -m, 0, -m + hv_partHeight - 1, hv_partWidth - 1);
                    HOperatorSet.DispObj(ho_Image, smartWin.HalconWindow);
                }

                //超高图像
                //如果图片宽高比 小于 窗口宽高比
                //则高度方向顶格
                if (new HTuple(hv_picWHRatio.TupleLess(hv_winWHRatio)) != 0)
                {
                    hv_partWidth = hv_Height * hv_winWHRatio;
                    hv_partHeight = hv_Height.Clone();
                    //终于搞清楚setpart了。把花盆图片居中显示。setpart的概念相当于把图片放到画布上，setpart的参数就是放图片的坐标位置。
                    var m = (hv_partWidth - hv_Width) / 2.0;
                    HOperatorSet.SetPart(smartWin.HalconWindow, 0, -m, hv_partHeight - 1, -m + hv_partWidth - 1);
                    HOperatorSet.DispObj(ho_Image, smartWin.HalconWindow);
                }
            }
            else
            {
                //小图像
                //如果图片的长和宽都小于窗口，则以图片的原真实尺寸显示
                HOperatorSet.SetPart(smartWin.HalconWindow, 0, 0, -1, -1);
                HOperatorSet.DispObj(ho_Image, smartWin.HalconWindow);
            }

            hv_Width.Dispose();
            hv_Height.Dispose();
            hv_winWHRatio.Dispose();
            hv_picWHRatio.Dispose();
            hv_partWidth.Dispose();
            hv_partHeight.Dispose();
            hv_winWidth.Dispose();
            hv_winHeight.Dispose();
        }
        private void DisplayException(HDevEngineException Ex)
        {
            string FullMessage = "Message: <" + Ex.Message + ">" +
                                 ",  Error in program / procedure: <" + Ex.ProcedureName + ">" +
                                 ",  program line: <" + Ex.LineText + ">" +
                                 ",  line number: <" + Ex.LineNumber + ">" +
                                 ",  HALCON Error Number: <" + Ex.HalconError + ">";

            string Title = "HDevEngine Exception (Category: " +
                           Ex.Category.ToString() + ")";

           MessageBox.Show(FullMessage, Title);
        }

        private void OnSelectDrawingObject(HDrawingObject dobj, HWindow hwin, string type)
        {
            selected_drawing_object = dobj;
            SobelFilter(dobj, hwin, type);
        }
        #endregion

        #region  光源控制相关函数

        private int[] lights = new int[32];                    //预设32通道亮度
        byte[] rcvBuffer = new byte[8];
        byte[] senBuffer = new byte[8];
        public int OutTime = 500;    //响应超时时间
        string RecString = "";

        //串口数据发送
        private void serialsend(byte command, byte port, int value)
        {
            byte[] b_value = new byte[3];              //亮度值用3位字节表示

            byte[] b_check = new byte[2];              //校验位用2位字表示

            string str1 = value.ToString("X3");        //亮度值处理,将value转化为3位的16进制字符
            b_value[0] = Convert.ToByte(str1[0]);      //将数据转化为Ascall码十进制数
            b_value[1] = Convert.ToByte(str1[1]);      //将数据转化为Ascall码十进制数
            b_value[2] = Convert.ToByte(str1[2]);      //将数据转化为Ascall码十进制数

            //MessageBox.Show(b_value[0].ToString() + " " + b_value[1].ToString() + " " + b_value[2].ToString());

            senBuffer[0] = 0x24;                                //特征字$
            //等价于senBuffer[0] =36; 
            senBuffer[1] = Convert.ToByte(command + 48);                      //命令1表示打开,2表示关闭,3表示设置,4表示读取,command+48表示将数据转化为Ascall码十进制数
            senBuffer[2] = Convert.ToByte(port + 48);                         //通道，port+48表示将数据转化为Ascall码十进制数
            senBuffer[3] = b_value[0];                         //数据高位
            senBuffer[4] = b_value[1];                         //数据中位
            senBuffer[5] = b_value[2];                         //数据低位

            senBuffer = GetCheckBits(senBuffer);            //调用验证位处理函数,处理senBuffer[]最后2个验证位
            //MessageBox.Show(senBuffer[1].ToString());

            if (lightSerialPort.IsOpen)
            {
                lightSerialPort.DiscardInBuffer();               //清除串口接收缓冲区
                lightSerialPort.Write(senBuffer, 0, 8);          //发送指令
                string SendString = GetByteToString(senBuffer);
                //ShowMesage("发送:" + SendString);
                CmdRespond(command, port, senBuffer);              //等待响应
            }
            else
            {
                //listBox1.Items.Add("串口没有打开，光源数据修改失败");
                Console.WriteLine("串口没有打开，修改失败");
            }
        }
        void ShowMesage(string Mes)                                            //通讯显示函数
        {

            string ch = "\r\n";
            Mes += ch;
            //sBuffer += DecodeData(senBuffer);
            //rBuffer += DecodeData(rcvBuffer);
            //textBox1.AppendText(Mes);
        }
        bool CmdRespond(byte command, byte port, byte[] senBuffer)  //响应等待函数
        {
            lightSerialPort.ReadTimeout = OutTime;
            bool res = false;
            RecString = "";
            string SendString = GetByteToString(senBuffer);
            if (command == 1 || command == 2 || command == 3)
            {
                try
                {
                    int reviByte = lightSerialPort.ReadByte();                         //指令1，2,3等待响应一个字符
                    RecString = ((char)reviByte).ToString();
                    if (RecString != "$") ;
                    else res = true;
                }
                catch (Exception a)
                {
                    //MessageBox.Show(SendString + "接收响应" + a.Message);
                    ShowMsg("错误行：" + a.StackTrace.ToString());
                }

            }
            if (command == 4)      //读取亮度指令响应处理
            {
                try
                {
                    for (int i = 0; i < 8; i++)
                    {
                        int reviByte = lightSerialPort.ReadByte();                         //指令4等待响应8个字符
                        RecString += ((char)reviByte).ToString();
                        if (i == 0 && RecString == "&") break;
                    }

                    byte[] CheckRecBuffer = GetCheckBits(GetStringToByte(RecString));
                    string CheckRecStr = GetByteToString(CheckRecBuffer);
                    if (CheckRecStr == RecString)  //
                    {
                        lights[port - 1] = GetValue(RecString);
                        res = true;
                    }
                    else
                    {
                        MessageBox.Show(RecString + "," + CheckRecStr + "指令4，校验和有误！");
                    }
                }
                catch (Exception b)
                {
                    //MessageBox.Show(SendString + "接收响应" + b.Message);
                    ShowMsg("错误行：" + b.StackTrace.ToString());
                }
            }

            //ShowMesage("接收:" + RecString);
            return res;
        }

        int GetValue(string RecString)     //解码亮度函数
        {
            int value;                                                           //解码后亮度值为16进制字符表示，转化为十进制
            byte value1 = ValueChangeTo10(RecString[3].ToString()[0]);                 //进制转换函数
            byte value2 = ValueChangeTo10(RecString[4].ToString()[0]);
            byte value3 = ValueChangeTo10(RecString[5].ToString()[0]);
            value = value1 * 16 * 16 + value2 * 16 + value3;
            return value;
        }
        byte[] GetStringToByte(string str)
        {
            byte[] b = Encoding.ASCII.GetBytes(str);
            return b;
        }
        byte ValueChangeTo10(char ch)   //16进制转10进制，个位转换函数
        {
            byte result = 16;             //失败返回16，成功返回0-15
            switch (ch)
            {
                case '0':
                    result = 0;
                    break;
                case '1':
                    result = 1;
                    break;
                case '2':
                    result = 2;
                    break;
                case '3':
                    result = 3;
                    break;

                case '4':
                    result = 4;
                    break;
                case '5':
                    result = 5;
                    break;
                case '6':
                    result = 6;
                    break;
                case '7':
                    result = 7;
                    break;

                case '8':
                    result = 8;
                    break;
                case '9':
                    result = 9;
                    break;
                case 'A':
                    result = 10;
                    break;
                case 'B':
                    result = 11;
                    break;

                case 'C':
                    result = 12;
                    break;
                case 'D':
                    result = 13;
                    break;
                case 'E':
                    result = 14;
                    break;
                case 'F':
                    result = 15;
                    break;
            }

            return result;

        }
        private void lightStatus_Click(object sender, EventArgs e)
        {
            if (lightSerialPort.IsOpen)
            {
                closeLight();
            }
            else
            {
                openLight();
            }
        }
        private void detectResultBox_TextChanged(object sender, EventArgs e)
        {
            string de = detectResultBox.Text;
            string std = stdProductBatchBox.Text;
            if (de == std)//不清楚为什么一样还NG
            {
                label56.Text = "OK";
                label56.ForeColor = Color.Green;
            }
            else
            {
                label56.Text = "NG";
                label56.ForeColor = Color.Red;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            form3.Show();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
        }
        private void lightUpDown_ValueChanged(object sender, EventArgs e)
        {
            lightValue = (int)lightUpDown.Value;
            serialsend(3, 1, lightValue);
            serialsend(3, 2, lightValue);
            serialsend(3, 3, lightValue);
            serialsend(3, 4, lightValue);
        }
        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("确认需要执行重置操作吗?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ShowMsg("执行了流程重置");
                if (line == "B线")
                {
                    if (detect_type == "首检")
                    {
                        processX_1 = 0;
                        sys_ini.WriteKey("processX_1", processX_1.ToString());
                    }
                    else if (detect_type == "PQS")
                    {
                        //processX_2 -= 1;
                        //sys_ini.WriteKey("processX_2", processX_2.ToString());
                    }
                    else
                    {
                        processX_3 = 0;
                        sys_ini.WriteKey("processX_3", processX_3.ToString());

                    }


                }

                InitStatus();
            }
            else if (result == DialogResult.No)
            {

            }

            line1_comboBox.Text = IniAPI.INIGetStringValue(pathuser, "抽检信息", "线体号", "");
            inspector1_comboBox.Text = IniAPI.INIGetStringValue(pathuser, "抽检信息", "抽检人员", "");
            detectType1_comboBox.Text = IniAPI.INIGetStringValue(pathuser, "抽检信息", "检查类型", "");
            textBox1.Text = IniAPI.INIGetStringValue(pathuser, "抽检信息", "项目号", "");
            CleanImageInfo();
            CleanLineChange();
            CleanProject();
            CleanWriteInfo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Thread music_th = new Thread(music_play);
            music_th.IsBackground = true;
            music_th.Start();
        }



        private void button9_Click(object sender, EventArgs e)
        {
            bool _ifTrue;
            IfTrue(out _ifTrue);
            if (!personSure)
            {
               MessageBoxShow("请进行人工确认！");
                return;
            }
            if (label59.Text == "NG" || label56.Text == "NG" || label60.Text == "NG")
            {
               MessageBoxShow("请确认拍照结果！");
                return;
            }
            if (_ifTrue)
            {
                if (label56.Text == "OK")// && label57.Text == "OK")
                {
                   MessageBoxShow("提交成功");
                    sap_code = outerSapBox.Text;
                }
                else
                {
                   MessageBoxShow("信息不一致,不可提交");
                }
            }
            else
            {
               MessageBoxShow("存在未确认数据！");
            }
            personSure = false;
        }

        private void button8_Click_2(object sender, EventArgs e)
        {


        }

        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("确认需要执行重置操作吗?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ShowMsg("执行了全部流程重置");
                if (line == "B线")
                {

                    processX_1 = processX_2 = processX_3 = 0;
                    sys_ini.WriteKey("processX_1", processX_1.ToString()); // 更新配置文件
                    sys_ini.WriteKey("processX_2", processX_2.ToString()); // 更新配置文件
                    sys_ini.WriteKey("processX_3", processX_3.ToString()); // 更新配置文件

                }
                else if (line == "Y线")
                {

                    processY_1 = processY_2 = processY_3 = 0;
                    sys_ini.WriteKey("processY_1", processY_1.ToString()); // 更新配置文件
                    sys_ini.WriteKey("processY_2", processY_2.ToString()); // 更新配置文件
                    sys_ini.WriteKey("processY_3", processY_3.ToString()); // 更新配置文件


                }
                else if (line == "Z线")
                {

                    processZ_1 = processZ_2 = processZ_3 = 0;
                    sys_ini.WriteKey("processZ_1", processZ_1.ToString()); // 更新配置文件
                    sys_ini.WriteKey("processZ_2", processZ_2.ToString()); // 更新配置文件
                    sys_ini.WriteKey("processZ_3", processZ_3.ToString()); // 更新配置文件
                }

                InitStatus();
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {

            try
            {
                lightSerialPort.Open();
                serialsend(3, 1, 255); //R
                serialsend(3, 2, 255);//G
                serialsend(3, 3, 0);//B
                ShowMsg("蓝光打开成功");

            }
            catch (Exception ex)
            {
                ShowMsg("拒绝连接");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            try
            {
                lightSerialPort.Open();
                serialsend(3, 1, 0); //R
                serialsend(3, 2, 255);//G
                serialsend(3, 3, 0);//B
                ShowMsg("红光打开成功");

            }
            catch (Exception ex)
            {
                ShowMsg("拒绝连接");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                lightSerialPort.Open();
                serialsend(3, 1, 255); //R
                serialsend(3, 2, 255);//G
                serialsend(3, 3, 255);//B
                ShowMsg("白光打开成功");

            }
            catch (Exception ex)
            {
                ShowMsg("拒绝连接");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tubWeightBox6_Leave(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4(AddCtr, get);
            f4.ShowDialog();
            locktime = 0;
            pictureBox4.Image = Resources.unlock;

        }

        //委托传值调用此方法
        private void AddCtr()
        {
            button7.Enabled = true;
            button17.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
        }

        //委托传方法
        private void get(string res, bool a)
        {
            b7b17 = a;
            ShowMsg("登录成功");

        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            IniAPI.INIWriteValue(pathuser, "抽检信息", "线体号", line1_comboBox.Text);
            IniAPI.INIWriteValue(pathuser, "抽检信息", "抽检人员", inspector1_comboBox.Text);
            IniAPI.INIWriteValue(pathuser, "抽检信息", "检查类型", detectType1_comboBox.Text);
            IniAPI.INIWriteValue(pathuser, "抽检信息", "项目号", textBox1.Text);

            Form4 f4 = new Form4(AddCtr, get);
            f4.ShowDialog();
            locktime = 0;
            if (b7b17)
            {
                b7b17 = false;
                button7.PerformClick();
            }
        }

        private void button17_MouseDown(object sender, MouseEventArgs e)
        {
            Form4 f4 = new Form4(AddCtr, get);
            f4.ShowDialog();
            locktime = 0;
            if (b7b17)
            {
                b7b17 = false;
                button17.PerformClick();
            }
        }
        //新增员工
        private void button3_Click_1(object sender, EventArgs e)
        {
            //齐鲁磊
            //黄亚萍
            //何秀秀
            //周本荣
            //钟家桂
            //程永康
            //何玉清
            //齐传兵
            //王华玲
            if (IniAPI.INIGetAllItemKeys(pathuser, "员工信息").Contains(textBox5.Text))
            {
               MessageBoxShow("员工信息已录入，请勿重复录入");
            }
            else
            {
                IniAPI.INIWriteValue(pathuser, "员工信息", textBox5.Text, "");
                inspector1_comboBox.Items.Add(textBox5.Text);
                comboBox1.Items.Add(textBox5.Text);
            }

        }
        //员工删除
        private void button24_Click(object sender, EventArgs e)
        {


        }





        private void endBtn_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void tubWeightBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tubWeightBox1_Click(object sender, EventArgs e)
        {
            if (tubWeightBox1.Enabled == false)
            {
               MessageBoxShow("请点击开始称重");
            }
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            closeLight();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 8)
            {
                string project_change = IniAPI.INIGetStringValue(pathuser, "项目号变更", "项目号", "");
                if (project_change != textBox1.Text && textBox1.Text != "")
                {
                    IniAPI.INIWriteValue(pathuser, "项目号变更", "项目号", textBox1.Text);
                    detectType1_comboBox.Text = "首检";

                }

            }



        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //if (e.TabPageIndex == 2)
            //{
            //    if (selectpage != true)
            //    {
            //        e.Cancel = true;
            //    }
            //    else
            //    {
            //        e.Cancel = false;
            //    }

            //}
        }
        void Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (selectpage != true)
            {
                if (e.TabPageIndex == 2)
                {
                   MessageBoxShow("请先确认项目号");
                    e.Cancel = true;
                    tabControl1.Selecting -= new TabControlCancelEventHandler(Selecting);
                }
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            //齐鲁磊
            //黄亚萍
            //何秀秀
            //周本荣
            //钟家桂
            //程永康
            //何玉清
            //齐传兵
            //王华玲
            if (IniAPI.INIGetAllItemKeys(pathuser, "员工信息").Contains(textBox5.Text))
            {
               MessageBoxShow("员工信息已录入，请勿重复录入");
            }
            else
            {
                IniAPI.INIWriteValue(pathuser, "员工信息", textBox5.Text, "");
                inspector1_comboBox.Items.Add(textBox5.Text);
                comboBox1.Items.Add(textBox5.Text);
            }
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            inspector1_comboBox.Items.Remove(comboBox1.Text);
            IniAPI.INIDeleteKey(pathuser, "员工信息", comboBox1.Text);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
           MessageBoxShow("删除成功");
        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            bool _ifTrue;
            IfTrue(out _ifTrue);
            if (!_ifTrue)
            {
                return;
            }
            if (camOn)
            {
                photograph = "项目号";

                ChangeT_F();
                shotFlag = true;
                camOn = false;
            }
            else
            {

                CamOn();
                photograph = "项目号";

                button2.Enabled = false;
                button27.Enabled = false;
                button29.Enabled = false;
                button12.Enabled = true;
                //shotFlag = true;
            }

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Thread.Sleep(10);
            if (textBox7.Text == textBox8.Text)
            {
                label57.Text = "OK";
                label57.ForeColor = Color.Green;
            }
            else
            {
                label57.Text = "NG";
                label57.ForeColor = Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //删除当前选中
        private void button19_Click_1(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedCells.Count == 0)
            {
                MessageBoxShow("表中无数据！");
                return;
            }
            DialogResult result =MessageBox.Show("确定删除此条信息?", "确认", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string deleteQuery;
                if (dataGridView4.SelectedCells.Count > 0)
                {

                    // 获取选中的单元格的行
                    int rowIndex = dataGridView4.SelectedCells[0].RowIndex;
                    // 获取选中行的detect_time值，假设detect_time列在第一列
                    string selectedDetectTime = dataGridView4.Rows[rowIndex].Cells[3].Value.ToString(); // 假设detect_time在第一列

                    // 构建删除数据的SQL语句
                    deleteQuery = $"DELETE FROM detect_record WHERE detect_time = '{selectedDetectTime}'";

                    if (DateTime.TryParse(selectedDetectTime, out DateTime detectTime))
                    {
                        // 将 DateTime 对象转换为适当的日期时间格式
                        string formattedDetectTime = detectTime.ToString("yyyy-MM-dd HH:mm:ss");

                        // 构建删除数据的SQL语句
                        deleteQuery = $"DELETE FROM detect_record WHERE detect_time = '{formattedDetectTime}'";

                        using (MySqlConnection writeConnection = OpenWriteConnection())
                        using (MySqlCommand command = new MySqlCommand(deleteQuery, writeConnection))
                        {
                            try
                            {
                                // 执行删除操作
                                command.ExecuteNonQuery();

                                // 从DataGridView中移除选中行
                                dataGridView4.Rows.RemoveAt(rowIndex);

                                // 更新序号列
                                UpdateRowNumbers();
                            }
                            catch (Exception ex)
                            {

                                ShowMsg("删除失败，此设备无数据库删除权限！" + ex);
                                MessageBoxShow("删除失败，此设备无数据库删除权限！");
                            }
                            MessageBoxShow("数据删除成功！");
                        }
                    }
                    else
                    {
                       MessageBoxShow("选中行的日期时间格式无效。");
                    }
                }
                else
                {
                   MessageBoxShow("请选择要删除的行。");
                }
            }
            else
            {
                return;
            }

        }
        private void UpdateRowNumbers()
        {
            // 更新序号列
            int number = 1;
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                row.Cells[0].Value = number; // 假设序号列在第一列
                number++;
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(AddCtr, get);
            f4.ShowDialog();
            locktime = 0;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            form2.MessageFromForm1 = defect_comboBox.Text;
            Form2 f2 = new Form2();
            f2.Show();
            form2.updataFrom();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            string pictureFile = @"D:\Saveimage";
            Task.Run(() =>
            {
                try
                {
                    Process.Start(pictureFile);
                }
                catch (Exception ex)
                {
                    ShowMsg("错误行：" + ex.StackTrace.ToString());
                }
            });
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button25_Click_2(object sender, EventArgs e)
        {
            if (defect_comboBox.Text == "")
            {
               MessageBoxShow("请选择缺陷类型");
                return;
            }
            // 将需要传递的变量赋值给 Form2 的属性
            form2.MessageFromForm1 = defect_comboBox.Text;
            // 显示 Form2 窗口
            form2.Show();
            form2.updataFrom();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            shotFlag = true;
            photograph = "关闭";
            button2.Enabled = true;
            button12.Enabled = true;
            button27.Enabled = true;
            button29.Enabled = true;
            camOn = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        int camnum2 = 0;
        private void button27_Click(object sender, EventArgs e)
        {
            camnum2++;
            if (camnum2 != 1)
            {
               MessageBoxShow("请勿双击或多次点击！");
                return;
            }
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                camnum2 = 0;
            });
            button27.Enabled = false;



            bool _ifTrue;
            IfTrue(out _ifTrue);
            if (!_ifTrue)
            {
                return;
            }//这是判断是否上一步完成的
            if (camOn)
            {
                photograph = "正标";
                ChangeT_F();
                shotFlag = true;
                camOn = false;
                button2.Enabled = true;
                button29.Enabled = true;
            }
            else
            {
                CamOn();
                photograph = "正标";
                //button27.Enabled = true;
                button2.Enabled = false;
                button12.Enabled = false;
                button29.Enabled = false;
                //shotFlag = true;
            }
            button27.Enabled = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = false;
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                button29.Enabled = true;
            });
            bool _ifTrue;
            IfTrue(out _ifTrue);
            if (!_ifTrue)
            {
                return;
            }
            if (camOn)
            {

                photograph = "背标";
                //button29.Enabled = true;
                ChangeT_F();
                shotFlag = true;
                camOn = false;
                button2.Enabled = true;
                button27.Enabled = true;
            }
            else
            {

                CamOn();
                photograph = "背标";
                button29.Enabled = true;
                button2.Enabled = false;
                button12.Enabled = false;
                button27.Enabled = false;
                //shotFlag = true;
            }

        }
        public void ChangeT_F()
        {
            if (backlabelingprojectnum.Text != "")
            {
                button29.Enabled = true;
            }
            button2.Enabled = true;
            button12.Enabled = true;
            if (labelingprojectnum.Text != "")
            {
                button27.Enabled = true;
            }

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            Thread.Sleep(10);
            if (labelingprojectnum.Text == textBox25.Text)
            {
                label59.Text = "OK";
                label59.ForeColor = Color.Green;
            }
            else
            {
                label59.Text = "NG";
                label59.ForeColor = Color.Red;
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            Thread.Sleep(10);
            if (backlabelingprojectnum.Text == textBox22.Text)
            {
                label60.Text = "OK";
                label60.ForeColor = Color.Green;
            }
            else
            {
                label60.Text = "NG";
                label60.ForeColor = Color.Red;
            }
        }
        private void MessageBoxShow(string message)
        {
            Form msg = new Form();
            Task.Run(new Action(() =>
            {
                Thread.Sleep(sleep);
                Invoke(new Action(() => {
                    try
                    {
                        msg.Close();
                    }
                    catch
                    {
                    }
                   
                }));

            }));
           MessageBox.Show(msg, message);

        }

        private void button30_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < firsttextBoxes.Length; i++)//点击校称清空数据
            {
                firsttextBoxes[i].Text = "";
                fistWiG_OK_NG[i].Text = "";
            }
            textBox26.Enabled = true;
            textBox27.Enabled = true;
            textBox28.Enabled = true;
            textBox30.Enabled = true;
            textBox31.Enabled = true;
            textBox26.ReadOnly = true;
            textBox27.ReadOnly = true;
            textBox28.ReadOnly = true;
            textBox30.ReadOnly = true;
            textBox31.ReadOnly = true;
            Current_weighing_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            openweight = true;
            firstweight = 0;
        }

        private void button31_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < firsttextBoxes.Length; i++)
                {
                    if (Convert.ToDouble(firsttextBoxes[i].Text) > 1001 || Convert.ToDouble(firsttextBoxes[i].Text) < 999)
                    {
                        if (Convert.ToDouble(firsttextBoxes[i].Text) > 500.5 || Convert.ToDouble(firsttextBoxes[i].Text) < 499.5)
                        {
                            Weighing_status = "不合格";
                        }
                        else
                        {
                            Weighing_status = "合格";
                        }

                    }
                    else
                    {
                        Weighing_status = "合格";
                    }
                }
                string sql = $"INSERT INTO scale_check (line,weight_1,weight_2,weight_3,weight_4,weight_5,verification_time,status) VALUES ('B','{float.Parse(textBox26.Text)}','{float.Parse(textBox27.Text)}','{float.Parse(textBox28.Text)}','{float.Parse(textBox30.Text)}','{float.Parse(textBox31.Text)}','{Current_weighing_time}','{Weighing_status}')";
                using (MySqlConnection writeConnection = OpenWriteConnection())
                using (MySqlCommand command = new MySqlCommand(sql, writeConnection))
                {
                    command.ExecuteNonQuery();
                }
               MessageBoxShow("首次称重数据保存成功");
            }
            catch (Exception ex)
            {
                ShowMsg("错误行：" + ex.StackTrace.ToString());
                if (textBox26.Text == "" || textBox27.Text == "" || textBox28.Text == "" || textBox30.Text == "" || textBox31.Text == "")
                {
                   MessageBoxShow("请确保五次校称！");
                }
                else
                {
                   MessageBoxShow("数据库链接失败，请检查网络！");
                }

                // throw;
            }
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            fistWeighing = true;//点击提交后可以使用检测功能
            IniAPI.INIWriteValue(pathuser, "是否首检", "首检", fistWeighing.ToString());
        }
        #region 判断变红 
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox10.Text != this.textBox9.Text)
            {
                this.textBox10.ForeColor = Color.Red;
            }
            else
            {
                this.textBox10.ForeColor = Color.Green;
            }
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox11.Text != this.textBox12.Text)
            {
                this.textBox11.ForeColor = Color.Red;
            }
            else
            {
                this.textBox11.ForeColor = Color.Green;
            }
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox13.Text != this.textBox14.Text)
            {
                this.textBox13.ForeColor = Color.Red;
            }
            else
            {
                this.textBox13.ForeColor = Color.Green;
            }
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox15.Text != this.textBox16.Text)
            {
                this.textBox15.ForeColor = Color.Red;
            }
            else
            {
                this.textBox15.ForeColor = Color.Green;
            }
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox17.Text != this.textBox18.Text)
            {
                this.textBox17.ForeColor = Color.Red;
            }
            else
            {
                this.textBox17.ForeColor = Color.Green;
            }
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox19.Text != this.textBox20.Text)
            {
                this.textBox19.ForeColor = Color.Red;
            }
            else
            {
                this.textBox19.ForeColor = Color.Green;
            }
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox21.Text != this.textBox24.Text)
            {
                this.textBox21.ForeColor = Color.Red;
            }
            else
            {
                this.textBox21.ForeColor = Color.Green;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox4 .Text != this.textBox29.Text)
            //{
            //    this.textBox4 .ForeColor = Color.Red;
            //}
            //else
            //{
            //    this.textBox4.ForeColor = Color.Green;
            //}
        }

        #endregion 
        private void button5_Click(object sender, EventArgs e)
        {

        }
        //有数据未进行确认不能进行下一步
        private void SureButton_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < readInfo.Length; i++)
            //{
            //    if (!writeInfo[i].ReadOnly  )
            //    {
            //        if (readInfo[i].Text != "" && writeInfo[i].Text == "")
            //        {
            //           MessageBoxShow("存在未确认数据！");
            //            btnSure = false;
            //            return;
            //        }
            //    }
            //}
            //btnSure = true;
            //MessageBox.Show("数据确认完成！");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            bool _ifTrue;
            IfTrue(out _ifTrue);
            if (!_ifTrue)
            {
                return;
            }
            button4.Enabled = true;
            tubWeightBox.Text = "";
            qupi = true;
            openweight = false;

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        byte[] GetCheckBits(byte[] buffer)                      //计算校验和,传入8位，返回8位
        {
            buffer[buffer.Length - 2] = 0;                      //任何数据与0异或都等于其本身，故先对第一个（高位）验证位赋0
            for (int i = 0; i < buffer.Length - 2; i++)
            {
                buffer[buffer.Length - 2] = Convert.ToByte(buffer[buffer.Length - 2] ^ buffer[i]);           //验证位分别与前面的每个数据累计作异或运算
            }

            buffer[buffer.Length - 1] = buffer[buffer.Length - 2];   //令buffer后2位元素（即验证位）相等
            buffer[buffer.Length - 2] >>= 4;                          //高位右移4位，得到高位验证位
            buffer[buffer.Length - 1] &= 15;                         //15二进制即0000 1111，按位与可获得低位验证位

            buffer[buffer.Length - 2] = Convert.ToByte(buffer[buffer.Length - 2].ToString("X1")[0]);   //强制转化16位进制字符，再转化为Ascall码
            buffer[buffer.Length - 1] = Convert.ToByte(buffer[buffer.Length - 1].ToString("X1")[0]);

            return buffer;
        }

        string GetByteToString(byte[] Buffer)                                       //解码函数，返回处理后的字符串
        {
            string str = Encoding.ASCII.GetString(Buffer);                    //解码全部发送的消息
            return str;
        }

        void openLight()
        {
            try
            {
                lightSerialPort.Open();
                serialsend(3, 1, 255);
                serialsend(3, 2, 255);
                serialsend(3, 3, 255);
                serialsend(3, 4, 255);
                lightUpDown.Value = 255;
                lightStatus.Image = Resources.green_circle;
                lightUpDown.Enabled = true;
                ShowMsg("光源打开成功");

            }
            catch (Exception ex)
            {
                ShowMsg("拒绝连接");
                ShowMsg("错误行：" + ex.StackTrace.ToString());
            }

        }

        void closeLight()
        {
            serialsend(3, 1, 0);
            serialsend(3, 2, 0);
            serialsend(3, 3, 0);
            serialsend(3, 4, 0);
            lightSerialPort.Close();
            lightUpDown.Value = 0;
            lightStatus.Image = Resources.gray_circle;
            ShowMsg("光源关闭成功");
            lightUpDown.Enabled = false;
        }
        private string saveimage(string type)
        {
            string rootPath = picFile;
            DateTime now = DateTime.Now;
            DateTime folderDate;
            if (now.Hour < 7 || (now.Hour == 7 && now.Minute < 30))
            {
                folderDate = now.Date.AddDays(-1);
            }
            else
            {
                folderDate = now.Date;
            }
            string detaPath = Path.Combine(rootPath, folderDate.ToString("yyyyMMdd"));
            if (!Directory.Exists(detaPath))
            {
                Directory.CreateDirectory(detaPath);
            }
            return detaPath + "\\";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            string videoFile = @"D:\视频";
            Task.Run(() =>
            {
                try
                {
                    Process.Start(videoFile);
                }
                catch (Exception ex)
                {
                    ShowMsg("错误行：" + ex.StackTrace.ToString());

                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (outerProductBatchBox.Text == textBox34.Text && outerSapBox.Text == textBox35.Text)
            {
                personSure = true;
            }
            else
            {
               MessageBoxShow("请正确输入数据！");
            }
        }

        private void button26_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged_1(object sender, EventArgs e)
        {
            if (labelingprojectnum.Text == textBox25.Text)
            {
                label59.Text = "OK";
                label59.ForeColor = Color.Green;
            }
            else
            {
                label59.Text = "NG";
                label59.ForeColor = Color.Red;
            }
        }

        private void textBox22_TextChanged_1(object sender, EventArgs e)
        {
            if (backlabelingprojectnum.Text == textBox22.Text)
            {
                label60.Text = "OK";
                label60.ForeColor = Color.Green;
            }
            else
            {
                label60.Text = "NG";
                label60.ForeColor = Color.Red;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.start_time = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 7:30";
            f5.end_time = dateTimePicker2.Value.AddDays(1).ToString("yyyy-MM-dd") + " 7:30";
            f5.ShowDialog();
        }

        private void button26_Click_2(object sender, EventArgs e)
        {
            if (num > 0)
            {
                if (wight_OK_NG[num - 1].Text == "NG")
                {
                    num -= 1;
                    textBoxes[num].Text = "";
                    wight_OK_NG[num].Text = "";
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //if (connection != null || connection2 != null)
            //{
            //    if (connection.State.ToString() == "Closed" || connection2.State.ToString() == "Closed")
            //    {
            //        ShowMsg("数据库断开链接！");
            //        open_mysql_connect();
            //    }
            //}
            CleanOldFolders("D:/视频");
        }

        public void CleanOldFolders(string rootPath)
        {
            // 获取驱动器信息
            DriveInfo drive = new DriveInfo(Path.GetPathRoot(rootPath));

            // 计算当前磁盘使用率
            double usedPercentage = 100 - (drive.AvailableFreeSpace * 100.0 / drive.TotalSize);

            // 如果磁盘使用率超过90%，则执行清理
            if (usedPercentage > 80)
            {
                ShowMsg($"磁盘空间警告：已使用 {usedPercentage:0.00}%，开始清理...");

                // 获取所有符合日期格式的文件夹
                var datedFolders = Directory.EnumerateDirectories(rootPath)
                    .Select(folderPath => new
                    {
                        Path = folderPath,
                        Name = Path.GetFileName(folderPath),
                        Date = TryParseFolderDate(Path.GetFileName(folderPath))
                    })
                    .Where(x => x.Date != null)
                    .OrderBy(x => x.Date) // 按日期升序排序（最早的在前）
                    .ToList();

                // 删除最早的文件夹直到磁盘空间低于90%或没有更多可删除的文件夹
                foreach (var folder in datedFolders)
                {
                    try
                    {
                        Directory.Delete(folder.Path, recursive: true);
                        ShowMsg($"已删除最早文件夹：{folder.Path}");

                        // 重新检查磁盘空间
                        drive = new DriveInfo(Path.GetPathRoot(rootPath));
                        usedPercentage = 100 - (drive.AvailableFreeSpace * 100.0 / drive.TotalSize);

                        if (usedPercentage <= 90)
                        {
                            ShowMsg($"磁盘空间已降至 {usedPercentage:0.00}%，停止清理");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowMsg($"删除失败 [{folder.Path}]：{ex.Message}");
                    }
                }
            }
            else
            {
                ShowMsg($"磁盘空间正常：已使用 {usedPercentage:0.00}%，无需清理");
            }
        }


        private static DateTime? TryParseFolderDate(string folderName)
        {
            if (DateTime.TryParseExact(folderName, "yyyy-MM-dd",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime folderDate))
            {
                return folderDate;
            }
            return null;
        }




        private void button19_MouseDown(object sender, MouseEventArgs e)
        {
            Form4 f4 = new Form4(AddCtr, get);
            f4.ShowDialog();
            locktime = 0;
            if (b7b17)
            {
                b7b17 = false;
                button19.PerformClick();
            }
        }

        private void checkBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!checkBox2.Checked)
            {
                Form4 f4 = new Form4(AddCtr, get);
                f4.ShowDialog();
                locktime = 0;
                if (b7b17)
                {
                    b7b17 = false;
                    checkBox2.Checked = true;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = textBox3.ReadOnly = !checkBox2.Checked;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            stdPrintCodeBox.Text = stdProductBatchBox.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            sapCodeBox.Text = textBox3.Text;
            if (textBox3.Text.Contains("\r\n"))
            {
                outerProductBatchBox.Text = textBox3.Text.Split('\r')[0].Trim();
                outerSapBox.Text = textBox3.Text.Split('\r')[1].Trim();
            }
        }

        private void stdProductBatchBox_TextChanged(object sender, EventArgs e)
        {
            string de = detectResultBox.Text;
            string std = stdProductBatchBox.Text;
            if (de == std)//不清楚为什么一样还NG
            {
                label56.Text = "OK";
                label56.ForeColor = Color.Green;
            }
            else
            {
                if (de == "")
                {

                }
                else
                {
                    label56.Text = "NG";
                    label56.ForeColor = Color.Red;
                }

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }



        #endregion

        #region 流程重置
        //作业指导流程重置
        private void CleanProject()
        {
            for (int i = 0; i < readInfo.Length; i++)
            {
                readInfo[i].Text = "";
                writeInfo[i].Text = "";
                writeInfo[i].ReadOnly = false;
                writeInfo[i].BackColor = SystemColors.Window;
            }
            button4.Enabled = true;
            textBox33.Text = "";
            textBox32.Text = "";
            textBox6.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox_Name.Text = "";
            textBox1.Text = "";
            // btnSure = false;
        }
        //照片保存流程重置
        private void CleanImageInfo()
        {
            stdProductBatchBox.Text = "";

            detectResultBox.Text = "";
            detectResultBox.ReadOnly = false;
            textBox7.Text = "";
            textBox8.Text = "";
            textBox8.ReadOnly = false;
            labelingprojectnum.Text = "";
            backlabelingprojectnum.Text = "";
            textBox25.Text = "";
            textBox25.ReadOnly = false;
            textBox22.Text = "";
            textBox22.ReadOnly = false;
            outerProductBatchBox.Text = "";
            outerSapBox.Text = "";
            label56.Text = "";
            label57.Text = "";
            label59.Text = "";
            label60.Text = "";
            textBox35.Text = "";
            textBox34.Text = "";
            button2.Enabled = true;
            button12.Enabled = true;
            button27.Enabled = true;
            button29.Enabled = true;
        }

        private void CleanLineChange()
        {
            detectType2_Box.Text = "";
            projectNameBox.Text = "";
            stdPrintCodeBox.Text = "";
            sapCodeBox.Text = "";
            redCountBox.Text = "";
            yellowCountBox.Text = "";
            spotCheckCountBox.Text = "";
            for (int i = 0; i < comboBox6.Items.Count; i++)
            {
                comboBox6.Items[i] = "";
            }
            cleanInfofg = true;
        }

        private void CleanWriteInfo()
        {
            for (int i = 0; i < wight_OK_NG.Length; i++)
            {
                wight_OK_NG[i].Text = "";
            }
            for (int i = 0; i < 6; i++)
            {
                textBoxes[i].Text = "";
            }
            //tubWeightBox.Text = "";
            qupi = false;
        }
        #endregion 
    }
}
