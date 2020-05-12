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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace RunOthers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public readonly Process hello=new Process();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startHello(object sender, RoutedEventArgs e)
        {
            hello.StartInfo.FileName = @"C:\Users\QYL\source\repos\RunOthers\HelloBoy\bin\Debug\netcoreapp3.1\HelloBoy.exe";
            hello.StartInfo.Arguments = "";
            hello.Start();
            Stop.IsEnabled = true;
            Start.IsEnabled = false;
        }

        private void stopHello(object sender, RoutedEventArgs e)
        {
            hello.CloseMainWindow();
            //  hello.Close();
            hello.Kill();
            Stop.IsEnabled = false;                                                                                                                                
            Start.IsEnabled = true;
        }
    }
}
