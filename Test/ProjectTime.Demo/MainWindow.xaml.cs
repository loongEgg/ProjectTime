using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjectTime.Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
            => this.DragMove();

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                //string cmd = btn.Content.ToString().ToLower();
                string cmd = btn.Tag.ToString().ToLower();
                switch (cmd)
                {
                    case "minimize": this.WindowState = WindowState.Minimized; break;
                    case "maximize": this.WindowState ^= WindowState.Maximized; break;
                    case "close": this.Close(); break;
                    default:
                        Debugger.Break();
                        break;
                }
            }
        }
    }
}
