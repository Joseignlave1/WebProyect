using System.Collections.Generic;
namespace MiProyectoWeb
// Implementar métodos para añadir una habilidad a las listas(habilidades actuales, habilidades futuras), y quitarlas
{
    public class Habilidad
    {
        private List<Habilidad> HabilidadesActuales = new List<Habilidad>();
        private List<Habilidad> HabilidadesFuturas = new List<Habilidad>();
    

    
        public Habilidad(List<Habilidad> HabilidadesActuales, List<Habilidad> HabilidadesFuturas)
        {
            this.HabilidadesActuales=HabilidadesActuales;
            this.HabilidadesFuturas= HabilidadesFuturas;

        }

    
        public List<Habilidad> GetHabilidadesActuales()
        {
            return HabilidadesActuales;
        }

        public List<Habilidad> GetHabilidadesFuturas()
        {
            return HabilidadesFuturas;
        }
    }
}