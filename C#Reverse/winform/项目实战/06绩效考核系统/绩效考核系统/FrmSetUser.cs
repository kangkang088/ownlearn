using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace 绩效考核系统 {
    public partial class FrmSetUser : Form {
        private DelBindDGV dtl;
        public FrmSetUser(DelBindDGV dtl) {
            InitializeComponent();
            this.dtl = dtl;
        }
        private Users user;
        public FrmSetUser(DelBindDGV dtl,int userId):this(dtl) {
            user = Users.ListAll().Find(m => m.Id == userId);
            
        }

        private void FrmSetUser_Load(object sender, EventArgs e) {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            appraisalBases.AddRange(AppraisalBases.ListAll());
            comboBox1.DataSource = appraisalBases;
            comboBox1.DisplayMember = "BaseType";
            comboBox1.ValueMember = "Id";

            textBox1.Text = user.UserName;
            comboBox1.SelectedValue = user.BaseTypeId;
            comboBox2.Text = user.Sex;
            checkBox1.Checked = user.IsDel;
        }

        private void button1_Click(object sender, EventArgs e) {
            string userName = textBox1.Text.Trim();
            int baseType = (int)comboBox1.SelectedValue;
            string sex = comboBox2.Text.Trim();
            bool isDel = checkBox1.Checked;

            if (user == null) {
                Users users = new Users {
                    UserName = userName,
                    BaseTypeId = baseType,
                    Password = "111",
                    Sex = sex,
                    IsDel = isDel
                };
                Users.Insert(users);
                MessageBox.Show("用户添加成功");
            }
            else {
                user.UserName = userName;
                user.BaseTypeId = baseType;
                user.Password = "111";
                user.Sex = sex;
                user.IsDel = isDel;
                Users.Update(user);
                MessageBox.Show("用户修改成功");
            }
            dtl.Invoke();
            this.Close();
        }
    }
}
