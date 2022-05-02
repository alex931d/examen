﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class database
    {

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

        public string AllbookQuery = "SELECT * FROM Table";
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
               
                books book = new books();
                book.Author = Author;
                book.Title = Title;
                book.Publisher = Publisher;
          
                book.Year = Publication;
                book.Copies = Copies;
                book.ISBN = ISBN;
                AllBooks.Add(book);
            }
            return AllBooks;
        }
        public void AddNew(books book)
        {
            string addNewBookQuery =
                    $"INSERT INTO Table (Author),(Title),(Publisher) VALUES('{book.Year}','{book.Copies}','{book.ISBN}')";
            Execute(addNewBookQuery);
        }

 
      /*  public void Remove(books book)

        {
            string removeBookQuery = $"DELETE INTO Table ()"

        } */
    }
}