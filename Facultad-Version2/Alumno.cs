namespace Facultad_Version2
{
    internal class Alumno : Persona
    {
        private int _codigo;

        public Alumno(string apellido, string nombre, int codigo) : base(apellido, nombre)
        {
            _codigo = codigo;
        }

        public int Codigo { get { return _codigo; } set { _codigo = value; } }
        public string Credencial { get; set; }

        public override string GetCredencial()
        {
            throw new System.NotImplementedException();
        }

        public override string GetNombreCompleto()
        {
            throw new System.NotImplementedException();
        }
    }
}