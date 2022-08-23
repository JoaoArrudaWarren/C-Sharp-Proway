using System;

namespace Console._99_Exercicios
{
    internal class _000Cadastro
    {
        //Sistema de cadastro de pessoas
        //sistema deve exibir mensagem de boas vinda
        //solicitar nome, sobrenome e idade
        //ao fim, mostrar o nome completo e a idade, junto com uma msg de despedida

       public void Cadastro()
        {
          System.Console.WriteLine("Boas vindas, meu rei");
            System.Console.WriteLine("Digite seu nome:");
          string nome = System.Console.ReadLine();
            System.Console.WriteLine("Digite seu sobrenome:");
            string sobrenome = System.Console.ReadLine();
            System.Console.WriteLine("Digite sua idade:");
            byte idade = System.Console.ReadLine();

            System.Console.WriteLine("Olá, " + nome + " " + sobrenome + ", de " + idade + " anos");
        }
    }
}
