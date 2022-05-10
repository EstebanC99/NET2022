namespace Clases
{
    public class A
    {
        protected string NombreInstancia { get; set; }

        public A()
        {
            this.NombreInstancia = "Instancia sin nombre";
        }

        public A(string nombreInstancia)
        {
            this.NombreInstancia = nombreInstancia;
        }

        public string MostrarNombre()
        {
            return this.NombreInstancia;
        }

        private string M(string m)
        {
            return "El metodo " + m + " fue invocado";
        }

        public string M1()
        {
            return this.M(nameof(this.M1));
        }

        public string M2()
        {
            return this.M(nameof(this.M2));
        }

        public string M3()
        {
            return this.M(nameof(this.M3));
        }
    }
}
