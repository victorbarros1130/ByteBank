namespace CSharp_Parte4_Home
{
    public class Cliente
    {
        //Classe para guardar as informações pessoais do cliente.
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }

        public Cliente(string _nome)
        {
            Nome = _nome;
        }

    }
}
