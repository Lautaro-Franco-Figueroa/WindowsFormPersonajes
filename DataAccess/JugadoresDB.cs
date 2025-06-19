using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace DataAccess
{
    public class JugadoresDB
    {
        private static string str = "Data Source=DESKTOP-760TDK3;Initial Catalog=LibraryLoan;Integrated Security=True";

        public static DataTable CargaDGV()
        {
            string sql = "SELECT * FROM jugadores";

            SqlDataAdapter db = new SqlDataAdapter(sql, str);
            DataTable table = new DataTable();
            db.Fill(table);
        }

        public static void Crear(Jugador jugador)
        {
            using (SqlConnection conexion = new SqlConnection(str))
            {
                conexion.Open();
                string insert = "insert into jugadores values (@nombre, @vida, @daño)";
                using (SqlCommand cmd = new SqlCommand(insert, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", jugador.p_Nombre);
                    cmd.Parameters.AddWithValue("@vida", jugador.p_Vida);
                    cmd.Parameters.AddWithValue("@daño", jugador.p_Daño);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
