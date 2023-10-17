using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02事件演示_拥有者和响应者是两个不同的对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();//拥有者
            Controller controller = new Controller(form);//响应者
            form.ShowDialog();
        }
    }
    class Controller
    { 
        private Form form;
        public Controller(Form form)
        {
            if (form != null)
            {
                this.form = form;
                //       事件   订阅     事件处理器
                this.form.Click += this.FormClicked;
            }
        }
        //事件处理器
        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
