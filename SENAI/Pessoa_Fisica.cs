namespace D1
{
    class Pessoa_Fisica : Clientes
    {
        public string cpf;
        public string rg;
        public Pessoa_Fisica(string nome, string endereco,string cpf, string rg)
        {
            this.cpf = cpf;
            this.rg = rg;
            this.nome = nome;
            this.endereco = endereco;
            this.valor = valor;
            this.valor_imposto =  valor_imposto;
            this.total = total;

        }
        public void Mensagem_Pf()
        {
            Console.WriteLine("_______ PESSOA FÍSICA _______"          +
                              "\nNome         : " + this.nome          +
                              "\nEndereço     : " + this.endereco      +
                              "\nCPF          : " + this.cpf           +
                              "\nRG           : " + this.rg            +
                              "\nValor a pagar: " + this.valor         +
                              "\nImpostos     : " + this.valor_imposto +
                              "\nValor a pagar: " + this.total);
        }
    }


}