using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CRUDTEST
{
    /// <summary>
    /// Interaction logic for Display.xaml
    /// </summary>
    public partial class Display : Window
    {
        public Display()
        {
            InitializeComponent();
        }

        private void student_button_Click(object sender, RoutedEventArgs e)
        {
            

                try

                {

                    string MyConnection2 = "datasource=localhost;username=root;password=;database=test";

                    //Display query 

                    string Query = "select * from student;";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);



                    //  MyConn2.Open(); 

                    //For offline connection we weill use  MySqlDataAdapter class. 

                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

                    MyAdapter.SelectCommand = MyCommand2;

                    DataTable dTable =   new DataTable();

                    MyAdapter.Fill(dTable);
                    ListView1.DataContext = dTable;

                // dataGrid.ItemsSource = dTable.DefaultView; // here i have assign dTable object to the dataGridView1 object to display data. 



                // MyConn2.Close(); 

            }

            catch (Exception ex)

                {



                    MessageBox.Show(ex.Message);

                }

            
        }

        private void teacher_button_Click(object sender, RoutedEventArgs e)
        {
            try

            {

                string MyConnection2 = "datasource=localhost;username=root;password=;database=test";

                //Display query 

                string Query = "select * from teacher;";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);



                //  MyConn2.Open(); 

                //For offline connection we weill use  MySqlDataAdapter class. 

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

                MyAdapter.SelectCommand = MyCommand2;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);




                //dataGrid.ItemsSource = dTable.DefaultView; // here i have assign dTable object to the dataGridView1 object to display data. 



                // MyConn2.Close(); 

            }

            catch (Exception ex)

            {



                MessageBox.Show(ex.Message);

            }

        }
    }
}
    

