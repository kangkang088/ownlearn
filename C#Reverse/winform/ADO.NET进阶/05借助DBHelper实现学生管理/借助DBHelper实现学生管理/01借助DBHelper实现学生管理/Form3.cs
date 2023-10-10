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
    public partial class Form3 : Form
    {
        public string StuId { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        private void BindPro()
        {
            DBHelper.PrepareSql("select* from ProfessionInfo");
            DataTable dt = new DataTable();
            dt = DBHelper.ExecQuery();
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "professionName";//要显示的内容
            this.comboBox1.ValueMember = "ProfessionID";//内容的值
        }
        private void BindDetail()
        {
            string sqlStr = "select* from StudentInfo where StuId = @StuId";
            DBHelper.PrepareSql(sqlStr);
            DBHelper.SetParameter("StuId", this.StuId);
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            if (dataTable.Rows.Count != 1)
            {
                MessageBox.Show("数据有误");
                this.Close();
            }
            this.textBox1.Text = dataTable.Rows[0]["StuId"].ToString();
            this.textBox2.Text = dataTable.Rows[0]["StuName"].ToString();
            this.textBox3.Text = dataTable.Rows[0]["StuAge"].ToString();
            if (dataTable.Rows[0]["StuSex"].ToString().Equals("男"))
            {
                this.radioButton1.Checked = true;
            }
            else
            {
                this.radioButton2.Checked = true;
            }
            string[] arrHobby = dataTable.Rows[0]["StuHobby"].ToString().Split(',');
            foreach (string s in arrHobby)
            {
                foreach (CheckBox item in this.panel2.Controls)
                {
                    if (s == item.Text)
                    {
                        item.Checked = true;
                    }
                }
            }
            this.comboBox1.SelectedValue = dataTable.Rows[0]["ProfessionID"].ToString();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.textBox1.ReadOnly = true;
            BindPro();
            BindDetail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "update StudentInfo set StuName = @StuName,StuAge = @StuAge,StuSex = @StuSex,StuHobby = @StuHobby,ProfessionID = @ProfessionID where StuId = @StuId";
            DBHelper.PrepareSql(sqlStr);
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
            DBHelper.SetParameter("StuID", this.textBox1.Text);
            int rowCount = DBHelper.ExecNonQuery();
            if (rowCount == 1)
                MessageBox.Show("修改成功");
            else
                MessageBox.Show("修改失败");
        }
    }
}
