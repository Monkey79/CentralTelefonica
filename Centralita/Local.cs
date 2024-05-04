using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        private float costo;

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo) { 

        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen){
            this.costo = costo;
        }

        public float CostoLlamada { get  { 
                return CalcularCosto();
            } 
        }

        //TODO complete
        private float CalcularCosto() {
            return (float)(base.Duracion * this.costo);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"llamada-local.costo = {costo}");
            return sb.ToString();
        }
    }
}
