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
        private static string str = "Data Source=DESKTOP-760TDK3;Initial Catalog=Duelo;Integrated Security=True";

        public static DataTable CargarDGV()
        {

            string sql = "SELECT * FROM jugadores";

            SqlDataAdapter db = new SqlDataAdapter(sql, str);
            DataTable table = new DataTable();
            db.Fill(table);

            return table;
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
        public static void Actualizar(Jugador jugador)
        {
            using (SqlConnection conexion = new SqlConnection(str))
            {
                conexion.Open();
                string update = "UPDATE jugadores SET nombre = @nombre, vida = @vida, daño = @daño WHERE nombre = @nombre";
                using (SqlCommand cmd = new SqlCommand(update, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", jugador.p_Nombre);
                    cmd.Parameters.AddWithValue("@vida", jugador.p_Vida);
                    cmd.Parameters.AddWithValue("@daño", jugador.p_Daño);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void Eliminar(string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(str))
            {
                conexion.Open();
                string delete = "DELETE FROM jugadores WHERE nombre = @nombre";
                using (SqlCommand cmd = new SqlCommand(delete, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static Jugador Buscar(string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(str))
            {
                conexion.Open();
                string query = "SELECT * FROM jugadores WHERE nombre = @nombre";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Jugador jugador = new Jugador();

                        jugador.p_Nombre = reader["nombre"].ToString();
                        jugador.p_Vida = Convert.ToInt32(reader["vida"]);
                        jugador.p_Daño = Convert.ToInt32(reader["daño"]);
                        return jugador;

                    }
                }
            }   
        }
    }
}
