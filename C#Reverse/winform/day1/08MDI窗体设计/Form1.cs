namespace _08MDI窗体设计
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 显示子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            Form4 form4 = new Form4();
            form2.Show();
            form2.MdiParent = this;
            form3.Show();
            form3.MdiParent = this;
            form4.Show();
            form4.MdiParent = this;
        }

        private void 横向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 纵向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}