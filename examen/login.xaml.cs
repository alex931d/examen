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

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        static String connectionString = @"Data Source=192.168.0.192;Initial Catalog=DBCustomer;User ID=sa;Password=1234;";
        public login()
        {
            InitializeComponent();
          
        }
    }
}
