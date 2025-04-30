using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PedidosApp_CristianPrimeraV2.IEntrega;

namespace PedidosApp_CristianPrimeraV2
{
    public class EstrategiasEntrega
    {
        public class EntregaDron : IMetodoEntrega
        {
            public double CalcularCosto(int km) => 20 * km;
            public string TipoEntrega() => "Dron";
        }
        public class EntregaMoto : IMetodoEntrega
        {
            public double CalcularCosto(int km) => 10 * km;
            public string TipoEntrega() => "Motocicleta";
        }
        public class EntregaCamion : IMetodoEntrega
        {
            public double CalcularCosto(int km) => 5 * km;
            public string TipoEntrega() => "Camión";
        }

        public class EntregaBicicleta : IMetodoEntrega
        {
            public double CalcularCosto(int km) => 3 * km;
            public string TipoEntrega() => "Bicicleta";
        }
    }
}
