using Models.SCRO.Models.Paciente;
using SCRO.Models.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SCRO.Views.Consulta
{
    public class CadastrarPacienteView
    {
        // Ideia inicial, criar um obj de paciente quando chamar a view e na view retornar o obj paciente
        // para ser cadastrado pelo controller
        
        public void Cadastrar()
        {
            

        }

        public void Cabecalho()
        {

        }

        public Paciente menuCadastrarPaciente(Paciente paciente)
        {
            Console.WriteLine("Informe o nome do paciente: ");
            paciente.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade do paciente: ");
            paciente.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o CPF do paciente: ");
            paciente.CPF = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o RG do paciente: ");
            paciente.RG = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o celular do paciente: ");
            paciente.Celular = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o telefone do paciente: ");
            paciente.Telefone = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o endereço do paciente: ");
            paciente.Endereco = Console.ReadLine();
            Console.WriteLine("Informe o bairro do paciente: ");
            paciente.Bairro = Console.ReadLine();
            Console.WriteLine("Informe o municipio do paciente: ");
            paciente.Municipio = Console.ReadLine();
            Console.WriteLine("Informe a UF do paciente: ");
            paciente.UF = Console.ReadLine();
            Console.WriteLine("Informe o CEP do paciente: ");
            paciente.CEP = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o sexo do paciente: ");
            paciente.Sexo = Console.ReadLine()[0];
            Console.WriteLine("Informe o profissao do paciente: ");
            paciente.Profissao = Console.ReadLine();
            Console.WriteLine("Informe o email do paciente: ");
            paciente.Email = Console.ReadLine();
            Console.WriteLine("Paciente possui responsável? [1] - Sim [2] - Não");
            char possuiResponsavel = Console.ReadLine()[0];
            if(possuiResponsavel == '1')
            {
                Responsavel responsavel = new Responsavel();
                CadastrarResponsavelView cadastroResponsavel = new CadastrarResponsavelView();
                cadastroResponsavel.menuCadastrarResponsavel(responsavel);
                paciente.Responsavel = responsavel;
            } else
            {
                paciente.Responsavel = null; 
            }
          
            return paciente;
        }


        public void ExibirPaciente(Paciente paciente)
        {
            Console.WriteLine(paciente.Nome);
            Console.WriteLine(paciente.Idade);
            Console.WriteLine(paciente.Responsavel);
            Console.WriteLine(paciente.CPF);
            Console.WriteLine(paciente.RG);
            Console.WriteLine(paciente.Celular);
            Console.WriteLine(paciente.Telefone);
            Console.WriteLine(paciente.Bairro);
            Console.WriteLine(paciente.Municipio);
            Console.WriteLine(paciente.UF);
            Console.WriteLine(paciente.CEP);
            Console.WriteLine(paciente.Sexo);
            Console.WriteLine(paciente.Profissao);
            Console.WriteLine(paciente.Email);
            Console.ReadKey();
        }
    }
}
