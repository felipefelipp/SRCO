using SCRO.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Views
{
    public static class MenuInicialView
    {

        public static void Cabecalho()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                  ║");
            Console.WriteLine("║          SCRO - Sistema de Classificação de Risco de Gestantes e Puérperas       ║");
            Console.WriteLine("║                                                                                  ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
        }

        public static void Opcoes()
        {


        }

        public static void MenuInicial()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine("Seja bem-vindo!");
            Console.WriteLine("Selecione uma das opções a seguir:");
            Console.WriteLine("[1] - Cadastrar paciente");
            Console.WriteLine("[2] - Consultar paciente");
            Console.WriteLine("[3] - Atualizar paciente");
            Console.WriteLine("[4] - Excluir paciente");
            Console.WriteLine("[5] - Cadastrar responsável");
            Console.WriteLine("[6] - Consultar responsável");
            Console.WriteLine("[7] - Atualizar responsavel");
            Console.WriteLine("[8] - Excluir responsável");
            Console.WriteLine("[0] - Sair do sistema");

            string opcaoSelecionada = Console.ReadLine();

            if (string.IsNullOrEmpty(opcaoSelecionada))
            {
                Console.WriteLine("Opção incorreta, tente novamente");
                Console.ReadLine();
                MenuInicial();
                return;
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
                    ResponsavelView.CadastrarResponsavel();
                    break;
                case "6":
                    ResponsavelView.ConsultarResponsavel();
                    break;
                case "7":
                    ResponsavelView.AtualizarResponsavel();
                    break;
                case "8":
                    ResponsavelView.ExcluirResponsavel();
                    break;
                case "0":
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
