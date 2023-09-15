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
using System.Data.SqlClient;

namespace Hotel
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            DB.Users_ID = "sa";
            DB.Password = "123";
            DB.ConnectionStrig = string.Format(DB.ConnectionStrig, DB.Users_ID, DB.Password);
            DB db = new DB();
            try
            {
                if (cbavt.SelectedIndex == 0)
                {
                    //SqlCommand Command = new SqlCommand("SELECT Login_Employee, Password_Employee FROM [Employee] WHERE Login = @Login_Employee AND Password = @Password_Employee");
                    //Command.Parameters.AddWithValue("@Login", Logavtr.Text);
                    //Command.Parameters.AddWithValue("@Password", Passavtr.Text);
                    //Command.Connection = db.connection;
                    //db.connection.Open();
                    //int rule = (int)Command.ExecuteScalar();
                    Employee employee = new Employee();
                    employee.Show();
                    Close();
                }
                else if (cbavt.SelectedIndex == 1)
                {
                    //SqlCommand Command = new SqlCommand("[Visitors] WHERE Login = @Login AND Password = @Password");
                    //Command.Parameters.AddWithValue("@Login", Logavtr.Text);
                    //Command.Parameters.AddWithValue("@Password", Passavtr.Text);
                    //Command.Connection = db.connection;
                    //db.connection.Open();
                    //int rule = (int)Command.ExecuteScalar();
                    Visitor visitor = new Visitor();
                    visitor.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Логин или пароль неверен");
                }
            }
            catch
            {
                MessageBox.Show("Не верный логин или пароль!", DB.App_Name);
                Show();
                Logavtr.Focus();
            }
            finally
            {
                db.connection.Close();
                Logavtr.Clear();
                Passavtr.Clear();
            }
        }
    }
}
