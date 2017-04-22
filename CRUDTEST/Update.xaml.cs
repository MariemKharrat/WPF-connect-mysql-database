using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;

namespace CRUDTEST
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        public Update()
        {
            InitializeComponent();
        }

        private void update_S_Click(object sender, RoutedEventArgs e)
        {

            try

            {

                //This is my connection string i have assigned the database file address path 

                string MyConnection2 = "datasource=localhost;username=root;password=;database=test";

                //This is my update query in which i am taking input from the user through windows forms and update the record. 
            
                string Query = "update student set field='" + this.FieldS.Text + "'where id=2;";

                //This is  MySqlConnection here i have created the object and pass my connection string. 

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Updated");

                while (MyReader2.Read())

                {



                }

                MyConn2.Close();//Connection closed here 

            }

            catch (Exception ex)

            {



                MessageBox.Show(ex.Message);

            }
        }

        private void update_T_Click(object sender, RoutedEventArgs e)
        {
            try

            {

                //This is my connection string i have assigned the database file address path 

                string MyConnection2 = "datasource=localhost;username=root;password=;database=test";

                //This is my insert query in which i am taking input from the user through windows forms 

                string Query = "insert into teacher(name,field) VALUES('"+ this.NameT.Text +"','"+ this.FildT.Text +"')";

                //This is  MySqlConnection here i have created the object and pass my connection string. 

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                //This is command class which will handle the query and connection object. 

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database. 

                MessageBox.Show("Save Data");

                while (MyReader2.Read())

                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)

            {



                MessageBox.Show(ex.Message);

            }

        }
    }
}
