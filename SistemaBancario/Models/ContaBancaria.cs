namespace SistemaBancario.Models
{
    //Pilar: Abstração Classe abstrata
    public abstract class ContaBancaria
    {

        //pilar: Encapsulamento: Compos privados protegodos por propriedades publicas
        private string _numeroConta;
        private decimal _saldo;

        //extems 3 tipos de modificadores
        //public - todos acessam
        //private - somente classse acessa
        //private - somente classse filho
        //propriedades
        public string NumeroConta
        {
            get => _numeroConta;
            protected set => _numeroConta = value;
        }

        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        }

        public string NomeTitular { get; set; }
        public List <string>ExtratoTrasancoes { get; set; } = new List<string>();

        //construtor da classe base
        protected ContaBancaria(string numeroConta,string nomeTitular,decimal saldorInicial)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldorInicial;
            ExtratoTrasancoes.Add($"Conta Criada com saldo inicial de : R$ {saldorInicial}");
        }


    }

}
