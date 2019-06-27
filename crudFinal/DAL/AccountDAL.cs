using System;
using System.Data.SqlClient;

namespace DAL
{
    public static class AccountDAL
    {
        public static bool Validate(string email,string password)
        {
            bool status = false;

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dac\Desktop\dotNetDemo\DotNetEndModule_Preperation\EndModuleEcommApp1\ECommWebFE\App_Data\ECommDB.mdf;Integrated Security=True";
            conn.ConnectionString = connStr;
            string qry = "select * from customer where email=@email and password=@password";//ColName=@ParamName
            cmd.CommandText = qry;
            cmd.Parameters.Add(new SqlParameter("@email",email));
            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Connection = conn;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    status = true;
                }
                reader.Close();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public static bool Insert(int id,string name, string city, string email,string password, string mob)
        {
            bool status = false;

            string qry = "insert into customer values(@id,@name,@city,@email,@password,@mob)";
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dac\Desktop\dotNetDemo\DotNetEndModule_Preperation\EndModuleEcommApp1\ECommWebFE\App_Data\ECommDB.mdf;Integrated Security=True"; 
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(qry))
                {

                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@city", city));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    cmd.Parameters.Add(new SqlParameter("@mob", mob));
              
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    status = true;
                }
            }    
            return status;
        }
        public static bool update(int id,string password)
        {
            bool status = false;

            string query = "update customer set password=@password where id=@id";
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dac\Desktop\dotNetDemo\DotNetEndModule_Preperation\EndModuleEcommApp1\ECommWebFE\App_Data\ECommDB.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    status = true;
                }
            }
            return status;
        }
        public static bool Delete(int Id)
        {
            bool status = false;
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dac\Desktop\dotNetDemo\DotNetEndModule_Preperation\EndModuleEcommApp1\ECommWebFE\App_Data\ECommDB.mdf;Integrated Security=True";
            string query = "delete from customer where Id=@Id";
            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.Add(new SqlParameter("@Id", Id));
                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    status = true;
                }
                
            }
            return status;
        }

    }
}
