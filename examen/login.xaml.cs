using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace examen
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>      
      
    public partial class login : Window
    {

       /* bool login1 = false;
        private string connectionString = "Data Source=CV-BB-5995;Initial Catalog=bogdatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
   
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
       */
        public login()
        {
            InitializeComponent();
          
        }



        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            
            
            
            String username = "username";
        String password = "password";

           if ((txtUserId.Text == username) && (txtPassword.Text == password))
            { 
        
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
                this.Close();
            }
                else if (!(txtUserId.Text == username) || !(txtPassword.Text == password))
                {
                 MessageBox.Show("type password and username correct");
                }
           

        

           /* String message = "Invalid Credentials";
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("Select * from tblCustomerInfo where CustomerEmail=@CustomerEmail", con);
                cmd.Parameters.AddWithValue("@CustomerEmail", txtUserId.Text.ToString());
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["Password"].ToString().Equals(txtPassword.Password.ToString(), StringComparison.InvariantCulture))
                    {
                        message = "1";
                        login1 = true;
                        userinfo.CustomerEmail = txtUserId.Text.ToString();
                        userinfo.CustomerName = reader["CustomerName"].ToString();
                    }
                }

                reader.Close();
                reader.Dispose();
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                message = ex.Message.ToString();
            }
            if (message == "1" || login1 == true)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
                MessageBox.Show(message, "Info");
        */ 



       



      /*  public void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        } */
    }
}
}
