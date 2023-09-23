using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MatchGame
{
    using System.Threading;
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int tenthsOfSecondsElapsed;
        int matchesFound;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            SetUpGame();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;
            timeTextBlock.Text = (tenthsOfSecondsElapsed / 10f).ToString("0.0s");
            if (matchesFound == 8)
            { 
                timer.Stop();
                timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
            }
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🤣","🤣",
                "😂","😂",
                "😊","😊",
                "❤","❤",
                "😍","😍",
                "😒","😒",
                "👌","👌",
                "😘","😘"
            };
            Random random = new Random();
            foreach (TextBlock textBlock in mainGird.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    int index = random.Next(animalEmoji.Count);
                    string nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);
                }
            }
            timer.Start();
            tenthsOfSecondsElapsed = 0;
            matchesFound = 0;
        }
        //点击第一次和第二次相同，则消失，第二次与第一次不同，则全部出现

        //记录是否点击了成对中的第一个，正在寻找成对的
        bool findingMatch = false;
        //记录最后一次点击的对象，与下一次对比
        TextBlock lastTextBlockClicked;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock senderTextBlock = sender as TextBlock;
            //没有正在寻找
            //开始找，同时记录找的这个对象，看看下一次点击的对象是否与之相同
            if (findingMatch == false)
            {
                senderTextBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = senderTextBlock;
                findingMatch = true;
            }
            //找完一对中的第一个并且记录下来了，并且相同
            else if (senderTextBlock.Text == lastTextBlockClicked.Text)
            {
                senderTextBlock.Visibility = Visibility.Hidden;
                //更改记录，重写从第一个if开始找
                findingMatch = false;
                matchesFound++;
            }
            //找完了，并且不同
            else
            {
                //让上一个点击的显示出来
                lastTextBlockClicked.Visibility = Visibility.Visible;
                //更改记录，重写从第一个if开始找
                findingMatch = false;
            }
        }

        private void timeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(matchesFound == 8)
            {
                SetUpGame();
            }
        }
    }
}
