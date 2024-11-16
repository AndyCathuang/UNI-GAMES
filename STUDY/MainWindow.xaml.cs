using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace STUDY
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
        private void CenterWindowOnScreen()
        {
            
        }
       
       

        private void stg_Click_1(object sender, RoutedEventArgs e)
        {
            提示 ts = new 提示();//直接调用窗体内容
            ts.ShowDialog();//打开窗体
            
        }
        private void usn_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://afdian.com/a/andycat");
        }

        

        private void bilbil_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://space.bilibili.com/58403171?spm_id_from=333.1007.0.0");
        }

        
        private void bilbil复制__C__Click_1(object sender, RoutedEventArgs e)
        {
            提示 ts = new 提示();//直接调用窗体内容
            ts.ShowDialog();
        }

        

        private void UH_Click_1(object sender, RoutedEventArgs e)
        {
            login login = new login();
            login.ShowDialog();
        }

        private void sitting_Click(object sender, RoutedEventArgs e)
        {
            sittings sittings = new sittings();
            sittings.ShowDialog();

        }
    }
}



