using System.Text;

namespace Centralita
{

    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen){
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion { get => duracion; }
        public string NroDestino { get => nroDestino; }
        public string NroOrigen { get => nroOrigen;}

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"llamada.duracion={duracion}-llamada.nun_origen={nroOrigen}-llamada.duracion={duracion}");      
            return sb.ToString();
        }
        //TODO complete
        public static int OrdernarPorDuracion(Llamada llm1, Llamada llm2){
            return (int)(llm1.duracion - llm2.duracion);
        }
       
    }
}