namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        private int _IdCurso;
        public int IdCurso
        {
            get { return this._IdCurso; }
            set { this._IdCurso = value; }
        }

        private int _IdDocente;
        public int IdDocente
        {
            get { return this._IdDocente; }
            set { this._IdDocente = value; }
        }

        private TiposCargo _TipoCargo;

        public TiposCargo TipoCargo
        {
            get { return this._TipoCargo; }
            set { this._TipoCargo = value; }
        }

        public enum TiposCargo
        {

        }

    }
}
