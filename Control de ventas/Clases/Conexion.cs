using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Control_de_ventas.Clases
{
    class Conexion
    {
        SqlConnection SqlCon;


        public void Conectar()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-M29H6EG\\SQLEXPRESS,1433";
            builder.InitialCatalog = "DBCsharp";
            builder.UserID = "sa";
            builder.Password = "Kevin.jair19";
            builder.IntegratedSecurity = false;

            try
            {
                SqlCon = new SqlConnection(builder.ConnectionString);
                SqlCon.Open();
                Console.WriteLine("Se conecto");

            }
            catch(Exception e)
            {
               
            }
           

        }
    }
}

