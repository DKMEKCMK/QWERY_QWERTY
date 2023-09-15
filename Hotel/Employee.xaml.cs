using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    /// Логика взаимодействия для Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void TabItem_Loaded_1(object sender, RoutedEventArgs e)
        {
            Sotr();
        }

        private void Sotr()
        {
            if (sotr != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Employee], [Name_Employee], [Surname_Employee], [Last_Name_Employee], [Email_Employee], [Phone_Number_Employee], [Login_Employee], [Password_Employee], [ID_Role_Employee] from [dbo].[Employee]"), DB.act.select);
                        db.dependency.OnChange += OnChange_sotr;
                        sotr.ItemsSource = db.resultTable.DefaultView;
                        sotr.Columns[0].Visibility = Visibility.Hidden;
                        sotr.Columns[1].Header = "Имя";
                        sotr.Columns[2].Header = "Фамилия";
                        sotr.Columns[3].Header = "Отчество";
                        sotr.Columns[4].Header = "Почта";
                        sotr.Columns[5].Header = "Номер телефона";
                        sotr.Columns[6].Header = "Логин";
                        sotr.Columns[7].Header = "Пароль";
                        sotr.Columns[8].Visibility = Visibility.Hidden;
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_sotr(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Sotr();
        }


        private void TabItem_Loaded_2(object sender, RoutedEventArgs e)
        {
            Bron();
        }

        private void bron_Loaded(object sender, RoutedEventArgs e)
        {
            Bron();
        }

        private void Bron()
        {
            if (bron != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Booking], [Name_Booking], [Surname_Booking], [Last_Name_Booking], [Date_Booking], [Hotel_Class_Booking], [Floors_Booking], [Rooms_Booking], [People_Booking], [Sum_Booking] from [dbo].[Booking] inner join [dbo].[Visitors] on [ID_Visitors] = [Visitors_ID] inner join [dbo].[Hotel] on [ID_Hotel] = [Hotel_ID]"), DB.act.select);
                        db.dependency.OnChange += OnChange_bron;
                        bron.ItemsSource = db.resultTable.DefaultView;
                        bron.Columns[0].Visibility = Visibility.Hidden;
                        bron.Columns[1].Header = "Имя";
                        bron.Columns[2].Header = "Фамилия";
                        bron.Columns[3].Header = "Отчество";
                        bron.Columns[4].Header = "Дата";
                        bron.Columns[5].Header = "Класс отеля";
                        bron.Columns[6].Header = "Этаж";
                        bron.Columns[7].Header = "Количество комнат";
                        bron.Columns[8].Header = "Количество людей";
                        bron.Columns[9].Header = "Итоговая сумма";
                        bron.Columns[10].Visibility = Visibility.Hidden;
                        bron.Columns[11].Visibility = Visibility.Hidden;
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_bron(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Bron();
        }

        private void bron_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bron.Items.Count != 0 & bron.SelectedItems.Count != 0)
            {
                DataRowView dataRow = (DataRowView)bron.SelectedItems[0];
                Name_Booking.Text = dataRow[1].ToString();
                Surname_Booking.Text = dataRow[2].ToString();
                Last_Name_Booking.Text = dataRow[3].ToString();
                Date_Booking.Text = dataRow[4].ToString();
                Hotel_Class_Booking.Text = dataRow[5].ToString();
                Floors_Booking.Text = dataRow[6].ToString();
                Rooms_Booking.Text = dataRow[7].ToString();
                People_Booking.Text = dataRow[8].ToString();
                Sum_Booking.Text = dataRow[9].ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                db.sqlExecute(string.Format("insert into [dbo].[Booking]([Name_Booking], [Surname_Booking], [Last_Name_Booking], [Date_Booking], [Hotel_Class_Booking], [Floors_Booking], [Rooms_Booking], [People_Booking], [Sum_Booking])" +
                    " values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", Surname_Booking.Text, Name_Booking.Text, Last_Name_Booking.Text, Date_Booking.Text, Hotel_Class_Booking.Text, Floors_Booking.Text, Rooms_Booking.Text, People_Booking.Text, Sum_Booking.Text), DB.act.manipulation);
                Surname_Booking.Clear(); Name_Booking.Clear(); Last_Name_Booking.Clear(); Date_Booking.Clear(); Hotel_Class_Booking.Clear(); Floors_Booking.Clear(); Rooms_Booking.Clear(); People_Booking.Clear(); Sum_Booking.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bron.Items.Count != 0 & bron.SelectedItems.Count != 0)
                {
                    DataRowView dataRowView = (DataRowView)bron.SelectedItems[0];
                    DB db = new DB();
                    db.sqlExecute(string.Format("update [dbo].[Booking] set " +
                        "[Name_Booking] = '{0}'," +
                        "[Surname_Booking] = '{1}'," +
                        "[Last_Name_Booking] = '{2}'," +
                        "[Date_Booking] = '{3}'," +
                        "[Hotel_Class_Booking] = '{4}'," +
                        "[Floors_Booking] = '{5}'," +
                        "[Rooms_Booking] = '{6}'," +
                        "[People_Booking] = '{7}'," +
                        "[Sum_Booking] = '{8}'," +
                        "where [ID_Booking] = '{9}'", Surname_Booking.Text, Name_Booking.Text, Last_Name_Booking.Text, Date_Booking.Text, Hotel_Class_Booking.Text, Floors_Booking.Text, Rooms_Booking.Text, People_Booking.Text, Sum_Booking.Text,
                        dataRowView[0]), DB.act.manipulation);
                }
                Surname_Booking.Clear(); Name_Booking.Clear(); Last_Name_Booking.Clear(); Date_Booking.Clear(); Hotel_Class_Booking.Clear(); Floors_Booking.Clear(); Rooms_Booking.Clear(); People_Booking.Clear(); Sum_Booking.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (MessageBox.Show("Удалить выбранную запись?", DB.App_Name, MessageBoxButton.YesNo, MessageBoxImage.Question))
                {
                    case MessageBoxResult.Yes:
                        if (bron.Items.Count != 0 & bron.SelectedItems.Count != 0)
                        {
                            DataRowView dataRowView = (DataRowView)bron.SelectedItems[0];
                            DB db = new DB();
                            db.sqlExecute(string.Format("delete from [dbo].[Booking] where [ID_Booking] = {0}", dataRowView[0]), DB.act.manipulation);
                        }
                        break;
                }
                Surname_Booking.Clear(); Name_Booking.Clear(); Last_Name_Booking.Clear(); Date_Booking.Clear(); Hotel_Class_Booking.Clear(); Floors_Booking.Clear(); Rooms_Booking.Clear(); People_Booking.Clear(); Sum_Booking.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {

        }


        private void TabItem_Loaded_3(object sender, RoutedEventArgs e)
        {
            Gostin();
        }

        private void gostin_Loaded(object sender, RoutedEventArgs e)
        {
            Gostin();
        }

        private void Gostin()
        {
            if (gostin != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Hotel], [Hotel_Class], [Floors_Hotel], [Rooms_Amount_Hotel], [Rooms_On_Floors_Hotel], [Room_Capacity_Hotel], [Household_Services_Hotel], [Food_Zones_Hotel], [Entertainments_Hotel] from [dbo].[Hotel] inner join [dbo].[Employee] on [ID_Employee] = [Employee_ID]"), DB.act.select);
                        db.dependency.OnChange += OnChange_gostin;
                        gostin.ItemsSource = db.resultTable.DefaultView;
                        gostin.Columns[0].Visibility = Visibility.Hidden;
                        gostin.Columns[1].Header = "Класс отеля";
                        gostin.Columns[2].Header = "Количество этажей";
                        gostin.Columns[3].Header = "Количество номеров";
                        gostin.Columns[4].Header = "Номеров на этаже";
                        gostin.Columns[5].Header = "Местность номера";
                        gostin.Columns[6].Header = "Служба быта";
                        gostin.Columns[7].Header = "Зоны питания";
                        gostin.Columns[8].Header = "Развлечения";
                        gostin.Columns[9].Visibility = Visibility.Hidden;
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_gostin(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Gostin();
        }

        private void gostin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                if (gostin.Items.Count != 0 & gostin.SelectedItems.Count != 0)
                {
                    DataRowView dataRow = (DataRowView)gostin.SelectedItems[0];
                    Hotel_Class.Text = dataRow[1].ToString();
                    Floors_Hotel.Text = dataRow[2].ToString();
                    Rooms_Amount_Hotel.Text = dataRow[3].ToString();
                    Rooms_On_Floors_Hotel.Text = dataRow[4].ToString();
                    Room_Capacity_Hotel.Text = dataRow[5].ToString();
                    Household_Services_Hotel.Text = dataRow[6].ToString();
                    Food_Zones_Hotel.Text = dataRow[7].ToString();
                    Entertainments_Hotel.Text = dataRow[8].ToString();
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                db.sqlExecute(string.Format("insert into [dbo].[Hotel]([Hotel_Class], [Floors_Hotel], [Rooms_Amount_Hotel], [Rooms_On_Floors_Hotel], [Room_Capacity_Hotel], [Household_Services_Hotel], [Food_Zones_Hotel], [Entertainments_Hotel])" +
                    " values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", Hotel_Class.Text, Floors_Hotel.Text, Rooms_Amount_Hotel.Text, Rooms_On_Floors_Hotel.Text, Room_Capacity_Hotel.Text, Household_Services_Hotel.Text, Food_Zones_Hotel.Text, Entertainments_Hotel.Text), DB.act.manipulation);
                Hotel_Class.Clear(); Floors_Hotel.Clear(); Rooms_Amount_Hotel.Clear(); Rooms_On_Floors_Hotel.Clear(); Room_Capacity_Hotel.Clear(); Household_Services_Hotel.Clear(); Food_Zones_Hotel.Clear(); Entertainments_Hotel.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                if (gostin.Items.Count != 0 & gostin.SelectedItems.Count != 0)
                {
                    DataRowView dataRowView = (DataRowView)gostin.SelectedItems[0];
                    DB db = new DB();
                    db.sqlExecute(string.Format("update [dbo].[Hotel] set " +
                        "[Hotel_Class] = '{0}'," +
                        "[Floors_Hotel] = '{1}'," +
                        "[Rooms_Amount_Hotel] = '{2}'," +
                        "[Rooms_On_Floors_Hotel] = '{3}'," +
                        "[Room_Capacity_Hotel] = '{4}'," +
                        "[Household_Services_Hotel] = '{5}'," +
                        "[Food_Zones_Hotel] = '{6}'," +
                        "[Entertainments_Hotel] = '{7}'," +
                        "where [ID_Hotel] = '{8}'", Hotel_Class.Text, Floors_Hotel.Text, Rooms_Amount_Hotel.Text, Rooms_On_Floors_Hotel.Text, Room_Capacity_Hotel.Text, Household_Services_Hotel.Text, Food_Zones_Hotel.Text, Entertainments_Hotel.Text,
                        dataRowView[0]), DB.act.manipulation);
                }
                Hotel_Class.Clear(); Floors_Hotel.Clear(); Rooms_Amount_Hotel.Clear(); Rooms_On_Floors_Hotel.Clear(); Room_Capacity_Hotel.Clear(); Household_Services_Hotel.Clear(); Food_Zones_Hotel.Clear(); Entertainments_Hotel.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (MessageBox.Show("Удалить выбранную запись?", DB.App_Name, MessageBoxButton.YesNo, MessageBoxImage.Question))
                {
                    case MessageBoxResult.Yes:
                        if (gostin.Items.Count != 0 & gostin.SelectedItems.Count != 0)
                        {
                            DataRowView dataRowView = (DataRowView)gostin.SelectedItems[0];
                            DB db = new DB();
                            db.sqlExecute(string.Format("delete from [dbo].[Hotel] where [ID_Hotel] = {0}", dataRowView[0]), DB.act.manipulation);
                        }
                        break;
                }
                Hotel_Class.Clear(); Floors_Hotel.Clear(); Rooms_Amount_Hotel.Clear(); Rooms_On_Floors_Hotel.Clear(); Room_Capacity_Hotel.Clear(); Household_Services_Hotel.Clear(); Food_Zones_Hotel.Clear(); Entertainments_Hotel.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }


        private void TabItem_Loaded_4(object sender, RoutedEventArgs e)
        {
            Firm();
        }

        private void firm_Loaded(object sender, RoutedEventArgs e)
        {
            Firm();
        }

        private void Firm()
        {
            if (firm != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Company], [Name_Company], [Type_Company] from [dbo].[Company]"), DB.act.select);
                        db.dependency.OnChange += OnChange_firm;
                        firm.ItemsSource = db.resultTable.DefaultView;
                        firm.Columns[0].Visibility = Visibility.Hidden;
                        firm.Columns[1].Header = "Название";
                        firm.Columns[2].Header = "Тип деятельности";
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_firm(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Firm();
        }

        private void firm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (firm.Items.Count != 0 & firm.SelectedItems.Count != 0)
            {
                DataRowView dataRow = (DataRowView)firm.SelectedItems[0];
                Name_Company.Text = dataRow[1].ToString();
                Type_Company.Text = dataRow[2].ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                db.sqlExecute(string.Format("insert into [dbo].[Company]([Name_Company], [Type_Company])" +
                    " values ('{0}', '{1}')", Name_Company.Text, Type_Company.Text), DB.act.manipulation);
                Name_Company.Clear(); Type_Company.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            try
            {
                if (firm.Items.Count != 0 & firm.SelectedItems.Count != 0)
                {
                    DataRowView dataRowView = (DataRowView)firm.SelectedItems[0];
                    DB db = new DB();
                    db.sqlExecute(string.Format("update [dbo].[Company] set " +
                        "[Name_Company] = '{0}'," +
                        "[Type_Company] = '{1}' where [ID_Company] = '{2}'", Name_Company.Text, Type_Company.Text,
                        dataRowView[0]), DB.act.manipulation);
                }
                Name_Company.Clear(); Type_Company.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (MessageBox.Show("Удалить выбранную запись?", DB.App_Name, MessageBoxButton.YesNo, MessageBoxImage.Question))
                {
                    case MessageBoxResult.Yes:
                        if (firm.Items.Count != 0 & firm.SelectedItems.Count != 0)
                        {
                            DataRowView dataRowView = (DataRowView)firm.SelectedItems[0];
                            DB db = new DB();
                            db.sqlExecute(string.Format("delete from [dbo].[Company] where [ID_Company] = {0}", dataRowView[0]), DB.act.manipulation);
                        }
                        break;
                }
                Name_Company.Clear(); Type_Company.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }


        private void TabItem_Loaded_5(object sender, RoutedEventArgs e)
        {
            Jalob();
        }

        private void jalob_Loaded(object sender, RoutedEventArgs e)
        {
            Jalob();
        }

        private void Jalob()
        {
            if (jalob != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Complaints], [Feedback_Complaints] from [dbo].[Complaints] inner join [dbo].[Visitors] on [ID_Visitors] = [Visitors_ID]"), DB.act.select);
                        db.dependency.OnChange += OnChange_jalob;
                        jalob.ItemsSource = db.resultTable.DefaultView;
                        jalob.Columns[0].Visibility = Visibility.Hidden;
                        jalob.Columns[1].Header = "Отзыв";
                        jalob.Columns[2].Visibility = Visibility.Hidden;
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_jalob(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Jalob();
        }


        private void TabItem_Loaded_6(object sender, RoutedEventArgs e)
        {
            Dolg();
        }

        private void dolg_Loaded(object sender, RoutedEventArgs e)
        {
            Dolg();
        }

        private void Dolg()
        {
            if (dolg != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Debts], [Name_Debts], [Surname_Debts], [Last_Name_Debts], [Sum_Debts], [Date_Debts] from [dbo].[Debts] inner join [dbo].[Company] on [ID_Company] = [Company_ID] inner join [dbo].[Visitors] on [ID_Visitors] = [Visitors_ID]"), DB.act.select);
                        db.dependency.OnChange += OnChange_dolg;
                        dolg.ItemsSource = db.resultTable.DefaultView;
                        dolg.Columns[0].Visibility = Visibility.Hidden;
                        dolg.Columns[1].Header = "Имя";
                        dolg.Columns[2].Header = "Фамилия";
                        dolg.Columns[3].Header = "Отчество";
                        dolg.Columns[4].Header = "Сумма";
                        dolg.Columns[5].Header = "Дата";
                        dolg.Columns[6].Visibility = Visibility.Hidden;
                        dolg.Columns[7].Visibility = Visibility.Hidden;
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_dolg(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Dolg();
        }

        private void dolg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                if (dolg.Items.Count != 0 & dolg.SelectedItems.Count != 0)
                {
                    DataRowView dataRow = (DataRowView)dolg.SelectedItems[0];
                    Name_Debts.Text = dataRow[1].ToString();
                    Surname_Debts.Text = dataRow[2].ToString();
                    Last_Name_Debts.Text = dataRow[3].ToString();
                    Sum_Debts.Text = dataRow[4].ToString();
                    Date_Debts.Text = dataRow[5].ToString();
                }
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                db.sqlExecute(string.Format("insert into [dbo].[Debts]([Name_Debts], [Surname_Debts], [Last_Name_Debts], [Sum_Debts], [Date_Debts])" +
                    " values ('{0}', '{1}', '{2}', '{3}', '{4}')", Name_Debts.Text, Surname_Debts.Text, Last_Name_Debts.Text, Sum_Debts.Text, Date_Debts.Text), DB.act.manipulation);
                Name_Debts.Clear(); Surname_Debts.Clear(); Last_Name_Debts.Clear(); Sum_Debts.Clear(); Date_Debts.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dolg.Items.Count != 0 & dolg.SelectedItems.Count != 0)
                {
                    DataRowView dataRowView = (DataRowView)dolg.SelectedItems[0];
                    DB db = new DB();
                    db.sqlExecute(string.Format("update [dbo].[Debts] set " +
                        "[Name_Debts] = '{0}'," +
                        "[Surname_Debts] = '{1}'," +
                        "[Last_Name_Debts] = '{2}'," +
                        "[Sum_Debts] = '{3}'," +
                        "[Date_Debts] = '{4}'," +
                        "where [ID_Debts] = '{5}'", Name_Debts.Text, Surname_Debts.Text, Last_Name_Debts.Text, Sum_Debts.Text, Date_Debts.Text,
                        dataRowView[0]), DB.act.manipulation);
                }
                Name_Debts.Clear(); Surname_Debts.Clear(); Last_Name_Debts.Clear(); Sum_Debts.Clear(); Date_Debts.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (MessageBox.Show("Удалить выбранную запись?", DB.App_Name, MessageBoxButton.YesNo, MessageBoxImage.Question))
                {
                    case MessageBoxResult.Yes:
                        if (dolg.Items.Count != 0 & dolg.SelectedItems.Count != 0)
                        {
                            DataRowView dataRowView = (DataRowView)dolg.SelectedItems[0];
                            DB db = new DB();
                            db.sqlExecute(string.Format("delete from [dbo].[Debts] where [ID_Debts] = {0}", dataRowView[0]), DB.act.manipulation);
                        }
                        break;
                }
                Name_Debts.Clear(); Surname_Debts.Clear(); Last_Name_Debts.Clear(); Sum_Debts.Clear(); Date_Debts.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }


        private void TabItem_Loaded_7(object sender, RoutedEventArgs e)
        {
            Klient();
        }

        private void klient_Loaded(object sender, RoutedEventArgs e)
        {
            Klient();
        }

        private void Klient()
        {
            if (klient != null)
            {
                Action action = () =>
                {
                    try
                    {
                        DB db = new DB();
                        db.sqlExecute(string.Format("select [ID_Client_Base], [Name_Client_Base], [Surname_Client_Base], [Last_Name_Client_Base], [Email_Client_Base], [Phone_Number_Client_Base] from [dbo].[Client_Base] inner join [dbo].[Visitors] on [ID_Visitors] = [Visitors_ID]"), DB.act.select);
                        db.dependency.OnChange += OnChange_klient;
                        klient.ItemsSource = db.resultTable.DefaultView;
                        klient.Columns[0].Visibility = Visibility.Hidden;
                        klient.Columns[1].Header = "Имя";
                        klient.Columns[2].Header = "Фамилия";
                        klient.Columns[3].Header = "Отчество";
                        klient.Columns[4].Header = "Почта";
                        klient.Columns[5].Header = "Номер телефона";
                        klient.Columns[6].Visibility = Visibility.Hidden;
                    }
                    catch { }
                };
                Dispatcher.Invoke(action);
            }
        }

        private void OnChange_klient(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                Klient();
        }

        private void klient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                if (klient.Items.Count != 0 & klient.SelectedItems.Count != 0)
                {
                    DataRowView dataRow = (DataRowView)klient.SelectedItems[0];
                    Name_Client_Base.Text = dataRow[1].ToString();
                    Surname_Client_Base.Text = dataRow[2].ToString();
                    Last_Name_Client_Base.Text = dataRow[3].ToString();
                    Email_Client_Base.Text = dataRow[4].ToString();
                    Phone_Number_Client_Base.Text = dataRow[5].ToString();
                }
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                db.sqlExecute(string.Format("insert into [dbo].[Client_Base]([Name_Client_Base], [Surname_Client_Base], [Last_Name_Client_Base], [Email_Client_Base], [Phone_Number_Client_Base])" +
                    " values ('{0}', '{1}', '{2}', '{3}', '{4}')", Name_Client_Base.Text, Surname_Client_Base.Text, Last_Name_Client_Base.Text, Email_Client_Base.Text, Phone_Number_Client_Base.Text), DB.act.manipulation);
                Name_Client_Base.Clear(); Surname_Client_Base.Clear(); Last_Name_Client_Base.Clear(); Email_Client_Base.Clear(); Phone_Number_Client_Base.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            try
            {
                if (klient.Items.Count != 0 & klient.SelectedItems.Count != 0)
                {
                    DataRowView dataRowView = (DataRowView)klient.SelectedItems[0];
                    DB db = new DB();
                    db.sqlExecute(string.Format("update [dbo].[Client_Base] set " +
                        "[Name_Client_Base] = '{0}'," +
                        "[Surname_Client_Base] = '{1}'," +
                        "[Last_Name_Client_Base] = '{2}'," +
                        "[Email_Client_Base] = '{3}'," +
                        "[Phone_Number_Client_Base] = '{4}'," +
                        "where [ID_Client_Base] = '{5}'", Name_Client_Base.Text, Surname_Client_Base.Text, Last_Name_Client_Base.Text, Email_Client_Base.Text, Phone_Number_Client_Base.Text,
                        dataRowView[0]), DB.act.manipulation);
                }
                Name_Client_Base.Clear(); Surname_Client_Base.Clear(); Last_Name_Client_Base.Clear(); Email_Client_Base.Clear(); Phone_Number_Client_Base.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (MessageBox.Show("Удалить выбранную запись?", DB.App_Name, MessageBoxButton.YesNo, MessageBoxImage.Question))
                {
                    case MessageBoxResult.Yes:
                        if (klient.Items.Count != 0 & klient.SelectedItems.Count != 0)
                        {
                            DataRowView dataRowView = (DataRowView)klient.SelectedItems[0];
                            DB db = new DB();
                            db.sqlExecute(string.Format("delete from [dbo].[Client_Base] where [ID_Client_Base] = {0}", dataRowView[0]), DB.act.manipulation);
                        }
                        break;
                }
                Name_Client_Base.Clear(); Surname_Client_Base.Clear(); Last_Name_Client_Base.Clear(); Email_Client_Base.Clear(); Phone_Number_Client_Base.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка данных!");
            }
        }
    }
}
