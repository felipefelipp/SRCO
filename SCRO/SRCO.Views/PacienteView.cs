using Microsoft.IdentityModel.Tokens;
using Models.SCRO.Models.Paciente;
using SCRO.Controllers;
using SCRO.Models.Classificacao;
using SCRO.Models.Paciente;
using SCRO.Views;
using System;

namespace SCRO.Views
{
    public static class PacienteView
    {
        //Ideia inicial, criar um obj de paciente quando chamar a view e na view retornar o obj paciente
        //para ser cadastrado pelo controller
        //PacienteController pacienteController = new PacienteController();
        static PacienteController paciente; 
        static PacienteView()
        {
            paciente = new PacienteController();
        }
        public static void Cadastrar()
        {
            

        }

        public static void Cabecalho()
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("************** SCRO - Sistema de classificação de risco de gestantes e puérperas *************");
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("**********************************************************************************************");
        }



        public static Paciente CadastrarPaciente()
        {
            Console.Clear();
            Cabecalho();

            Console.WriteLine("Informe o nome do paciente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a idade do paciente: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o CPF do paciente: ");
            long cpf = long.Parse(Console.ReadLine());

            Console.WriteLine("Informe o RG do paciente: ");
            int rg = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o celular do paciente: ");
            long celular = long.Parse(Console.ReadLine());

            Console.WriteLine("Informe o telefone do paciente: ");
            long? telefone = long.TryParse(Console.ReadLine(), out long parsedTelefone) ? parsedTelefone : (long?)null;

            Console.WriteLine("Informe a rua do paciente: ");
            string rua = Console.ReadLine();

            Console.WriteLine("Informe o número do paciente: ");
            int numero = Console.Read();

            Console.WriteLine("Informe o bairro do paciente: ");
            string bairro = Console.ReadLine();

            Console.WriteLine("Informe o município do paciente: ");
            string municipio = Console.ReadLine();

            Console.WriteLine("Informe a UF do paciente: ");
            string uf = Console.ReadLine();
            
            Console.WriteLine("Informe o CEP do paciente: ");
            int cep = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o sexo do paciente: ");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe a profissão do paciente: ");
            string profissao = Console.ReadLine();

            Console.WriteLine("Informe o email do paciente: ");
            string email = Console.ReadLine();

            Console.WriteLine("Paciente possui responsável? [1] - Sim [2] - Não");
            char possuiResponsavel = Console.ReadLine()[0];

            int responsavelId = 0;
            if (possuiResponsavel == '1')
            {
                Responsavel responsavel = new Responsavel();
                ResponsavelView cadastroResponsavel = new ResponsavelView();
                cadastroResponsavel.menuCadastrarResponsavel(responsavel);
                responsavelId = responsavel.IdResponsavel;
            }

            Paciente paciente = new Paciente(responsavelId, nome, idade, cpf, rg, celular, telefone, rua, numero,  bairro, municipio, uf, cep, sexo, profissao, email);
            return paciente; // tirar o retorno e chamar o metodo de cadastrar paciente do controler
        }


        public static void ExibirPaciente(IList<Paciente> paciente)
        {
            Console.Clear();
            Cabecalho();
            if ( paciente != null ) 
            {
                for (int i = 0; i < paciente.Count; i++)//var p in paciente)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine($"Pagina: {i + 1} de {paciente.Count}");
                    Console.WriteLine("********************************");

                    Console.WriteLine($"Nome: {paciente[i].Nome}");
                    Console.WriteLine($"Idade: {paciente[i].Idade}");
                    Console.WriteLine($"ResponsavelId: {paciente[i].ResponsavelId}");
                    Console.WriteLine($"CPF: {paciente[i].CPF}");
                    Console.WriteLine($"RG: {paciente[i].RG}");
                    Console.WriteLine($"Celular: {paciente[i].Celular}");
                    Console.WriteLine($"Telefone: {paciente[i].Telefone}");
                    Console.WriteLine($"Bairro: {paciente[i].Bairro}");
                    Console.WriteLine($"Municipio: {paciente[i].Municipio}");
                    Console.WriteLine($"UF: {paciente[i].UF}");
                    Console.WriteLine($"CEP: {paciente[i].CEP}");
                    Console.WriteLine($"Sexo: {paciente[i].Sexo}");
                    Console.WriteLine($"Profissao: {paciente[i].Profissao}");
                    Console.WriteLine($"Email: {paciente[i].Email}");
                    Console.WriteLine("\n\n");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }



        public static void ConsultarPaciente()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine("Você deseja realizar a busca por:");
            Console.WriteLine("[1] - Nome");
            Console.WriteLine("[2] - Idade");
            Console.WriteLine("[3] - CPF");
            Console.WriteLine("[4] - Celular");
            Console.WriteLine("[5] - Email");
            Console.WriteLine("[6] - Retornar à opção anterior");

            string opcaoSelecionada = Console.ReadLine();

            if (string.IsNullOrEmpty(opcaoSelecionada))
            {
                Console.WriteLine("Opção incorreta, tente novamente");
                Console.ReadLine(); 
                ConsultarPaciente();
            }

            switch (opcaoSelecionada[0])
            {
                case '1':
                    ConsultaPacienteNome();
                    break;

                case '2':
                    ConsultaPacienteIdade();
                    break;

                case '3':
                    ConsultaPacienteCpf();
                    break;

                case '4':
                    ConsultaPacienteCelular();
                    break;

                case '5':
                    ConsultaPacienteEmail();
                    break;

                case '6':
                    MenuInicialView.MenuInicial();
                    break;

                default:
                    Console.WriteLine("Opção incorreta, tente novamente");
                    Console.ReadLine(); 
                    ConsultarPaciente();
                    break;
            }
        }


        private static void ConsultaPacienteEmail()
        {
            Console.WriteLine("Informe o e-mail do paciente: ");
            var email = Console.ReadLine();
            var pacienteEncontrado = paciente.BuscarPaciente(email: email);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
            }
            ConsultarPaciente();
        }

        private static void ConsultaPacienteCelular()
        {
            Console.WriteLine("Informe o celular do paciente: ");
            var celular = long.Parse(Console.ReadLine());
            var pacienteEncontrado = paciente.BuscarPaciente(celular: celular);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
            }
            ConsultarPaciente();
        }

        public static void ConsultaPacienteNome()
        {

            Console.WriteLine("Informe o nome do paciente: ");
            var nome = Console.ReadLine();
            var pacienteEncontrado = paciente.BuscarPaciente(nome: nome);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
            }
            ConsultarPaciente();
        }

        public static void ConsultaPacienteIdade()
        {

            Console.WriteLine("Informe a idade do paciente: ");
            var idade = int.Parse(Console.ReadLine());
            var pacienteEncontrado = paciente.BuscarPaciente(idade: idade);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
            }
            ConsultarPaciente();
        }

        private static void ConsultaPacienteCpf()
        {
            Console.WriteLine("Informe o CPF do paciente: ");
            var cpf = int.Parse(Console.ReadLine());
            var pacienteEncontrado = paciente.BuscarPaciente(cpf: cpf);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
            }
            ConsultarPaciente();
        }

        public static void AtualizarPaciente()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine("Informe o CPF do paciente: ");
            var cpf = int.Parse(Console.ReadLine());
            var pacienteEncontrado = paciente.BuscarPaciente(cpf: cpf);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);

                bool selecionarCampos = true;

                while (selecionarCampos)
                {
                    Console.WriteLine("\nSelecione os campos a seguir para atualizar:");
                    Console.WriteLine("[1] - Nome");
                    Console.WriteLine("[2] - Idade");
                    Console.WriteLine("[3] - CPF");
                    Console.WriteLine("[4] - RG");
                    Console.WriteLine("[5] - Celular");
                    Console.WriteLine("[6] - Telefone");
                    Console.WriteLine("[7] - Rua");
                    Console.WriteLine("[8] - Numero");
                    Console.WriteLine("[9] - Bairro");
                    Console.WriteLine("[10] - Municipio");
                    Console.WriteLine("[11] - UF");
                    Console.WriteLine("[12] - CEP");
                    Console.WriteLine("[13] - Sexo");
                    Console.WriteLine("[14] - Profissão");
                    Console.WriteLine("[15] - E-mail");
                    Console.WriteLine("[0] - Finalizar e salvar alterações");

                    string opcaoSelecionada = Console.ReadLine();

                    switch (opcaoSelecionada)
                    {
                        case "1":
                            Console.WriteLine("Informe o novo nome: ");
                            pacienteEncontrado[0].Nome = Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Informe a nova idade: ");
                            pacienteEncontrado[0].Idade = int.Parse(Console.ReadLine());
                            break;
                        case "3":
                            Console.WriteLine("Informe o novo CPF: ");
                            pacienteEncontrado[0].CPF = long.Parse(Console.ReadLine());
                            break;
                        case "4":
                            Console.WriteLine("Informe o novo RG: ");
                            pacienteEncontrado[0].RG = int.Parse(Console.ReadLine());
                            break;
                        case "5":
                            Console.WriteLine("Informe o novo celular: ");
                            pacienteEncontrado[0].Celular = long.Parse(Console.ReadLine());
                            break;
                        case "6":
                            Console.WriteLine("Informe o novo telefone: ");
                            pacienteEncontrado[0].Telefone = long.Parse(Console.ReadLine());
                            break;
                        case "7":
                            Console.WriteLine("Informe a nova rua: ");
                            pacienteEncontrado[0].Rua = Console.ReadLine();
                            break;
                        case "8":
                            Console.WriteLine("Informe o novo número: ");
                            pacienteEncontrado[0].Numero = int.Parse(Console.ReadLine());
                            break;
                        case "9":
                            Console.WriteLine("Informe o novo bairro: ");
                            pacienteEncontrado[0].Bairro = Console.ReadLine();
                            break;
                        case "10":
                            Console.WriteLine("Informe o novo município: ");
                            pacienteEncontrado[0].Municipio = Console.ReadLine();
                            break;
                        case "11":
                            Console.WriteLine("Informe a nova UF: ");
                            pacienteEncontrado[0].UF = Console.ReadLine();
                            break;
                        case "12":
                            Console.WriteLine("Informe o novo CEP: ");
                            pacienteEncontrado[0].CEP = int.Parse(Console.ReadLine());
                            break;
                        case "13":
                            Console.WriteLine("Informe o novo sexo: ");
                            pacienteEncontrado[0].Sexo = Console.ReadLine()[0];
                            break;
                        case "14":
                            Console.WriteLine("Informe a nova profissão: ");
                            pacienteEncontrado[0].Profissao = Console.ReadLine();
                            break;
                        case "15":
                            Console.WriteLine("Informe o novo e-mail: ");
                            pacienteEncontrado[0].Email = Console.ReadLine();
                            break;
                        case "0":
                            selecionarCampos = false; // Sai do loop
                            break;
                        default:
                            Console.WriteLine("Opção incorreta, tente novamente");
                            break;
                    }
                }

                paciente.AtualizarPaciente(pacienteEncontrado[0]);
                Console.WriteLine("Paciente atualizado com sucesso!");
                Console.ReadKey();
                MenuInicialView.MenuInicial();
            }
            else
            {
                Console.Clear();
                Cabecalho();
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
                MenuInicialView.MenuInicial();
            }
        }

        public static void ExcluirPaciente()
        {
            Console.WriteLine("Informe o CPF do paciente: ");
            var cpf = long.Parse(Console.ReadLine());
            var pacienteEncontrado = paciente.BuscarPaciente(cpf: cpf);
            bool selecionarCampos = true;

            while (selecionarCampos)
            {
                if (pacienteEncontrado.Count > 0)
                {
                    ExibirPaciente(pacienteEncontrado);

                    Console.WriteLine("Você deseja excluir este paciente? Digite [1] para confirmar ou [2] para retornar ao menu inicial");
                    var opcao = Console.ReadLine();
                    if (!string.IsNullOrEmpty(opcao))
                    {
                        switch (opcao)
                        {
                            case "1":
                                paciente.ExcluirPaciente(pacienteEncontrado[0]);
                                Console.WriteLine("Paciente excluído com sucesso");
                                Console.WriteLine("Retornando ao menu inicial");
                                Console.WriteLine("Pressione enter para continuar...");
                                Console.ReadKey();
                                MenuInicialView.MenuInicial();
                                break;
                            case "2":
                                selecionarCampos = false; 
                                Console.WriteLine("Retornando ao menu inicial");
                                Console.WriteLine("Pressione enter para continuar...");
                                Console.ReadKey();
                                MenuInicialView.MenuInicial();
                                break;
                            default:
                                Console.WriteLine("Opção incorreta, tente novamente");
                                break;

                        }
                    }


                }
                else
                {
                    Console.WriteLine("Paciente não encontrado!");
                    Console.ReadKey();
                }
            }
        }
    }
}
﻿