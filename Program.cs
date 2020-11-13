using System;

namespace Calculadora_Idade
{
    class Program
    {
        static void Main(string[] args)
        {

            //variáveis
            float idade, idadeMeses, idadeDias, idadeHoras, idadeMinutos;

            Console.Write("Digite a idade: ");
            idade = float.Parse(Console.ReadLine());

            //processamento
            idadeMeses = (idade*12);
            Console.WriteLine("A idade em meses é de: "+idadeMeses+ " meses ");

            idadeDias = (idade*365);
            Console.WriteLine("A idade em dias é de: "+idadeDias+ " dias ");

            idadeHoras = (idadeDias*24);
            Console.WriteLine("A idade em horas é de: "+idadeHoras+ " horas ");

            idadeMinutos = (idadeHoras*60);
            Console.WriteLine("A idade em minutos é de: "+idadeMinutos+ " minutos ");

        }
    }
}
