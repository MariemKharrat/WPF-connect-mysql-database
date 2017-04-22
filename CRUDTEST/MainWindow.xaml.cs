using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRUDTEST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DateTime d = DateTime.Now;
            dateTime.Text = "it is "+ d.ToString();
        }

        private void Connection_Click(object sender, RoutedEventArgs e)
        {
            //try

            //{

            //    //This is my connection string i have assigned the database file address path 

            //    string MyConnection2 = "datasource=localhost;username=root;password=;Database=test";
            //    //This is  MySqlConnection here i have created the object and pass my connection string. 

            //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //    MyConn2.Open();
            //    MessageBox.Show("Connection etablie");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}




            Display NextPage = new Display();
            Hide();
            NextPage.Show();
        }
             

    }
}
