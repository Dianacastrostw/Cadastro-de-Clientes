namespace D1
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj { get; set;}
        public string ie { get; set;}

        public override void Pagar_imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor_imposto + this.valor;
        }
        public Pessoa_Juridica(string nome, string endereco,string cnpj, string ie)
        {
            this.cnpj = cnpj;
            this.ie = ie;
            this.nome = nome;
            this.endereco = endereco;
            this.valor = valor;
            this.valor_imposto =  valor_imposto;
            this.total = total;

        }
        public void Mensagem_Pj()
        {
            Console.WriteLine("______ PESSOA jURÍDICA ______"          +
                              "\nNome         : " + this.nome          +
                              "\nEndereço     : " + this.endereco      +
                              "\nCNPJ         : " + this.cnpj          +
                              "\nIE           : " + this.ie            +
                              "\nValor a pagar: " + this.valor         +
                              "\nImpostos     : " + this.valor_imposto +
                              "\nValor a pagar: " + this.total);
        }
    }
}