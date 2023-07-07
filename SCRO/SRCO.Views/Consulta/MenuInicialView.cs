using SCRO.Views.Consulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.SRCO.Views.Consulta
{
    public static class MenuInicialView
    {

        public static void Cabecalho()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("************** SCRO - Sistema de classificação de risco de gestantes e puérperas *************");
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("**********************************************************************************************");
        }

        public static void Opcoes()
        {
            

        }
        public static void MenuInicial()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine("Selecione uma das opções a seguir ");
            Console.WriteLine("[1] - Cadastrar paciente ");
            Console.WriteLine("[2] - Consultar paciente ");
            Console.WriteLine("[3] - Atualizar paciente ");
            Console.WriteLine("[4] - Excluir paciente ");
            Console.WriteLine("[5] - Sair do sistema");


            string opcaoSelecionada = Console.ReadLine();

            if(string.IsNullOrEmpty(opcaoSelecionada))
            {
                Console.WriteLine("Opção incorreta, tente novamente");
                Console.ReadLine();
                MenuInicial();
            }
                switch (opcaoSelecionada)
                {
                    case "1":
                    PacienteView.CadastrarPaciente();
                        break;

                    case "2":
                    PacienteView.ConsultarPaciente();
                        break;
                    
                    case "3":
                    PacienteView.AtualizarPaciente();
                        break;
                     
                    case "4":
                    PacienteView.ExcluirPaciente();
                        break;

                    case "5":
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção incorreta, tente novamente");
                        Console.ReadLine();
                        MenuInicial();
                        break;
                }


            

        }
    }
}
