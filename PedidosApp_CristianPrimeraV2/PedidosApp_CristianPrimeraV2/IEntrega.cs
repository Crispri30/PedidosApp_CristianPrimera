using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp_CristianPrimeraV2
{
    public class IEntrega
    {
        public interface IMetodoEntrega
        {
            double CalcularCosto(int km);
            string TipoEntrega();
        }
    }
}
