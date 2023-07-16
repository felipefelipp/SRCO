using Microsoft.IdentityModel.Tokens;
using SCRO.Models.Paciente;
using SCRO.Controllers;
using SCRO.Models.Classificacao;
using SCRO.Models.Paciente;
using SCRO.Views;
using System;

namespace SCRO.Views
{
    public static class PacienteView
    {

        private static readonly PacienteController Paciente;
        static PacienteView()
        {
            Paciente = new PacienteController();
        }
        public static void CadastrarPaciente()
        {
            Console.Clear();
            Cabecalho();

            Console.WriteLine("Informe o nome do paciente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a idade do paciente: ");
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
            {
                Console.WriteLine("Idade inválida. Informe a idade do paciente: ");
            }

            Console.WriteLine("Informe o CPF do paciente: ");
            long cpf;
            while (!long.TryParse(Console.ReadLine(), out cpf) || cpf <= 0)
            {
                Console.WriteLine("CPF inválido. Informe o CPF do paciente: ");
            }

            if (Paciente.VerificaSeExisteCpf(cpf))
            {

                Console.WriteLine("Este paciente já existe, deseja atualizá-lo? [1] - Sim [2] - Não ");
                char atualizarPaciente;
                while (!char.TryParse(Console.ReadLine(), out atualizarPaciente) || (atualizarPaciente != '1' && atualizarPaciente != '2'))
                {
                    Console.WriteLine("Opção inválida. Este paciente já existe, deseja atualizá-lo? [1] - Sim [2] - Não ");
                }

                if (atualizarPaciente == '1')
                {
                    AtualizarPacienteEncontrado(cpf);
                    return;
                }
                else
                {
                    Console.WriteLine("Informe o CPF do paciente: ");
                    cpf = long.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Informe o RG do paciente: ");
            int rg;
            while (!int.TryParse(Console.ReadLine(), out rg) || rg <= 0)
            {
                Console.WriteLine("RG inválido. Informe o RG do paciente: ");
            }

            Console.WriteLine("Informe o celular do paciente: ");
            long celular;
            while (!long.TryParse(Console.ReadLine(), out celular) || celular <= 0)
            {
                Console.WriteLine("Celular inválido. Informe o celular do paciente: ");
            }

            Console.WriteLine("Informe o telefone do paciente (opcional, deixe em branco se não possuir): ");
            long? telefone = null;
            long parsedCelular;
            if (long.TryParse(Console.ReadLine(), out parsedCelular) && parsedCelular > 0)
            {
                telefone = parsedCelular;
            }

            Console.WriteLine("Informe a rua do paciente: ");
            string rua = Console.ReadLine();

            Console.WriteLine("Informe o número da rua do paciente: ");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.WriteLine("Número inválido. Informe o número do paciente: ");
            }

            Console.WriteLine("Informe o bairro do paciente: ");
            string bairro = Console.ReadLine();

            Console.WriteLine("Informe o município do paciente: ");
            string municipio = Console.ReadLine();

            Console.WriteLine("Informe a UF do paciente: ");
            string uf = Console.ReadLine();

            Console.WriteLine("Informe o CEP do paciente: ");
            int cep;
            while (!int.TryParse(Console.ReadLine(), out cep) || cep <= 0)
            {
                Console.WriteLine("CEP inválido. Informe o CEP do paciente: ");
            }

            Console.WriteLine("Informe o sexo do paciente [M] ou [F]: ");
            char sexo;
            while (!char.TryParse(Console.ReadLine(), out sexo) || (sexo != 'M' && sexo != 'F'))
            {
                Console.WriteLine("Sexo inválido. Informe o sexo do paciente [M] ou [F]: ");
            }

            Console.WriteLine("Informe a profissão do paciente: ");
            string profissao = Console.ReadLine();

            Console.WriteLine("Informe o email do paciente: ");
            string email = Console.ReadLine();

            Console.WriteLine("O paciente possui responsável? [1] - Sim [2] - Não");
            char possuiResponsavel;
            while (!char.TryParse(Console.ReadLine(), out possuiResponsavel) || (possuiResponsavel != '1' && possuiResponsavel != '2'))
            {
                Console.WriteLine("Opção inválida. O paciente possui responsável? [1] - Sim [2] - Não");
            }

            int responsavelId = 0;
            if (possuiResponsavel == '1')
            {
                responsavelId = ResponsavelView.CadastrarResponsavel();
            }

            Paciente.CadastrarPaciente(new Paciente(responsavelId, nome, idade, cpf, rg, celular, telefone, rua, numero, bairro, municipio, uf, cep, sexo, profissao, email));
            Console.WriteLine("Paciente cadastrado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
            Console.ReadKey();
            MenuInicialView.MenuInicial();
        }
        public static void ExibirPaciente(IList<Paciente> pacientes)
        {
            Console.Clear();
            if (pacientes != null && pacientes.Count > 0)
            {
                if (pacientes.Count == 1)
                {
                    Cabecalho();
                    ExibirInformacoesPaciente(pacientes[0]);
                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu anterior...");
                    Console.ReadKey();
                    ConsultarPaciente();
                    return;
                }

                int pacientesPorPagina = 1;
                int totalPaginas = (int)Math.Ceiling((double)pacientes.Count / pacientesPorPagina);
                int paginaAtual = 0;

                while (true)
                {
                    Console.Clear();
                    Cabecalho();
                    Console.WriteLine("********************************");
                    Console.WriteLine($"Pagina: {paginaAtual + 1} de {totalPaginas}");
                    Console.WriteLine("********************************");

                    Paciente pacienteAtual = pacientes[paginaAtual];

                    // Exibir informações do paciente atual
                    ExibirInformacoesPaciente(pacienteAtual);

                    Console.WriteLine("Pressione [1] para avançar para a próxima página, [2] para voltar para a página anterior ou [3] para sair.");

                    string escolha = Console.ReadLine();
                    if (escolha == "1")
                    {
                        paginaAtual++;
                        if (paginaAtual >= totalPaginas)
                        {
                            paginaAtual = 0;
                        }
                    }
                    else if (escolha == "2")
                    {
                        paginaAtual--;
                        if (paginaAtual < 0)
                        {
                            paginaAtual = totalPaginas - 1;
                        }
                    }
                    else if (escolha == "3")
                    {
                        ConsultarPaciente();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Nenhum paciente encontrado!");
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
                Console.ReadKey();
                MenuInicialView.MenuInicial();
            }
        }
        private static void ExibirInformacoesPaciente(Paciente pacienteAtual)
        {
            Console.WriteLine($"Nome: {pacienteAtual.Nome}");
            Console.WriteLine($"Idade: {pacienteAtual.Idade}");
            Console.WriteLine($"ResponsavelId: {pacienteAtual.ResponsavelId}");
            Console.WriteLine($"CPF: {pacienteAtual.CPF}");
            Console.WriteLine($"RG: {pacienteAtual.RG}");
            Console.WriteLine($"Celular: {pacienteAtual.Celular}");
            Console.WriteLine($"Telefone: {pacienteAtual.Telefone}");
            Console.WriteLine($"Rua: {pacienteAtual.Rua}");
            Console.WriteLine($"Número: {pacienteAtual.Numero}");
            Console.WriteLine($"Bairro: {pacienteAtual.Bairro}");
            Console.WriteLine($"Municipio: {pacienteAtual.Municipio}");
            Console.WriteLine($"UF: {pacienteAtual.UF}");
            Console.WriteLine($"CEP: {pacienteAtual.CEP}");
            Console.WriteLine($"Sexo: {pacienteAtual.Sexo}");
            Console.WriteLine($"Profissao: {pacienteAtual.Profissao}");
            Console.WriteLine($"Email: {pacienteAtual.Email}");
        }
        public static void Cabecalho()
        {
            MenuInicialView.Cabecalho();
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
            Console.WriteLine("[6] - Buscar todos os pacientes");
            Console.WriteLine("[7] - Retornar à opção anterior");

            string opcaoSelecionada = Console.ReadLine();

            if (string.IsNullOrEmpty(opcaoSelecionada))
            {
                Console.WriteLine("Opção incorreta, tente novamente");
                Console.ReadLine();
                ConsultarPaciente();
                return;
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
                    ConsultaTodosOsPacientes();
                    break;
                case '7':
                    MenuInicialView.MenuInicial();
                    break;

                default:
                    Console.WriteLine("Opção incorreta, tente novamente");
                    Console.ReadLine();
                    ConsultarPaciente();
                    break;
            }
        }
        private static void ConsultaTodosOsPacientes()
        {
            var todosOsPacientes = Paciente.BuscarTodos();
            ExibirPaciente(todosOsPacientes);
        }
        private static void ConsultaPacienteEmail()
        {
            Console.WriteLine("Informe o e-mail do paciente: ");
            var email = Console.ReadLine();
            var pacienteEncontrado = Paciente.BuscarPaciente(email: email);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            ConsultarPaciente();
        }
        private static void ConsultaPacienteCelular()
        {
            Console.WriteLine("Informe o celular do paciente: ");
            var celular = long.Parse(Console.ReadLine());
            var pacienteEncontrado = Paciente.BuscarPaciente(celular: celular);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            ConsultarPaciente();
        }
        public static void ConsultaPacienteNome()
        {
            Console.WriteLine("Informe o nome do paciente: ");
            var nome = Console.ReadLine();
            var pacienteEncontrado = Paciente.BuscarPaciente(nome: nome);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            ConsultarPaciente();
        }
        public static void ConsultaPacienteIdade()
        {
            Console.WriteLine("Informe a idade do paciente: ");
            var idade = int.Parse(Console.ReadLine());
            var pacienteEncontrado = Paciente.BuscarPaciente(idade: idade);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            ConsultarPaciente();
        }
        private static void ConsultaPacienteCpf()
        {
            Console.WriteLine("Informe o CPF do paciente: ");
            var cpf = long.Parse(Console.ReadLine());
            var pacienteEncontrado = Paciente.BuscarPaciente(cpf: cpf);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirPaciente(pacienteEncontrado);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
                Console.ReadKey();
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            ConsultarPaciente();
        }
        public static void AtualizarPaciente()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine("Informe o CPF do paciente: ");
            var cpf = long.Parse(Console.ReadLine());
            var pacienteEncontrado = Paciente.BuscarPaciente(cpf: cpf);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirInformacoesPaciente(pacienteEncontrado[0]);

                Console.WriteLine("\nSelecione os campos a seguir para atualizar:");
                Console.WriteLine("[1] - Nome");
                Console.WriteLine("[2] - Idade");
                Console.WriteLine("[3] - RG");
                Console.WriteLine("[4] - Celular");
                Console.WriteLine("[5] - Telefone");
                Console.WriteLine("[6] - Rua");
                Console.WriteLine("[7] - Numero");
                Console.WriteLine("[8] - Bairro");
                Console.WriteLine("[9] - Municipio");
                Console.WriteLine("[10] - UF");
                Console.WriteLine("[11] - CEP");
                Console.WriteLine("[12] - Sexo");
                Console.WriteLine("[13] - Profissão");
                Console.WriteLine("[14] - E-mail");
                Console.WriteLine("[0] - Finalizar e salvar alterações");

                bool selecionarCampos = true;

                while (selecionarCampos)
                {
                    string opcaoSelecionada = Console.ReadLine();

                    switch (opcaoSelecionada)
                    {
                        case "1":
                            Console.WriteLine("Informe o novo nome: ");
                            pacienteEncontrado[0].Nome = Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Informe a nova idade: ");
                            int novaIdade;
                            while (!int.TryParse(Console.ReadLine(), out novaIdade) || novaIdade <= 0)
                            {
                                Console.WriteLine("Idade inválida. Informe a nova idade: ");
                            }
                            pacienteEncontrado[0].Idade = novaIdade;
                            break;
                        case "3":
                            Console.WriteLine("Informe o novo RG: ");
                            int novoRG;
                            while (!int.TryParse(Console.ReadLine(), out novoRG) || novoRG <= 0)
                            {
                                Console.WriteLine("RG inválido. Informe o novo RG: ");
                            }
                            pacienteEncontrado[0].RG = novoRG;
                            break;
                        case "4":
                            Console.WriteLine("Informe o novo celular: ");
                            long novoCelular;
                            while (!long.TryParse(Console.ReadLine(), out novoCelular) || novoCelular <= 0)
                            {
                                Console.WriteLine("Celular inválido. Informe o novo celular: ");
                            }
                            pacienteEncontrado[0].Celular = novoCelular;
                            break;
                        case "5":
                            Console.WriteLine("Informe o novo telefone: ");
                            long? novoTelefone = null;
                            long parsedTelefone;
                            if (long.TryParse(Console.ReadLine(), out parsedTelefone) && parsedTelefone > 0)
                            {
                                novoTelefone = parsedTelefone;
                            }
                            pacienteEncontrado[0].Telefone = novoTelefone;
                            break;
                        case "6":
                            Console.WriteLine("Informe a nova rua: ");
                            pacienteEncontrado[0].Rua = Console.ReadLine();
                            break;
                        case "7":
                            Console.WriteLine("Informe o novo número: ");
                            int novoNumero;
                            while (!int.TryParse(Console.ReadLine(), out novoNumero) || novoNumero <= 0)
                            {
                                Console.WriteLine("Número inválido. Informe o novo número: ");
                            }
                            pacienteEncontrado[0].Numero = novoNumero;
                            break;
                        case "8":
                            Console.WriteLine("Informe o novo bairro: ");
                            pacienteEncontrado[0].Bairro = Console.ReadLine();
                            break;
                        case "9":
                            Console.WriteLine("Informe o novo município: ");
                            pacienteEncontrado[0].Municipio = Console.ReadLine();
                            break;
                        case "10":
                            Console.WriteLine("Informe a nova UF: ");
                            pacienteEncontrado[0].UF = Console.ReadLine();
                            break;
                        case "11":
                            Console.WriteLine("Informe o novo CEP: ");
                            int novoCEP;
                            while (!int.TryParse(Console.ReadLine(), out novoCEP) || novoCEP <= 0)
                            {
                                Console.WriteLine("CEP inválido. Informe o novo CEP: ");
                            }
                            pacienteEncontrado[0].CEP = novoCEP;
                            break;
                        case "12":
                            Console.WriteLine("Informe o novo sexo [M] ou [F]: ");
                            char novoSexo;
                            while (!char.TryParse(Console.ReadLine(), out novoSexo) || (novoSexo != 'M' && novoSexo != 'F'))
                            {
                                Console.WriteLine("Sexo inválido. Informe o novo sexo [M] ou [F]: ");
                            }
                            pacienteEncontrado[0].Sexo = novoSexo;
                            break;
                        case "13":
                            Console.WriteLine("Informe a nova profissão: ");
                            pacienteEncontrado[0].Profissao = Console.ReadLine();
                            break;
                        case "14":
                            Console.WriteLine("Informe o novo e-mail: ");
                            pacienteEncontrado[0].Email = Console.ReadLine();
                            break;
                        case "0":
                            selecionarCampos = false;
                            break;
                        default:
                            Console.WriteLine("Opção incorreta, tente novamente");
                            break;
                    }

                    if (selecionarCampos)
                    {
                        Console.WriteLine("\nSelecione o próximo campo para atualizar ou digite 0 para finalizar e salvar as alterações.");
                    }

                }

                Paciente.AtualizarPaciente(pacienteEncontrado[0]);
                Console.WriteLine("Paciente atualizado com sucesso!");
            }
            else
            {
                Console.Clear();
                Cabecalho();
                Console.WriteLine("Paciente não encontrado!");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuInicialView.MenuInicial();
        }
        public static void AtualizarPacienteEncontrado(long cpf)
        {
            var pacienteEncontrado = Paciente.BuscarPaciente(cpf: cpf);

            if (pacienteEncontrado.Count > 0)
            {
                ExibirInformacoesPaciente(pacienteEncontrado[0]);

                Console.WriteLine("\nSelecione os campos a seguir para atualizar:");
                Console.WriteLine("[1] - Nome");
                Console.WriteLine("[2] - Idade");
                Console.WriteLine("[3] - RG");
                Console.WriteLine("[4] - Celular");
                Console.WriteLine("[5] - Telefone");
                Console.WriteLine("[6] - Rua");
                Console.WriteLine("[7] - Numero");
                Console.WriteLine("[8] - Bairro");
                Console.WriteLine("[9] - Municipio");
                Console.WriteLine("[10] - UF");
                Console.WriteLine("[11] - CEP");
                Console.WriteLine("[12] - Sexo");
                Console.WriteLine("[13] - Profissão");
                Console.WriteLine("[14] - E-mail");
                Console.WriteLine("[0] - Finalizar e salvar alterações");

                bool selecionarCampos = true;

                while (selecionarCampos)
                {
                    string opcaoSelecionada = Console.ReadLine();

                    switch (opcaoSelecionada)
                    {
                        case "1":
                            Console.WriteLine("Informe o novo nome: ");
                            pacienteEncontrado[0].Nome = Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Informe a nova idade: ");
                            int novaIdade;
                            while (!int.TryParse(Console.ReadLine(), out novaIdade) || novaIdade <= 0)
                            {
                                Console.WriteLine("Idade inválida. Informe a nova idade: ");
                            }
                            pacienteEncontrado[0].Idade = novaIdade;
                            break;
                        case "3":
                            Console.WriteLine("Informe o novo RG: ");
                            int novoRG;
                            while (!int.TryParse(Console.ReadLine(), out novoRG) || novoRG <= 0)
                            {
                                Console.WriteLine("RG inválido. Informe o novo RG: ");
                            }
                            pacienteEncontrado[0].RG = novoRG;
                            break;
                        case "4":
                            Console.WriteLine("Informe o novo celular: ");
                            long novoCelular;
                            while (!long.TryParse(Console.ReadLine(), out novoCelular) || novoCelular <= 0)
                            {
                                Console.WriteLine("Celular inválido. Informe o novo celular: ");
                            }
                            pacienteEncontrado[0].Celular = novoCelular;
                            break;
                        case "5":
                            Console.WriteLine("Informe o novo telefone: ");
                            long? novoTelefone = null;
                            long parsedTelefone;
                            if (long.TryParse(Console.ReadLine(), out parsedTelefone) && parsedTelefone > 0)
                            {
                                novoTelefone = parsedTelefone;
                            }
                            pacienteEncontrado[0].Telefone = novoTelefone;
                            break;
                        case "6":
                            Console.WriteLine("Informe a nova rua: ");
                            pacienteEncontrado[0].Rua = Console.ReadLine();
                            break;
                        case "7":
                            Console.WriteLine("Informe o novo número: ");
                            int novoNumero;
                            while (!int.TryParse(Console.ReadLine(), out novoNumero) || novoNumero <= 0)
                            {
                                Console.WriteLine("Número inválido. Informe o novo número: ");
                            }
                            pacienteEncontrado[0].Numero = novoNumero;
                            break;
                        case "8":
                            Console.WriteLine("Informe o novo bairro: ");
                            pacienteEncontrado[0].Bairro = Console.ReadLine();
                            break;
                        case "9":
                            Console.WriteLine("Informe o novo município: ");
                            pacienteEncontrado[0].Municipio = Console.ReadLine();
                            break;
                        case "10":
                            Console.WriteLine("Informe a nova UF: ");
                            pacienteEncontrado[0].UF = Console.ReadLine();
                            break;
                        case "11":
                            Console.WriteLine("Informe o novo CEP: ");
                            int novoCEP;
                            while (!int.TryParse(Console.ReadLine(), out novoCEP) || novoCEP <= 0)
                            {
                                Console.WriteLine("CEP inválido. Informe o novo CEP: ");
                            }
                            pacienteEncontrado[0].CEP = novoCEP;
                            break;
                        case "12":
                            Console.WriteLine("Informe o novo sexo [M] ou [F]: ");
                            char novoSexo;
                            while (!char.TryParse(Console.ReadLine(), out novoSexo) || (novoSexo != 'M' && novoSexo != 'F'))
                            {
                                Console.WriteLine("Sexo inválido. Informe o novo sexo [M] ou [F]: ");
                            }
                            pacienteEncontrado[0].Sexo = novoSexo;
                            break;
                        case "13":
                            Console.WriteLine("Informe a nova profissão: ");
                            pacienteEncontrado[0].Profissao = Console.ReadLine();
                            break;
                        case "14":
                            Console.WriteLine("Informe o novo e-mail: ");
                            pacienteEncontrado[0].Email = Console.ReadLine();
                            break;
                        case "0":
                            selecionarCampos = false;
                            break;
                        default:
                            Console.WriteLine("Opção incorreta, tente novamente");
                            break;
                    }

                    if (selecionarCampos)
                    {
                        Console.WriteLine("\nSelecione o próximo campo para atualizar ou digite 0 para finalizar e salvar as alterações.");
                    }

                }

                Paciente.AtualizarPaciente(pacienteEncontrado[0]);
                Console.WriteLine("Paciente atualizado com sucesso!");
            }
            else
            {
                Console.Clear();
                Cabecalho();
                Console.WriteLine("Paciente não encontrado!");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuInicialView.MenuInicial();
        }
        public static void ExcluirPaciente()
        {
            Console.WriteLine("Informe o CPF do paciente: ");
            var cpf = long.Parse(Console.ReadLine());
            var pacienteEncontrado = Paciente.BuscarPaciente(cpf: cpf);

            if (pacienteEncontrado.Count > 0)
            {
                Console.Clear();
                Cabecalho();
                ExibirInformacoesPaciente(pacienteEncontrado[0]);

                Console.WriteLine("Você deseja excluir este paciente? Digite [1] para confirmar ou [2] para cancelar");
                var opcao = Console.ReadLine();

                if (!string.IsNullOrEmpty(opcao) && opcao == "1")
                {
                    Paciente.ExcluirPaciente(pacienteEncontrado[0]);
                    Console.WriteLine("Paciente excluído com sucesso!");
                }
                else
                {
                    Console.WriteLine("Exclusão cancelada. O paciente não foi removido.");
                }
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuInicialView.MenuInicial();
        }
    }
}
