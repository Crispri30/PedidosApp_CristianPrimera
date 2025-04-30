using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PedidosApp_CristianPrimeraV2.EstrategiasEntrega;
using static PedidosApp_CristianPrimeraV2.IEntrega;

namespace PedidosApp_CristianPrimeraV2
{
    public class FactoryMethod
    {
        public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double
        peso)
        {
            if (tipoProducto == "tecnología" && urgente)
                return new EntregaDron();
            else if (tipoProducto == "accesorio" && peso < 2 && !urgente)
                
                return new EntregaMoto();
            else if (tipoProducto == "componente" || peso > 10)
                return new EntregaCamion();
            else
                return new EntregaMoto(); // valor por defecto
        }
    }
}
