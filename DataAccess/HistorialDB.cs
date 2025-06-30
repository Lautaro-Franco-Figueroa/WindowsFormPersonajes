using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HistorialDB
    {
        private static string str = "Data Source=DESKTOP-760TDK3;Initial Catalog=Duelo;Integrated Security=True";

        public static DataTable CargarDGV()
        {

            string sql = "SELECT * FROM Partidas";

            SqlDataAdapter db = new SqlDataAdapter(sql, str);
            DataTable table = new DataTable();
            db.Fill(table);

            return table;
        }

        public static void Crear(Partida partida)
        {
            using (SqlConnection conexion = new SqlConnection(str))
            {
                conexion.Open();
                string insert = "insert into Partidas values (@Nombre, @Fecha, @Resultado)";
                using (SqlCommand cmd = new SqlCommand(insert, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", partida.j_Nombre);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Resultado", partida.j_Resultado);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
