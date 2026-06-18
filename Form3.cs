using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
            
        }
        int sleep = 1000;
        // 创建一个事件，用于在主窗口中传递提交的文本内容
        public event Action<string[]> ButtonClicked;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ngCountBox.Text==""|| reworkCountBox.Text==""|| reworkResultComboBox.Text=="")
            {
                MessageBoxShow("返工数据不完整");
                return;
            }
            if (Convert.ToInt32(reworkCountBox.Text)<Convert.ToInt32(ngCountBox.Text))
            {
                MessageBoxShow("不合格数目不能大于返工量");
                return;
            }
            try
            {
                string[] connect_text = new string[4];
                connect_text[0] = defectReworkDescriptionBox.Text;
                connect_text[1] = reworkCountBox.Text;
                connect_text[2] = ngCountBox.Text;
                connect_text[3] = reworkResultComboBox.Text;
                ButtonClicked?.Invoke(connect_text);
                this.Hide();
            }
            catch (Exception)
            {

                MessageBoxShow("返工数据不能为空");
            }
          
        }

        private void defectReworkDescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ngCountBox_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if ((Convert.ToInt32(ngCountBox.Text) > 6))
            //    {
            //        MessageBox.Show("不合格数最大为6");
            //        ngCountBox.Text = "6";
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
            //catch (Exception)
            //{

            //}
         
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            if (f1.cleanInfofg )
            {
                detectTimeBox.Text = "";
                classesBox.Text = "";
                shiftBox.Text = "";
                lineBox.Text = "";
                productLotNumBox.Text = "";
                sapBox.Text = "";
                productNameBox.Text = "";
                reworkCountBox.Text = "";
                ngCountBox.Text = "";
                defectReworkDescriptionBox.Text = "";
                for (int i = 0; i < reworkResultComboBox.Items .Count ; i++)
                {
                    reworkResultComboBox.Items[i] = "";
                }
            }
            f1.cleanInfofg = false;
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
    }
}
