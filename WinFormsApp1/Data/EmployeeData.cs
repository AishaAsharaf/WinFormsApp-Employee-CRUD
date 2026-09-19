using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Model;

namespace WinFormsApp1.Data
{
    public class EmployeeData
    {

        private readonly string connectionString = "paste your connection string here";
        

        public List<Client> GetClients()
        {
            var clients = new List<Client>();

            try
            {
                using(SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string sqlCommand = "SELECT * FROM dbo.Employees ORDER BY Id DESC";
                    using(SqlCommand command = new SqlCommand(sqlCommand, sqlConnection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) 
                            {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.first_Name = reader.GetString(1);
                                client.last_Name = reader.GetString(2);
                                client.age = reader.GetInt32(3);
                                client.location = reader.GetString(4);
                                client.date_time = reader.GetDateTime(5).ToString();
                                clients.Add(client);

                            }
                            
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return clients;
        }

        public Client? GetClient(int id)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string sqlCommand = "SELECT * Employees WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sqlCommand, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.first_Name = reader.GetString(1);
                                client.last_Name = reader.GetString(2);
                                client.age = reader.GetInt32(3);
                                client.location = reader.GetString(4);
                                client.date_time = reader.GetString(5).ToString();

                                return client;

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return null;
        }
   
        public void CreateClient(Client client)
        {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();

                        string sqlCommand = "INSERT INTO Employees" +
                                            "VALUES(First_Name,Last_Name,Age,Location)"+
                                            "(@First_Name, @Last_Name, @Age, @Location);"
                            ;
                                        
                        using (SqlCommand command = new SqlCommand(sqlCommand, sqlConnection))
                        {
                            command.Parameters.AddWithValue("@First_Name", client.first_Name);
                            command.Parameters.AddWithValue("@Last_Name", client.last_Name);
                            command.Parameters.AddWithValue("@Last_Name", client.age);
                            command.Parameters.AddWithValue("@Last_Name", client.location);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.ToString());
                }

            }

        public void DeleteClient(Client client) {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string sqlCommand = "DELETE FROM Employees WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sqlCommand, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", client.id);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

        }

        public void UpdateClient(Client client) {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string sqlCommand = "UPDATE Employees" +
                                        "SET first_name=@First_Name, last_name=@Last_Name, age=@Age, location=@Location" +
                                        "WHERE id=@id;";
                    using (SqlCommand command = new SqlCommand(sqlCommand, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", client.id);
                        command.Parameters.AddWithValue("@First_Name", client.first_Name);
                        command.Parameters.AddWithValue("@Last_Name", client.last_Name);
                        command.Parameters.AddWithValue("@Last_Name", client.age);
                        command.Parameters.AddWithValue("@Last_Name", client.location);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }


        }
    }



}
