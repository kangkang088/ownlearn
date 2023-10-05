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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Student> list = new List<Student>();
        private void Form2_Load(object sender, EventArgs e)
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "学号";
            columnHeader1.Width = 200;
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "姓名";
            columnHeader2.Width = 200;
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "年龄";
            columnHeader3.Width = 200;
            this.listView1.Columns.Add(columnHeader1);
            this.listView1.Columns.Add(columnHeader2);
            this.listView1.Columns.Add(columnHeader3);
            this.listView1.View = View.Details;
            BindData();
        }
        private void BindData()
        {
            if (!File.Exists("C:\\Users\\Administrator\\Desktop\\list.ini"))
            {
                return;
            }
            using (FileStream fsRead = new FileStream("C:\\Users\\Administrator\\Desktop\\list.ini", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                list = (List<Student>)binaryFormatter.Deserialize(fsRead);
                this.listView1.Items.Clear();
                foreach (Student student in list)
                {
                    ListViewItem item = new ListViewItem(student.StuNum.ToString("000"));
                    item.SubItems.Add(student.StuName);
                    item.SubItems.Add(student.StuAge.ToString());
                    this.listView1.Items.Add(item);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StuNum = Convert.ToInt32(this.textNum.Text);
            student.StuName = this.textName.Text;
            student.StuAge = Convert.ToInt32(this.textAge.Text);
            list.Add(student);
            using (FileStream fsWrite = new FileStream("C:\\Users\\Administrator\\Desktop\\list.ini", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fsWrite, list);
            }
            MessageBox.Show("添加成功");
            BindData();
        }
    }
}
