using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Final_Practica_1
{
    internal class ConexionBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;
        public ConexionBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./ProductosHardware.accdb;";
        }
        public List<Dictionary<string, object>> ObtenerProductosComoDiccionario()
        {
            List<Dictionary<string, object>> productos = new List<Dictionary<string, object>>();

            try
            {
                conexion = new OleDbConnection(cadena);
                conexion.Open();

                comando = new OleDbCommand
                {
                    Connection = conexion,
                    CommandType = CommandType.Text,
                    CommandText = "SELECT Id, Nombre, Marca, Categoria, Precio FROM Productos"
                };

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var producto = new Dictionary<string, object>
                {
                    { "Id", reader["Id"] },
                    { "Nombre", reader["Nombre"] },
                    { "Marca", reader["Marca"] },
                    { "Categoria", reader["Categoria"] },
                    { "Precio", reader["Precio"] }
                };

                    productos.Add(producto);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return productos;
        }
    }
}
