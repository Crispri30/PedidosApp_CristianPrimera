using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PedidosApp__CristianPrimera.EstrategiasEntrega;
using static PedidosApp__CristianPrimera.I_Entrega;

namespace PedidosApp__CristianPrimera
{
    public class FactoryMethod
    {
            public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double
            peso)
            {
                if (tipoProducto == "tecnología" && urgente)
                    return new EntregaDron();
                else if (tipoProducto == "accesorio")
                    return new EntregaMoto();
                else if (tipoProducto == "componente" || peso > 10)
                    return new EntregaCamion();
                else
                    return new EntregaMoto(); // valor por defecto
            }
    }
}
