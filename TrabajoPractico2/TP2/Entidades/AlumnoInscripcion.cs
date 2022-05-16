namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private string _Condicion;
        public string Condicion
        {
            get { return this._Condicion; }
            set { this._Condicion = value; }
        }

        private int _IdAlumno;
        public int IdAlumno
        {
            get { return this._IdAlumno; }
            set { this._IdAlumno = value; }
        }

        private int _IdCurso;
        public int IdCurso
        {
            get { return this._IdCurso; }
            set { this._IdCurso = value; }
        }

        private int _Nota;
        public int Nota
        {
            get { return this._Nota; }
            set { this._Nota = value; }
        }

    }
}
