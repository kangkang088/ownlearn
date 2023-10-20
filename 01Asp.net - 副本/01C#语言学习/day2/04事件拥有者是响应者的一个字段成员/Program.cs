using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04事件拥有者是响应者的一个字段成员
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyForm myForm = new MyForm();
            myForm.ShowDialog();
        }
    }
    class MyForm:Form
    {
        private TextBox TextBox;
        private Button Button;
        public MyForm()
        {
            this.TextBox = new TextBox();
            this.Button = new Button();
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Button);
            this.Button.Click += this.ButtonClicked;
            this.Button.Text = "Say Hello!";
            this.Button.Top = this.TextBox.Width;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.TextBox.Text = "Hello World!!!!!!!!!!!!";
        }
    }
}
