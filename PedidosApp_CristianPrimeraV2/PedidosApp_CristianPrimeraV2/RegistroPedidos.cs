using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp_CristianPrimeraV2
{
    public sealed class RegistroPedidos
    {
        private static RegistroPedidos _instancia;
        private static readonly object _lock = new object();
        public List<Pedido> Pedidos { get; private set; }
        private RegistroPedidos() => Pedidos = new List<Pedido>();
        public static RegistroPedidos Instancia
        {
            get
            {
                lock (_lock)
                {
                    return _instancia ??= new RegistroPedidos();
                }
            }
        }
        public void AgregarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }
    }
}
