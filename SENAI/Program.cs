using System;
namespace D1
{
    class Program
    {   
        static void Main(string[] args)
        {   string nome,endereco,rg,cpf,cnpj,ie;

            Console.WriteLine("Inserir nome:");
            nome     = Console.ReadLine();
            Console.WriteLine("Inserir endereço:");
            endereco = Console.ReadLine();
            string tipo;
            do{
                Console.WriteLine("Pessoa Física (f) | Pessoa Júridica (j)");
                tipo = Console.ReadLine();
                if(tipo == "f" || tipo == "F" || tipo == "J" ||tipo == "j")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERRO! Por favor, isnira uma opção válida.");
                }

            }while(true);
            if(tipo == "f" || tipo == "F")
            {
                Console.WriteLine("Inserir CPF:");
                cpf = Console.ReadLine();

                Console.WriteLine("Inserir RG");
                rg = Console.ReadLine();
                Pessoa_Fisica PF = new Pessoa_Fisica(nome,endereco,cpf,rg);
                PF.Mensagem_Pf();
            }
            else if (tipo == "j" || tipo == "J")
            {
                Console.WriteLine("Insirir CNPJ:");
                cnpj = Console.ReadLine();
                Console.WriteLine("Insira o IE:");
                ie = Console.ReadLine();
                Pessoa_Juridica PJ = new Pessoa_Juridica(nome,endereco,cnpj,ie);
                Console.WriteLine("Valor a pagar:");
                float valor = float.Parse(Console.ReadLine());
                PJ.Pagar_imposto(valor);
                PJ.Mensagem_Pj();
            }
        }

    }
}