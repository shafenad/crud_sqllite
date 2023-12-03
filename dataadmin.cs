using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_database.classes
{
    public class dataadmin
    {
        public int id_admin { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shavi\\source\\repos\\crud_database\\crud_database\\admin.mdf;Integrated Security=True";

        public List<dataadmin> Getadmin()
        {
            List<dataadmin> adminList = new List<dataadmin>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "SELECT id_admin, email, password from data_admin";
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    dataadmin admin = new dataadmin();

                    admin.id_admin = Convert.ToInt32(dr["id_admin"]);
                    admin.email = dr["email"].ToString();
                    admin.password = dr["password"].ToString();

                    adminList.Add(admin);
                }
            }
            return adminList;
        }

        public void Createadmin(dataadmin admin)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "INSERT INTO data_admin (id_admin, email, password) VALUES (@id_admin, @email, @password)"; 
            SqlCommand cmd = new SqlCommand(selectSQL, con);
           

            
            cmd.Parameters.Add(new SqlParameter("@id_admin", admin.id_admin));
            cmd.Parameters.Add(new SqlParameter("@email", admin.email));
            cmd.Parameters.Add(new SqlParameter("@password", admin.password));


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();



        }

        public dataadmin GetDataadmin(int id_admin)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "SELECT id_admin, email, password FROM data_admin WHERE id_admin = " + id_admin;
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();

            dataadmin admin = new dataadmin();

            if (dr != null)
            {
                while (dr.Read())
                {
                    admin.id_admin = Convert.ToInt32(dr["id_admin"]);
                    admin.email = dr["email"].ToString();
                    admin.password = dr["password"].ToString();

                }
            }
            return admin;
        }


        public void Editdata(dataadmin admin)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "UPDATE data_admin SET email = @email, password = @password WHERE id_admin = @id_admin";
            SqlCommand cmd = new SqlCommand(selectSQL, con);



            cmd.Parameters.Add(new SqlParameter("@id_admin", admin.id_admin));
            cmd.Parameters.Add(new SqlParameter("@email", admin.email));
            cmd.Parameters.Add(new SqlParameter("@password", admin.password));


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Hapusdata(int id_admin)
        {
            SqlConnection con = new SqlConnection (connectionString);
            string selectSQL = "DELETE FROM data_admin WHERE id_admin = @id_admin"; 
            SqlCommand cmd = new SqlCommand(selectSQL, con);

            cmd.Parameters.Add(new SqlParameter("@id_admin", id_admin));
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
