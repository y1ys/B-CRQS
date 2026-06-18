using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // 属性用于存储从 Form1 传递过来的值
        string defect_type = ""; 
        public string MessageFromForm1 { get; set; }
        // 创建一个事件，用于在主窗口中传递提交的文本内容
        public event Action<string[]> ButtonClicked;
        string[] yellow_bag_defects = { "1-印刷-颜色", "2-印刷-包装",  "3-印刷-文字", "4-清洁-灰尘", "5-清洁-污渍/脏/油腻", "10-产品颜色/分层/相分离", "13-包装材料分层", "14-破损-开裂", "15-损坏-挤压/变形/褶痕/撕开", "16-损坏-破孔", "17-损坏-划痕/磨损", "18-开启装置-配合松弛", "19-封边-对齐", "20-封边-烧焦", "21-封边-损坏", "22-封边-叠接", "23-包装外的收缩膜-完整性", "24-条形码-可读性/缺失/位置", "25-生产打码-缺失/不清楚/位置","无" };

        string[] red_bag_defects = { "1-印刷-颜色", "2-印刷-包装", "3-印刷-文字", "4-清洁-灰尘", "5-清洁-污渍/脏/油腻", "6-产品外观", "7-净重偏差", "8-灌装高度偏差", "9-异物", "10-产品颜色/分层/相分离", "11-组装-缺失", "12-组装-错误", "13-包装材料分层", "14-破损-开裂", "15-损坏-挤压/变形/褶痕/撕开", "16-损坏-破孔", "17-损坏-划痕/磨损", "18-开启装置-配合松弛", "19-封边-对齐", "20-封边-烧焦", "21-封边-损坏", "22-封边-叠接", "23-包装外的收缩膜-完整性", "24-条形码-可读性/缺失/位置", "25-生产打码-缺失/不清楚/位置","无" };

        string[] yellow_bottle_defects = { "1-标贴/束膜/包装纸(膜)-位置", "2-标贴/束膜-附贴", "3-标贴/束膜-损坏", "4-印刷-颜色", "5-印刷-文字", "6-印刷-包装,标贴或小袋膜切割/定位", "7-清洁-灰尘", "8-清洁-污渍/脏/油腻", "9-气泡/空气窝眼", "14-产品颜色/分层/相分离", "17-锋利边缘", "18-防篡改装置", "19-破损-开裂", "20-损坏-挤压/变形/褶痕/撕裂", "21-损坏-破孔", "22-损坏-划痕/磨损", "23-锁紧装置", "24-开启装置-配合松弛", "25-喷枪/泵/驱动装置-错位", "26-条形码-可读性/缺失/位置", "27-生产打码-缺失/不清楚/位置" ,"无" };

        string[] red_bottle_defects = { "1-标贴/束膜/包装纸(膜)-位置", "2-标贴/束膜-附贴", "3-标贴/束膜-损坏", "4-印刷-颜色", "5-印刷-文字", "6-印刷-包装,标贴或小袋膜切割/定位", "7-清洁-灰尘", "8-清洁-污渍/脏/油腻", "9-气泡/空气窝眼", "10-净重偏差", "11-灌装高度偏差", "12-异物", "13-产品外观(指透明包装)", "14-产品颜色/分层/相分离", "15-组装-缺失", "16-组装-错误", "17-锋利边缘", "18-防篡改装置", "19-破损-开裂", "20-损坏-挤压/变形/褶痕/撕裂", "21-损坏-破孔", "22-损坏-划痕/磨损", "23-锁紧装置", "24-开启装置-配合松弛", "25-喷枪/泵/驱动装置-错位", "26-条形码-可读性/缺失/位置", "27-生产打码-缺失/不清楚/位置", "无" };


        private void button1_Click(object sender, EventArgs e)
        {

            // 获取文本框的内容，并触发 ButtonClicked 事件，将文本内容传递回主窗口
            string[] connect_text  = new string[12];
            connect_text[0] = comboBox1.Text;
            connect_text[1] = comboBox2.Text;
            connect_text[2] = comboBox3.Text;
            connect_text[3] = comboBox4.Text;
            connect_text[4] = comboBox5.Text;
            connect_text[5] = comboBox6.Text;
            connect_text[6] = comboBox7.Text;
            connect_text[7] = comboBox8.Text;
            connect_text[8] = comboBox9.Text;
            connect_text[9] = comboBox10.Text;
            connect_text[10] = comboBox11.Text;
            connect_text[11] = comboBox12.Text;
            ButtonClicked?.Invoke(connect_text);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;

            // 关闭 Form2 窗口
            this.Hide();


        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void comboBoxClear()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            comboBox9.Items.Clear();
            comboBox10.Items.Clear();
            comboBox11.Items.Clear();
            comboBox12.Items.Clear();
        }

        


        public void updataFrom()
        {
            comboBoxClear();
            if (MessageFromForm1 == "软袋")
            {
                comboBox1.Items.AddRange(yellow_bag_defects);
                comboBox2.Items.AddRange(yellow_bag_defects);
                comboBox3.Items.AddRange(yellow_bag_defects);
                comboBox4.Items.AddRange(yellow_bag_defects);
                comboBox5.Items.AddRange(yellow_bag_defects);
                comboBox6.Items.AddRange(yellow_bag_defects);
                comboBox7.Items.AddRange(red_bag_defects);
                comboBox8.Items.AddRange(red_bag_defects);
                comboBox9.Items.AddRange(red_bag_defects);
                comboBox10.Items.AddRange(red_bag_defects);
                comboBox11.Items.AddRange(red_bag_defects);
                comboBox12.Items.AddRange(red_bag_defects);
            }
            else if (MessageFromForm1 == "塑料瓶")
            {
                comboBox1.Items.AddRange(yellow_bottle_defects);
                comboBox2.Items.AddRange(yellow_bottle_defects);
                comboBox3.Items.AddRange(yellow_bottle_defects);
                comboBox4.Items.AddRange(yellow_bottle_defects);
                comboBox5.Items.AddRange(yellow_bottle_defects);
                comboBox6.Items.AddRange(yellow_bottle_defects);
                comboBox7.Items.AddRange(red_bottle_defects);
                comboBox8.Items.AddRange(red_bottle_defects);
                comboBox9.Items.AddRange(red_bottle_defects);
                comboBox10.Items.AddRange(red_bottle_defects);
                comboBox11.Items.AddRange(red_bottle_defects);
                comboBox12.Items.AddRange(red_bottle_defects);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            comboBox11.Text = "";
            comboBox12.Text = "";
        }
    }
}
