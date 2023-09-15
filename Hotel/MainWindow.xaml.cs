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

namespace Hotel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DB.Users_ID = "sa";
            DB.Password = "123";
            DB.ConnectionStrig = string.Format(DB.ConnectionStrig, DB.Users_ID, DB.Password);
            DB db = new DB();
            if (cbReg.SelectedIndex == 0)
            {
                try
                {
                    db.sqlExecute(string.Format("insert into [dbo].[Employee] ([Name_Employee], [Surname_Employee], [Last_Name_Employee], [Email_Employee], [Phone_Number_Employee], [Login_Employee], [Password_Employee])" +
                        " values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", Ima.Text, Fam.Text, Otch.Text, Mail.Text, Nomer.Text, Login.Text, Password.Text), DB.act.manipulation);
                }
                catch
                {
                    MessageBox.Show("Ошибка данных!");
                }
            }
            else if (cbReg.SelectedIndex == 1)
            {
                try
                {
                    db.sqlExecute(string.Format("insert into [dbo].[Visitors] ([Name_Visitors], [Surname_Visitors], [Last_Name_Visitors], [Email_Visitors], [Phone_Number_Visitors], [Login_Visitors], [Password_Visitors])" +
                        " values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", Ima.Text, Fam.Text, Otch.Text, Mail.Text, Nomer.Text, Login.Text, Password.Text), DB.act.manipulation);
                }
                catch
                {
                    MessageBox.Show("Ошибка данных!");
                }
            }
        }
    }
}