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
        private protected Bruger BG = new Bruger("", "", 0);
        database db = new database();
        public string connectionString = "Data Source=CV-BB-5995;Initial Catalog=bogdatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        DataSet Bind = new DataSet();


        private void btn1_Click(object sender, RoutedEventArgs e)
        {


            db.GetAndRemove(book,txtdata2;
            this.bindgrid(movie);


            /*  MessageBox.Show("One Record Inserted");
              txtdata1.Text = string.Empty;
              txtdata2.Text = string.Empty; */






        }



        public MainWindow()
        {

            InitializeComponent();



        


    }

        public string Getstext2() { 
            
            string txt = txtdata2.Text;

            return txt;
        
        }

        public string Get_combo()
        {
            string movie = ((ComboBoxItem)comboboxdata.SelectedItem).Content.ToString();
            return movie;
        }



       
       


        public void bindgrid(string movie)
        {


             SqlConnection Conn = new SqlConnection(connectionString);

             // Open the Database Connection
             Conn.Open();




               
              SqlDataAdapter Adapter = new SqlDataAdapter($"Select Author, Title, Bruger from book_Table WHERE Title = '{movie}'", Conn);



         

            Adapter.Fill(Bind, "MyDataBinding");

         

            dataGrid1.DataContext = Bind;
            dataGrid1.Items.Refresh();
            // Close the Database Connection
            Conn.Close(); 
        }



        public void comboboxdata_Loaded(object sender, RoutedEventArgs e)
        {



        }

        public DataSet Execute(string query)

        {
            try
            {
                DataSet resultSet = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, new SqlConnection(connectionString))))
                {

                    // Open conn, execute query, close conn, wrap result in DataSet: 
                    adapter.Fill(resultSet);
                }

                return resultSet;
            }

            catch (InvalidOperationException)
            {
                throw;
            }
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

