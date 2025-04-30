using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp__CristianPrimera
{
    public partial class HistorialPedidos : Form
    {
        public HistorialPedidos()
        {
            InitializeComponent();
            cmbFiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;

        }
        private void HistorialPedidos_Load(object sender, EventArgs e)
        {
            // Cargar tipos únicos de entrega + opción "Todos"
            var tiposEntrega = RegistroPedidos.Instancia.Pedidos
                .Select(p => p.MetodoEntrega.TipoEntrega())
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            tiposEntrega.Insert(0, "Todos");
            cmbFiltro.DataSource = tiposEntrega;

            // Cargar todos los pedidos por defecto
            CargarPedidos("Todos");
        }

        private void CargarPedidos(string tipoEntrega)
        {
            var pedidos = RegistroPedidos.Instancia.Pedidos
                .Where(p => tipoEntrega == "Todos" || p.MetodoEntrega.TipoEntrega() == tipoEntrega)
                .Select(p => new
                {
                    Cliente = p.Cliente,
                    Producto = p.Producto,
                    Urgente = p.Urgente ? "Sí" : "No",
                    PesoKg = p.Peso,
                    DistanciaKm = p.Distancia,
                    TipoEntrega = p.MetodoEntrega.TipoEntrega(),
                    Costo = p.ObtenerCosto().ToString("0.00")
                })
                .ToList();

            dgvHistorial.DataSource = pedidos;
        }
        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSeleccionado = cmbFiltro.SelectedItem.ToString();
            CargarPedidos(tipoSeleccionado);
        }

    }
}
