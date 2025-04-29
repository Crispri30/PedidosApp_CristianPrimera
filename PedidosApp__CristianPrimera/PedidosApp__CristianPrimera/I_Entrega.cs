using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp__CristianPrimera
{
    public class I_Entrega
    {
       public interface IMetodoEntrega
        {
            double CalcularCosto(int km);
            string TipoEntrega();
        }
    }
}
