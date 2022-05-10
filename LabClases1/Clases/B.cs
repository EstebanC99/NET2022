namespace Clases
{
    public class B : A
    {
        private const string NombreInstancia = "Instancia de B";

        public B() : base(NombreInstancia)
        {

        }

        public string M4()
        {
            return "Metodo del hijo invocado";
        }
    }
}
