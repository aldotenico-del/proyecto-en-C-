using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{



    public partial class FormsProducto : Form
    {
        // Carpeta y archivo donde se guardan los productos
        private const string CarpetaDatos =
            @"C:\Users\user\OneDrive - Universidad Central del Este\documentos de la UCE\MIDEL.COD\proyectos en C#\WinFormsApp1";
        private readonly string archivoProductos = Path.Combine(CarpetaDatos, "productos.txt");

        // Lista en memoria con todos los productos
        private List<Producto> productos = new List<Producto>();

        public FormsProducto()
        {
            InitializeComponent();
        }

        private void dataGrid_PRODUCTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormsProducto_Load(object sender, EventArgs e)
        {
            // Configuración de la tabla
            dataGrid_PRODUCTO.ReadOnly = true;
            dataGrid_PRODUCTO.AllowUserToAddRows = false;
            dataGrid_PRODUCTO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_PRODUCTO.MultiSelect = true;
            dataGrid_PRODUCTO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cargar lo que ya estaba guardado en el archivo
            CargarDesdeArchivo();
            MostrarProductos(productos);

            // ===== ACTION (lambda): muestra un aviso y pone el cursor en el campo con error =====
            Action<string, Control> avisar = (mensaje, campo) =>
            {
                MessageBox.Show(mensaje, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.Focus();
            };

            // ===== LAMBDA DE INSTRUCCIONES: botón GUARDAR =====
            btn_GURADAR_produc.Click += (s, ev) =>
            {
                string codigo = TXT_CODIGO_produc.Text.Trim();
                string nombre = TXT_NOMBRE_product.Text.Trim();
                string descripcion = TXT_DESCRIPCION.Text.Trim();

                // --- Validaciones ---
                if (codigo == "")
                {
                    avisar("El código es obligatorio.", TXT_CODIGO_produc);
                    return;
                }

                if (nombre == "")
                {
                    avisar("El nombre es obligatorio.", TXT_NOMBRE_product);
                    return;
                }

                if (!decimal.TryParse(TXT_PRECIO.Text.Trim(), NumberStyles.Number,
                        CultureInfo.CurrentCulture, out decimal precio) || precio <= 0)
                {
                    avisar("El precio debe ser un número mayor que 0.", TXT_PRECIO);
                    return;
                }

                if (!int.TryParse(TXT_CANTIDAD.Text.Trim(), out int cantidad) || cantidad < 0)
                {
                    avisar("La cantidad debe ser un número entero mayor o igual a 0.", TXT_CANTIDAD);
                    return;
                }

                // Código repetido (lambda con Any)
                if (productos.Any(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase)))
                {
                    avisar("Ya existe un producto con ese código.", TXT_CODIGO_produc);
                    return;
                }

                // --- Registrar ---
                Producto nuevo = new Producto
                {
                    Codigo = codigo,
                    Nombre = nombre,
                    Precio = precio,
                    Cantidad = cantidad,
                    Descripcion = descripcion
                };
                productos.Add(nuevo);

                try
                {
                    GuardarEnArchivo();
                }
                catch (Exception ex)
                {
                    productos.Remove(nuevo); // si no se pudo guardar, no se registra
                    MessageBox.Show("No se pudo guardar en el archivo:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MostrarProductos(productos);

                // --- Limpiar cuadros de texto (solo si todo salió bien) ---
                TXT_CODIGO_produc.Clear();
                TXT_NOMBRE_product.Clear();
                TXT_PRECIO.Clear();
                TXT_CANTIDAD.Clear();
                TXT_DESCRIPCION.Clear();
                TXT_CODIGO_produc.Focus();

                MessageBox.Show("Producto registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // ===== LAMBDA DE INSTRUCCIONES: botón ELIMINAR =====
            btn_ELIMINAR_product.Click += (s, ev) =>
            {
                // Productos de las filas seleccionadas en la tabla
                List<Producto> seleccionados = dataGrid_PRODUCTO.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(r => (Producto)r.DataBoundItem)
                    .ToList();

                if (seleccionados.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos un producto de la tabla.",
                        "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Seguro que desea eliminar " + seleccionados.Count + " producto(s)?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes) return;

                productos.RemoveAll(p => seleccionados.Contains(p));

                try
                {
                    GuardarEnArchivo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar el archivo:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                TXT_FILTRO_PRECIO.Clear();
                MostrarProductos(productos);
            };

            // ===== FILTRAR con Where + lambda =====
            btn_FILTRAR_product.Click += (s, ev) =>
            {
                if (!decimal.TryParse(TXT_FILTRO_PRECIO.Text.Trim(), NumberStyles.Number,
                        CultureInfo.CurrentCulture, out decimal minimo))
                {
                    avisar("Escriba un precio válido para filtrar.", TXT_FILTRO_PRECIO);
                    return;
                }

                List<Producto> filtrados = productos.Where(p => p.Precio >= minimo).ToList();
                MostrarProductos(filtrados);
            };

            // ===== LAMBDA DE EXPRESIÓN: mostrar todo =====
            btn_MOSTRAR_TODO_product.Click += (s, ev) =>
            {
                TXT_FILTRO_PRECIO.Clear();
                MostrarProductos(productos);
            };

            // ===== LAMBDA DE EXPRESIÓN: botón ATRÁS =====
            BTN_BACK_product.Click += (s, ev) => Close();
        }

        // Refresca la tabla con la lista que se le pase
        private void MostrarProductos(List<Producto> lista)
        {
            dataGrid_PRODUCTO.DataSource = null;
            dataGrid_PRODUCTO.DataSource = lista.ToList();
        }

        // Guarda todos los productos en el archivo (una línea por producto)
        private void GuardarEnArchivo()
        {
            Directory.CreateDirectory(CarpetaDatos); // crea la carpeta si no existe

            List<string> lineas = productos.Select(p => string.Join("|",
                Limpiar(p.Codigo),
                Limpiar(p.Nombre),
                p.Precio.ToString(CultureInfo.InvariantCulture),
                p.Cantidad.ToString(),
                Limpiar(p.Descripcion))).ToList();

            File.WriteAllLines(archivoProductos, lineas, Encoding.UTF8);
        }

        // Lee el archivo y llena la lista al abrir el formulario
        private void CargarDesdeArchivo()
        {
            productos.Clear();

            try
            {
                if (!File.Exists(archivoProductos)) return;

                foreach (string linea in File.ReadAllLines(archivoProductos, Encoding.UTF8))
                {
                    string[] partes = linea.Split('|');
                    if (partes.Length < 5) continue;

                    if (!decimal.TryParse(partes[2], NumberStyles.Number,
                            CultureInfo.InvariantCulture, out decimal precio)) continue;
                    if (!int.TryParse(partes[3], out int cantidad)) continue;

                    productos.Add(new Producto
                    {
                        Codigo = partes[0],
                        Nombre = partes[1],
                        Precio = precio,
                        Cantidad = cantidad,
                        Descripcion = partes[4]
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo leer el archivo de productos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evita que un "|" o un salto de línea rompa el formato del archivo
        private string Limpiar(string texto)
        {
            return (texto ?? "").Replace("|", " ").Replace("\r", " ").Replace("\n", " ");
        }

        private void BTN_BACK_product_Click(object sender, EventArgs e)
        {
            FormMenuprincipal FormMenu = new FormMenuprincipal();
            this.Hide();
            FormMenu.Show();
        }
    }

    // La clase Producto va DESPUÉS del formulario para que el diseñador no se dañe
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}