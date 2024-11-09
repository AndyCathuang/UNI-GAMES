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
using System.Windows.Shapes;
using System.Windows.Forms;
using Microsoft.Win32;

namespace STUDY
{
    /// <summary>
    /// sittings.xaml 的交互逻辑
    /// </summary>
    public partial class sittings : Window
        
    {
        public sittings()
        {
            InitializeComponent();
            tx2.IsReadOnly = true;
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            
            tx2.Text = folderBrowserDialog.SelectedPath;
        }

        private void TextBox_TextChanged(object sender, object e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
