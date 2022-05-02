using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace examen
{
    class logindatabase
    {


        private string connectionString = "Data Source=CV-BB-5995;Initial Catalog=bogdatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public string AllbookQuery = $"Select * from tblCustomerInfo where CustomerEmail=@CustomerEmail", con;



        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
       

        public Login()
        {
            InitializeComponent();
        }

       public void addnewuser(Bruger bruger)
        {
        

            String message = "Invalid Credentials";

            cmd.Parameters.AddWithValue("@CustomerEmail", txtUserId.Text.ToString());
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["Password"].ToString().Equals(txtPassword.Password.ToString(), StringComparison.InvariantCulture))
                {
                    message = "1";
                 
                    userinfo.CustomerEmail = txtUserId.Text.ToString();
                    userinfo.CustomerName = reader["CustomerName"].ToString();
                }
            }

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            con.Close(); 

            public bool ispassword(string username, string password)
            {





                if (password == true)
                {
                    return true;
                }

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
    }
}
