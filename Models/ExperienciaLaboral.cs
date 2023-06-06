using System.Collections.Generic;
namespace MiProyectoWeb

// Añadir getter para lista LugaresTrabajados

{
    public class ExperienciaLaboral
    {
        private List<ExperienciaLaboral>  LugaresTrabajados = new List<ExperienciaLaboral>();

        public ExperienciaLaboral(List<ExperienciaLaboral> LugaresTrabajados)
        {
        this.LugaresTrabajados=LugaresTrabajados;
        }

        public void AddLugaresTrabajados(ExperienciaLaboral lugarTrabajado)
        {
            LugaresTrabajados.Add(lugarTrabajado);
        }
        
        
        public void RemoveLugaresTrabajados(ExperienciaLaboral lugarTrabajado)
        {
            LugaresTrabajados.Remove(lugarTrabajado);
        }


    }


}
    
