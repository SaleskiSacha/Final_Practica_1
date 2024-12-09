using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Practica_1
{
    public partial class frmPedido : Form
    {
        private Productos gestorProductos;
        public frmPedido()
        {
            InitializeComponent();
            gestorProductos = new Productos();
            // CargarProductosEnDataGridView();
            CargarComboBox();
            btnProcesador.Enabled = false;
            btnRam.Enabled = false;

        }

        //Esto es por si quiero cargar toda la lista de diccionarios en la Tabla
        /*private void CargarProductosEnDataGridView()
        {
            var productos = gestorProductos.ObtenerProductos();
            dgvTabla.DataSource = productos.Select(p => new
            {
                Id = p["Id"],
                Nombre = p["Nombre"],
                Marca = p["Marca"],
                Categoria = p["Categoria"],
                Precio = p["Precio"]
            }).ToList();
        }*/
        private void CargarComboBox()
        {
            // Filtrando solo la categoría 1
            var nombresCategoria1 = gestorProductos.ObtenerNombresPorCategoria(Convert.ToString(1));

            // Asignar los nombres filtrados al ComboBox
            cmbPlaca_Madre.DataSource = nombresCategoria1;
        }

        private void btnCargarPM_Click(object sender, EventArgs e)
        {
            
            string nombreSeleccionado = cmbPlaca_Madre.SelectedItem.ToString();

            // Buscar el producto correspondiente al nombre seleccionado
            var productoSeleccionado = gestorProductos.ObtenerProductoPorNombre(nombreSeleccionado);

            if (productoSeleccionado != null)
            {
            // Asignar el producto seleccionado al DataGridView
                dgvTabla.DataSource = new List<object>
                {
                    new
                    {
                        Nombre = productoSeleccionado["Nombre"],
                        Marca = productoSeleccionado["Marca"],
                        Precio = productoSeleccionado["Precio"]
                    }
                };
             // Obtener la marca del producto seleccionado
             string marcaSeleccionada = productoSeleccionado["Marca"].ToString();
             // Filtrar los productos de la categoría 2 con la misma marca
             var nombresProcesadores = gestorProductos.ObtenerProcesadoresPorMarcaYCategoria(marcaSeleccionada, "2");

            // Asignar al ComboBox de procesadores
            cmbProcesador.DataSource = nombresProcesadores;
            }
            btnCargarPM.Enabled = false;
            btnProcesador.Enabled = true;

        }

        private void btnProcesador_Click(object sender, EventArgs e)
        {
            string nombreProcesadorSeleccionado = cmbProcesador.SelectedItem.ToString();

            // Buscar el procesador seleccionado
            var procesadorSeleccionado = gestorProductos.ObtenerProductoPorNombre(nombreProcesadorSeleccionado);

            if (procesadorSeleccionado != null)
            {
                // Si el DataGridView no tiene un origen de datos, inicializarlo como una lista
                var dataGridSource = dgvTabla.DataSource as List<object> ?? new List<object>();

                // Agregar el procesador seleccionado a la lista existente
                dataGridSource.Add(new
                {
                    Nombre = procesadorSeleccionado["Nombre"],
                    Marca = procesadorSeleccionado["Marca"],
                    Precio = procesadorSeleccionado["Precio"]
                });

                // Actualizar la fuente de datos del DataGridView
                dgvTabla.DataSource = null; // Para refrescar el control
                dgvTabla.DataSource = dataGridSource;
            }
            // Filtrando solo la categoría 1
            var nombresCategoria3 = gestorProductos.ObtenerNombresPorCategoria(Convert.ToString(3));

            // Asignar los nombres filtrados al ComboBox
            cmbRam.DataSource = nombresCategoria3;
            btnProcesador.Enabled = false;
            btnRam.Enabled = true;
        }

        private void btbRam_Click(object sender, EventArgs e)
        {
            string nombreProcesadorSeleccionado = cmbRam.SelectedItem.ToString();

            // Buscar el procesador seleccionado
            var procesadorSeleccionado = gestorProductos.ObtenerProductoPorNombre(nombreProcesadorSeleccionado);

            // Si el DataGridView no tiene un origen de datos, inicializarlo como una lista
            var dataGridSource = dgvTabla.DataSource as List<object> ?? new List<object>();

            // Agregar el procesador seleccionado a la lista existente
            dataGridSource.Add(new
            {
                Nombre = procesadorSeleccionado["Nombre"],
                Marca = procesadorSeleccionado["Marca"],
                Precio = procesadorSeleccionado["Precio"]
            });

            // Actualizar la fuente de datos del DataGridView
            dgvTabla.DataSource = null; // Para refrescar el control
            dgvTabla.DataSource = dataGridSource;
            btnRam.Enabled = false;

            int suma = 0;
           

            for (int filaIndex = 0; filaIndex < Math.Min(3, dgvTabla.Rows.Count); filaIndex++)
            {
                var celda = dgvTabla.Rows[filaIndex].Cells[2];

                // Verificar que la celda no sea nula y que contenga un valor numérico
                if (celda.Value != null && int.TryParse(celda.Value.ToString(), out int valor))
                {
                    suma += valor;
                }
            }
            txtTotal.Text = "$"+suma.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            dgvTabla.Columns.Clear();
            btnCargarPM.Enabled = true;
            cmbPlaca_Madre.SelectedIndex = -1;
            cmbProcesador.DataSource = null;
            cmbProcesador.Items.Clear();
            cmbRam.DataSource = null;
            cmbRam.Items.Clear();
        }
    }
}
