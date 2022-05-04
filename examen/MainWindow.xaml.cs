using Microsoft.IdentityModel.Protocols;
using NLog.Internal;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


using MongoDB.Driver.Core.Configuration;

namespace examen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<books> book = new List<books>();
        private protected logic LC = new logic();
        bool btn1click = false, btn2click = false, btn3click = false;
        private protected Bruger BG = new Bruger("", "", 0);
        public string connectionString = "Data Source=CV-BB-5995;Initial Catalog=bogdatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        DataSet Bind = new DataSet();

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            /* SqlConnection Conn = new SqlConnection(connectionString);

             // Open the Database Connection
             Conn.Open();



             // Command String
             string Update = $"Update Table SET User = '" + txtdata1.Text + "' where ID = '" + txtblock2.Text + "'";



             // Initialize the command query and connection
             SqlCommand cmd = new SqlCommand(Update, Conn);


             // Execute the command
             cmd.ExecuteNonQuery(); */


            try
            {

                var sql = "UPDATE [book_Table] SET Bruger = '@User' WHERE ID = 1";
                string insert = $"INSERT INTO [Table] (User)";

                // dataGrid1.ItemsSource = null;
                string select = $"SELECT (User) FORM [Table]";
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@User", txtdata2.Text);


                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGrid1.Items.Clear();
                
                        btn1click = true;

                        this.bindgrid();
                        //  dataGrid1.DataContext = Bind;
                    }
                }
            }
            catch (Exception g)
            {
                MessageBox.Show($"Failed to update. Error message: {g.Message}");
            }




            /*  MessageBox.Show("One Record Inserted");
              txtdata1.Text = string.Empty;
              txtdata2.Text = string.Empty; */






        }



        public MainWindow()
        {

            InitializeComponent();





        }










        public void bindgrid()
        {


             SqlConnection Conn = new SqlConnection(connectionString);

             // Open the Database Connection
             Conn.Open();

             SqlDataAdapter Adapter = new SqlDataAdapter("Select * from book_Table", Conn);


             Adapter.Fill(Bind, "MyDataBinding");
         
             dataGrid1.DataContext = Bind;
            dataGrid1.Items.Refresh();
            // Close the Database Connection
            Conn.Close(); 
        }



        public void comboboxdata_Loaded(object sender, RoutedEventArgs e)
        {



        }

        public void BindGrid_Loaded(object sender, RoutedEventArgs e)
        {



            /*   SqlConnection Conn = new SqlConnection(connectionString);

               // Open the Database Connection
               Conn.Open();

               SqlDataAdapter Adapter = new SqlDataAdapter("Select * from book_Table", Conn);


               Adapter.Fill(Bind, "MyDataBinding");

               dataGrid1.DataContext = Bind;

               // Close the Database Connection
               Conn.Close();    */






          /*  string CmdString = string.Empty;

            using (SqlConnection con = new SqlConnection(connectionString))

            {
                var displaybookQuery = $"";



                CmdString = $"Select Author, Title from [book_Table]";

                SqlCommand cmd = new SqlCommand(CmdString, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                dataGrid1.ItemsSource = null;
                dataGrid1.ItemsSource = dt.DefaultView;  */

            }

        }
    }

    

    










    /*  public string Brugerinfo()
          {
              string brugernavn = brugerTXT.Text;

              return brugernavn;

          }
      } */

