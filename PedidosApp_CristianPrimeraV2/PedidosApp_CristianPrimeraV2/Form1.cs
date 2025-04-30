namespace PedidosApp_CristianPrimeraV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbProducto.Items.AddRange(new string[] {
                "accesorio",
                "tecnología",
                "componente"
            });
            cmbProducto.SelectedIndex = 0;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
                string cliente = txtCliente.Text;
                string producto = cmbProducto.SelectedItem.ToString();
                bool urgente = chkUrgente.Checked;
                double peso = Convert.ToDouble(nudPeso.Value);
                int distancia = Convert.ToInt32(nudDistancia.Value);
                Pedido pedido = new Pedido(cliente, producto, urgente, peso, distancia);
                RegistroPedidos.Instancia.AgregarPedido(pedido);
                lblResultado2.Text =($"Entrega: {pedido.MetodoEntrega.TipoEntrega()}" +
                 $" Costo: ${pedido.ObtenerCosto():0.00}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bttHistorial_Click(object sender, EventArgs e)
        {
            HistorialPedido historialForm = new HistorialPedido();
            historialForm.ShowDialog();
        }
    }
}
