using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14简单播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消程序加载时的自动播放
            this.axWindowsMediaPlayer1.settings.autoStart = false;
            //this.axWindowsMediaPlayer1.URL = "C:\\Users\\Administrator\\Music\\ad46f62bfb68406661793de6ba03c694.mp3";

            this.label1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\放音.jpg");
            this.label1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        /// <summary>
        /// 播放或者暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool b = true;
        private void btnPlatOrPause_Click(object sender, EventArgs e)
        {
            if (this.btnPlatOrPause.Text == "播放")
            {
                if (this.listBox1.Items.Count == 0)
                {
                    MessageBox.Show("请先选择歌曲");
                    this.btnPlatOrPause.Text = "播放";
                    return;
                }
                if (this.listBox1.SelectedIndex >= 0)
                {
                    if (b)
                    {
                        this.axWindowsMediaPlayer1.URL = listPath[this.listBox1.SelectedIndex];
                    }
                    this.axWindowsMediaPlayer1.Ctlcontrols.play();
                    this.btnPlatOrPause.Text = "暂停";


                }
                else
                {
                    MessageBox.Show("未选择歌曲");
                    return;
                }

            }
            else if (this.btnPlatOrPause.Text == "暂停")
            {

                this.axWindowsMediaPlayer1.Ctlcontrols.pause();
                this.btnPlatOrPause.Text = "播放";
                //避免每次播放都是从头开始
                b = false;
            }


        }
        //存储音乐文件的全路径
        List<string> listPath = new List<string>();
        /// <summary>
        /// 选择播放的音乐文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\Users\\Administrator\\Music";
            ofd.Title = "请选择要播放的文件";
            ofd.Filter = "音乐文件|*.wav|MP3文件|*.mp3|所有文件|*.*";
            ofd.Multiselect = true;
            ofd.ShowDialog();

            //获得所有选中文件的全路径
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                listPath.Add(path[i]);

                //将音乐文件我文件名存储到listbox中
                this.listBox1.Items.Add(Path.GetFileName(path[i]));
            }
        }
        /// <summary>
        /// 双击播放对应的音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count == 0)
            {
                MessageBox.Show("请首先选择音乐文件");
                return;
            }
            try
            {
                this.axWindowsMediaPlayer1.URL = listPath[this.listBox1.SelectedIndex];
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
                this.btnPlatOrPause.Text = "暂停";
                this.label2.Text = this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
                IsExistLrc(listPath[this.listBox1.SelectedIndex]);
            }
            catch { }
        }
        /// <summary>
        /// 点击上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            this.listBox1.SelectedIndices.Clear();
            index--;
            if (index < 0)
            {
                index = this.listBox1.Items.Count - 1;
            }
            this.listBox1.SelectedIndex = index;
            this.axWindowsMediaPlayer1.URL = listPath[index];
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        /// <summary>
        /// 点击下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //当前选中项的索引
            int index = this.listBox1.SelectedIndex;
            //因为我们是可以多选的，所有点下一曲的时候，切换到下一曲，把之前选中的清空
            this.listBox1.SelectedIndices.Clear();

            index++;
            if (index == this.listBox1.Items.Count)
            {
                index = 0;
            }
            this.listBox1.SelectedIndex = index;
            this.axWindowsMediaPlayer1.URL = listPath[index];
            this.axWindowsMediaPlayer1.Ctlcontrols.play();

        }
        /// <summary>
        /// 点击删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //先删除列表还是先删除集合？？

            //首先获得要删除的个数
            int count = this.listBox1.SelectedItems.Count;

            //先集合后列表
            for (int i = 0; i < count; i++)
            {
                listPath.RemoveAt(this.listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }

            //先列表后集合  报错
            //for (int i = 0; i < count; i++)
            //{
            //    listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            //    listPath.RemoveAt(this.listBox1.SelectedIndex);
            //}
            //根据列表中的选中项的索引来的。要是你删除了，就会发生索引越界
            //比如列表中有六个，0.1.2.3.4.5.6 列表先删除123，然后集合再删除
            //列表删除完了之后，列表变成了0.4.5，即0.1.2，集合删除是根据列表索引删除的，在删除123索引的时候发现3没了，索引访问异常，超出范围
        }
        /// <summary>
        /// 点击切换静音和放音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            if (this.label1.Tag.ToString() == "1")
            {
                this.axWindowsMediaPlayer1.settings.mute = true;
                this.label1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\静音.jpg");
                this.label1.Tag = "2";
            }
            else if (this.label1.Tag.ToString() == "2")
            {
                this.axWindowsMediaPlayer1.settings.mute = false;
                this.label1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\放音.jpg");
                this.label1.Tag = "1";
            }
        }
        /// <summary>
        /// 点+提高音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.settings.volume++;
        }
        /// <summary>
        /// 点-降低音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.settings.volume--;
        }
        /// <summary>
        /// 自动播放下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 方法1
            ////如果播放器的状态等于正在播放中
            //if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            //{
            //    this.label2.Text = this.axWindowsMediaPlayer1.currentMedia.duration.ToString() + "\r\n" + this.axWindowsMediaPlayer1.currentMedia.durationString + "\r\n" +
            //        this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString() + "\r\n" +
            //        this.axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

            //    //如果歌曲当前播放时间等于歌曲总时间，则下一曲
            //    double d1 = double.Parse(this.axWindowsMediaPlayer1.currentMedia.duration.ToString());
            //    double d2 = double.Parse(this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()) + 1;
            //    if (d1 <= d2)
            //    {
            //        //当前选中项的索引
            //        int index = this.listBox1.SelectedIndex;
            //        //因为我们是可以多选的，所有点下一曲的时候，切换到下一曲，把之前选中的清空
            //        this.listBox1.SelectedIndices.Clear();

            //        index++;
            //        if (index == this.listBox1.Items.Count)
            //        {
            //            index = 0;
            //        }
            //        this.listBox1.SelectedIndex = index;
            //        this.axWindowsMediaPlayer1.URL = listPath[index];
            //        this.axWindowsMediaPlayer1.Ctlcontrols.play();
            //    }
            //}
            #endregion

            //如果播放器的状态等于正在播放中
            if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                this.label2.Text = this.axWindowsMediaPlayer1.currentMedia.duration.ToString() + "\r\n" + this.axWindowsMediaPlayer1.currentMedia.durationString + "\r\n" +
                    this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString() + "\r\n" +
                    this.axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            }
        }
        #region 方法2
        /// <summary>
        /// 当播放器状态发生改变时，我输出当前播放器的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                //当前选中项的索引
                int index = this.listBox1.SelectedIndex;
                //因为我们是可以多选的，所有点下一曲的时候，切换到下一曲，把之前选中的清空
                this.listBox1.SelectedIndices.Clear();

                index++;
                if (index == this.listBox1.Items.Count)
                {
                    index = 0;
                }
                this.listBox1.SelectedIndex = index;
                this.axWindowsMediaPlayer1.URL = listPath[index];
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                try
                {
                    this.axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch { }
            }

        }
        #endregion
        /// <summary>
        /// 显示歌词
        /// </summary>
        /// <param name="songPath"></param>
        
        //判断是否存在歌词
        void IsExistLrc(string songPath)
        {
            //清空两个集合
            listLrcText.Clear();
            listTime.Clear();
            songPath += ".lrc";
            if (File.Exists(songPath))
            {
                //读取歌词文件
                string[] lrcText = File.ReadAllLines(songPath,Encoding.Default);
                //格式化歌词
                ForMatter(lrcText);
            }
            else //不存在歌词 
            {
                this.label3.Text = "----歌词未找到----";
            }
        }
        List<double> listTime = new List<double>();
        List<string> listLrcText = new List<string>();
        /// <summary>
        /// 格式化歌词时间
        /// </summary>
        /// <param name="lrcText"></param>
        void ForMatter(string[] lrcText)
        {
            for (int i = 0; i < lrcText.Length; i++)
            {
                //[00:15.57]当世界和我不一样

                //00：15.57  lrcTemp[0]
                //当世界和我不一样 lrcTemp[1]
                string[] lrcTemp = lrcText[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

                //00 lrcNewTemp[0]
                //15.57 lrcNewTemp[1]
                string[] lrcNewTemp = lrcTemp[0].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                double time = double.Parse(lrcNewTemp[0]) * 60 + double.Parse(lrcNewTemp[1]);
                //截取出来的时间加到集合中保存
                listTime.Add(time);
                listLrcText.Add(lrcTemp[1]);
                

            }
        }
        /// <summary>
        /// 播放歌词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listTime.Count; i++)
            {
                if (this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition >= listTime[i] && this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition < listTime[i + 1])
                {
                    this.label3.Text = listLrcText[i];
                }
            }
            
        }
    }
}
