using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01借助DBHelper实现学生管理
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void BindPro()
        {
            DBHelper.PrepareSql("select* from ProfessionInfo");
            DataTable dt = new DataTable();
            dt = DBHelper.ExecQuery();
            DataRow dataRow = dt.NewRow();
            dataRow["ProfessionID"] = 0;
            dataRow["professionName"] = "-请选择-";
            dt.Rows.InsertAt(dataRow, 0);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "professionName";//要显示的内容
            this.comboBox1.ValueMember = "ProfessionID";//内容的值
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            BindPro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)\r\nvalues(@StuID,@StuName,@StuAge,@StuSex,@StuHobby,@ProfessionID)";
            DBHelper.PrepareSql(sqlStr);
            DBHelper.SetParameter("StuID", this.textBox1.Text);
            DBHelper.SetParameter("StuName", this.textBox2.Text);
            DBHelper.SetParameter("StuAge", this.textBox3.Text);
            string sex = "";
            if (this.radioButton1.Checked == true)
            {
                sex = this.radioButton1.Text;
            }
            if (this.radioButton2.Checked == true)
            {
                sex = this.radioButton2.Text;
            }
            DBHelper.SetParameter("StuSex", sex);
            string hobby = "";
            foreach (CheckBox item in this.panel2.Controls)
            {
                if (item.Checked == true)
                {
                    if (!hobby.Equals(""))
                        hobby += ",";
                    hobby += item.Text;
                }
            }
            DBHelper.SetParameter("StuHobby", hobby);
            DBHelper.SetParameter("ProfessionID", this.comboBox1.SelectedValue.ToString());
            int rowCount = DBHelper.ExecNonQuery();
            if (rowCount == 1)
                MessageBox.Show("添加成功");
            else
                MessageBox.Show("添加失败");
        }
    }
}
