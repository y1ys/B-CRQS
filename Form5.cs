using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp5
{
    public partial class Form5 : Form
    {
        public string  start_time { get; set; }
        public string end_time { get; set; }
        MySqlConnection connection2 = new MySqlConnection();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            try
            {
                // 在构造函数中创建数据库连接
                string connectionString = "server=172.16.16.10;user=ecrqs_xy;password=ecrqs_xy;database=ecrqs_data";
                connection2 = new MySqlConnection(connectionString);
                connection2.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败，请检查网络！");
            }
            try
            {
                string query1 = $"SELECT * FROM scale_check WHERE line='B' AND verification_time >= '{start_time}' AND verification_time < '{end_time}'";
                //  string query1 = $"SELECT(detect_time,detect_type,line,classes,shift,project_num,product_batch,sap_code,product_name,detailed_information,total_count,red_light_count,yellow_light_count,tub_weight_1,tub_weight_2,tub_weight_3,tub_weight_4,tub_weight_5,tub_weight_6,defect_rework_description,rework_count,ng_count,rework_result,notes,inspector) FROM detect_record WHERE detect_time >= '{start_time}' AND detect_time < '{end_time}'";
                MySqlCommand command = new MySqlCommand(query1, connection2);

                // 创建数据适配器
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                // 创建数据表
                System.Data.DataTable dataTable = new System.Data.DataTable();
                // 填充数据表
                adapter.Fill(dataTable);
                // 将数据表绑定到DataGridView

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("数据库连接失败，请检查网络！");
                return;
            }


            // 为第一列添加序号
            int columnIndex = 0;
            int number = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[columnIndex].Value = number;
                number++;
            }

        }
    }
}
