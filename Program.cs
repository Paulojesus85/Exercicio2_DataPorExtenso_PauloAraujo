using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_DataPorExtenso_PauloAraujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerocidade, sair, dia, mes, ano;
            string cidade = null;
            string mesextesno = null;
            DateTime dataEscolhida;

            do
            {
                Console.WriteLine("Escolha uma das cidades abaixo a partir do código apresentado");
                Console.Write("1 – Atibaia; \n" +
                    "2 – Bragança Paulista; \n" +
                    "3 – Mairiporã; \n" +
                    "4 – Nazaré; \n" +
                    "5 – Terra Preta; \n" +
                    "6 – Extrema; \n" +
                    "7 – Vargem.\n" +
                    "Digite a sua opção: ");
                numerocidade = Convert.ToInt32(Console.ReadLine());

                switch (numerocidade)
                {
                    case 1: cidade = "Atibaia"; 
                        break;
                    case 2: cidade = "Bragança Paulista";
                        break;
                    case 3: cidade = "Mairiporã";
                        break;
                    case 4: cidade = "Nazaré";
                        break;
                    case 5: cidade = "Terra Preta";
                        break;
                    case 6: cidade = "Extrema";
                        break;
                    case 7: cidade = "Vargem";
                        break;
                }


                Console.Write("Digite uma data (no formato dd/mm/aaaa): ");
                dataEscolhida = Convert.ToDateTime(Console.ReadLine());

                dia = dataEscolhida.Day;
                mes = dataEscolhida.Month;
                ano = dataEscolhida.Year;
                
                switch (mes)
                {
                    case 1: mesextesno = "Janeiro";
                        break;
                    case 2: mesextesno = "Fevereiro";
                       break;
                    case 3: mesextesno = "Março";
                        break;
                    case 4: mesextesno = "Abril";
                        break;
                    case 5: mesextesno = "Maio";
                        break;
                    case 6: mesextesno = "Junho";
                        break;
                    case 7: mesextesno = "Julho";
                        break;
                    case 8: mesextesno = "Agosto";
                        break;
                    case 9: mesextesno = "Setembro";
                        break;
                    case 10: mesextesno = "Outubro";
                        break;
                    case 11: mesextesno = "Novembro";
                        break;
                    case 12: mesextesno = "Dezembro";
                        break;
                }
                Console.WriteLine();
                Console.WriteLine($"{cidade}, {dia} de {mesextesno} de {ano}\n");
                Console.WriteLine("Digite 1 para CONTINUAR e 2 para SAIR");
                sair = Convert.ToInt32(Console.ReadLine());
            } while (sair != 2);

        }
    }
}
