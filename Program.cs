using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CPF cpf = new CPF();
            cpf.nome = "Mateus";
            Console.WriteLine( cpf.Saudar() );

            cpf.cpf = "123.456.789.01";
            Console.WriteLine( cpf.ValidarCpf () );

            CNPJ cnpj = new CNPJ();
            cnpj.nome = "Gatti";
            Console.WriteLine( cnpj.Saudar() );

            cnpj.cnpj = "123.456.789.01";
            Console.WriteLine( cnpj.ValidarCNPJ() );

            
    
        }
    }
}
