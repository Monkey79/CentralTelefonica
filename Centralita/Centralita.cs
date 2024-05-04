using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> llamadas;
        private string razonSocial;

        public Centralita() {
            llamadas = new List<Llamada>();
        }
        public Centralita(string razonSocial) {
            this.razonSocial = razonSocial;
        }

        //TODO complete
        public float GananciaPorLocal {           
            get {
                float gananAcumLocal = 0.0f;
                foreach (var item in llamadas) {
                    if (item is Local)
                        gananAcumLocal += ((Local)item).CostoLlamada + CalcularGanancia(TipoLlamada.Local);
                }
                return gananAcumLocal;
            }
        }
        //TODO complete
        public float GananciaPorProvincia {
            get {
                float gananAcumPcia = 0.0f;
                foreach (var item in llamadas){
                    if (item is Provincial)
                        gananAcumPcia += ((Provincial)item).CostoLlamada + CalcularGanancia(TipoLlamada.Provincial);
                }
                return gananAcumPcia;
            }
        }
        //TODO complete
        public float GananciaPorTotal {
            get {
                float gananAcumTodas = 0.0f;
                foreach (var item in llamadas) {
                    if (item is Provincial)
                        gananAcumTodas += ((Provincial)item).CostoLlamada + CalcularGanancia(TipoLlamada.Todas);
                    else if (item is Local)
                        gananAcumTodas += ((Local)item).CostoLlamada + CalcularGanancia(TipoLlamada.Todas);
                }
                return gananAcumTodas;
            }
        }
        public List<Llamada> Llamadas {get=>llamadas;}

        //TODO complete
        private float CalcularGanancia(TipoLlamada tipoLlamada) {
            float ganancia = 0.0f;
            switch (tipoLlamada) {
                case TipoLlamada.Local:
                    ganancia = 50.50f;
                    break;
                case TipoLlamada.Provincial:
                    ganancia = 70.50f;
                    break;
                case TipoLlamada.Todas:
                    ganancia = 85.55f;
                    break;
            }
            return ganancia; 
        }

        //TODO complete
        public void OrdenarLlamada() {
            llamadas.Sort(Llamada.OrdernarPorDuracion);
        }
        public override string ToString(){
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Centraliza.empresa_nombre={razonSocial}");
            return stringBuilder.ToString();
        }
    }
}
