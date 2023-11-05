using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10监控预警系统.UControls {
    public partial class UCAlarmControl : UserControl {
        System.Timers.Timer timer;
        int colorIndex = 0;//当前颜色索引
        Rectangle m_rectangle;//矩形工作区

        public UCAlarmControl() {
            InitializeComponent();
            //控件样式
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);//忽略窗口消息-减少闪烁
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//绘制到缓冲区-减少闪烁
            SetStyle(ControlStyles.UserPaint, true);//控件自身绘制，而不是操作系统绘制
            SetStyle(ControlStyles.ResizeRedraw, true);//调整大小时进行重绘
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);//支持透明背景
            //控件尺寸发生改变时发生，使内部绘制区动态计算
            SizeChanged += UCAlarmControl_SizeChanged;
            this.Size = new Size(50, 50);//默认宽高
            //定时器切换灯泡颜色
            timer = new System.Timers.Timer();
            timer.Interval = 200;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
        }
        /// <summary>
        /// 灯泡颜色数组的切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            this.Invoke(new Action(() => {
                colorIndex++;
                if (colorIndex >= alarmLightColor.Length) {
                    colorIndex = 0;
                }
                Invalidate();
            }));
        }

        /// <summary>
        /// 动态计算绘制工作区的大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UCAlarmControl_SizeChanged(object sender, EventArgs e) {
            m_rectangle = new Rectangle(Width / 8, Height / 8, Width - Width / 4, Height - Height / 4);
        }
        private Color[] alarmLightColor = { Color.Red };
        /// <summary>
        /// 灯泡颜色数组(如果需要闪烁，至少两种颜色)
        /// </summary>
        public Color[] AlarmLightColor {
            get { return alarmLightColor; }
            set {
                if (value == null || value.Length == 0) { return; }
                alarmLightColor = value;
                Invalidate();
            }
        }
        private Color standColor = Color.Gray;
        /// <summary>
        /// 灯的底座颜色
        /// </summary>
        [DefaultValue(typeof(Color), "Gray"), Description("灯的底座颜色")]//描述文本
        public Color StandColor {
            get { return standColor; }
            set {
                standColor = value;
                Invalidate();
            }
        }
        private int twinkleInterval = 0;
        /// <summary>
        /// 闪烁间隔（如果值为0，不闪烁）
        /// </summary>
        public int TwinkleInterval {
            get { return twinkleInterval; }
            set {
                if (twinkleInterval < 0) { return; }
                twinkleInterval = value;
                if (value == 0 || alarmLightColor.Length <= 1) {
                    timer.Enabled = false;
                }
                else {
                    colorIndex = 0;//从第一种颜色开始闪烁
                }
                Invalidate();
            }

        }
        private bool isOn = false;
        /// <summary>
        /// 是否报警
        /// </summary>
        public bool IsOn {
            get { return isOn; }
            set {
                isOn = value;
                if (isOn && twinkleInterval > 0) {
                    timer.Interval = twinkleInterval;
                    timer.Start();
                }
                else {
                    timer.Stop();
                    colorIndex = 0;
                }
                Invalidate();
            }

        }
        private string varName;
        /// <summary>
        /// 报警的检测的参数名
        /// </summary>
        public string VarName {
            get { return varName; }
            set { varName = value; }
        }
        /// <summary>
        /// 重写绘制事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//消除锯齿
            //灯的颜色
            Color c = alarmLightColor[colorIndex];
            //灯泡部分的路径
            GraphicsPath path = new GraphicsPath();
            //左边竖线
            path.AddLine(m_rectangle.Left, m_rectangle.Bottom - Height / 4 + 2, m_rectangle.Left, m_rectangle.Top + m_rectangle.Width);
            //半圆弧
            path.AddArc(m_rectangle.Left, m_rectangle.Top, m_rectangle.Width, m_rectangle.Width, 180f, 180f);
            //右边竖线
            path.AddLine(m_rectangle.Right, m_rectangle.Top - m_rectangle.Width, m_rectangle.Right, m_rectangle.Bottom - Height / 4 + 2);
            path.CloseAllFigures();//关闭图形，形成闭合区域
            //填充灯泡
            g.FillPath(new SolidBrush(c), path);
            //填充底座
            g.FillRectangle(new SolidBrush(standColor), new Rectangle(0, m_rectangle.Bottom - Height / 4, Width, Height / 4));
        }

    }
}
