namespace D1
{
    class Clientes
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        protected float valor { get; set; }
        protected float valor_imposto { get; set; }
        protected float total { get; set; }

        public virtual void Pagar_imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor_imposto + this.valor;
        }
    }
}