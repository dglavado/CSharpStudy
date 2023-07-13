using System;

namespace ProjetosAulas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Primeiro programa!");

            // Variáveis
            int idade = 33;
            Console.WriteLine(idade);
            string nomePessoa = "Rafael Almeida";
            Console.WriteLine(nomePessoa);
            decimal valor = 200.99m; //m para converter de double (implícito) para Decimal
            double valorDouble = 200.99;
            float valorFloat = 200.99f; //f para converter de double (implícito) para Float
            var idadeNova = 34;
            Console.WriteLine(valor);
            Console.WriteLine(valorDouble);
            Console.WriteLine(valorFloat);
            Console.WriteLine(idadeNova);
            char flag = 'Y';
            Console.WriteLine(flag);
            bool ativo = true;
            Console.WriteLine(ativo);

            // Constantes
            const string descricao = "Curso CSharp";
            //descricao = "Curso";  // não é possível alterar valor de uma Constante

            Console.WriteLine(descricao);
            */

            /*
            int numero1 = 1;
            var numero2 = 2; // tipo de dados será int

            
            //Operadores Aritméticos
            int soma = numero1 + numero2;
            Console.WriteLine(soma);

            int subtracao = numero2 - numero1;
            Console.WriteLine(subtracao);

            int multiplicacao = (numero2 * numero1) * 10;
            Console.WriteLine(multiplicacao);

            int divisao = numero2 / numero1;
            Console.WriteLine(divisao);
            */

            /*
            //Operadores relacionais
            bool igual = numero1 == numero2;
            Console.WriteLine(igual);

            bool maior = numero2 > numero1;
            Console.WriteLine(maior);

            bool menor = numero2 < numero1;
            Console.WriteLine(maior);

            bool menorOuIgual = numero2 <= numero1;
            Console.WriteLine(menorOuIgual);

            bool maiorOuIgual = numero2 >= numero1;
            Console.WriteLine(maiorOuIgual);

            bool diferente = numero2 != numero1;
            Console.WriteLine(diferente);
            */


            //Operadores Lógicos
            //int numero1 = 1;
            //var numero2 = 2; // tipo de dados será int

            /*
            bool valido = numero2 > numero1 && 6 > 7; //&& and
            Console.WriteLine(valido);

            bool valido2 = numero2 > numero1 || 6 > 7; //|| Or
            Console.WriteLine(valido2);
            
            bool valido3 = !(numero2 > 1 );
            Console.WriteLine(valido3);
            */

            //Operador Ternário
            bool ativo = true;
            //string status = ativo == true ? "Cadastro Ativo" : "Cadastro Inativo";
            string status = !ativo ? "Cadastro Ativo" : "Cadastro Inativo";
            Console.WriteLine(status);

        }
    }
}
