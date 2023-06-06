namespace MiProyectoWeb
{
    public class Contacto
    {
        private string Nombre;
        private string Email;
        private int Telefono;
        private string Dirección;
        public Contacto(string Nombre, string Email, int Telefono, string Dirección)
        {
            this.Nombre=Nombre;
            this.Email=Email;
            this.Telefono=Telefono;
            this.Dirección=Dirección;
        }


        public string GetEmail()
        {
            return this.Email;
        }


        public int GetTelefono()
        {
            return this.Telefono;
        }

        public string GetDirección()
        {
            return this.Dirección;
        }
        




    }


}