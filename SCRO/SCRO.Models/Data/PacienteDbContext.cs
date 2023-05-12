using SCRO.Models.Paciente;
using SCRO.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SCRO.Models.Data
{
    public class PacienteDbContext : DatabaseContext
    {

        public PacienteDbContext()
        {
            
        }



        public void InsertPaciente(Paciente.Paciente paciente)
        {
            string queryInsert = $"INSERT INTO PACIENTE (nome" +
                                                      $",idade" +
                                                      $",id_responsavel" +
                                                      $",cpf" +
                                                      $",rg" +
                                                      $",celular" +
                                                      $",telefone" +
                                                      $",bairro" +
                                                      $",municipio" +
                                                      $",uf" +
                                                      $",cep" +
                                                      $",sexo" +
                                                      $",profissao" +
                                                      $",email" +
                                                      $",inseridoPor" +
                                                      $",inseridoEm)" +
                                 $"VALUES ('{paciente.Nome}'" +
                                       $", {paciente.Idade}" +
                                       $", NULL" + // Adicionar responsavel
                                       $", {paciente.CPF}" +
                                       $", {paciente.RG}" +
                                       $", {paciente.Celular}" +
                                       $", {paciente.Telefone}" +
                                       $", '{paciente.Bairro}'" +
                                       $", '{paciente.Municipio}'" +
                                       $", '{paciente.UF}'" +
                                       $", {paciente.CEP}" +
                                       $", '{paciente.Sexo}'" +
                                       $", '{paciente.Profissao}'" +
                                       $", '{paciente.Email}'" +
                                       $", 1" +
                                       $", GETDATE())";

             using (SqlConnection connection = new SqlConnection(connectionString))
             {
               connection.Open();

                using (SqlCommand command = new SqlCommand(queryInsert, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            
        }
    }
}
