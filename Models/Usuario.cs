namespace MiProyectoWeb
{
    public class Usuario
    {
        private string NombreUsuario;
        private string EmailUsuario;
    
    public Usuario(string NombreUsuario, String EmailUsuario)
    {
        this.NombreUsuario= NombreUsuario;
        this.EmailUsuario=EmailUsuario;
    }

    public string GetNombreUsuario()
    {
        return this.NombreUsuario;

    }
    public string GetEmailUsuario()
    {
        return this.EmailUsuario;
    }


    }
}