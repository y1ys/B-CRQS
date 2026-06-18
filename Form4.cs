using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniReadWrite;
using System.Threading;

namespace WindowsFormsApp5
{
    public partial class Form4 : Form
    {
        string path = Application.StartupPath + "\\Info.ini";
        public delegate void MyDelegate1();
        public delegate void MyDelegate2(string res,bool a);
        MyDelegate1 _myDele1;
        MyDelegate2 _myDele2;
        bool b7b17 = false;
        public Form4(MyDelegate1 del1, MyDelegate2 del2)
        {
            InitializeComponent();
            _myDele1 = del1;
            _myDele2 = del2;
        }
        int sleep = 1000;
        private void Form4_Load(object sender, EventArgs e)
        {
            this.textBoxname.Text = "admin";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxname.Text == "" || this.textBoxpwd.Text == "")
            {
                MessageBoxShow("用户名或密码不能为空！");
            }
            else
            {
                if (File.Exists(path))
                {
                    string[] msg = IniAPI.INIGetAllItemKeys(path, "账户信息");
                    string[] keyss = { "用户名", "密码" };
                    string InfoName = IniAPI.INIGetStringValue(path, "账户信息", "用户名", "");
                    string Infopwd = IniAPI.INIGetStringValue(path, "账户信息", "密码", "");

                    if ((this.textBoxname.Text == InfoName) && (this.textBoxpwd.Text == Infopwd))
                    {
                        MessageBoxShow("登录成功");
                        //this.buttonSetpwd.Enabled = true;
                        _myDele1();
                        this.Close();
                        b7b17 = true;
                        _myDele2("登录成功", b7b17);
                    }
                    else
                    {
                        
                        MessageBoxShow("登录失败，用户名或密码错误");
                        _myDele2("登录失败，用户名或密码错误", b7b17);
                    }
                }
                else
                {
                    File.Create(Application.StartupPath + "\\Info.ini");
                }
            }
        }
        private void MessageBoxShow(string message)
        {
            Form msg = new Form();
            Task.Run(new Action(() =>
            {
                Thread.Sleep(sleep);
                try
                {
                    Invoke(new Action(() => {
                        try
                        {
                            msg.Close();
                        }
                        catch 
                        {

                            
                        }
                        
                    }));

                }
                catch 
                {
                    
                   
                }
               
            }));
            MessageBox.Show(msg, message);

        }
    }
}
