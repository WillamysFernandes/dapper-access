using System;
using CrudSqlServer.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace CrudSqlServer
{
    class Program
    {
        private const string connectionString = "Data Source=DESKTOP-8U0OIEV\\SQLEXPRESS1;Initial Catalog=projetinho;Integrated Security=True;TrustServerCertificate=True";
        public static void Main()
        {
            //ReadMarcas();
            //ReadMarca();
            //CreateMarca();
            //UpdateMarca();
            //DeleteMarca();
        }
        public static void ReadMarcas()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var marca = connection.GetAll<Marca>();
                foreach (var item in marca)
                {
                    Console.WriteLine(item.nome);
                }
            }
        }
        public static void ReadMarca()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var item = connection.Get<Marca>(3);
                    Console.WriteLine(item.nome);
            }
        }
        public static void CreateMarca()
        {
            var marca = new Marca(){
                nome = "sansung"
            };
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Insert<Marca>(marca);
                    Console.WriteLine($"Registros Inseridos com Sucesso!!");
            }
        }
        public static void UpdateMarca()
        {
            var marca = new Marca(){
                id = 7,
                nome = "Puma"
            };
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Update<Marca>(marca);
                    Console.WriteLine($"Registros Atualizados com Sucesso!!");
            }
        }
        public static void DeleteMarca()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var marca = connection.Get<Marca>(6);
                connection.Delete<Marca>(marca);
                    Console.WriteLine($"Registros Deletados com Sucesso!!");
            }
        }
    }
}