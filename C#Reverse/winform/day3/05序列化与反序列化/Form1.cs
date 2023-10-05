using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05序列化与反序列化
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StuNum = Convert.ToInt32(this.textNum.Text);
            student.StuName = this.textName.Text;
            student.StuAge = Convert.ToInt32(this.textAge.Text);
            using (FileStream fsWrite = new FileStream("C:\\Users\\Administrator\\Desktop\\stu.ini", FileMode.OpenOrCreate, FileAccess.Write))
            { 
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fsWrite,student);
                MessageBox.Show("保存成功");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (FileStream fsRead = new FileStream("C:\\Users\\Administrator\\Desktop\\stu.ini", FileMode.Open, FileAccess.Read))
            { 
                BinaryFormatter binaryFormatter= new BinaryFormatter();
                Student student = (Student)binaryFormatter.Deserialize(fsRead);
                this.textName.Text = student.StuName;
                this.textNum.Text = student.StuNum.ToString();
                this.textAge.Text = student.StuAge.ToString();
            }
        }
    }
}
