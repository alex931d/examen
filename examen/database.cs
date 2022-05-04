using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace examen
{
    class database
    {
        DataSet Bind = new DataSet();

        private string connectionString = "Data Source=CV-BB-5995;Initial Catalog=bogdatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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

 
 





/*  public Enemy unit(int received)
  {
      Enemy enemy = new Enemy();
      string enemyQuery = $"SELECT * FROM Enemies WHERE enemyid = {received}";
      DataSet resultSet = Execute(enemyQuery);

      // Get the first table of the data set, and save in variable:
      DataTable EnemiesTable = resultSet.Tables[0];
      foreach (DataRow Enemiesrow in EnemiesTable.Rows)
      {
          string Name = (string)Enemiesrow["Name"];
          int Dmg = (int)Enemiesrow["Dmg"];
          int Hp = (int)Enemiesrow["Hp"];
          enemy.Name = Name;
          enemy.AttackDmg = Dmg;
          enemy.Hp = Hp;
      }
      return enemy;

  } */

public string AllbookQuery = "SELECT * FROM book_Table";
        public List<books> GetBooks()
        {
            List<books> AllBooks = new List<books>(0);
           

            // Perform query and save result in variable:
            DataSet resultSet = Execute(AllbookQuery);

            // Get the first table of the data set, and save in variable:
            DataTable BookTable = resultSet.Tables[0];

            // Iterate through the rows of the table, and extract the data,

            // and create a new person object each time, and add that to the list of persons.
            foreach (DataRow Tablerow in BookTable.Rows)
            {
                string Author = (string)Tablerow["Author"];
                string Title = (string)Tablerow["Title"];
                string Publisher = (string)Tablerow["Publisher"];
                
                int Publication = (int)Tablerow["Publication"];
                int Copies = (int)Tablerow["Copies"];
                int ISBN = (int)Tablerow["ISBN"];
                string User = (string)Tablerow["Bruger"];
               
                books book = new books();
                book.Author = Author;
                book.Title = Title;
                book.Publisher = Publisher;
          
                book.Year = Publication;
                book.Copies = Copies;
                book.ISBN = ISBN;
                book.User = User;
                
              
                AllBooks.Add(book);
            }
            return AllBooks;
        }
        public void AddNew(books book)
        {
            string addNewBookQuery =
                    $"INSERT INTO book_Table (Author),(Title),(Publisher) VALUES('','{book.Copies}','')";
            Execute(addNewBookQuery);
        }


        public void checkifexist(books book, string movie, string txt)
        {
            string s = $"SELECT Title, Bruger WHERE Bruger='{book.User}'";
            
            if (book.User == txt && book.Title == movie && book.Copies == 0)
            {
                string removebookquery = $"UPDATE [book_Table] SET Bruger = '', Copies = '1' WHERE Title = '{movie}'";

                Execute(removebookquery);
            }
            


            int i = 0;
            if (i != book.Copies)
            {
                string updatequery = $"UPDATE [book_Table] Set  WHERE {movie}";
            }
         
        }

     


 public void insert(books book)
        {

            string insertburgernavnQuery = $"INSERT INTO book_Table (book.Copies), (Lent)";

        }
      /*  public void Remove(books book)

        {
            string removeBookQuery = $"DELETE INTO Table ()"

        } */


        public void removereg(Bruger brug)
        {

            string RemoveNewBookQuery = $"INSERT INTO book_Table (Author),(Title),(Publisher) VALUES('','.','')";
            Execute(RemoveNewBookQuery);

        }
        public string GetAndRemove(books book, string movie, string txt)
        {

            if (book.User == txt && book.Title == movie && book.Copies == 0)
            {
                string removebookquery = $"UPDATE [book_Table] SET Bruger = '', Copies = '1' WHERE Title = '{movie}'";

                Execute(removebookquery);
                return "";
            }
            else if (book.Title == movie && book.Copies == 1)
            {
                try
                {
                    var sql = $@"UPDATE [book_Table] SET Bruger = '@User', Copies = '0' WHERE Title = '{movie}'";



                    string insert = $"INSERT INTO [Table] (User)";

                    // dataGrid1.ItemsSource = null;
                    string select = $"SELECT (User) FORM [Table]";
                    
                    using (var connection = new SqlConnection(connectionString))
                    {
                        using (var command = new SqlCommand(sql, connection))

                        {


                            command.Parameters.AddWithValue("@User", txt);


                            connection.Open();
                            command.ExecuteNonQuery();

                            //  dataGrid1.Items.Clear();



                            
                            //  dataGrid1.DataContext = Bind;

                        }
                    }

                }
                catch (Exception g)
                {
                    MessageBox.Show($"Failed to update. Error message: {g.Message}");
                }
            }
            return "";

        }

      




    }
}
