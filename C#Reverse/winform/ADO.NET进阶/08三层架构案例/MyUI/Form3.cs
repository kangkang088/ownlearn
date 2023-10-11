using MyBLL;
using MyEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string StuId { get; set; }
        ProfessionBLL proBLL = new ProfessionBLL();
        StudentInfoBLL stuBLL = new StudentInfoBLL();
        private void BindProfession()
        {
            List<ProfessionInfoEntity> list = new List<ProfessionInfoEntity>();
            list = proBLL.List();
            list.Insert(0, new ProfessionInfoEntity { ProfessionInfoID = 0, ProfessionName = "--请选择--" });
            this.comboBox1.DataSource = list;
            this.comboBox1.DisplayMember = "ProfessionName";
            this.comboBox1.ValueMember = "ProfessionInfoID";
        }
        private void BindDetail()
        {
            StudentInfoEntity studentInfoEntity = new StudentInfoEntity();
            studentInfoEntity = stuBLL.Detail(this.StuId.ToString());
            this.textBox1.Text = studentInfoEntity.StuID.ToString();
            this.textBox2.Text = studentInfoEntity.StuName.ToString();
            this.textBox3.Text = studentInfoEntity.StuAge.ToString();
            if(studentInfoEntity.StuSex.Equals("男")) this.radioButton1.Checked = true;
            else this.radioButton2.Checked = true;
            string[] strings = studentInfoEntity.StuHobby.Split(',');
            foreach(string s in strings) 
            {
                foreach (CheckBox checkBox in this.groupBox2.Controls)
                { 
                    if (checkBox.Text == s) checkBox.Checked = true;
                }
            }
            this.comboBox1.SelectedValue = studentInfoEntity.ProfessionID;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            BindProfession();
            BindDetail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (this.radioButton1.Checked == true)
                sex = this.radioButton1.Text;
            if (this.radioButton2.Checked == true)
                sex = this.radioButton2.Text;
            string hobby = "";
            foreach (CheckBox item in this.groupBox2.Controls)
            {
                if (item.Checked == true)
                {
                    if (hobby != "")
                        hobby += ",";
                    hobby += item.Text;
                }
            }
            StudentInfoEntity studentInfoEntity = new StudentInfoEntity();
            studentInfoEntity.StuID = this.StuId;
            studentInfoEntity.StuName = this.textBox2.Text;
            studentInfoEntity.StuAge = int.Parse(this.textBox3.Text.ToString());
            studentInfoEntity.StuSex = sex;
            studentInfoEntity.StuHobby = hobby;
            studentInfoEntity.ProfessionID = int.Parse(this.comboBox1.SelectedValue.ToString());
            if (stuBLL.Update(studentInfoEntity) == 1) MessageBox.Show("修改成功");
            else MessageBox.Show("修改失败");
            this.Close();
        }
    }
}
