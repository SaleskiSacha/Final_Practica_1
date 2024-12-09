using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Practica_1
{
    public class Productos
    {
        private List<Dictionary<string, object>> productos;

        public Productos()
        {
            ConexionBD conexionBD = new ConexionBD();
            productos = conexionBD.ObtenerProductosComoDiccionario();
        }

        // Devuelve la lista completa
        public List<Dictionary<string, object>> ObtenerProductos()
        {
            return productos;
        }

        // Devuelve una lista filtrada, por ejemplo, solo productos de una categoría específica
        public List<string> ObtenerNombresPorCategoria(string categoria)
        {
            return productos
                .Where(p => p["Categoria"].ToString() == categoria)
                .Select(p => p["Nombre"].ToString())
                .ToList();
        }
        // Se hace una busqueda por el nombre
        public Dictionary<string, object> ObtenerProductoPorNombre(string nombreProducto)
        {
            return productos.FirstOrDefault(p => p["Nombre"].ToString() == nombreProducto);
        }
        // Hace un filtro de marca seleccionada y la categoria
        public List<string> ObtenerProcesadoresPorMarcaYCategoria(string marca, string categoria)
        {
            return productos
                .Where(p => p["Categoria"].ToString() == categoria && p["Marca"].ToString() == marca)
                .Select(p => p["Nombre"].ToString())
                .ToList();
        }
    }
}
