//using SCRO.Models.Paciente;
//using SCRO.Controllers;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SCRO.Views
//{
//    public static class ResponsavelView
//    {
//        private static readonly ResponsavelController Responsavel;
//        static ResponsavelView()
//        {
//            Responsavel = new ResponsavelController();
//        }
//        public static Responsavel CadastrarResponsavel()
//        {
//            Console.Clear();
//            Cabecalho();

//            Console.WriteLine("Informe o nome do responsável: ");
//            string nome = Console.ReadLine();

//            Console.WriteLine("Informe a idade do responsável: ");
//            int idade;
//            while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
//            {
//                Console.WriteLine("Idade inválida. Informe a idade do responsável: ");
//            }

//            Console.WriteLine("Informe o CPF do responsável: ");
//            long cpf;
//            while (!long.TryParse(Console.ReadLine(), out cpf) || cpf < 0)
//            {
//                Console.WriteLine("CPF já existe ou está inválido. Informe o CPF do responsável: ");
//            }

//            if (Responsavel.VerificaSeExisteCpf(cpf))
//            {
//                Console.WriteLine("Este responsável já existe, digite [1] para selecioná-lo ou [2] para atualizar o cadastro: ");

//                char atualizarResponsavel;
//                while (!char.TryParse(Console.ReadLine(), out atualizarResponsavel) ||
//                      (atualizarResponsavel != '1' &&
//                       atualizarResponsavel != '2' &&
//                       atualizarResponsavel != '3'))
//                {
//                    Console.WriteLine("Este responsável já existe, digite [1] para selecioná-lo " +
//                                                                         "[2] para atualizar o cadastro: " +
//                                                                         "[3] para informar outro CPF: ");
//                }

//                if (atualizarResponsavel == '1')
//                {
//                    var responsavelSelecionado = Responsavel.BuscarResponsavel(cpf: cpf);
//                    return responsavelSelecionado[0];
//                }
//                else if (atualizarResponsavel == '2')
//                {
//                    AtualizarResponsavel();
//                }
//                else
//                {
//                    while (!long.TryParse(Console.ReadLine(), out cpf) || cpf < 0)
//                    {
//                        Console.WriteLine("CPF já existe ou está inválido. Informe o CPF do responsavel: ");
//                    }
//                }

//            }

//            Console.WriteLine("Informe o RG do responsavel: ");
//            int rg;
//            while (!int.TryParse(Console.ReadLine(), out rg) || rg <= 0)
//            {
//                Console.WriteLine("RG inválido. Informe o RG do responsável: ");
//            }

//            Console.WriteLine("Informe o celular do responsável: ");
//            long celular;
//            while (!long.TryParse(Console.ReadLine(), out celular) || celular <= 0)
//            {
//                Console.WriteLine("Celular inválido. Informe o celular do responsável: ");
//            }

//            Console.WriteLine("Informe o email do responsável: ");
//            string email = Console.ReadLine();

//            var responsavelCadastro = new Responsavel(nome, idade, cpf, rg, celular, email);
//            Responsavel.CadastrarResponsavel(responsavelCadastro);
//            Console.WriteLine("Responsavel cadastrado com sucesso, pressione qualquer tecla para continuar...");
//            Console.ReadLine();
//            return responsavelCadastro;
//        }
//        public static void AtualizarResponsavel()
//        {
//            Console.Clear();
//            Cabecalho();
//            Console.WriteLine("Informe o CPF do responsavel: ");
//            var cpf = long.Parse(Console.ReadLine());
//            var responsavelEncontrado = Responsavel.BuscarResponsavel(cpf: cpf);

//            if (responsavelEncontrado.Count > 0)
//            {
//                ExibirInformacoesResponsavel(responsavelEncontrado[0]);

//                Console.WriteLine("\nSelecione os campos a seguir para atualizar:");
//                Console.WriteLine("[1] - Nome");
//                Console.WriteLine("[2] - Idade");
//                Console.WriteLine("[3] - RG");
//                Console.WriteLine("[4] - Celular");
//                Console.WriteLine("[5] - E-mail");
//                Console.WriteLine("[0] - Finalizar e salvar alterações");

//                bool selecionarCampos = true;

//                while (selecionarCampos)
//                {
//                    string opcaoSelecionada = Console.ReadLine();

//                    switch (opcaoSelecionada)
//                    {
//                        case "1":
//                            Console.WriteLine("Informe o novo nome: ");
//                            responsavelEncontrado[0].Nome = Console.ReadLine();
//                            break;
//                        case "2":
//                            Console.WriteLine("Informe a nova idade: ");
//                            int novaIdade;
//                            while (!int.TryParse(Console.ReadLine(), out novaIdade) || novaIdade <= 0)
//                            {
//                                Console.WriteLine("Idade inválida. Informe a nova idade: ");
//                            }
//                            responsavelEncontrado[0].Idade = novaIdade;
//                            break;
//                        case "3":
//                            Console.WriteLine("Informe o novo RG: ");
//                            int novoRG;
//                            while (!int.TryParse(Console.ReadLine(), out novoRG) || novoRG <= 0)
//                            {
//                                Console.WriteLine("RG inválido. Informe o novo RG: ");
//                            }
//                            responsavelEncontrado[0].RG = novoRG;
//                            break;
//                        case "4":
//                            Console.WriteLine("Informe o novo celular: ");
//                            long novoCelular;
//                            while (!long.TryParse(Console.ReadLine(), out novoCelular) || novoCelular <= 0)
//                            {
//                                Console.WriteLine("Celular inválido. Informe o novo celular: ");
//                            }
//                            responsavelEncontrado[0].Celular = novoCelular;
//                            break;
//                        case "5":
//                            Console.WriteLine("Informe o novo e-mail: ");
//                            responsavelEncontrado[0].Email = Console.ReadLine();
//                            break;
//                        case "0":
//                            selecionarCampos = false;
//                            break;
//                        default:
//                            Console.WriteLine("Opção incorreta, tente novamente");
//                            break;
//                    }

//                    if (selecionarCampos)
//                    {
//                        Console.WriteLine("\nSelecione o próximo campo para atualizar ou digite 0 para finalizar e salvar as alterações.");
//                    }

//                }

//                Responsavel.AtualizarResponsavel(responsavelEncontrado[0]);
//                Console.WriteLine("Paciente atualizado com sucesso!");
//            }
//            else
//            {
//                Console.Clear();
//                Cabecalho();
//                Console.WriteLine("Paciente não encontrado!");
//            }

//            Console.WriteLine("Pressione qualquer tecla para continuar...");
//            Console.ReadKey();
//            MenuInicialView.MenuInicial();
//        }
//        public static void ExibirResponsavel(IList<Responsavel> responsaveis)
//        {
//            Console.Clear();
//            if (responsaveis != null && responsaveis.Count > 0)
//            {
//                if (responsaveis.Count == 1)
//                {
//                    Cabecalho();
//                    ExibirInformacoesResponsavel(responsaveis[0]);
//                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu anterior...");
//                    Console.ReadKey();
//                    ConsultarResponsavel();
//                    return;
//                }

//                int responsaveisPorPagina = 1;
//                int totalPaginas = (int)Math.Ceiling((double)responsaveis.Count / responsaveisPorPagina);
//                int paginaAtual = 0;

//                while (true)
//                {
//                    Console.Clear();
//                    Cabecalho();
//                    Console.WriteLine("********************************");
//                    Console.WriteLine($"Pagina: {paginaAtual + 1} de {totalPaginas}");
//                    Console.WriteLine("********************************");

//                    Responsavel pacienteAtual = responsaveis[paginaAtual];

//                    // Exibir informações do paciente atual
//                    ExibirInformacoesResponsavel(pacienteAtual);

//                    Console.WriteLine("Pressione [1] para avançar para a próxima página, [2] para voltar para a página anterior ou [3] para sair.");

//                    string escolha = Console.ReadLine();
//                    if (escolha == "1")
//                    {
//                        paginaAtual++;
//                        if (paginaAtual >= totalPaginas)
//                        {
//                            paginaAtual = 0;
//                        }
//                    }
//                    else if (escolha == "2")
//                    {
//                        paginaAtual--;
//                        if (paginaAtual < 0)
//                        {
//                            paginaAtual = totalPaginas - 1;
//                        }
//                    }
//                    else if (escolha == "3")
//                    {
//                        ConsultarResponsavel();
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
//                        Console.ReadKey();
//                    }
//                }
//            }
//            else
//            {
//                Console.WriteLine("Nenhum paciente encontrado!");
//                Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
//                Console.ReadKey();
//                MenuInicialView.MenuInicial();
//            }
//        }
//        public static void ExibirInformacoesResponsavel(Responsavel responsavelAtual)
//        {
//            Console.WriteLine($"Nome: {responsavelAtual.Nome}");
//            Console.WriteLine($"Idade: {responsavelAtual.Idade}");
//            Console.WriteLine($"CPF: {responsavelAtual.CPF}");
//            Console.WriteLine($"RG: {responsavelAtual.RG}");
//            Console.WriteLine($"Celular: {responsavelAtual.Celular}");
//            Console.WriteLine($"Email: {responsavelAtual.Email}");
//        }
//        public static void Cabecalho()
//        {
//            MenuInicialView.Cabecalho();
//        }
//        public static void ConsultarResponsavel()
//        {
//            Console.Clear();
//            Cabecalho();
//            Console.WriteLine("Você deseja realizar a busca por:");
//            Console.WriteLine("[1] - Nome");
//            Console.WriteLine("[2] - Idade");
//            Console.WriteLine("[3] - CPF");
//            Console.WriteLine("[4] - Celular");
//            Console.WriteLine("[5] - Email");
//            Console.WriteLine("[6] - Buscar todos os responsaveis");
//            Console.WriteLine("[7] - Retornar à opção anterior");

//            string opcaoSelecionada = Console.ReadLine();

//            if (string.IsNullOrEmpty(opcaoSelecionada))
//            {
//                Console.WriteLine("Opção incorreta, tente novamente");
//                Console.ReadLine();
//                ConsultarResponsavel();
//                return;
//            }

//            switch (opcaoSelecionada[0])
//            {
//                case '1':
//                    ConsultaResponsavelNome();
//                    break;

//                case '2':
//                    ConsultaResponsavelIdade();
//                    break;

//                case '3':
//                    ConsultaResponsavelCpf();
//                    break;

//                case '4':
//                    ConsultaResponsavelCelular();
//                    break;

//                case '5':
//                    ConsultaResponsavelEmail();
//                    break;

//                case '6':
//                    ConsultaTodosOsResponsaveis();
//                    break;
//                case '7':
//                    MenuInicialView.MenuInicial();
//                    break;

//                default:
//                    Console.WriteLine("Opção incorreta, tente novamente");
//                    Console.ReadLine();
//                    ConsultarResponsavel();
//                    break;
//            }
//        }
//        public static void ConsultaTodosOsResponsaveis()
//        {
//            var todosOsResponsaveis = Responsavel.BuscarTodos();
//            ExibirResponsavel(todosOsResponsaveis);
//        }
//        public static void ConsultaResponsavelEmail()
//        {
//            Console.WriteLine("Informe o e-mail do responsavel: ");
//            var email = Console.ReadLine();
//            var responsavelEncontrado = Responsavel.BuscarResponsavel(email: email);

//            if (responsavelEncontrado.Count > 0)
//            {
//                ExibirResponsavel(responsavelEncontrado);
//            }
//            else
//            {
//                Console.WriteLine("Responsavel não encontrado!");
//                Console.ReadKey();
//            }

//            Console.WriteLine("Pressione qualquer tecla para continuar...");
//            Console.ReadKey();
//            ConsultarResponsavel();
//        }
//        public static void ConsultaResponsavelCelular()
//        {
//            Console.WriteLine("Informe o celular do responsavel: ");
//            long celular;
//            while (!long.TryParse(Console.ReadLine(), out celular) || celular <= 0)
//            {
//                Console.WriteLine("Celular inválido. Informe o celular do responsável: ");
//            }
//            var responsavelEncontrado = Responsavel.BuscarResponsavel(celular: celular);

//            if (responsavelEncontrado.Count > 0)
//            {
//                ExibirResponsavel(responsavelEncontrado);
//            }
//            else
//            {
//                Console.WriteLine("Responsavel não encontrado!");
//                Console.ReadKey();
//            }

//            Console.WriteLine("Pressione qualquer tecla para continuar...");
//            Console.ReadKey();
//            ConsultarResponsavel();
//        }
//        public static void ConsultaResponsavelNome()
//        {
//            Console.WriteLine("Informe o nome do responsavel: ");
//            var nome = Console.ReadLine();
//            var responsavelEncontrado = Responsavel.BuscarResponsavel(nome: nome);

//            if (responsavelEncontrado.Count > 0)
//            {
//                ExibirResponsavel(responsavelEncontrado);
//            }
//            else
//            {
//                Console.WriteLine("Responsavel não encontrado!");
//                Console.ReadKey();
//            }

//            Console.WriteLine("Pressione qualquer tecla para continuar...");
//            Console.ReadKey();
//            ConsultarResponsavel();
//        }
//        public static void ConsultaResponsavelIdade()
//        {
//            Console.WriteLine("Informe a idade do responsavel: ");
//            int idade;
//            while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
//            {
//                Console.WriteLine("Idade inválida. Informe a idade do responsável: ");
//            }
//            var responsavelEncontrado = Responsavel.BuscarResponsavel(idade: idade);

//            if (responsavelEncontrado.Count > 0)
//            {
//                ExibirResponsavel(responsavelEncontrado);
//            }
//            else
//            {
//                Console.WriteLine("Responsavel não encontrado!");
//                Console.ReadKey();
//            }

//            Console.WriteLine("Pressione qualquer tecla para continuar...");
//            Console.ReadKey();
//            ConsultarResponsavel();
//        }
//        public static void ConsultaResponsavelCpf()
//        {
//            Console.WriteLine("Informe o CPF do responsavel: ");
//            long cpf;
//            while (!long.TryParse(Console.ReadLine(), out cpf) || cpf < 0)
//            {
//                Console.WriteLine("O CPF está inválido. Informe o CPF do responsavel: ");
//            }

//            var responsavelEncontrado = Responsavel.BuscarResponsavel(cpf: cpf);

//            if (responsavelEncontrado.Count > 0)
//            {
//                ExibirResponsavel(responsavelEncontrado);
//            }
//            else
//            {
//                Console.WriteLine("Responsavel não encontrado!");
//                Console.ReadKey();
//            }

//            Console.WriteLine("Pressione qualquer tecla para continuar...");
//            Console.ReadKey();
//            ConsultarResponsavel();
//        }
//        public static void ExcluirResponsavel()
//        {
//            Console.WriteLine("Informe o CPF do paciente: ");
//            var cpf = long.Parse(Console.ReadLine());
//            var responsavelEncontrado = Responsavel.BuscarResponsavel(cpf: cpf);

//            if (responsavelEncontrado.Count > 0)
//            {
//                Console.Clear();
//                Cabecalho();
//                ExibirInformacoesResponsavel(responsavelEncontrado[0]);

//                Console.WriteLine("Você deseja excluir este paciente? Digite [1] para confirmar ou [2] para cancelar");
//                var opcao = Console.ReadLine();

//                if (!string.IsNullOrEmpty(opcao) && opcao == "1")
//                {
//                    Responsavel.ExcluirResponsavel(responsavelEncontrado[0]);
//                    Console.WriteLine("Paciente excluído com sucesso!");
//                }
//                else
//                {
//                    Console.WriteLine("Exclusão cancelada. O paciente não foi removido.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Paciente não encontrado!");
//            }

//            Console.WriteLine("Pressione qualquer tecla para continuar...");
//            Console.ReadKey();
//            MenuInicialView.MenuInicial();
//        }
//    }
//}
