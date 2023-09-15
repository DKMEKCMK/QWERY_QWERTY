using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Hotel
{
    /// <summary>
    /// Логика взаимодействия для Visitor.xaml
    /// </summary>
    public partial class Visitor : Window
    {
        public Visitor()
        {
            InitializeComponent();
        }

        private void TabItem_Loaded_8(object sender, RoutedEventArgs e)
        {
            Poset();
        }

        private void Poset()
        {
            if (poset != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Visitors], [Name_Visitors], [Surname_Visitors], [Last_Name_Visitors], [Email_Visitors], [Phone_Number_Visitors], [Login_Visitors], [Password_Visitors], [ID_Role_Visitors] from [dbo].[Visitors]"), DB.act.select);
                        db.dependency.OnChange += OnChange_poset;
                        poset.ItemsSource = db.resultTable.DefaultView;
                        poset.Columns[0].Visibility = Visibility.Hidden;
                        poset.Columns[1].Header = "Имя";
                        poset.Columns[2].Header = "Фамилия";
                        poset.Columns[3].Header = "Отчество";
                        poset.Columns[4].Header = "Почта";
                        poset.Columns[5].Header = "Номер телефона";
                        poset.Columns[6].Header = "Логин";
                        poset.Columns[7].Header = "Пароль";
                        poset.Columns[8].Visibility = Visibility.Hidden;
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_poset(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Poset();
        }


        private void TabItem_Loaded_9(object sender, RoutedEventArgs e)
        {
            Bron1();
        }

        private void bron1_Loaded(object sender, RoutedEventArgs e)
        {
            Bron1();
        }

        private void Bron1()
        {
            if (bron1 != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Booking], [Name_Booking], [Surname_Booking], [Last_Name_Booking], [Date_Booking], [Hotel_Class_Booking], [Floors_Booking], [Rooms_Booking], [People_Booking], [Sum_Booking] from [dbo].[Booking] inner join [dbo].[Visitors] on [ID_Visitors] = [Visitors_ID] inner join [dbo].[Hotel] on [ID_Hotel] = [Hotel_ID]"), DB.act.select);
                        db.dependency.OnChange += OnChange_bron1;
                        bron1.ItemsSource = db.resultTable.DefaultView;
                        bron1.Columns[0].Visibility = Visibility.Hidden;
                        bron1.Columns[1].Visibility = Visibility.Hidden;
                        bron1.Columns[2].Visibility = Visibility.Hidden;
                        bron1.Columns[3].Visibility = Visibility.Hidden;
                        bron1.Columns[4].Header = "Дата";
                        bron1.Columns[5].Header = "Класс отеля";
                        bron1.Columns[6].Header = "Этаж";
                        bron1.Columns[7].Header = "Количество комнат";
                        bron1.Columns[8].Header = "Количество людей";
                        bron1.Columns[9].Header = "Итоговая сумма";
                        bron1.Columns[10].Visibility = Visibility.Hidden;
                        bron1.Columns[11].Visibility = Visibility.Hidden;
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_bron1(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Bron1();
        }

        private void bron1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                if (bron1.Items.Count != 0 & bron1.SelectedItems.Count != 0)
                {
                    DataRowView dataRow = (DataRowView)bron1.SelectedItems[0];
                    Date_Booking.Text = dataRow[4].ToString();
                    Hotel_Class_Booking.Text = dataRow[5].ToString();
                    Floors_Booking.Text = dataRow[6].ToString();
                    Rooms_Booking.Text = dataRow[7].ToString();
                    People_Booking.Text = dataRow[8].ToString();
                    Sum_Booking.Text = dataRow[9].ToString();
                }
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                db.sqlExecute(string.Format("insert into [dbo].[Booking]([Date_Booking], [Hotel_Class_Booking], [Floors_Booking], [Rooms_Booking], [People_Booking], [Sum_Booking])" +
                    " values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", Date_Booking.Text, Hotel_Class_Booking.Text, Floors_Booking.Text, Rooms_Booking.Text, People_Booking.Text, Sum_Booking.Text), DB.act.manipulation);
                Date_Booking.Clear(); Hotel_Class_Booking.Clear(); Floors_Booking.Clear(); Rooms_Booking.Clear(); People_Booking.Clear(); Sum_Booking.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bron1.Items.Count != 0 & bron1.SelectedItems.Count != 0)
                {
                    DataRowView dataRowView = (DataRowView)bron1.SelectedItems[0];
                    DB db = new DB();
                    db.sqlExecute(string.Format("update [dbo].[Booking] set " +
                        "[Date_Booking] = '{0}'," +
                        "[Hotel_Class_Booking] = '{1}'," +
                        "[Floors_Booking] = '{2}'," +
                        "[Rooms_Booking] = '{3}'," +
                        "[People_Booking] = '{4}'," +
                        "[Sum_Booking] = '{5}'," +
                        "where [ID_Booking] = '{6}'", Date_Booking.Text, Hotel_Class_Booking.Text, Floors_Booking.Text, Rooms_Booking.Text, People_Booking.Text, Sum_Booking.Text,
                        dataRowView[0]), DB.act.manipulation);
                }
                Date_Booking.Clear(); Hotel_Class_Booking.Clear(); Floors_Booking.Clear(); Rooms_Booking.Clear(); People_Booking.Clear(); Sum_Booking.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (MessageBox.Show("Удалить выбранную запись?", DB.App_Name, MessageBoxButton.YesNo, MessageBoxImage.Question))
                {
                    case MessageBoxResult.Yes:
                        if (bron1.Items.Count != 0 & bron1.SelectedItems.Count != 0)
                        {
                            DataRowView dataRowView = (DataRowView)bron1.SelectedItems[0];
                            DB db = new DB();
                            db.sqlExecute(string.Format("delete from [dbo].[Booking] where [ID_Booking] = {0}", dataRowView[0]), DB.act.manipulation);
                        }
                        break;
                }
                Date_Booking.Clear(); Hotel_Class_Booking.Clear(); Floors_Booking.Clear(); Rooms_Booking.Clear(); People_Booking.Clear(); Sum_Booking.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }


        private void TabItem_Loaded_10(object sender, RoutedEventArgs e)
        {
            Gostin1();
        }

        private void gostin1_Loaded(object sender, RoutedEventArgs e)
        {
            Gostin1();
        }

        private void Gostin1()
        {
            if (gostin1 != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Hotel], [Hotel_Class], [Floors_Hotel], [Rooms_Amount_Hotel], [Rooms_On_Floors_Hotel], [Room_Capacity_Hotel], [Household_Services_Hotel], [Food_Zones_Hotel], [Entertainments_Hotel] from [dbo].[Hotel] inner join [dbo].[Employee] on [ID_Employee] = [Employee_ID]"), DB.act.select);
                        db.dependency.OnChange += OnChange_gostin1;
                        gostin1.ItemsSource = db.resultTable.DefaultView;
                        gostin1.Columns[0].Visibility = Visibility.Hidden;
                        gostin1.Columns[1].Header = "Класс отеля";
                        gostin1.Columns[2].Header = "Количество этажей";
                        gostin1.Columns[3].Header = "Количество номеров";
                        gostin1.Columns[4].Header = "Номеров на этаже";
                        gostin1.Columns[5].Header = "Местность номера";
                        gostin1.Columns[6].Header = "Служба быта";
                        gostin1.Columns[7].Header = "Зоны питания";
                        gostin1.Columns[8].Header = "Развлечения";
                        gostin1.Columns[9].Visibility = Visibility.Hidden;
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_gostin1(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Gostin1();
        }


        private void TabItem_Loaded_11(object sender, RoutedEventArgs e)
        {
            Firm1();
        }

        private void firm1_Loaded(object sender, RoutedEventArgs e)
        {
            Firm1();
        }

        private void Firm1()
        {
            if (firm1 != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Company], [Name_Company], [Type_Company] from [dbo].[Company]"), DB.act.select);
                        db.dependency.OnChange += OnChange_firm1;
                        firm1.ItemsSource = db.resultTable.DefaultView;
                        firm1.Columns[0].Visibility = Visibility.Hidden;
                        firm1.Columns[1].Header = "Название";
                        firm1.Columns[2].Header = "Тип деятельности";
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_firm1(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Firm1();
        }


        private void TabItem_Loaded_12(object sender, RoutedEventArgs e)
        {
            Jalob1();
        }

        private void jalob1_Loaded(object sender, RoutedEventArgs e)
        {
            Jalob1();
        }

        private void Jalob1()
        {
            if (jalob1 != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Complaints], [Feedback_Complaints] from [dbo].[Complaints] inner join [dbo].[Visitors] on [ID_Visitors] = [Visitors_ID]"), DB.act.select);
                        db.dependency.OnChange += OnChange_jalob1;
                        jalob1.ItemsSource = db.resultTable.DefaultView;
                        jalob1.Columns[0].Visibility = Visibility.Hidden;
                        jalob1.Columns[1].Header = "Отзыв";
                        jalob1.Columns[2].Visibility = Visibility.Hidden;
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_jalob1(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Jalob1();
        }

        private void jalob1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                if (jalob1.Items.Count != 0 & jalob1.SelectedItems.Count != 0)
                {
                    DataRowView dataRow = (DataRowView)jalob1.SelectedItems[0];
                    Feedback_Complaints.Text = dataRow[1].ToString();
                }
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                db.sqlExecute(string.Format("insert into [dbo].[Complaints]([Feedback_Complaints])" +
                    " values ('{0}')", Feedback_Complaints.Text), DB.act.manipulation);
                Feedback_Complaints.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            try
            {
                if (jalob1.Items.Count != 0 & jalob1.SelectedItems.Count != 0)
                {
                    DataRowView dataRowView = (DataRowView)jalob1.SelectedItems[0];
                    DB db = new DB();
                    db.sqlExecute(string.Format("update [dbo].[Complaints] set " +
                        "[Feedback_Complaints] = '{0}' where [ID_Complaints] = '{1}'", Feedback_Complaints.Text,
                        dataRowView[0]), DB.act.manipulation);
                }
                Feedback_Complaints.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (MessageBox.Show("Удалить выбранную запись?", DB.App_Name, MessageBoxButton.YesNo, MessageBoxImage.Question))
                {
                    case MessageBoxResult.Yes:
                        if (jalob1.Items.Count != 0 & jalob1.SelectedItems.Count != 0)
                        {
                            DataRowView dataRowView = (DataRowView)jalob1.SelectedItems[0];
                            DB db = new DB();
                            db.sqlExecute(string.Format("delete from [dbo].[Complaints] where [ID_Complaints] = {0}", dataRowView[0]), DB.act.manipulation);
                        }
                        break;
                }
                Feedback_Complaints.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }
    }
}
