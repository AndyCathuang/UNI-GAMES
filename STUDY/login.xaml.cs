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

namespace STUDY
{
    /// <summary>
    /// login.xaml 的交互逻辑
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
            registration zc = new registration();
            zc.ShowDialog();
        }




        private void login_Click(object sender, RoutedEventArgs e)
        {

            string password = usrpsssword.Password; // 获取密码
             // 设置密码
            PasswordBox usrpassword = sender as PasswordBox;
            string password1 = usrpsssword.Password; // 获取改变的密码
            string usrname = usr_name.Text;

            if (usrname == "AndyCat" && password1 == "huang1209")
            {
                USER_AY ay = new USER_AY();
                ay.ShowDialog();
                this.Close();
            }
            else if (usrname == "Administrator 0002" && password1 == "UG002")
            {
                USER_JY Jy = new USER_JY();
                Jy.ShowDialog();
                this.Close();
            }
            else if(usrname == " ")
            {

            }
            else
            {
                登录失败 Loginfailure =  new 登录失败();
                Loginfailure.ShowDialog();
            }
            

        }

        private void usr_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            string urn = usr_name.Text;
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {



        }
        private void usrpassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
