
namespace ControleConstraste.Classes
{
    public  class Paciente
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }

        public Paciente(string nome, string codigo, DateTime data, string tipo)
        {
            Nome = nome;
            Codigo = codigo;
            Data = data;
            Tipo = tipo;
        }
    }
}
