using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        private const float FRJ_1_COSTO = 0.99f;
        private const float FRJ_2_COSTO = 1.25f;
        private const float FRJ_3_COSTO = 0.66f;

        private Franja franjaHoraria;

        public Provincial(Franja franja, Llamada llamada) :this(llamada.NroOrigen, franja, llamada.Duracion, llamada.NroDestino) {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion, destino, origen) { 
            franjaHoraria = miFranja;
        }

        public float CostoLlamada{
            get {
                return CalcularCosto();
            }
        }

        //TODO complete
        private float CalcularCosto() {
            float resultado=0f;
            switch (franjaHoraria) {
                case Franja.Franja_1:
                    resultado = FRJ_1_COSTO * duracion;
                    break;
                case Franja.Franja_2:
                    resultado = FRJ_2_COSTO * duracion;
                    break;
                case Franja.Franja_3:
                    resultado = FRJ_3_COSTO * duracion;
                    break;
            }
            return resultado;
        }
        public override string ToString(){
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"llamada-provincial.franja-horaria={franjaHoraria}");
            return sb.ToString();
        }
    }
}
