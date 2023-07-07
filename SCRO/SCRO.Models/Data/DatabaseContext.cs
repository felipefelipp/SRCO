using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
 


namespace SCRO.Models.Data
{
    public class DatabaseContext
    {
        protected string connectionString = "Data Source=localhost;Initial Catalog=SCRO;Integrated Security=True";

        public DatabaseContext() 
        {
            Conectar();

        }
        
        public void Conectar()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

        }
       

        



    }
}

/*
         Para exemplificar como realizar operações de banco de dados em um projeto de supermercado, podemos criar um modelo de dados simples com as seguintes entidades: Produto, Categoria e Fornecedor.

Segue um exemplo de como ficaria     uma classe DatabaseContext que permite realizar operações CRUD nas entidades do modelo de dados:

csharp
Copy code
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace Supermercado.Models.Data {
    public class DatabaseContext {
        private readonly string connectionString;

        public DatabaseContext() {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public List<Produto> GetAllProdutos() {
            string querySelect = "SELECT * FROM Produto";

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                using (SqlCommand command = new SqlCommand(querySelect, connection)) {
                    SqlDataReader reader = command.ExecuteReader();

                    List<Produto> produtos = new List<Produto>();
                    while (reader.Read()) {
                        Produto produto = new Produto();
                        produto.Id = Convert.ToInt32(reader["Id"]);
                        produto.Nome = reader["Nome"].ToString();
                        produto.Preco = Convert.ToDecimal(reader["Preco"]);
                        produto.Quantidade = Convert.ToInt32(reader["Quantidade"]);
                        produto.Categoria = new Categoria() { Id = Convert.ToInt32(reader["CategoriaId"]) };
                        produto.Fornecedor = new Fornecedor() { Id = Convert.ToInt32(reader["FornecedorId"]) };

                        produtos.Add(produto);
                    }

                    return produtos;
                }
            }
        }

        public void InsertProduto(Produto produto) {
            string queryInsert = $"INSERT INTO Produto (Nome, Preco, Quantidade, CategoriaId, FornecedorId) " +
                                 $"VALUES ('{produto.Nome}', {produto.Preco}, {produto.Quantidade}, " +
                                 $"{produto.Categoria.Id}, {produto.Fornecedor.Id})";

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryInsert, connection)) {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduto(Produto produto) {
            string queryUpdate = $"UPDATE Produto SET Nome = '{produto.Nome}', Preco = {produto.Preco}, " +
                                 $"Quantidade = {produto.Quantidade}, CategoriaId = {produto.Categoria.Id}, " +
                                 $"FornecedorId = {produto.Fornecedor.Id} WHERE Id = {produto.Id}";

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryUpdate, connection)) {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduto(int id) {
            string queryDelete = $"DELETE FROM Produto WHERE Id = {id}";

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryDelete, connection)) {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
Neste exemplo, a classe DatabaseContext permite realizar operações CRUD na entidade Produto. Os métodos GetAllProdutos(), InsertProduto(), UpdateProduto() e DeleteProduto() permitem, respectivamente, obter todos os produtos, inserir um novo produto, atualizar um produto existente e excluir um produto existente.

Cada método utiliza uma conexão com o banco de dados e uma instrução SQL para realizar a operação desejada. É importante lembrar que, em um projeto real, é necessário utilizar técnicas para evitar ataques de SQL injection e garantir a segurança dos dados.

Na camada de controller do projeto, podemos utilizar a classe DatabaseContext
         */